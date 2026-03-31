// Auto-generated. Do not edit manually.

using System.Text.Json;
using Lolzteam.Api.Runtime;

namespace Lolzteam.Api.Generated.Forum;

public sealed class AssetsApi
{
    private readonly LolzteamHttpClient _http;

    public AssetsApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get CSS</summary>
    /// <remarks>
    /// Gets css rulesets for requested selectors.
    /// </remarks>
    public async Task<AssetsApiTypes.AssetsCssResponse> CssAsync(AssetsApiTypes.AssetsCssParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/css",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<AssetsApiTypes.AssetsCssResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class BatchApi
{
    private readonly LolzteamHttpClient _http;

    public BatchApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Batch</summary>
    /// <remarks>
    /// Execute multiple API requests at once (Separated by comma). Maximum batch jobs is 10.
    /// 
    /// Required scopes:
    /// + Same as called API requests.
    /// </remarks>
    public async Task<BatchApiTypes.BatchExecuteResponse> ExecuteAsync(List<JsonElement>? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/batch",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<BatchApiTypes.BatchExecuteResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class CategoriesApi
{
    private readonly LolzteamHttpClient _http;

    public CategoriesApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Categories</summary>
    /// <remarks>
    /// List of all categories in the system.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<CategoriesApiTypes.CategoriesListResponse> ListAsync(CategoriesApiTypes.CategoriesListParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/categories",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoriesApiTypes.CategoriesListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Category</summary>
    /// <remarks>
    /// Detail information of a category.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="CategoryId">Id of category.</param>
    public async Task<CategoriesApiTypes.CategoriesGetResponse> GetAsync(long CategoryId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/categories/{CategoryId}",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoriesApiTypes.CategoriesGetResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class ChatboxApi
{
    private readonly LolzteamHttpClient _http;

    public ChatboxApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Chats</summary>
    /// <remarks>
    /// Get chat rooms.
    /// 
    /// Required scopes:
    /// + chatbox
    /// </remarks>
    public async Task<ChatboxApiTypes.ChatboxIndexResponse> IndexAsync(ChatboxApiTypes.ChatboxIndexParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/chatbox",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ChatboxApiTypes.ChatboxIndexResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Chat Messages</summary>
    /// <remarks>
    /// Get chat messages.
    /// 
    /// Required scopes:
    /// + chatbox
    /// </remarks>
    public async Task<ChatboxApiTypes.ChatboxGetMessagesResponse> GetMessagesAsync(ChatboxApiTypes.ChatboxGetMessagesParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/chatbox/messages",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ChatboxApiTypes.ChatboxGetMessagesResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Create Chat Message</summary>
    /// <remarks>
    /// Create chat message.
    /// 
    /// Required scopes:
    /// + chatbox
    /// </remarks>
    public async Task<ChatboxApiTypes.ChatboxPostMessageResponse> PostMessageAsync(ChatboxApiTypes.ChatboxPostMessageBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/chatbox/messages",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ChatboxApiTypes.ChatboxPostMessageResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Edit Chat Message</summary>
    /// <remarks>
    /// Edit chat message.
    /// 
    /// Required scopes:
    /// + chatbox
    /// </remarks>
    public async Task<ChatboxApiTypes.ChatboxEditMessageResponse> EditMessageAsync(ChatboxApiTypes.ChatboxEditMessageBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "PUT",
            Path = "/chatbox/messages",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ChatboxApiTypes.ChatboxEditMessageResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Delete Chat Message</summary>
    /// <remarks>
    /// Delete chat message.
    /// 
    /// Required scopes:
    /// + chatbox
    /// </remarks>
    public async Task<ChatboxApiTypes.ChatboxDeleteMessageResponse> DeleteMessageAsync(ChatboxApiTypes.ChatboxDeleteMessageBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = "/chatbox/messages",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ChatboxApiTypes.ChatboxDeleteMessageResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Chat Online</summary>
    /// <remarks>
    /// Get chat Online Users.
    /// 
    /// Required scopes:
    /// + chatbox
    /// </remarks>
    public async Task<ChatboxApiTypes.ChatboxOnlineResponse> OnlineAsync(ChatboxApiTypes.ChatboxOnlineParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/chatbox/messages/online",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ChatboxApiTypes.ChatboxOnlineResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Chat Message Report Reasons</summary>
    /// <remarks>
    /// Report chat message.
    /// 
    /// Required scopes:
    /// + chatbox
    /// </remarks>
    public async Task<ChatboxApiTypes.ChatboxReportReasonsResponse> ReportReasonsAsync(ChatboxApiTypes.ChatboxReportReasonsParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/chatbox/messages/report",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ChatboxApiTypes.ChatboxReportReasonsResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Report Chat Message</summary>
    /// <remarks>
    /// Report chat message.
    /// 
    /// Required scopes:
    /// + chatbox
    /// </remarks>
    public async Task<ChatboxApiTypes.ChatboxReportResponse> ReportAsync(ChatboxApiTypes.ChatboxReportBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/chatbox/messages/report",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ChatboxApiTypes.ChatboxReportResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Chat Leaderboard</summary>
    /// <remarks>
    /// Get chat leaderboard.
    /// 
    /// Required scopes:
    /// + chatbox
    /// </remarks>
    public async Task<ChatboxApiTypes.ChatboxGetLeaderboardResponse> GetLeaderboardAsync(ChatboxApiTypes.ChatboxGetLeaderboardParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/chatbox/messages/leaderboard",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ChatboxApiTypes.ChatboxGetLeaderboardResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Ignored Chat Users</summary>
    /// <remarks>
    /// Get list of ignored chat users.
    /// 
    /// Required scopes:
    /// + chatbox
    /// </remarks>
    public async Task<ChatboxApiTypes.ChatboxGetIgnoreResponse> GetIgnoreAsync(CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/chatbox/ignore",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ChatboxApiTypes.ChatboxGetIgnoreResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Ignore Chat User</summary>
    /// <remarks>
    /// Ignore chat user.
    /// 
    /// Required scopes:
    /// + chatbox
    /// </remarks>
    public async Task<ChatboxApiTypes.ChatboxPostIgnoreResponse> PostIgnoreAsync(ChatboxApiTypes.ChatboxPostIgnoreBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/chatbox/ignore",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ChatboxApiTypes.ChatboxPostIgnoreResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Unignore Chat User</summary>
    /// <remarks>
    /// Unignore chat user.
    /// 
    /// Required scopes:
    /// + chatbox
    /// </remarks>
    public async Task<ChatboxApiTypes.ChatboxDeleteIgnoreResponse> DeleteIgnoreAsync(ChatboxApiTypes.ChatboxDeleteIgnoreBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = "/chatbox/ignore",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ChatboxApiTypes.ChatboxDeleteIgnoreResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class ConversationsApi
{
    private readonly LolzteamHttpClient _http;

    public ConversationsApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Conversations</summary>
    /// <remarks>
    /// List of conversations (with pagination).
    /// 
    /// Required scopes:
    /// + read
    /// + conversate
    /// </remarks>
    public async Task<ConversationsApiTypes.ConversationsListResponse> ListAsync(ConversationsApiTypes.ConversationsListParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/conversations",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Create Conversation</summary>
    /// <remarks>
    /// Create a new conversation.
    /// 
    /// Required scopes:
    /// + post
    /// + conversate
    /// </remarks>
    public async Task<ConversationsApiTypes.ConversationsCreateResponse> CreateAsync(ConversationsApiTypes.ConversationsCreateBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/conversations",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsCreateResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Edit Conversation</summary>
    /// <remarks>
    /// Edit conversation.
    /// 
    /// Required scopes:
    /// + conversate
    /// </remarks>
    public async Task<ConversationsApiTypes.ConversationsUpdateResponse> UpdateAsync(ConversationsApiTypes.ConversationsUpdateBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "PUT",
            Path = "/conversations",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsUpdateResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Leave Conversation</summary>
    /// <remarks>
    /// Leave the conversation.
    /// 
    /// Required scopes:
    /// + post
    /// + conversate
    /// </remarks>
    public async Task<ConversationsApiTypes.ConversationsDeleteResponse> DeleteAsync(ConversationsApiTypes.ConversationsDeleteBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = "/conversations",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsDeleteResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Start Conversation</summary>
    /// <remarks>
    /// Start a new conversation with a user.
    /// 
    /// Required scopes:
    /// + conversate
    /// </remarks>
    public async Task<ConversationsApiTypes.ConversationsStartResponse> StartAsync(ConversationsApiTypes.ConversationsStartBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/conversations/start",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsStartResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Send Content To Saved Messages</summary>
    /// <remarks>
    /// Send content to Saved Messages.
    /// 
    /// Required scopes:
    /// + conversate
    /// </remarks>
    public async Task<ConversationsApiTypes.ConversationsSaveResponse> SaveAsync(ConversationsApiTypes.ConversationsSaveBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/conversations/save",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsSaveResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Conversation</summary>
    /// <remarks>
    /// Detail information of a conversation.
    /// 
    /// Required scopes:
    /// + read
    /// + conversate
    /// </remarks>
    /// <param name="ConversationId">Id of conversation.</param>
    public async Task<ConversationsApiTypes.ConversationsGetResponse> GetAsync(long ConversationId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/conversations/{ConversationId}",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Conversation Messages</summary>
    /// <remarks>
    /// List of messages in a conversation (with pagination).
    /// 
    /// Required scopes:
    /// + read
    /// + conversate
    /// </remarks>
    /// <param name="ConversationId">Id of conversation.</param>
    public async Task<ConversationsApiTypes.ConversationsMessagesListResponse> MessagesListAsync(long ConversationId, ConversationsApiTypes.ConversationsMessagesListParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/conversations/{ConversationId}/messages",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsMessagesListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Create Conversation Message</summary>
    /// <remarks>
    /// Create a new conversation message.
    /// 
    /// Required scopes:
    /// + post
    /// + conversate
    /// </remarks>
    /// <param name="ConversationId">Id of conversation.</param>
    public async Task<ConversationsApiTypes.ConversationsMessagesCreateResponse> MessagesCreateAsync(long ConversationId, ConversationsApiTypes.ConversationsMessagesCreateBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/conversations/{ConversationId}/messages",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsMessagesCreateResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Search Conversations Messages</summary>
    /// <remarks>
    /// Search for conversations messages or recipients.
    /// 
    /// Required scopes:
    /// + read
    /// + conversate
    /// </remarks>
    public async Task<ConversationsApiTypes.ConversationsSearchResponse> SearchAsync(ConversationsApiTypes.ConversationsSearchBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/conversations/search",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsSearchResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Conversation Message</summary>
    /// <remarks>
    /// Detail information of a message.
    /// 
    /// Required scopes:
    /// + read
    /// + conversate
    /// </remarks>
    /// <param name="MessageId">Id of message.</param>
    public async Task<ConversationsApiTypes.ConversationsMessagesGetResponse> MessagesGetAsync(long MessageId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/conversations/messages/{MessageId}",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsMessagesGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Edit Conversation Message</summary>
    /// <remarks>
    /// Edit a message.
    /// 
    /// Required scopes:
    /// + post
    /// + conversate
    /// </remarks>
    /// <param name="ConversationId">Id of conversation.</param>
    /// <param name="MessageId">Id of message.</param>
    public async Task<ConversationsApiTypes.ConversationsMessagesEditResponse> MessagesEditAsync(long ConversationId, long MessageId, ConversationsApiTypes.ConversationsMessagesEditBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "PUT",
            Path = $"/conversations/{ConversationId}/messages/{MessageId}",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsMessagesEditResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Delete Conversation Message</summary>
    /// <remarks>
    /// Deletes a message from a conversation.
    /// 
    /// Required scopes:
    /// + conversate
    /// </remarks>
    /// <param name="ConversationId">Id of conversation.</param>
    /// <param name="MessageId">Id of message.</param>
    public async Task<ConversationsApiTypes.ConversationsMessagesDeleteResponse> MessagesDeleteAsync(long ConversationId, long MessageId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/conversations/{ConversationId}/messages/{MessageId}",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsMessagesDeleteResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Invite Users to Conversation</summary>
    /// <remarks>
    /// Invite one or more users to an existing conversation.
    /// 
    /// Required scopes:
    /// + conversate
    /// + post
    /// </remarks>
    /// <param name="ConversationId">Id of conversation.</param>
    public async Task<ConversationsApiTypes.ConversationsInviteResponse> InviteAsync(long ConversationId, ConversationsApiTypes.ConversationsInviteBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/conversations/{ConversationId}/invite",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsInviteResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Kick User from Conversation</summary>
    /// <remarks>
    /// Kicks a user from a conversation.
    /// 
    /// Required scopes:
    /// + conversate
    /// </remarks>
    /// <param name="ConversationId">Id of conversation.</param>
    public async Task<ConversationsApiTypes.ConversationsKickResponse> KickAsync(long ConversationId, ConversationsApiTypes.ConversationsKickBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/conversations/{ConversationId}/kick",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsKickResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Read a Conversation</summary>
    /// <remarks>
    /// Read a specific conversation.
    /// 
    /// Required scopes:
    /// + conversate
    /// </remarks>
    /// <param name="ConversationId">Id of conversation.</param>
    public async Task<ConversationsApiTypes.ConversationsReadResponse> ReadAsync(long ConversationId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/conversations/{ConversationId}/read",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsReadResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Read All Conversations</summary>
    /// <remarks>
    /// Mark all conversations as read.
    /// 
    /// Required scopes:
    /// + read
    /// + conversate
    /// </remarks>
    public async Task<ConversationsApiTypes.ConversationsReadAllResponse> ReadAllAsync(CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/conversations/read-all",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsReadAllResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Stick Conversation Message</summary>
    /// <remarks>
    /// Stick a message in a conversation.
    /// 
    /// Required scopes:
    /// + post
    /// + conversate
    /// </remarks>
    /// <param name="ConversationId">Id of conversation.</param>
    /// <param name="MessageId">Id of message.</param>
    public async Task<ConversationsApiTypes.ConversationsMessagesStickResponse> MessagesStickAsync(long ConversationId, long MessageId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/conversations/{ConversationId}/messages/{MessageId}/stick",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsMessagesStickResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Unstick Conversation Message</summary>
    /// <remarks>
    /// Unstick a message in a conversation.
    /// 
    /// Required scopes:
    /// + post
    /// + conversate
    /// </remarks>
    /// <param name="ConversationId">Id of conversation.</param>
    /// <param name="MessageId">Id of message.</param>
    public async Task<ConversationsApiTypes.ConversationsMessagesUnstickResponse> MessagesUnstickAsync(long ConversationId, long MessageId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/conversations/{ConversationId}/messages/{MessageId}/stick",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsMessagesUnstickResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Star Conversation</summary>
    /// <remarks>
    /// Star conversation.
    /// 
    /// Required scopes:
    /// + post
    /// + conversate
    /// </remarks>
    /// <param name="ConversationId">Id of conversation.</param>
    public async Task<ConversationsApiTypes.ConversationsStarResponse> StarAsync(long ConversationId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/conversations/{ConversationId}/star",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsStarResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Unstar Conversation</summary>
    /// <remarks>
    /// Unstar conversation.
    /// 
    /// Required scopes:
    /// + post
    /// + conversate
    /// </remarks>
    /// <param name="ConversationId">Id of conversation.</param>
    public async Task<ConversationsApiTypes.ConversationsUnstarResponse> UnstarAsync(long ConversationId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/conversations/{ConversationId}/star",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsUnstarResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Enable Conversation Alerts</summary>
    /// <remarks>
    /// Enable alerts for conversation.
    /// 
    /// Required scopes:
    /// + post
    /// + conversate
    /// </remarks>
    /// <param name="ConversationId">Id of conversation.</param>
    public async Task<ConversationsApiTypes.ConversationsAlertsEnableResponse> AlertsEnableAsync(long ConversationId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/conversations/{ConversationId}/alerts",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsAlertsEnableResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Disable Conversation Alerts</summary>
    /// <remarks>
    /// Disable alerts for conversation.
    /// 
    /// Required scopes:
    /// + post
    /// + conversate
    /// </remarks>
    /// <param name="ConversationId">Id of conversation.</param>
    public async Task<ConversationsApiTypes.ConversationsAlertsDisableResponse> AlertsDisableAsync(long ConversationId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/conversations/{ConversationId}/alerts",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ConversationsApiTypes.ConversationsAlertsDisableResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class FormsApi
{
    private readonly LolzteamHttpClient _http;

    public FormsApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Forms List</summary>
    /// <remarks>
    /// Get Forms List
    /// </remarks>
    public async Task<FormsApiTypes.FormsListResponse> ListAsync(FormsApiTypes.FormsListParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/forms",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<FormsApiTypes.FormsListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Create Form</summary>
    /// <remarks>
    /// Create Form.
    /// </remarks>
    public async Task<FormsApiTypes.FormsCreateResponse> CreateAsync(FormsApiTypes.FormsCreateBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/forms/save",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<FormsApiTypes.FormsCreateResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class ForumsApi
{
    private readonly LolzteamHttpClient _http;

    public ForumsApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Forums</summary>
    /// <remarks>
    /// List of all forums in the system.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<ForumsApiTypes.ForumsListResponse> ListAsync(ForumsApiTypes.ForumsListParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/forums",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ForumsApiTypes.ForumsListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Forums Tree</summary>
    /// <remarks>
    /// Returns grouped forums.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<ForumsApiTypes.ForumsGroupedResponse> GroupedAsync(CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/forums/grouped",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ForumsApiTypes.ForumsGroupedResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Forum</summary>
    /// <remarks>
    /// Detail information of a forum.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="ForumId">Id of forum.</param>
    public async Task<ForumsApiTypes.ForumsGetResponse> GetAsync(long ForumId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/forums/{ForumId}",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ForumsApiTypes.ForumsGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Followers</summary>
    /// <remarks>
    /// List of a forum's followers. For privacy reason, only the current user will be included in the list (if the user follows the specified forum).
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="ForumId">Id of forum.</param>
    public async Task<ForumsApiTypes.ForumsFollowersResponse> FollowersAsync(long ForumId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/forums/{ForumId}/followers",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ForumsApiTypes.ForumsFollowersResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Follow Forum</summary>
    /// <remarks>
    /// Follow a forum.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ForumId">Id of forum.</param>
    public async Task<ForumsApiTypes.ForumsFollowResponse> FollowAsync(long ForumId, ForumsApiTypes.ForumsFollowBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/forums/{ForumId}/followers",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ForumsApiTypes.ForumsFollowResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Unfollow Forum</summary>
    /// <remarks>
    /// Unfollow a forum.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ForumId">Id of forum.</param>
    public async Task<ForumsApiTypes.ForumsUnfollowResponse> UnfollowAsync(long ForumId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/forums/{ForumId}/followers",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ForumsApiTypes.ForumsUnfollowResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Followed Forums</summary>
    /// <remarks>
    /// List of followed forums by current user.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<ForumsApiTypes.ForumsFollowedResponse> FollowedAsync(ForumsApiTypes.ForumsFollowedParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/forums/followed",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ForumsApiTypes.ForumsFollowedResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Feed Options</summary>
    /// <remarks>
    /// Returns available options for the forums feed.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<ForumsApiTypes.ForumsGetFeedOptionsResponse> GetFeedOptionsAsync(CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/forums/feed/options",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ForumsApiTypes.ForumsGetFeedOptionsResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Edit Feed Options</summary>
    /// <remarks>
    /// Edit feed options.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<ForumsApiTypes.ForumsEditFeedOptionsResponse> EditFeedOptionsAsync(ForumsApiTypes.ForumsEditFeedOptionsBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "PUT",
            Path = "/forums/feed/options",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ForumsApiTypes.ForumsEditFeedOptionsResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class LinksApi
{
    private readonly LolzteamHttpClient _http;

    public LinksApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Links Forum</summary>
    /// <remarks>
    /// List of all link forums.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<LinksApiTypes.LinksListResponse> ListAsync(CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/link-forums",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<LinksApiTypes.LinksListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Link Forum</summary>
    /// <remarks>
    /// Detail information of a link forum.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="LinkId">Id of link forum.</param>
    public async Task<LinksApiTypes.LinksGetResponse> GetAsync(long LinkId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/link-forums/{LinkId}",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<LinksApiTypes.LinksGetResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class NavigationApi
{
    private readonly LolzteamHttpClient _http;

    public NavigationApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Navigation</summary>
    /// <remarks>
    /// List of navigation elements within the system.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<NavigationApiTypes.NavigationListResponse> ListAsync(NavigationApiTypes.NavigationListParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/navigation",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<NavigationApiTypes.NavigationListResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class NotificationsApi
{
    private readonly LolzteamHttpClient _http;

    public NotificationsApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Notifications</summary>
    /// <remarks>
    /// List of notifications (both read and unread).
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<NotificationsApiTypes.NotificationsListResponse> ListAsync(NotificationsApiTypes.NotificationsListParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/notifications",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<NotificationsApiTypes.NotificationsListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Notification</summary>
    /// <remarks>
    /// Get associated content of notification. The response depends on the content type.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="NotificationId">Id of notification.</param>
    public async Task<NotificationsApiTypes.NotificationsGetResponse> GetAsync(long NotificationId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/notifications/{NotificationId}/content",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<NotificationsApiTypes.NotificationsGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Mark Notification Read</summary>
    /// <remarks>
    /// Mark single notification or all existing notifications read.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<NotificationsApiTypes.NotificationsReadResponse> ReadAsync(NotificationsApiTypes.NotificationsReadBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/notifications/read",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<NotificationsApiTypes.NotificationsReadResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class OAuthApi
{
    private readonly LolzteamHttpClient _http;

    public OAuthApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Access Token</summary>
    /// <remarks>
    /// Obtain an access token using various grant types.
    /// 
    /// Supports the following grant types:
    /// - Client Credentials
    /// - Authorization Code
    /// - Refresh Token
    /// - Password
    /// </remarks>
    public async Task<OAuthApiTypes.OAuthTokenResponse> TokenAsync(OAuthApiTypes.OAuthTokenBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/oauth/token",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Multipart,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<OAuthApiTypes.OAuthTokenResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class PagesApi
{
    private readonly LolzteamHttpClient _http;

    public PagesApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Pages</summary>
    /// <remarks>
    /// List of all pages in the system.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<PagesApiTypes.PagesListResponse> ListAsync(PagesApiTypes.PagesListParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/pages",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PagesApiTypes.PagesListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Page</summary>
    /// <remarks>
    /// Detail information of a page.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="PageId">Id of page.</param>
    public async Task<PagesApiTypes.PagesGetResponse> GetAsync(long PageId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/pages/{PageId}",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PagesApiTypes.PagesGetResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class PostsApi
{
    private readonly LolzteamHttpClient _http;

    public PostsApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Posts</summary>
    /// <remarks>
    /// List of posts in a thread (with pagination).
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<PostsApiTypes.PostsListResponse> ListAsync(PostsApiTypes.PostsListParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/posts",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PostsApiTypes.PostsListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Create Post</summary>
    /// <remarks>
    /// Create a new post.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<PostsApiTypes.PostsCreateResponse> CreateAsync(PostsApiTypes.PostsCreateBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/posts",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PostsApiTypes.PostsCreateResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Post</summary>
    /// <remarks>
    /// Detail information of a post.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="PostId">Id of post.</param>
    public async Task<PostsApiTypes.PostsGetResponse> GetAsync(long PostId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/posts/{PostId}",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PostsApiTypes.PostsGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Edit Post</summary>
    /// <remarks>
    /// Edit a post.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="PostId">Id of post.</param>
    public async Task<PostsApiTypes.PostsEditResponse> EditAsync(long PostId, PostsApiTypes.PostsEditBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "PUT",
            Path = $"/posts/{PostId}",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PostsApiTypes.PostsEditResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Delete Post</summary>
    /// <remarks>
    /// Delete a post.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="PostId">Id of post.</param>
    public async Task<PostsApiTypes.PostsDeleteResponse> DeleteAsync(long PostId, PostsApiTypes.PostsDeleteBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/posts/{PostId}",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PostsApiTypes.PostsDeleteResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Post Likes</summary>
    /// <remarks>
    /// List of users who liked a post.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="PostId">Id of post.</param>
    public async Task<PostsApiTypes.PostsLikesResponse> LikesAsync(long PostId, PostsApiTypes.PostsLikesParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/posts/{PostId}/likes",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PostsApiTypes.PostsLikesResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Like Post</summary>
    /// <remarks>
    /// Like a post.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="PostId">Id of post.</param>
    public async Task<PostsApiTypes.PostsLikeResponse> LikeAsync(long PostId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/posts/{PostId}/likes",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PostsApiTypes.PostsLikeResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Unlike Post</summary>
    /// <remarks>
    /// Unlike a post.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="PostId">Id of post.</param>
    public async Task<PostsApiTypes.PostsUnlikeResponse> UnlikeAsync(long PostId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/posts/{PostId}/likes",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PostsApiTypes.PostsUnlikeResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Post Report Reasons</summary>
    /// <remarks>
    /// Get post report reasons.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="PostId">Id of post.</param>
    public async Task<PostsApiTypes.PostsReportReasonsResponse> ReportReasonsAsync(long PostId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/posts/{PostId}/report",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PostsApiTypes.PostsReportReasonsResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Report Post</summary>
    /// <remarks>
    /// Report a post.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="PostId">Id of post.</param>
    public async Task<PostsApiTypes.PostsReportResponse> ReportAsync(long PostId, PostsApiTypes.PostsReportBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/posts/{PostId}/report",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PostsApiTypes.PostsReportResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Post Comments</summary>
    /// <remarks>
    /// List of post comments in a thread.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<PostsApiTypes.PostsCommentsGetResponse> CommentsGetAsync(PostsApiTypes.PostsCommentsGetParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/posts/comments",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PostsApiTypes.PostsCommentsGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Create Post Comment</summary>
    /// <remarks>
    /// Create a post comment.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<PostsApiTypes.PostsCommentsCreateResponse> CommentsCreateAsync(PostsApiTypes.PostsCommentsCreateBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/posts/comments",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PostsApiTypes.PostsCommentsCreateResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Edit Post Comment</summary>
    /// <remarks>
    /// Edit a post comment.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<PostsApiTypes.PostsCommentsEditResponse> CommentsEditAsync(PostsApiTypes.PostsCommentsEditBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "PUT",
            Path = "/posts/comments",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PostsApiTypes.PostsCommentsEditResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Delete Post Comment</summary>
    /// <remarks>
    /// Delete a post comment.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<PostsApiTypes.PostsCommentsDeleteResponse> CommentsDeleteAsync(PostsApiTypes.PostsCommentsDeleteBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = "/posts/comments",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PostsApiTypes.PostsCommentsDeleteResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Report Post Comment</summary>
    /// <remarks>
    /// Report a post comment.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<PostsApiTypes.PostsCommentsReportResponse> CommentsReportAsync(PostsApiTypes.PostsCommentsReportBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/posts/comments/report",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PostsApiTypes.PostsCommentsReportResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class ProfilePostsApi
{
    private readonly LolzteamHttpClient _http;

    public ProfilePostsApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Profile Posts</summary>
    /// <remarks>
    /// List of profile posts (with pagination).
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<ProfilePostsApiTypes.ProfilePostsListResponse> ListAsync(Lolzteam.Api.Runtime.StringOrLong UserId, ProfilePostsApiTypes.ProfilePostsListParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/users/{UserId}/profile-posts",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Profile Post</summary>
    /// <remarks>
    /// Detail information of a profile post.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="ProfilePostId">Id of profile post.</param>
    public async Task<ProfilePostsApiTypes.ProfilePostsGetResponse> GetAsync(long ProfilePostId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/profile-posts/{ProfilePostId}",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Edit Profile Post</summary>
    /// <remarks>
    /// Edit a profile post.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ProfilePostId">Id of profile post.</param>
    public async Task<ProfilePostsApiTypes.ProfilePostsEditResponse> EditAsync(long ProfilePostId, ProfilePostsApiTypes.ProfilePostsEditBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "PUT",
            Path = $"/profile-posts/{ProfilePostId}",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsEditResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Delete Profile Post</summary>
    /// <remarks>
    /// Delete a profile post.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ProfilePostId">Id of profile post.</param>
    public async Task<ProfilePostsApiTypes.ProfilePostsDeleteResponse> DeleteAsync(long ProfilePostId, ProfilePostsApiTypes.ProfilePostsDeleteParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/profile-posts/{ProfilePostId}",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsDeleteResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Profile Post Report Reasons</summary>
    /// <remarks>
    /// Get Profile Post Report Reasons.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="ProfilePostId">Id of profile post.</param>
    public async Task<ProfilePostsApiTypes.ProfilePostsReportReasonsResponse> ReportReasonsAsync(long ProfilePostId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/profile-posts/{ProfilePostId}/report",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsReportReasonsResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Report a Profile Post</summary>
    /// <remarks>
    /// Report a profile post.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ProfilePostId">Id of profile post.</param>
    public async Task<ProfilePostsApiTypes.ProfilePostsReportResponse> ReportAsync(long ProfilePostId, ProfilePostsApiTypes.ProfilePostsReportBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/profile-posts/{ProfilePostId}/report",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsReportResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Create Profile Post</summary>
    /// <remarks>
    /// Create a profile post on a user profile.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<ProfilePostsApiTypes.ProfilePostsCreateResponse> CreateAsync(ProfilePostsApiTypes.ProfilePostsCreateBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/profile-posts",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsCreateResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Stick Profile Post</summary>
    /// <remarks>
    /// Stick a profile post.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ProfilePostId">Id of profile post.</param>
    public async Task<ProfilePostsApiTypes.ProfilePostsStickResponse> StickAsync(long ProfilePostId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/profile-posts/{ProfilePostId}/stick",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsStickResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Unstick Profile Post</summary>
    /// <remarks>
    /// Unstick a profile post.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ProfilePostId">Id of profile post.</param>
    public async Task<ProfilePostsApiTypes.ProfilePostsUnstickResponse> UnstickAsync(long ProfilePostId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/profile-posts/{ProfilePostId}/stick",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsUnstickResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Profile Post Likes</summary>
    /// <remarks>
    /// List of users who liked a profile post.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="ProfilePostId">Id of profile post.</param>
    public async Task<ProfilePostsApiTypes.ProfilePostsLikesResponse> LikesAsync(long ProfilePostId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/profile-posts/{ProfilePostId}/likes",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsLikesResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Like Profile Post</summary>
    /// <remarks>
    /// Like a profile post.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ProfilePostId">Id of profile post.</param>
    public async Task<ProfilePostsApiTypes.ProfilePostsLikeResponse> LikeAsync(long ProfilePostId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/profile-posts/{ProfilePostId}/likes",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsLikeResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Unlike Profile Post</summary>
    /// <remarks>
    /// Unlike a profile post.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ProfilePostId">Id of profile post.</param>
    public async Task<ProfilePostsApiTypes.ProfilePostsUnlikeResponse> UnlikeAsync(long ProfilePostId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/profile-posts/{ProfilePostId}/likes",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsUnlikeResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Profile Post Comments</summary>
    /// <remarks>
    /// List of comments of a profile post.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<ProfilePostsApiTypes.ProfilePostsCommentsListResponse> CommentsListAsync(ProfilePostsApiTypes.ProfilePostsCommentsListParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/profile-posts/comments",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsCommentsListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Create Profile Post Comment</summary>
    /// <remarks>
    /// Create a new profile post comment.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<ProfilePostsApiTypes.ProfilePostsCommentsCreateResponse> CommentsCreateAsync(ProfilePostsApiTypes.ProfilePostsCommentsCreateBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/profile-posts/comments",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsCommentsCreateResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Edit Profile Post Comment</summary>
    /// <remarks>
    /// Edit a profile post comment.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<ProfilePostsApiTypes.ProfilePostsCommentsEditResponse> CommentsEditAsync(ProfilePostsApiTypes.ProfilePostsCommentsEditBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "PUT",
            Path = "/profile-posts/comments",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsCommentsEditResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Delete Profile Post Comment</summary>
    /// <remarks>
    /// Delete a profile post comment.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<ProfilePostsApiTypes.ProfilePostsCommentsDeleteResponse> CommentsDeleteAsync(ProfilePostsApiTypes.ProfilePostsCommentsDeleteBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = "/profile-posts/comments",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsCommentsDeleteResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Profile Post Comment</summary>
    /// <remarks>
    /// Detail information of a profile post comment.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="ProfilePostId">Id of profile post.</param>
    /// <param name="CommentId">Id of profile post comment.</param>
    public async Task<ProfilePostsApiTypes.ProfilePostsCommentsGetResponse> CommentsGetAsync(long ProfilePostId, long CommentId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/profile-posts/{ProfilePostId}/comments/{CommentId}",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsCommentsGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Report a Profile Post Comment</summary>
    /// <remarks>
    /// Report a profile post comment.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="CommentId">Id of profile post comment.</param>
    public async Task<ProfilePostsApiTypes.ProfilePostsCommentsReportResponse> CommentsReportAsync(long CommentId, ProfilePostsApiTypes.ProfilePostsCommentsReportBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/profile-posts/comments/{CommentId}/report",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfilePostsApiTypes.ProfilePostsCommentsReportResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class SearchApi
{
    private readonly LolzteamHttpClient _http;

    public SearchApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Search</summary>
    /// <remarks>
    /// Search for all supported contents.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<SearchApiTypes.SearchAllResponse> AllAsync(SearchApiTypes.SearchAllBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/search",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<SearchApiTypes.SearchAllResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Search Thread</summary>
    /// <remarks>
    /// Search for threads.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<SearchApiTypes.SearchThreadsResponse> ThreadsAsync(SearchApiTypes.SearchThreadsBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/search/threads",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<SearchApiTypes.SearchThreadsResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Search Post</summary>
    /// <remarks>
    /// Search for posts.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<SearchApiTypes.SearchPostsResponse> PostsAsync(SearchApiTypes.SearchPostsBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/search/posts",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<SearchApiTypes.SearchPostsResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Search Users</summary>
    /// <remarks>
    /// Search for users.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<SearchApiTypes.SearchUsersResponse> UsersAsync(SearchApiTypes.SearchUsersBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/search/users",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<SearchApiTypes.SearchUsersResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Search Profile Posts</summary>
    /// <remarks>
    /// Search for profile posts.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<SearchApiTypes.SearchProfilePostsResponse> ProfilePostsAsync(SearchApiTypes.SearchProfilePostsBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/search/profile-posts",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<SearchApiTypes.SearchProfilePostsResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Search Tagged</summary>
    /// <remarks>
    /// Search for tagged contents.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<SearchApiTypes.SearchTaggedResponse> TaggedAsync(SearchApiTypes.SearchTaggedBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/search/tagged",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<SearchApiTypes.SearchTaggedResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Search Results</summary>
    /// <remarks>
    /// List of search results (with pagination).
    /// 
    /// Required scopes:
    /// + get
    /// </remarks>
    /// <param name="SearchId">Search ID.</param>
    public async Task<SearchApiTypes.SearchResultsResponse> ResultsAsync(Lolzteam.Api.Runtime.StringOrLong SearchId, SearchApiTypes.SearchResultsParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/search/{SearchId}/results",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<SearchApiTypes.SearchResultsResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class TagsApi
{
    private readonly LolzteamHttpClient _http;

    public TagsApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Popular Tags</summary>
    /// <remarks>
    /// List of popular tags (no pagination).
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<TagsApiTypes.TagsPopularResponse> PopularAsync(CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/tags",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<TagsApiTypes.TagsPopularResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Tags</summary>
    /// <remarks>
    /// List of tags.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<TagsApiTypes.TagsListResponse> ListAsync(TagsApiTypes.TagsListParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/tags/list",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<TagsApiTypes.TagsListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Tagged Content</summary>
    /// <remarks>
    /// List of tagged contents.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="TagId">Id of tag.</param>
    public async Task<TagsApiTypes.TagsGetResponse> GetAsync(long TagId, TagsApiTypes.TagsGetParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/tags/{TagId}",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<TagsApiTypes.TagsGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Filtered Content</summary>
    /// <remarks>
    /// Filtered list of tags.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<TagsApiTypes.TagsFindResponse> FindAsync(TagsApiTypes.TagsFindParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/tags/find",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<TagsApiTypes.TagsFindResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class ThreadsApi
{
    private readonly LolzteamHttpClient _http;

    public ThreadsApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Threads</summary>
    /// <remarks>
    /// List of threads in a forum (with pagination).
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<ThreadsApiTypes.ThreadsListResponse> ListAsync(ThreadsApiTypes.ThreadsListParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/threads",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Create Thread</summary>
    /// <remarks>
    /// Create a new thread.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<ThreadsApiTypes.ThreadsCreateResponse> CreateAsync(ThreadsApiTypes.ThreadsCreateBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/threads",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsCreateResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Create Contest</summary>
    /// <remarks>
    /// Create a new contest.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<ThreadsApiTypes.ThreadsCreateContestResponse> CreateContestAsync(ThreadsApiTypes.ThreadsCreateContestBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/contests",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsCreateContestResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Create Claim</summary>
    /// <remarks>
    /// Create a Claim.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<ThreadsApiTypes.ThreadsClaimResponse> ClaimAsync(ThreadsApiTypes.ThreadsClaimBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/claims",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsClaimResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Thread</summary>
    /// <remarks>
    /// Detail information of a thread.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="ThreadId">Id of thread.</param>
    public async Task<ThreadsApiTypes.ThreadsGetResponse> GetAsync(long ThreadId, ThreadsApiTypes.ThreadsGetParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/threads/{ThreadId}",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Edit thread</summary>
    /// <remarks>
    /// Edit a thread.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ThreadId">Id of thread.</param>
    public async Task<ThreadsApiTypes.ThreadsEditResponse> EditAsync(long ThreadId, ThreadsApiTypes.ThreadsEditBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "PUT",
            Path = $"/threads/{ThreadId}",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsEditResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Delete Thread</summary>
    /// <remarks>
    /// Delete a thread.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ThreadId">Id of thread.</param>
    public async Task<ThreadsApiTypes.ThreadsDeleteResponse> DeleteAsync(long ThreadId, ThreadsApiTypes.ThreadsDeleteBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/threads/{ThreadId}",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsDeleteResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Move Thread</summary>
    /// <remarks>
    /// Move a thread to another forum.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ThreadId">Id of thread.</param>
    public async Task<ThreadsApiTypes.ThreadsMoveResponse> MoveAsync(long ThreadId, ThreadsApiTypes.ThreadsMoveBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/threads/{ThreadId}/move",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsMoveResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Bump Thread</summary>
    /// <remarks>
    /// Bump a thread.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ThreadId">Id of thread.</param>
    public async Task<ThreadsApiTypes.ThreadsBumpResponse> BumpAsync(long ThreadId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/threads/{ThreadId}/bump",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsBumpResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Hide Thread</summary>
    /// <remarks>
    /// Hide a thread from your feed.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ThreadId">Id of thread.</param>
    public async Task<ThreadsApiTypes.ThreadsHideResponse> HideAsync(long ThreadId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/threads/{ThreadId}/hide",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsHideResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Bookmark Thread</summary>
    /// <remarks>
    /// Bookmark a thread.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ThreadId">Id of thread.</param>
    public async Task<ThreadsApiTypes.ThreadsStarResponse> StarAsync(long ThreadId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/threads/{ThreadId}/star",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsStarResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Unbookmark Thread</summary>
    /// <remarks>
    /// Unbookmark a thread.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ThreadId">Id of thread.</param>
    public async Task<ThreadsApiTypes.ThreadsUnstarResponse> UnstarAsync(long ThreadId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/threads/{ThreadId}/star",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsUnstarResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Thread Followers</summary>
    /// <remarks>
    /// List of a thread's followers. For privacy reason, only the current user will be included in the list.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="ThreadId">Id of thread.</param>
    public async Task<ThreadsApiTypes.ThreadsFollowersResponse> FollowersAsync(long ThreadId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/threads/{ThreadId}/followers",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsFollowersResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Follow Thread</summary>
    /// <remarks>
    /// Follow a thread.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ThreadId">Id of thread.</param>
    public async Task<ThreadsApiTypes.ThreadsFollowResponse> FollowAsync(long ThreadId, ThreadsApiTypes.ThreadsFollowBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/threads/{ThreadId}/followers",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsFollowResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Unfollow Thread</summary>
    /// <remarks>
    /// Unfollow a thread.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ThreadId">Id of thread.</param>
    public async Task<ThreadsApiTypes.ThreadsUnfollowResponse> UnfollowAsync(long ThreadId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/threads/{ThreadId}/followers",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsUnfollowResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Followed Threads</summary>
    /// <remarks>
    /// List of followed threads by current user.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<ThreadsApiTypes.ThreadsFollowedResponse> FollowedAsync(ThreadsApiTypes.ThreadsFollowedParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/threads/followed",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsFollowedResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Navigation Elements</summary>
    /// <remarks>
    /// List of navigation elements to reach the specified thread.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="ThreadId">Id of thread.</param>
    public async Task<ThreadsApiTypes.ThreadsNavigationResponse> NavigationAsync(long ThreadId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/threads/{ThreadId}/navigation",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsNavigationResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Poll</summary>
    /// <remarks>
    /// Detail information of a poll.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="ThreadId">Id of thread.</param>
    public async Task<ThreadsApiTypes.ThreadsPollGetResponse> PollGetAsync(long ThreadId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/threads/{ThreadId}/poll",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsPollGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Vote Poll</summary>
    /// <remarks>
    /// Vote on a thread poll.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ThreadId">Id of thread.</param>
    public async Task<ThreadsApiTypes.ThreadsPollVoteResponse> PollVoteAsync(long ThreadId, ThreadsApiTypes.ThreadsPollVoteBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/threads/{ThreadId}/poll/votes",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsPollVoteResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Unread Threads</summary>
    /// <remarks>
    /// List of unread threads (must be logged in).
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<ThreadsApiTypes.ThreadsUnreadResponse> UnreadAsync(ThreadsApiTypes.ThreadsUnreadParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/threads/new",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsUnreadResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Recent Threads</summary>
    /// <remarks>
    /// List of recent threads.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<ThreadsApiTypes.ThreadsRecentResponse> RecentAsync(ThreadsApiTypes.ThreadsRecentParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/threads/recent",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsRecentResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Finish Contest</summary>
    /// <remarks>
    /// Finishes a contest.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="ThreadId">Id of thread.</param>
    public async Task<ThreadsApiTypes.ThreadsFinishResponse> FinishAsync(long ThreadId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/contests/{ThreadId}/finish",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ThreadsApiTypes.ThreadsFinishResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class UsersApi
{
    private readonly LolzteamHttpClient _http;

    public UsersApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Users</summary>
    /// <remarks>
    /// List of users (with pagination).
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<UsersApiTypes.UsersListResponse> ListAsync(UsersApiTypes.UsersListParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/users",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get User Fields</summary>
    /// <remarks>
    /// List of user fields.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<UsersApiTypes.UsersFieldsResponse> FieldsAsync(CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/users/fields",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersFieldsResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Find Users</summary>
    /// <remarks>
    /// List of users filtered by username, email or custom fields.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<UsersApiTypes.UsersFindResponse> FindAsync(UsersApiTypes.UsersFindParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/users/find",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersFindResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get User</summary>
    /// <remarks>
    /// Detail information of a user.
    /// 
    /// Required scopes:
    /// + read
    /// + basic
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersGetResponse> GetAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersGetParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/users/{UserId}",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Edit User</summary>
    /// <remarks>
    /// Edit a user.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersEditResponse> EditAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersEditBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "PUT",
            Path = $"/users/{UserId}",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersEditResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get User Claims</summary>
    /// <remarks>
    /// Get user claims.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersClaimsResponse> ClaimsAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersClaimsParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/users/{UserId}/claims",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersClaimsResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Upload Avatar</summary>
    /// <remarks>
    /// Upload avatar for a user.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersAvatarUploadResponse> AvatarUploadAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersAvatarUploadBody body, CancellationToken cancellationToken = default)
    {
        var jsonObj = new System.Text.Json.Nodes.JsonObject();
        if (body.X is not null) jsonObj["x"] = System.Text.Json.Nodes.JsonValue.Create(body.X);
        if (body.Y is not null) jsonObj["y"] = System.Text.Json.Nodes.JsonValue.Create(body.Y);
        if (body.Crop is not null) jsonObj["crop"] = System.Text.Json.Nodes.JsonValue.Create(body.Crop);
        var byteFields = new Dictionary<string, byte[]>();
        byteFields["avatar"] = body.Avatar;
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/users/{UserId}/avatar",
            Body = JsonSerializer.SerializeToElement(jsonObj),
            BodyEncoding = BodyEncoding.Multipart,
            ByteArrayFields = byteFields,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersAvatarUploadResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Delete Avatar</summary>
    /// <remarks>
    /// Delete avatar for a user.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersAvatarDeleteResponse> AvatarDeleteAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/users/{UserId}/avatar",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersAvatarDeleteResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Crop Avatar</summary>
    /// <remarks>
    /// Crop avatar for a user.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersAvatarCropResponse> AvatarCropAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersAvatarCropBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/users/{UserId}/avatar/crop",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersAvatarCropResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Upload Background</summary>
    /// <remarks>
    /// Upload background for a user.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersBackgroundUploadResponse> BackgroundUploadAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersBackgroundUploadBody body, CancellationToken cancellationToken = default)
    {
        var jsonObj = new System.Text.Json.Nodes.JsonObject();
        if (body.X is not null) jsonObj["x"] = System.Text.Json.Nodes.JsonValue.Create(body.X);
        if (body.Y is not null) jsonObj["y"] = System.Text.Json.Nodes.JsonValue.Create(body.Y);
        if (body.Crop is not null) jsonObj["crop"] = System.Text.Json.Nodes.JsonValue.Create(body.Crop);
        var byteFields = new Dictionary<string, byte[]>();
        byteFields["background"] = body.Background;
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/users/{UserId}/background",
            Body = JsonSerializer.SerializeToElement(jsonObj),
            BodyEncoding = BodyEncoding.Multipart,
            ByteArrayFields = byteFields,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersBackgroundUploadResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Delete Background</summary>
    /// <remarks>
    /// Delete background for a user.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersBackgroundDeleteResponse> BackgroundDeleteAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/users/{UserId}/background",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersBackgroundDeleteResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Crop Background</summary>
    /// <remarks>
    /// Crop background for a user.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersBackgroundCropResponse> BackgroundCropAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersBackgroundCropBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/users/{UserId}/background/crop",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersBackgroundCropResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get User Followers</summary>
    /// <remarks>
    /// List of a user's followers.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersFollowersResponse> FollowersAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersFollowersParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/users/{UserId}/followers",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersFollowersResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Follow User</summary>
    /// <remarks>
    /// Follow a user.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersFollowResponse> FollowAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/users/{UserId}/followers",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersFollowResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Unfollow User</summary>
    /// <remarks>
    /// Unfollow a user.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersUnfollowResponse> UnfollowAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/users/{UserId}/followers",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersUnfollowResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Followed Users By User</summary>
    /// <remarks>
    /// List of users whom are followed by a user.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersFollowingsResponse> FollowingsAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersFollowingsParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/users/{UserId}/followings",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersFollowingsResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get User Likes</summary>
    /// <remarks>
    /// Get information about user likes.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersLikesResponse> LikesAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersLikesParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/users/{UserId}/likes",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersLikesResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Ignored Users</summary>
    /// <remarks>
    /// List of ignored users of current user.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<UsersApiTypes.UsersIgnoredResponse> IgnoredAsync(UsersApiTypes.UsersIgnoredParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/users/ignored",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersIgnoredResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Ignore User</summary>
    /// <remarks>
    /// Ignore a user.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersIgnoreResponse> IgnoreAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/users/{UserId}/ignore",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersIgnoreResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Edit Ignoring Options</summary>
    /// <remarks>
    /// Edit ignoring options.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersIgnoreEditResponse> IgnoreEditAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersIgnoreEditParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "PUT",
            Path = $"/users/{UserId}/ignore",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersIgnoreEditResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Unignore User</summary>
    /// <remarks>
    /// Stop ignoring a user.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersUnignoreResponse> UnignoreAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/users/{UserId}/ignore",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersUnignoreResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Contents</summary>
    /// <remarks>
    /// List of contents created by user (with pagination).
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersContentsResponse> ContentsAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersContentsParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/users/{UserId}/timeline",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersContentsResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Trophies</summary>
    /// <remarks>
    /// List of user trophies.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    /// <param name="UserId">User ID. &gt; You can use shortlink `me` to interact with your profile.</param>
    public async Task<UsersApiTypes.UsersTrophiesResponse> TrophiesAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/users/{UserId}/trophies",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersTrophiesResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Secret Answer Types</summary>
    /// <remarks>
    /// Get available secret answer types for user account security.
    /// 
    /// Required scopes:
    /// + read
    /// </remarks>
    public async Task<UsersApiTypes.UsersSecretAnswerTypesResponse> SecretAnswerTypesAsync(CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/users/secret-answer/types",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersSecretAnswerTypesResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Reset Secret Answer</summary>
    /// <remarks>
    /// Request a reset of the secret answer for the account.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<UsersApiTypes.UsersSaResetResponse> SaResetAsync(CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/account/secret-answer/reset",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersSaResetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Cancel Secret Answer Reset</summary>
    /// <remarks>
    /// Cancel a pending secret answer reset request for the account.
    /// 
    /// Required scopes:
    /// + post
    /// </remarks>
    public async Task<UsersApiTypes.UsersSaCancelResetResponse> SaCancelResetAsync(CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = "/account/secret-answer/reset",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<UsersApiTypes.UsersSaCancelResetResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class ForumClient : IDisposable
{
    public AssetsApi Assets { get; }
    public BatchApi Batch { get; }
    public CategoriesApi Categories { get; }
    public ChatboxApi Chatbox { get; }
    public ConversationsApi Conversations { get; }
    public FormsApi Forms { get; }
    public ForumsApi Forums { get; }
    public LinksApi Links { get; }
    public NavigationApi Navigation { get; }
    public NotificationsApi Notifications { get; }
    public OAuthApi OAuth { get; }
    public PagesApi Pages { get; }
    public PostsApi Posts { get; }
    public ProfilePostsApi ProfilePosts { get; }
    public SearchApi Search { get; }
    public TagsApi Tags { get; }
    public ThreadsApi Threads { get; }
    public UsersApi Users { get; }

    private readonly LolzteamHttpClient _http;

    public ForumClient(ClientConfig config)
    {
        var resolvedConfig = config with
        {
            BaseUrl = config.BaseUrl ?? "https://prod-api.lolz.live",
            RateLimit = config.RateLimit ?? new RateLimitConfig(300),
        };
        _http = new LolzteamHttpClient(resolvedConfig);

        Assets = new AssetsApi(_http);
        Batch = new BatchApi(_http);
        Categories = new CategoriesApi(_http);
        Chatbox = new ChatboxApi(_http);
        Conversations = new ConversationsApi(_http);
        Forms = new FormsApi(_http);
        Forums = new ForumsApi(_http);
        Links = new LinksApi(_http);
        Navigation = new NavigationApi(_http);
        Notifications = new NotificationsApi(_http);
        OAuth = new OAuthApi(_http);
        Pages = new PagesApi(_http);
        Posts = new PostsApi(_http);
        ProfilePosts = new ProfilePostsApi(_http);
        Search = new SearchApi(_http);
        Tags = new TagsApi(_http);
        Threads = new ThreadsApi(_http);
        Users = new UsersApi(_http);
    }

    public static ForumClient Create(string token)
    {
        return new ForumClient(new ClientConfig { Token = token });
    }

    public void Dispose()
    {
        _http.Dispose();
    }
}
