# lolzteam-csharp

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![CI](https://github.com/kyo-lzt/lolzteam-csharp/actions/workflows/ci.yml/badge.svg)](https://github.com/kyo-lzt/lolzteam-csharp/actions)

C# SDK для [Lolzteam](https://lolz.live) Forum и Market API. **266 эндпоинтов** (151 Forum + 115 Market), автоматически сгенерированные из OpenAPI спецификаций. Полностью асинхронный с `Task`-based API и поддержкой `CancellationToken`.

---

## Содержание / Table of Contents

- [Быстрый старт / Quick Start](#быстрый-старт--quick-start)
- [Опции клиента / Client Options](#опции-клиента--client-options)
- [Прокси / Proxy](#прокси--proxy)
- [Авто-retry / Auto-retry](#авто-retry--auto-retry)
- [Обработка ошибок / Error Handling](#обработка-ошибок--error-handling)
- [Rate Limits](#rate-limits)
- [Forum API](#forum-api)
- [Market API](#market-api)
- [Генерация кода / Code Generation](#генерация-кода--code-generation)
- [Сборка и тесты / Build & Test](#сборка-и-тесты--build--test)
- [Структура проекта / Project Structure](#структура-проекта--project-structure)
- [Лицензия / License](#лицензия--license)

---

## Быстрый старт / Quick Start

Требуется **.NET 8+**.

```bash
git clone https://github.com/kyo-lzt/lolzteam-csharp.git
cd lolzteam-csharp
dotnet build
```

Минимальный пример:

```csharp
using Lolzteam.Api.Generated.Forum;
using Lolzteam.Api.Generated.Market;

// Быстрый старт — достаточно передать токен
using var forum = ForumClient.Create("your_token");
using var market = MarketClient.Create("your_token");

// Forum: получить список тем
var threads = await forum.Threads.ListAsync();

// Market: получить все категории
var items = await market.Category.AllAsync();
```

---

## Опции клиента / Client Options

Все настройки передаются через `ClientConfig`:

| Параметр | Тип | По умолчанию | Описание |
|----------|-----|-------------|----------|
| `Token` | `string` | *обязательный* | API токен доступа |
| `BaseUrl` | `string?` | per-client | Базовый URL API |
| `Proxy` | `ProxyConfig?` | `null` | Прокси (http/https/socks5) |
| `Timeout` | `TimeSpan?` | `30s` | Таймаут HTTP запроса |
| `Retry` | `RetryConfig?` | 3 попытки, 1s base, 30s max | Настройки повторов |
| `RateLimit` | `RateLimitConfig?` | Forum: 300/min, Market: 120/min | Лимит запросов |
| `SearchRateLimit` | `RateLimitConfig?` | Market: 20/min | Лимит поисковых запросов |
| `OnRetry` | `Action<RetryInfo>?` | `null` | Колбэк при повторе |

```csharp
var config = new ClientConfig
{
    Token = "your_token",
    BaseUrl = "https://prod-api.lolz.live",
    Proxy = new ProxyConfig("http://user:pass@127.0.0.1:8080"),
    Timeout = TimeSpan.FromSeconds(30),
    Retry = new RetryConfig
    {
        MaxRetries = 5,
        BaseDelay = TimeSpan.FromSeconds(1),
        MaxDelay = TimeSpan.FromSeconds(30),
    },
    RateLimit = new RateLimitConfig(200),
    SearchRateLimit = new RateLimitConfig(30),
    OnRetry = info => Console.WriteLine($"Retry #{info.Attempt}: {info.StatusCode}"),
};
```

---

## Прокси / Proxy

Поддерживаемые схемы: `http`, `https`, `socks5`.

```csharp
// HTTP прокси
var config = new ClientConfig { Token = "...", Proxy = new ProxyConfig("http://127.0.0.1:8080") };

// Прокси с авторизацией
var config = new ClientConfig { Token = "...", Proxy = new ProxyConfig("http://user:pass@127.0.0.1:8080") };

// SOCKS5 прокси
var config = new ClientConfig { Token = "...", Proxy = new ProxyConfig("socks5://127.0.0.1:1080") };
```

---

## Авто-retry / Auto-retry

Неудачные запросы повторяются автоматически для транзиентных ошибок. Задержка — экспоненциальный backoff с джиттером. Заголовок `Retry-After` на 429 учитывается.

| Статус | Повтор | Поведение |
|--------|--------|-----------|
| 429 | Да | Использует `Retry-After` если есть |
| 502, 503, 504 | Да | Экспоненциальный backoff с джиттером |
| Сетевые ошибки | Да | Таймаут и ошибки соединения |
| 401, 403 | Нет | Бросается сразу |
| 404 | Нет | Бросается сразу |

Формула задержки: `min(baseDelay * 2^attempt + random(0, baseDelay), maxDelay)`

```csharp
// Отключить retry
var client = new ForumClient(new ClientConfig { Token = "...", Retry = null });

// Колбэк OnRetry
var client = new ForumClient(new ClientConfig
{
    Token = "...",
    OnRetry = info => Console.WriteLine($"Retry #{info.Attempt}"),
});
```

---

## Обработка ошибок / Error Handling

Все исключения наследуют `LolzteamException`:

```
LolzteamException
├── HttpException
│   ├── RateLimitException    (429)
│   ├── AuthException         (401, 403)
│   ├── NotFoundException     (404)
│   └── ServerException       (500, 501, 502, 503)
├── NetworkException
└── ConfigException
```

```csharp
try
{
    var result = await forum.Threads.ListAsync();
}
catch (RateLimitException e)
{
    Console.WriteLine($"Rate limited, retry after: {e.RetryAfter}");
}
catch (AuthException e)
{
    Console.WriteLine($"Auth failed: {e.StatusCode}");
}
catch (NotFoundException)
{
    Console.WriteLine("Not found");
}
catch (ServerException e)
{
    Console.WriteLine($"Server error: {e.StatusCode}");
}
catch (HttpException e)
{
    Console.WriteLine($"HTTP {e.StatusCode}: {e.ResponseBody}");
}
catch (NetworkException e)
{
    Console.WriteLine($"Network error: {e.InnerException}");
}
```

---

## Rate Limits

Встроенный rate limiter использует алгоритм token bucket. Потокобезопасен через `SemaphoreSlim`. Когда bucket пуст, `AcquireAsync()` ждёт пополнения — запросы не отбрасываются.

| Клиент | Лимит по умолчанию |
|--------|--------------------|
| Forum  | 300 req/min |
| Market | 120 req/min |
| Market (search) | 20 req/min |

```csharp
var client = new MarketClient(new ClientConfig
{
    Token = "...",
    SearchRateLimit = new RateLimitConfig { RequestsPerMinute = 30 },
});
```

---

## Forum API

### OAuth

```csharp
// Получить токен доступа (POST /oauth/token)
var token = await forum.OAuth.TokenAsync(new OAuthApiTypes.OAuthTokenBody { /* ... */ });
```

### Ассеты / Assets

```csharp
// Получить CSS ассеты (GET /assets/css)
var css = await forum.Assets.CssAsync();
```

### Категории / Categories

```csharp
// Список категорий (GET /categories)
var categories = await forum.Categories.ListAsync();

// Получить категорию (GET /categories/{category_id})
var category = await forum.Categories.GetAsync(1);
```

### Форумы / Forums

```csharp
// Список форумов (GET /forums)
var forums = await forum.Forums.ListAsync();

// Форумы с группировкой (GET /forums/grouped)
var grouped = await forum.Forums.GroupedAsync();

// Получить форум (GET /forums/{forum_id})
var f = await forum.Forums.GetAsync(1);

// Подписчики форума (GET /forums/{forum_id}/followers)
var followers = await forum.Forums.FollowersAsync(1);

// Подписаться на форум (POST /forums/{forum_id}/followers)
var follow = await forum.Forums.FollowAsync(1);

// Отписаться от форума (DELETE /forums/{forum_id}/followers)
var unfollow = await forum.Forums.UnfollowAsync(1);

// Отслеживаемые форумы (GET /forums/followed)
var followed = await forum.Forums.FollowedAsync();

// Получить настройки ленты (GET /forums/feed-options)
var opts = await forum.Forums.GetFeedOptionsAsync();

// Изменить настройки ленты (PUT /forums/feed-options)
var edited = await forum.Forums.EditFeedOptionsAsync();
```

### Ссылки / Links

```csharp
// Список ссылок (GET /links)
var links = await forum.Links.ListAsync();

// Получить ссылку (GET /links/{link_id})
var link = await forum.Links.GetAsync(1);
```

### Страницы / Pages

```csharp
// Список страниц (GET /pages)
var pages = await forum.Pages.ListAsync();

// Получить страницу (GET /pages/{page_id})
var page = await forum.Pages.GetAsync(1);
```

### Навигация / Navigation

```csharp
// Список элементов навигации (GET /navigation)
var nav = await forum.Navigation.ListAsync();
```

### Темы / Threads

```csharp
// Список тем (GET /threads)
var threads = await forum.Threads.ListAsync();

// Создать тему (POST /threads)
var thread = await forum.Threads.CreateAsync(new() { ForumId = 876, PostBody = "Текст", Title = "Заголовок" });

// Создать конкурс (POST /threads/contests)
var contest = await forum.Threads.CreateContestAsync(new() { ForumId = 876, PostBody = "Текст", Title = "Конкурс" });

// Заявка на награду (POST /threads/claims)
var claim = await forum.Threads.ClaimAsync(new() { ThreadId = 1 });

// Получить тему (GET /threads/{thread_id})
var thread = await forum.Threads.GetAsync(1);

// Редактировать тему (PUT /threads/{thread_id})
var edited = await forum.Threads.EditAsync(1);

// Удалить тему (DELETE /threads/{thread_id})
var deleted = await forum.Threads.DeleteAsync(1);

// Переместить тему (POST /threads/{thread_id}/move)
var moved = await forum.Threads.MoveAsync(1, new() { ForumId = 2 });

// Поднять тему (POST /threads/{thread_id}/bump)
var bumped = await forum.Threads.BumpAsync(1);

// Скрыть тему (POST /threads/{thread_id}/hide)
var hidden = await forum.Threads.HideAsync(1);

// Добавить в избранное (POST /threads/{thread_id}/star)
var starred = await forum.Threads.StarAsync(1);

// Убрать из избранного (DELETE /threads/{thread_id}/star)
var unstarred = await forum.Threads.UnstarAsync(1);

// Подписчики темы (GET /threads/{thread_id}/followers)
var followers = await forum.Threads.FollowersAsync(1);

// Подписаться на тему (POST /threads/{thread_id}/followers)
var follow = await forum.Threads.FollowAsync(1);

// Отписаться от темы (DELETE /threads/{thread_id}/followers)
var unfollow = await forum.Threads.UnfollowAsync(1);

// Отслеживаемые темы (GET /threads/followed)
var followed = await forum.Threads.FollowedAsync();

// Навигация по теме (GET /threads/{thread_id}/navigation)
var nav = await forum.Threads.NavigationAsync(1);

// Получить опрос (GET /threads/{thread_id}/poll)
var poll = await forum.Threads.PollGetAsync(1);

// Голосовать в опросе (POST /threads/{thread_id}/poll/votes)
var vote = await forum.Threads.PollVoteAsync(1);

// Непрочитанные темы (GET /threads/unread)
var unread = await forum.Threads.UnreadAsync();

// Последние темы (GET /threads/recent)
var recent = await forum.Threads.RecentAsync();

// Завершить конкурс (POST /threads/{thread_id}/finish)
var finished = await forum.Threads.FinishAsync(1);
```

### Посты / Posts

```csharp
// Список постов (GET /posts)
var posts = await forum.Posts.ListAsync();

// Создать пост (POST /posts)
var post = await forum.Posts.CreateAsync(new() { ThreadId = 1, PostBody = "Текст" });

// Получить пост (GET /posts/{post_id})
var post = await forum.Posts.GetAsync(1);

// Редактировать пост (PUT /posts/{post_id})
var edited = await forum.Posts.EditAsync(1);

// Удалить пост (DELETE /posts/{post_id})
var deleted = await forum.Posts.DeleteAsync(1);

// Лайки поста (GET /posts/{post_id}/likes)
var likes = await forum.Posts.LikesAsync(1);

// Лайкнуть пост (POST /posts/{post_id}/likes)
var liked = await forum.Posts.LikeAsync(1);

// Убрать лайк (DELETE /posts/{post_id}/likes)
var unliked = await forum.Posts.UnlikeAsync(1);

// Причины жалоб (GET /posts/{post_id}/report/reasons)
var reasons = await forum.Posts.ReportReasonsAsync(1);

// Пожаловаться на пост (POST /posts/{post_id}/report)
var report = await forum.Posts.ReportAsync(1, new() { Message = "Причина" });

// Получить комментарии (GET /posts/comments)
var comments = await forum.Posts.CommentsGetAsync();

// Создать комментарий (POST /posts/comments)
var comment = await forum.Posts.CommentsCreateAsync(new() { PostId = 1, CommentBody = "Текст" });

// Редактировать комментарий (PUT /posts/comments)
var edited = await forum.Posts.CommentsEditAsync(new() { CommentBody = "Новый текст" });

// Удалить комментарий (DELETE /posts/comments)
var deleted = await forum.Posts.CommentsDeleteAsync(new() { CommentId = 1 });

// Пожаловаться на комментарий (POST /posts/comments/report)
var report = await forum.Posts.CommentsReportAsync(new() { CommentId = 1, Message = "Причина" });
```

### Пользователи / Users

```csharp
// Список пользователей (GET /users)
var users = await forum.Users.ListAsync();

// Поля пользователей (GET /users/fields)
var fields = await forum.Users.FieldsAsync();

// Поиск пользователей (GET /users/find)
var found = await forum.Users.FindAsync();

// Получить пользователя (GET /users/{user_id})
var user = await forum.Users.GetAsync(1);

// Редактировать пользователя (PUT /users/{user_id})
var edited = await forum.Users.EditAsync(1);

// Жалобы пользователя (GET /users/{user_id}/claims)
var claims = await forum.Users.ClaimsAsync(1);

// Загрузить аватар (POST /users/{user_id}/avatar)
var avatar = await forum.Users.AvatarUploadAsync(1, new() { Avatar = "base64..." });

// Удалить аватар (DELETE /users/{user_id}/avatar)
var deleted = await forum.Users.AvatarDeleteAsync(1);

// Обрезать аватар (POST /users/{user_id}/avatar-crop)
var cropped = await forum.Users.AvatarCropAsync(1);

// Загрузить фон (POST /users/{user_id}/background)
var bg = await forum.Users.BackgroundUploadAsync(1, new() { Background = "base64..." });

// Удалить фон (DELETE /users/{user_id}/background)
var deleted = await forum.Users.BackgroundDeleteAsync(1);

// Обрезать фон (POST /users/{user_id}/background-crop)
var cropped = await forum.Users.BackgroundCropAsync(1, new() { Size = 100 });

// Подписчики (GET /users/{user_id}/followers)
var followers = await forum.Users.FollowersAsync(1);

// Подписаться (POST /users/{user_id}/followers)
var follow = await forum.Users.FollowAsync(1);

// Отписаться (DELETE /users/{user_id}/followers)
var unfollow = await forum.Users.UnfollowAsync(1);

// Подписки (GET /users/{user_id}/followings)
var followings = await forum.Users.FollowingsAsync(1);

// Лайки пользователя (GET /users/{user_id}/likes)
var likes = await forum.Users.LikesAsync(1);

// Список игнора (GET /users/ignored)
var ignored = await forum.Users.IgnoredAsync();

// Добавить в игнор (POST /users/{user_id}/ignore)
var ignore = await forum.Users.IgnoreAsync(1);

// Редактировать игнор (PUT /users/{user_id}/ignore)
var edit = await forum.Users.IgnoreEditAsync(1);

// Убрать из игнора (DELETE /users/{user_id}/ignore)
var unignore = await forum.Users.UnignoreAsync(1);

// Контент пользователя (GET /users/{user_id}/contents)
var contents = await forum.Users.ContentsAsync(1);

// Трофеи (GET /users/{user_id}/trophies)
var trophies = await forum.Users.TrophiesAsync(1);

// Типы секретных ответов (GET /users/secret-answer-types)
var types = await forum.Users.SecretAnswerTypesAsync();

// Сброс секретного ответа (POST /users/secret-answer/reset)
var reset = await forum.Users.SaResetAsync();

// Отмена сброса секретного ответа (DELETE /users/secret-answer/reset)
var cancel = await forum.Users.SaCancelResetAsync();
```

### Посты профиля / Profile Posts

```csharp
// Список постов профиля (GET /profile-posts)
var posts = await forum.ProfilePosts.ListAsync(1);

// Создать пост профиля (POST /profile-posts)
var post = await forum.ProfilePosts.CreateAsync(new() { UserId = 1, PostBody = "Текст" });

// Получить пост профиля (GET /profile-posts/{profile_post_id})
var post = await forum.ProfilePosts.GetAsync(1);

// Редактировать пост профиля (PUT /profile-posts/{profile_post_id})
var edited = await forum.ProfilePosts.EditAsync(1);

// Удалить пост профиля (DELETE /profile-posts/{profile_post_id})
var deleted = await forum.ProfilePosts.DeleteAsync(1);

// Причины жалоб (GET /profile-posts/{profile_post_id}/report/reasons)
var reasons = await forum.ProfilePosts.ReportReasonsAsync(1);

// Пожаловаться (POST /profile-posts/{profile_post_id}/report)
var report = await forum.ProfilePosts.ReportAsync(1, new() { Message = "Причина" });

// Закрепить пост (POST /profile-posts/{profile_post_id}/stick)
var stick = await forum.ProfilePosts.StickAsync(1);

// Открепить пост (DELETE /profile-posts/{profile_post_id}/stick)
var unstick = await forum.ProfilePosts.UnstickAsync(1);

// Лайки поста (GET /profile-posts/{profile_post_id}/likes)
var likes = await forum.ProfilePosts.LikesAsync(1);

// Лайкнуть (POST /profile-posts/{profile_post_id}/likes)
var liked = await forum.ProfilePosts.LikeAsync(1);

// Убрать лайк (DELETE /profile-posts/{profile_post_id}/likes)
var unliked = await forum.ProfilePosts.UnlikeAsync(1);

// Список комментариев (GET /profile-posts/comments)
var comments = await forum.ProfilePosts.CommentsListAsync();

// Создать комментарий (POST /profile-posts/comments)
var comment = await forum.ProfilePosts.CommentsCreateAsync(new() { ProfilePostId = 1, CommentBody = "Текст" });

// Редактировать комментарий (PUT /profile-posts/comments)
var edited = await forum.ProfilePosts.CommentsEditAsync(new() { CommentBody = "Новый текст" });

// Удалить комментарий (DELETE /profile-posts/comments)
var deleted = await forum.ProfilePosts.CommentsDeleteAsync(new() { CommentId = 1 });

// Получить комментарий (GET /profile-posts/{profile_post_id}/comments/{comment_id})
var comment = await forum.ProfilePosts.CommentsGetAsync(1, 1);

// Пожаловаться на комментарий (POST /profile-posts/comments/{comment_id}/report)
var report = await forum.ProfilePosts.CommentsReportAsync(1, new() { Message = "Причина" });
```

### Личные сообщения / Conversations

```csharp
// Список диалогов (GET /conversations)
var convos = await forum.Conversations.ListAsync();

// Создать диалог (POST /conversations)
var convo = await forum.Conversations.CreateAsync();

// Обновить диалог (PUT /conversations)
var updated = await forum.Conversations.UpdateAsync(new() { ConversationId = 1, Title = "Новый" });

// Удалить диалог (DELETE /conversations)
var deleted = await forum.Conversations.DeleteAsync(new() { ConversationId = 1 });

// Начать диалог (POST /conversations/start)
var started = await forum.Conversations.StartAsync(new() { RecipientId = 1, MessageBody = "Привет" });

// Сохранить диалог (POST /conversations/save)
var saved = await forum.Conversations.SaveAsync(new() { ConversationId = 1 });

// Получить диалог (GET /conversations/{conversation_id})
var convo = await forum.Conversations.GetAsync(1);

// Список сообщений (GET /conversations/{conversation_id}/messages)
var msgs = await forum.Conversations.MessagesListAsync(1);

// Создать сообщение (POST /conversations/{conversation_id}/messages)
var msg = await forum.Conversations.MessagesCreateAsync(1, new() { MessageBody = "Текст" });

// Поиск диалогов (POST /conversations/search)
var results = await forum.Conversations.SearchAsync();

// Получить сообщение (GET /conversations/messages/{message_id})
var msg = await forum.Conversations.MessagesGetAsync(1);

// Редактировать сообщение (PUT /conversations/{conversation_id}/messages/{message_id})
var edited = await forum.Conversations.MessagesEditAsync(1, 1, new() { MessageBody = "Новый" });

// Удалить сообщение (DELETE /conversations/{conversation_id}/messages/{message_id})
var deleted = await forum.Conversations.MessagesDeleteAsync(1, 1);

// Пригласить в диалог (POST /conversations/{conversation_id}/invite)
var invite = await forum.Conversations.InviteAsync(1, new() { UserId = 2 });

// Кикнуть из диалога (POST /conversations/{conversation_id}/kick)
var kick = await forum.Conversations.KickAsync(1, new() { UserId = 2 });

// Прочитать диалог (POST /conversations/{conversation_id}/read)
var read = await forum.Conversations.ReadAsync(1);

// Прочитать все (POST /conversations/read)
var readAll = await forum.Conversations.ReadAllAsync();

// Закрепить сообщение (POST /conversations/{conversation_id}/messages/{message_id}/stick)
var stick = await forum.Conversations.MessagesStickAsync(1, 1);

// Открепить сообщение (DELETE /conversations/{conversation_id}/messages/{message_id}/stick)
var unstick = await forum.Conversations.MessagesUnstickAsync(1, 1);

// Пометить звездой (POST /conversations/{conversation_id}/star)
var star = await forum.Conversations.StarAsync(1);

// Убрать звезду (DELETE /conversations/{conversation_id}/star)
var unstar = await forum.Conversations.UnstarAsync(1);

// Включить уведомления (POST /conversations/{conversation_id}/alerts/enable)
var enable = await forum.Conversations.AlertsEnableAsync(1);

// Отключить уведомления (POST /conversations/{conversation_id}/alerts/disable)
var disable = await forum.Conversations.AlertsDisableAsync(1);
```

### Уведомления / Notifications

```csharp
// Список уведомлений (GET /notifications)
var notifs = await forum.Notifications.ListAsync();

// Получить уведомление (GET /notifications/{notification_id})
var notif = await forum.Notifications.GetAsync(1);

// Прочитать уведомления (POST /notifications/read)
var read = await forum.Notifications.ReadAsync();
```

### Теги / Tags

```csharp
// Популярные теги (GET /tags/popular)
var popular = await forum.Tags.PopularAsync();

// Список тегов (GET /tags)
var tags = await forum.Tags.ListAsync();

// Получить тег (GET /tags/{tag_id})
var tag = await forum.Tags.GetAsync(1);

// Найти тег (GET /tags/find)
var found = await forum.Tags.FindAsync();
```

### Поиск / Search

```csharp
// Поиск по всему (POST /search)
var all = await forum.Search.AllAsync();

// Поиск тем (POST /search/threads)
var threads = await forum.Search.ThreadsAsync();

// Поиск постов (POST /search/posts)
var posts = await forum.Search.PostsAsync();

// Поиск пользователей (POST /search/users)
var users = await forum.Search.UsersAsync();

// Поиск постов профиля (POST /search/profile-posts)
var pp = await forum.Search.ProfilePostsAsync();

// Поиск по тегам (POST /search/tagged)
var tagged = await forum.Search.TaggedAsync();

// Результаты поиска (GET /search/{search_id})
var results = await forum.Search.ResultsAsync(1);
```

### Batch

```csharp
// Выполнить batch-запрос (POST /batch)
var batch = await forum.Batch.ExecuteAsync();
```

### Чатбокс / Chatbox

```csharp
// Индекс чатбокса (GET /chatbox)
var index = await forum.Chatbox.IndexAsync();

// Получить сообщения (GET /chatbox/messages)
var msgs = await forum.Chatbox.GetMessagesAsync();

// Отправить сообщение (POST /chatbox/messages)
var msg = await forum.Chatbox.PostMessageAsync(new() { MessageBody = "Привет" });

// Редактировать сообщение (PUT /chatbox/messages)
var edited = await forum.Chatbox.EditMessageAsync(new() { MessageId = 1, MessageBody = "Новый" });

// Удалить сообщение (DELETE /chatbox/messages)
var deleted = await forum.Chatbox.DeleteMessageAsync(new() { MessageId = 1 });

// Онлайн в комнате (GET /chatbox/{room_id}/online)
var online = await forum.Chatbox.OnlineAsync();

// Причины жалоб (GET /chatbox/report/reasons)
var reasons = await forum.Chatbox.ReportReasonsAsync();

// Пожаловаться (POST /chatbox/report)
var report = await forum.Chatbox.ReportAsync(new() { MessageId = 1, Message = "Причина" });

// Лидерборд (GET /chatbox/leaderboard)
var leaders = await forum.Chatbox.GetLeaderboardAsync();

// Получить список игнора (GET /chatbox/ignore)
var ignore = await forum.Chatbox.GetIgnoreAsync();

// Добавить в игнор (POST /chatbox/ignore)
var added = await forum.Chatbox.PostIgnoreAsync(new() { UserId = 1 });

// Убрать из игнора (DELETE /chatbox/ignore)
var removed = await forum.Chatbox.DeleteIgnoreAsync(new() { UserId = 1 });
```

### Формы / Forms

```csharp
// Список форм (GET /forms)
var forms = await forum.Forms.ListAsync();

// Создать форму (POST /forms/save)
var form = await forum.Forms.CreateAsync(new() { /* ... */ });
```

---

## Market API

### Категории / Category

```csharp
// Все категории (GET /market)
var all = await market.Category.AllAsync();

// Steam (GET /market/steam)
var steam = await market.Category.SteamAsync();

// Fortnite (GET /market/fortnite)
var fortnite = await market.Category.FortniteAsync();

// Mihoyo (GET /market/mihoyo)
var mihoyo = await market.Category.MihoyoAsync();

// Riot (GET /market/riot)
var riot = await market.Category.RiotAsync();

// Telegram (GET /market/telegram)
var telegram = await market.Category.TelegramAsync();

// Supercell (GET /market/supercell)
var supercell = await market.Category.SupercellAsync();

// EA (GET /market/ea)
var ea = await market.Category.EaAsync();

// WoT (GET /market/wot)
var wot = await market.Category.WotAsync();

// WoT Blitz (GET /market/wot-blitz)
var wotBlitz = await market.Category.WotBlitzAsync();

// Gifts (GET /market/gifts)
var gifts = await market.Category.GiftsAsync();

// Epic Games (GET /market/epicgames)
var epic = await market.Category.EpicGamesAsync();

// Escape from Tarkov (GET /market/escape-from-tarkov)
var eft = await market.Category.EscapeFromTarkovAsync();

// Social Club (GET /market/socialclub)
var sc = await market.Category.SocialClubAsync();

// Uplay (GET /market/uplay)
var uplay = await market.Category.UplayAsync();

// Discord (GET /market/discord)
var discord = await market.Category.DiscordAsync();

// TikTok (GET /market/tiktok)
var tiktok = await market.Category.TikTokAsync();

// Instagram (GET /market/instagram)
var ig = await market.Category.InstagramAsync();

// Battle.net (GET /market/battlenet)
var bnet = await market.Category.BattleNetAsync();

// ChatGPT (GET /market/chatgpt)
var gpt = await market.Category.ChatGPTAsync();

// VPN (GET /market/vpn)
var vpn = await market.Category.VpnAsync();

// Roblox (GET /market/roblox)
var roblox = await market.Category.RobloxAsync();

// Warface (GET /market/warface)
var warface = await market.Category.WarfaceAsync();

// Minecraft (GET /market/minecraft)
var mc = await market.Category.MinecraftAsync();

// Hytale (GET /market/hytale)
var hytale = await market.Category.HytaleAsync();

// Список подкатегорий (GET /market/category)
var list = await market.Category.ListAsync();

// Параметры категории (GET /market/{category_name}/params)
var catParams = await market.Category.ParamsAsync("steam");

// Игры категории (GET /market/{category_name}/games)
var games = await market.Category.GamesAsync("steam");
```

### Список / List

```csharp
// Аккаунты пользователя (GET /market/user)
var user = await market.List.UserAsync();

// Заказы (GET /market/user/orders)
var orders = await market.List.OrdersAsync();

// Статусы (GET /market/user/states)
var states = await market.List.StatesAsync();

// Скачать данные (GET /market/user/{type}/download)
var download = await market.List.DownloadAsync("accounts");

// Избранное (GET /market/fave)
var faves = await market.List.FavoritesAsync();

// Просмотренные (GET /market/viewed)
var viewed = await market.List.ViewedAsync();
```

### Управление / Managing

```csharp
// Получить аккаунт (GET /market/{item_id})
var item = await market.Managing.GetAsync(123);

// Удалить аккаунт (DELETE /market/{item_id})
var deleted = await market.Managing.DeleteAsync(123, new() { Reason = "Не нужен" });

// Создать жалобу (POST /market/claims)
var claim = await market.Managing.CreateClaimAsync(new() { ItemId = 123 });

// Массовое получение (POST /market/bulk-get)
var bulk = await market.Managing.BulkGetAsync(new() { ItemIds = [1, 2, 3] });

// Стоимость инвентаря Steam (GET /market/{item_id}/steam-inventory-value)
var inv = await market.Managing.SteamInventoryValueAsync(123);

// Стоимость Steam (GET /market/steam-value)
var val = await market.Managing.SteamValueAsync();

// Превью Steam (GET /market/{item_id}/steam-preview)
var preview = await market.Managing.SteamPreviewAsync(123);

// Редактировать аккаунт (PUT /market/{item_id}/edit)
var edited = await market.Managing.EditAsync(123);

// AI-оценка (GET /market/{item_id}/ai-price)
var price = await market.Managing.AIPriceAsync(123);

// Цена автопокупки (GET /market/{item_id}/auto-buy-price)
var abp = await market.Managing.AutoBuyPriceAsync(123);

// Заметка (POST /market/{item_id}/note)
var note = await market.Managing.NoteAsync(123);

// Обновить стоимость Steam (PUT /market/{item_id}/steam-value)
var updated = await market.Managing.SteamUpdateValueAsync(123);

// Поднять аккаунт (POST /market/{item_id}/bump)
var bumped = await market.Managing.BumpAsync(123);

// Автоподнятие (POST /market/{item_id}/auto-bump)
var ab = await market.Managing.AutoBumpAsync(123, new() { Interval = 3600 });

// Отключить автоподнятие (DELETE /market/{item_id}/auto-bump)
var disabled = await market.Managing.AutoBumpDisableAsync(123);

// Открыть аккаунт (POST /market/{item_id}/open)
var opened = await market.Managing.OpenAsync(123);

// Закрыть аккаунт (POST /market/{item_id}/close)
var closed = await market.Managing.CloseAsync(123);

// Получить изображения (GET /market/{item_id}/image)
var img = await market.Managing.ImageAsync(123);

// Email код (GET /market/{item_id}/email-code)
var code = await market.Managing.EmailCodeAsync(123);

// Получить письма (GET /market/letters)
var letters = await market.Managing.GetLetters2Async();

// Получить MA-файл Steam (GET /market/{item_id}/steam-mafile)
var mafile = await market.Managing.SteamGetMafileAsync(123);

// Добавить MA-файл Steam (POST /market/{item_id}/steam-mafile)
var added = await market.Managing.SteamAddMafileAsync(123);

// Удалить MA-файл Steam (DELETE /market/{item_id}/steam-mafile)
var removed = await market.Managing.SteamRemoveMafileAsync(123);

// Код MA-файла Steam (GET /market/{item_id}/steam-mafile-code)
var code = await market.Managing.SteamMafileCodeAsync(123);

// Steam Desktop Authenticator (POST /market/{item_id}/steam-sda)
var sda = await market.Managing.SteamSDAAsync(123);

// Код Telegram (GET /market/{item_id}/telegram-code)
var code = await market.Managing.TelegramCodeAsync(123);

// Сброс авторизации Telegram (POST /market/{item_id}/telegram-reset-auth)
var reset = await market.Managing.TelegramResetAuthAsync(123);

// Отказ от гарантии (POST /market/{item_id}/refuse-guarantee)
var refused = await market.Managing.RefuseGuaranteeAsync(123);

// Отклонить видеозапись (POST /market/{item_id}/decline-video-recording)
var declined = await market.Managing.DeclineVideoRecordingAsync(123, new() { Reason = "Нет" });

// Проверить гарантию (POST /market/{item_id}/check-guarantee)
var checked = await market.Managing.CheckGuaranteeAsync(123);

// Сменить пароль (POST /market/{item_id}/change-password)
var changed = await market.Managing.ChangePasswordAsync(123);

// Временный пароль email (GET /market/{item_id}/temp-email-password)
var temp = await market.Managing.TempEmailPasswordAsync(123);

// Установить тег (POST /market/{item_id}/tag)
var tagged = await market.Managing.TagAsync(123, new() { TagId = 1 });

// Убрать тег (DELETE /market/{item_id}/tag)
var untagged = await market.Managing.UntagAsync(123, new() { TagId = 1 });

// Публичный тег (POST /market/{item_id}/public-tag)
var ptag = await market.Managing.PublicTagAsync(123, new() { TagId = 1 });

// Убрать публичный тег (DELETE /market/{item_id}/public-tag)
var uptag = await market.Managing.PublicUntagAsync(123, new() { TagId = 1 });

// В избранное (POST /market/{item_id}/star)
var faved = await market.Managing.FavoriteAsync(123);

// Убрать из избранного (DELETE /market/{item_id}/star)
var unfaved = await market.Managing.UnfavoriteAsync(123);

// Закрепить (POST /market/{item_id}/stick)
var stuck = await market.Managing.StickAsync(123);

// Открепить (DELETE /market/{item_id}/stick)
var unstuck = await market.Managing.UnstickAsync(123);

// Передать аккаунт (POST /market/{item_id}/transfer)
var transferred = await market.Managing.TransferAsync(123, new() { UserId = 1 });
```

### Профиль / Profile

```csharp
// Получить профиль (GET /market/me)
var profile = await market.Profile.GetAsync();

// Редактировать профиль (PUT /market/me)
var edited = await market.Profile.EditAsync();

// Жалобы (GET /market/me/claims)
var claims = await market.Profile.ClaimsAsync();
```

### Корзина / Cart

```csharp
// Получить корзину (GET /market/cart)
var cart = await market.Cart.GetAsync();

// Добавить в корзину (POST /market/cart)
var added = await market.Cart.AddAsync(new() { ItemId = 123 });

// Удалить из корзины (DELETE /market/cart)
var deleted = await market.Cart.DeleteAsync();
```

### Покупка / Purchasing

```csharp
// Быстрая покупка (POST /market/{item_id}/fast-buy)
var buy = await market.Purchasing.FastBuyAsync(123);

// Проверить аккаунт (POST /market/{item_id}/check-account)
var check = await market.Purchasing.CheckAsync(123);

// Подтвердить покупку (POST /market/{item_id}/confirm-buy)
var confirm = await market.Purchasing.ConfirmAsync(123);

// Запрос скидки (POST /market/{item_id}/discount-request)
var req = await market.Purchasing.DiscountRequestAsync(123, new() { Price = 100 });

// Отменить запрос скидки (DELETE /market/{item_id}/discount-request)
var cancel = await market.Purchasing.DiscountCancelAsync(123);
```

### Кастомные скидки / Custom Discounts

```csharp
// Получить скидки (GET /market/custom-discounts)
var discounts = await market.CustomDiscounts.GetAsync();

// Создать скидку (POST /market/custom-discounts)
var created = await market.CustomDiscounts.CreateAsync(new() { Discount = 10 });

// Редактировать скидку (PUT /market/custom-discounts)
var edited = await market.CustomDiscounts.EditAsync(new() { Discount = 15 });

// Удалить скидку (DELETE /market/custom-discounts)
var deleted = await market.CustomDiscounts.DeleteAsync(new() { DiscountId = 1 });
```

### Публикация / Publishing

```csharp
// Быстрая продажа (POST /item/fast-sell)
var sold = await market.Publishing.FastSellAsync(new() { Price = 100, CategoryId = 1, Currency = "rub", ItemOrigin = "brute" });

// Добавить аккаунт (POST /item/add)
var added = await market.Publishing.AddAsync(new() { Price = 100, CategoryId = 1, Currency = "rub", ItemOrigin = "brute" });

// Проверить детали (POST /{item_id}/goods/check)
var check = await market.Publishing.CheckAsync(123);

// Внешний аккаунт (POST /{item_id}/external-account)
var ext = await market.Publishing.ExternalAsync(123, new() { Login = "user", Password = "pass" });
```

### Платежи / Payments

```csharp
// Получить инвойс (GET /market/payments/invoice)
var invoice = await market.Payments.InvoiceGetAsync();

// Создать инвойс (POST /market/payments/invoice)
var created = await market.Payments.InvoiceCreateAsync(new() { Amount = 100 });

// Список инвойсов (GET /market/payments/invoices)
var list = await market.Payments.InvoiceListAsync();

// Валюты (GET /market/payments/currency)
var currency = await market.Payments.CurrencyAsync();

// Список балансов (GET /market/payments/balance)
var balance = await market.Payments.BalanceListAsync();

// Обмен валют (POST /market/payments/balance/exchange)
var exchange = await market.Payments.BalanceExchangeAsync(new() { Amount = 100, From = "rub", To = "usd" });

// Перевод средств (POST /market/payments/transfer)
var transfer = await market.Payments.TransferAsync(new() { UserId = 1, Amount = 100 });

// Комиссия (GET /market/payments/fee)
var fee = await market.Payments.FeeAsync();

// Отмена платежа (POST /market/payments/cancel)
var cancel = await market.Payments.CancelAsync(new() { PaymentId = 1 });

// История платежей (GET /market/payments/history)
var history = await market.Payments.HistoryAsync();

// Сервисы выплат (GET /market/payments/payout/services)
var services = await market.Payments.PayoutServicesAsync();

// Выплата (POST /market/payments/payout)
var payout = await market.Payments.PayoutAsync(new() { Amount = 100, Service = "card" });
```

### Автоплатежи / Auto Payments

```csharp
// Список автоплатежей (GET /market/auto-payments)
var list = await market.AutoPayments.ListAsync();

// Создать автоплатёж (POST /market/auto-payments)
var created = await market.AutoPayments.CreateAsync(new() { Amount = 100 });

// Удалить автоплатёж (DELETE /market/auto-payments)
var deleted = await market.AutoPayments.DeleteAsync(new() { PaymentId = 1 });
```

### Прокси / Proxy

```csharp
// Получить прокси (GET /market/proxy)
var proxy = await market.Proxy.GetAsync();

// Добавить прокси (POST /market/proxy)
var added = await market.Proxy.AddAsync(new() { ProxyUrl = "socks5://127.0.0.1:1080" });

// Удалить прокси (DELETE /market/proxy)
var deleted = await market.Proxy.DeleteAsync();
```

### IMAP

```csharp
// Создать IMAP (POST /market/imap)
var created = await market.Imap.CreateAsync(new() { Email = "test@example.com" });

// Удалить IMAP (DELETE /market/imap)
var deleted = await market.Imap.DeleteAsync(new() { Email = "test@example.com" });
```

### Batch

```csharp
// Batch-запрос (POST /market/batch)
var batch = await market.Batch.BatchAsync([]);
```

---

## Генерация кода / Code Generation

Клиенты и типы генерируются из OpenAPI 3.1.0 спецификаций в `schemas/`:

```bash
dotnet run --project codegen/Lolzteam.Codegen
```

| Вход | Выход |
|------|-------|
| `schemas/forum.json` | `Generated/Forum/ForumClient.cs`, `Types.cs` |
| `schemas/market.json` | `Generated/Market/MarketClient.cs`, `Types.cs` |

Исходный код генератора в `codegen/Lolzteam.Codegen/`.

---

## Сборка и тесты / Build & Test

```bash
dotnet build                                          # Собрать все проекты
dotnet run --project codegen/Lolzteam.Codegen         # Генерация клиентов из OpenAPI спецификаций
dotnet test                                           # Запустить тесты
```

---

## Структура проекта / Project Structure

```
schemas/                        OpenAPI 3.1.0 спецификации
codegen/Lolzteam.Codegen/      Генератор кода (console app)
src/Lolzteam.Api/
  Runtime/                      HTTP клиент, конфиг, retry, rate limiter, исключения
  Generated/
    Forum/                      ForumClient + типы (авто-генерация)
    Market/                     MarketClient + типы (авто-генерация)
tests/Lolzteam.Api.Tests/      xUnit тесты
Lolzteam.sln
```

---

## Лицензия / License

[MIT](LICENSE)
