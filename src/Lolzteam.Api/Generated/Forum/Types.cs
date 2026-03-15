// Auto-generated. Do not edit manually.

using System.Text.Json.Serialization;
using System.Text.Json;

namespace Lolzteam.Api.Generated.Forum;

// ─── Component Schemas ────────────────────────────────────────

public sealed record UserIDModel(
);

public sealed record Resp_NotificationModel(
	[property: JsonPropertyName("notification_id")] long NotificationId,
	[property: JsonPropertyName("notification_create_date")] long NotificationCreateDate,
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
	[property: JsonPropertyName("content_action")] string ContentAction,
	[property: JsonPropertyName("notification_is_unread")] bool NotificationIsUnread,
	[property: JsonPropertyName("creator_user_id")] long CreatorUserId,
	[property: JsonPropertyName("creator_username")] string CreatorUsername,
	[property: JsonPropertyName("creator_username_html")] string CreatorUsernameHtml,
	[property: JsonPropertyName("notification_type")] string NotificationType,
	[property: JsonPropertyName("links")] JsonElement Links,
	[property: JsonPropertyName("notification_html")] string NotificationHtml
);

public sealed record Resp_LinkModel(
	[property: JsonPropertyName("link_id")] long LinkId,
	[property: JsonPropertyName("link_title")] string LinkTitle,
	[property: JsonPropertyName("link_description")] string LinkDescription,
	[property: JsonPropertyName("links")] JsonElement Links,
	[property: JsonPropertyName("permissions")] JsonElement Permissions
);

public sealed record RoomIDModel(
);

public sealed record Resp_ChatboxMessageModel(
	[property: JsonPropertyName("can_report")] bool CanReport,
	[property: JsonPropertyName("date")] long Date,
	[property: JsonPropertyName("is_deleted")] bool IsDeleted,
	[property: JsonPropertyName("message")] string Message,
	[property: JsonPropertyName("message_id")] long MessageId,
	[property: JsonPropertyName("messageJson")] string MessageJson,
	[property: JsonPropertyName("messageRaw")] string MessageRaw,
	[property: JsonPropertyName("room")] JsonElement Room,
	[property: JsonPropertyName("user")] JsonElement User
);

public sealed record Resp_UserModel(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("username_html")] string UsernameHtml,
	[property: JsonPropertyName("user_message_count")] long UserMessageCount,
	[property: JsonPropertyName("user_register_date")] long UserRegisterDate,
	[property: JsonPropertyName("user_like_count")] long UserLikeCount,
	[property: JsonPropertyName("user_like2_count")] long UserLike2Count,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("trophy_count")] long TrophyCount,
	[property: JsonPropertyName("short_link")] string ShortLink,
	[property: JsonPropertyName("custom_title")] string CustomTitle,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_banner_id")] long DisplayBannerId,
	[property: JsonPropertyName("display_icon_group_id")] long DisplayIconGroupId,
	[property: JsonPropertyName("balance")] string Balance,
	[property: JsonPropertyName("hold")] string Hold,
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("user_email")] string UserEmail,
	[property: JsonPropertyName("user_unread_notification_count")] long UserUnreadNotificationCount,
	[property: JsonPropertyName("user_unread_conversation_count")] long UserUnreadConversationCount,
	[property: JsonPropertyName("conv_welcome_message")] string ConvWelcomeMessage,
	[property: JsonPropertyName("user_title")] string UserTitle,
	[property: JsonPropertyName("user_deposit")] long UserDeposit,
	[property: JsonPropertyName("user_is_valid")] bool UserIsValid,
	[property: JsonPropertyName("user_is_verified")] bool UserIsVerified,
	[property: JsonPropertyName("user_is_followed")] bool UserIsFollowed,
	[property: JsonPropertyName("user_last_seen_date")] long UserLastSeenDate,
	[property: JsonPropertyName("links")] JsonElement Links,
	[property: JsonPropertyName("permissions")] JsonElement Permissions,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("user_is_visitor")] bool UserIsVisitor,
	[property: JsonPropertyName("user_group_id")] long UserGroupId,
	[property: JsonPropertyName("curator_titles")] List<string> CuratorTitles,
	[property: JsonPropertyName("user_groups")] List<JsonElement> UserGroups,
	[property: JsonPropertyName("fields")] List<JsonElement> Fields,
	[property: JsonPropertyName("user_timezone_offset")] long UserTimezoneOffset,
	[property: JsonPropertyName("user_external_authentications")] List<JsonElement> UserExternalAuthentications,
	[property: JsonPropertyName("self_permissions")] JsonElement SelfPermissions,
	[property: JsonPropertyName("edit_permissions")] JsonElement EditPermissions,
	[property: JsonPropertyName("birthday")] JsonElement Birthday,
	[property: JsonPropertyName("secret_answer_rendered")] string SecretAnswerRendered,
	[property: JsonPropertyName("secret_answer_first_letter")] string SecretAnswerFirstLetter,
	[property: JsonPropertyName("user_following")] JsonElement UserFollowing,
	[property: JsonPropertyName("user_followers")] JsonElement UserFollowers,
	[property: JsonPropertyName("banner")] string Banner
);

public sealed record Resp_ThreadModel(
	[property: JsonPropertyName("thread_id")] long ThreadId,
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("thread_title")] string ThreadTitle,
	[property: JsonPropertyName("thread_view_count")] long ThreadViewCount,
	[property: JsonPropertyName("creator_user_id")] long CreatorUserId,
	[property: JsonPropertyName("creator_username")] string CreatorUsername,
	[property: JsonPropertyName("creator_username_html")] string CreatorUsernameHtml,
	[property: JsonPropertyName("thread_create_date")] long ThreadCreateDate,
	[property: JsonPropertyName("thread_update_date")] long ThreadUpdateDate,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("thread_post_count")] long ThreadPostCount,
	[property: JsonPropertyName("thread_is_published")] bool ThreadIsPublished,
	[property: JsonPropertyName("thread_is_deleted")] bool ThreadIsDeleted,
	[property: JsonPropertyName("thread_is_sticky")] bool ThreadIsSticky,
	[property: JsonPropertyName("thread_is_closed")] bool ThreadIsClosed,
	[property: JsonPropertyName("thread_is_followed")] bool ThreadIsFollowed,
	[property: JsonPropertyName("thread_is_starred")] bool ThreadIsStarred,
	[property: JsonPropertyName("first_post")] JsonElement FirstPost,
	[property: JsonPropertyName("thread_prefixes")] List<JsonElement> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] JsonElement ThreadTags,
	[property: JsonPropertyName("links")] JsonElement Links,
	[property: JsonPropertyName("permissions")] JsonElement Permissions,
	[property: JsonPropertyName("node_title")] string NodeTitle,
	[property: JsonPropertyName("restrictions")] JsonElement Restrictions,
	[property: JsonPropertyName("last_post")] JsonElement LastPost,
	[property: JsonPropertyName("contest")] JsonElement Contest
);

public sealed record Resp_PostModel(
	[property: JsonPropertyName("post_id")] long PostId,
	[property: JsonPropertyName("thread_id")] long ThreadId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("poster_username_html")] string PosterUsernameHtml,
	[property: JsonPropertyName("post_create_date")] long PostCreateDate,
	[property: JsonPropertyName("post_body")] string PostBody,
	[property: JsonPropertyName("post_body_html")] string PostBodyHtml,
	[property: JsonPropertyName("post_body_plain_text")] string PostBodyPlainText,
	[property: JsonPropertyName("signature")] string Signature,
	[property: JsonPropertyName("signature_html")] string SignatureHtml,
	[property: JsonPropertyName("signature_plain_text")] string SignaturePlainText,
	[property: JsonPropertyName("post_like_count")] long PostLikeCount,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("links")] JsonElement Links,
	[property: JsonPropertyName("permissions")] JsonElement Permissions,
	[property: JsonPropertyName("thread_is_deleted")] bool ThreadIsDeleted
);

public sealed record Resp_PostCommentModel(
	[property: JsonPropertyName("post_comment_id")] long PostCommentId,
	[property: JsonPropertyName("post_id")] long PostId,
	[property: JsonPropertyName("thread_id")] long ThreadId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("poster_username_html")] string PosterUsernameHtml,
	[property: JsonPropertyName("post_comment_create_date")] long PostCommentCreateDate,
	[property: JsonPropertyName("post_comment_body")] string PostCommentBody,
	[property: JsonPropertyName("post_comment_body_html")] string PostCommentBodyHtml,
	[property: JsonPropertyName("post_comment_body_plain_text")] string PostCommentBodyPlainText,
	[property: JsonPropertyName("post_comment_like_count")] long PostCommentLikeCount,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_comment_is_published")] bool PostCommentIsPublished,
	[property: JsonPropertyName("post_comment_is_deleted")] bool PostCommentIsDeleted,
	[property: JsonPropertyName("post_comment_update_date")] long PostCommentUpdateDate,
	[property: JsonPropertyName("links")] JsonElement Links,
	[property: JsonPropertyName("permissions")] JsonElement Permissions
);

public sealed record Resp_ProfilePostModel(
	[property: JsonPropertyName("profile_post_id")] long ProfilePostId,
	[property: JsonPropertyName("timeline_user_id")] long TimelineUserId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("poster_username_html")] string PosterUsernameHtml,
	[property: JsonPropertyName("post_create_date")] long PostCreateDate,
	[property: JsonPropertyName("post_body")] string PostBody,
	[property: JsonPropertyName("post_body_html")] string PostBodyHtml,
	[property: JsonPropertyName("post_body_plain_text")] string PostBodyPlainText,
	[property: JsonPropertyName("post_like_count")] long PostLikeCount,
	[property: JsonPropertyName("post_comment_count")] long PostCommentCount,
	[property: JsonPropertyName("post_comments_is_disabled")] long PostCommentsIsDisabled,
	[property: JsonPropertyName("timeline_username")] string TimelineUsername,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_is_liked")] bool PostIsLiked,
	[property: JsonPropertyName("post_is_sticked")] bool PostIsSticked,
	[property: JsonPropertyName("links")] JsonElement Links,
	[property: JsonPropertyName("permissions")] JsonElement Permissions,
	[property: JsonPropertyName("timeline_user")] Resp_UserModel TimelineUser
);

public sealed record Resp_ProfilePostCommentModel(
	[property: JsonPropertyName("comment_id")] long CommentId,
	[property: JsonPropertyName("profile_post_id")] long ProfilePostId,
	[property: JsonPropertyName("comment_user_id")] long CommentUserId,
	[property: JsonPropertyName("comment_username")] string CommentUsername,
	[property: JsonPropertyName("comment_username_html")] string CommentUsernameHtml,
	[property: JsonPropertyName("comment_create_date")] long CommentCreateDate,
	[property: JsonPropertyName("comment_body")] string CommentBody,
	[property: JsonPropertyName("comment_body_html")] string CommentBodyHtml,
	[property: JsonPropertyName("comment_body_plain_text")] string CommentBodyPlainText,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("timeline_user_id")] long TimelineUserId,
	[property: JsonPropertyName("links")] JsonElement Links,
	[property: JsonPropertyName("permissions")] JsonElement Permissions
);

public sealed record Resp_ConversationModel(
	[property: JsonPropertyName("conversation_id")] long ConversationId,
	[property: JsonPropertyName("conversation_title")] string ConversationTitle,
	[property: JsonPropertyName("creator_user_id")] long CreatorUserId,
	[property: JsonPropertyName("creator_username")] string CreatorUsername,
	[property: JsonPropertyName("creator_username_html")] string CreatorUsernameHtml,
	[property: JsonPropertyName("conversation_create_date")] long ConversationCreateDate,
	[property: JsonPropertyName("conversation_update_date")] long ConversationUpdateDate,
	[property: JsonPropertyName("conversation_last_read_date")] long ConversationLastReadDate,
	[property: JsonPropertyName("conversation_online_count")] long ConversationOnlineCount,
	[property: JsonPropertyName("is_starred")] long IsStarred,
	[property: JsonPropertyName("is_group")] long IsGroup,
	[property: JsonPropertyName("is_unread")] long IsUnread,
	[property: JsonPropertyName("alerts")] long Alerts,
	[property: JsonPropertyName("permissions")] JsonElement Permissions,
	[property: JsonPropertyName("conversation_message_count")] long ConversationMessageCount,
	[property: JsonPropertyName("conversation_is_new")] bool ConversationIsNew,
	[property: JsonPropertyName("creator_is_ignored")] bool CreatorIsIgnored,
	[property: JsonPropertyName("conversation_is_open")] bool ConversationIsOpen,
	[property: JsonPropertyName("conversation_is_deleted")] bool ConversationIsDeleted,
	[property: JsonPropertyName("recipient")] JsonElement Recipient,
	[property: JsonPropertyName("recipients")] List<JsonElement> Recipients,
	[property: JsonPropertyName("links")] JsonElement Links
);

public sealed record Resp_ConversationMessageModel(
	[property: JsonPropertyName("message_id")] long MessageId,
	[property: JsonPropertyName("conversation_id")] long ConversationId,
	[property: JsonPropertyName("creator_user_id")] long CreatorUserId,
	[property: JsonPropertyName("creator_username")] string CreatorUsername,
	[property: JsonPropertyName("creator_username_html")] string CreatorUsernameHtml,
	[property: JsonPropertyName("message_create_date")] long MessageCreateDate,
	[property: JsonPropertyName("message_is_unread")] long MessageIsUnread,
	[property: JsonPropertyName("message_need_translate")] bool MessageNeedTranslate,
	[property: JsonPropertyName("message_is_system")] bool MessageIsSystem,
	[property: JsonPropertyName("message_edit_date")] long MessageEditDate,
	[property: JsonPropertyName("message_body")] string MessageBody,
	[property: JsonPropertyName("message_body_html")] string MessageBodyHtml,
	[property: JsonPropertyName("message_body_plain_text")] string MessageBodyPlainText,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("links")] JsonElement Links,
	[property: JsonPropertyName("permissions")] JsonElement Permissions
);

public sealed record Resp_SystemInfo(
	[property: JsonPropertyName("visitor_id")] long VisitorId,
	[property: JsonPropertyName("time")] long Time
);

// ─── OAuthApi Types ────────────────────────────────────────

public static class OAuthApiTypes
{
	public sealed record OAuthTokenBody
	{
		[JsonPropertyName("grant_type")]
		public string? GrantType { get; init; }
		[JsonPropertyName("client_id")]
		public string? ClientId { get; init; }
		[JsonPropertyName("client_secret")]
		public string? ClientSecret { get; init; }
		[JsonPropertyName("scope")]
		public JsonElement? Scope { get; init; }
		[JsonPropertyName("code")]
		public string? Code { get; init; }
		[JsonPropertyName("redirect_uri")]
		public string? RedirectUri { get; init; }
		[JsonPropertyName("refresh_token")]
		public string? RefreshToken { get; init; }
		[JsonPropertyName("username")]
		public string? Username { get; init; }
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public sealed record OAuthTokenResponse(
		[property: JsonPropertyName("access_token")] string AccessToken,
		[property: JsonPropertyName("token_type")] string TokenType,
		[property: JsonPropertyName("expires_in")] long ExpiresIn,
		[property: JsonPropertyName("refresh_token")] string? RefreshToken,
		[property: JsonPropertyName("scope")] string? Scope
	);
}

// ─── AssetsApi Types ────────────────────────────────────────

public static class AssetsApiTypes
{
	public sealed record AssetsCssParams
	{
		[JsonPropertyName("css")]
		public List<string>? Css { get; init; }
	}

	public sealed record AssetsCssResponse(
		[property: JsonPropertyName("contents")] string Contents,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);
}

// ─── CategoriesApi Types ────────────────────────────────────────

public static class CategoriesApiTypes
{
	public sealed record CategoriesListParams
	{
		[JsonPropertyName("parent_category_id")]
		public int? ParentCategoryId { get; init; }
		[JsonPropertyName("parent_forum_id")]
		public int? ParentForumId { get; init; }
		[JsonPropertyName("order")]
		public string? Order { get; init; }
	}

	public sealed record CategoriesListResponse(
		[property: JsonPropertyName("categories")] List<JsonElement> Categories,
		[property: JsonPropertyName("categories_total")] long CategoriesTotal,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoriesGetResponse(
		[property: JsonPropertyName("category")] JsonElement Category,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);
}

// ─── ForumsApi Types ────────────────────────────────────────

public static class ForumsApiTypes
{
	public sealed record ForumsListParams
	{
		[JsonPropertyName("parent_category_id")]
		public int? ParentCategoryId { get; init; }
		[JsonPropertyName("parent_forum_id")]
		public int? ParentForumId { get; init; }
		[JsonPropertyName("order")]
		public string? Order { get; init; }
	}

	public sealed record ForumsListResponse(
		[property: JsonPropertyName("forums")] List<JsonElement> Forums,
		[property: JsonPropertyName("forums_total")] long ForumsTotal,
		[property: JsonPropertyName("tabs")] List<JsonElement> Tabs,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ForumsGroupedResponse(
		[property: JsonPropertyName("data")] JsonElement Data,
		[property: JsonPropertyName("tabs")] List<JsonElement> Tabs,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ForumsGetResponse(
		[property: JsonPropertyName("forum")] JsonElement Forum,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ForumsFollowersResponse(
		[property: JsonPropertyName("users")] List<JsonElement> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ForumsFollowBody
	{
		[JsonPropertyName("post")]
		public bool? Post { get; init; }
		[JsonPropertyName("alert")]
		public bool? Alert { get; init; }
		[JsonPropertyName("email")]
		public bool? Email { get; init; }
		[JsonPropertyName("prefix_ids")]
		public List<int?>? PrefixIds { get; init; }
		[JsonPropertyName("minimal_contest_amount")]
		public int? MinimalContestAmount { get; init; }
	}

	public sealed record ForumsFollowResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ForumsUnfollowResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ForumsFollowedParams
	{
		[JsonPropertyName("total")]
		public bool? Total { get; init; }
	}

	public sealed record ForumsFollowedResponse(
		[property: JsonPropertyName("forums")] List<JsonElement> Forums,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ForumsGetFeedOptionsResponse(
		[property: JsonPropertyName("forums")] List<JsonElement> Forums,
		[property: JsonPropertyName("excluded_forums_ids")] List<long> ExcludedForumsIds,
		[property: JsonPropertyName("default_excluded_forums_ids")] List<long> DefaultExcludedForumsIds,
		[property: JsonPropertyName("keywords")] string Keywords,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ForumsEditFeedOptionsBody
	{
		[JsonPropertyName("node_ids")]
		public List<int?>? NodeIds { get; init; }
		[JsonPropertyName("keywords")]
		public List<string>? Keywords { get; init; }
	}

	public sealed record ForumsEditFeedOptionsResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── LinksApi Types ────────────────────────────────────────

public static class LinksApiTypes
{
	public sealed record LinksListResponse(
		[property: JsonPropertyName("link-forums")] List<Resp_LinkModel> LinkForums,
		[property: JsonPropertyName("link-forums_total")] long LinkForumsTotal,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record LinksGetResponse(
		[property: JsonPropertyName("link-forum")] Resp_LinkModel LinkForum,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);
}

// ─── PagesApi Types ────────────────────────────────────────

public static class PagesApiTypes
{
	public sealed record PagesListParams
	{
		[JsonPropertyName("parent_page_id")]
		public int? ParentPageId { get; init; }
		[JsonPropertyName("order")]
		public string? Order { get; init; }
	}

	public sealed record PagesListResponse(
		[property: JsonPropertyName("pages")] List<JsonElement> Pages,
		[property: JsonPropertyName("pages_total")] long PagesTotal,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PagesGetResponse(
		[property: JsonPropertyName("page")] JsonElement Page,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);
}

// ─── NavigationApi Types ────────────────────────────────────────

public static class NavigationApiTypes
{
	public sealed record NavigationListParams
	{
		[JsonPropertyName("parent")]
		public int? Parent { get; init; }
	}

	public sealed record NavigationListResponse(
		[property: JsonPropertyName("elements")] List<JsonElement> Elements,
		[property: JsonPropertyName("elements_count")] long ElementsCount,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);
}

// ─── ThreadsApi Types ────────────────────────────────────────

public static class ThreadsApiTypes
{
	public sealed record ThreadsListParams
	{
		[JsonPropertyName("forum_id")]
		public int? ForumId { get; init; }
		[JsonPropertyName("tab")]
		public string? Tab { get; init; }
		[JsonPropertyName("state")]
		public string? State { get; init; }
		[JsonPropertyName("period")]
		public string? Period { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("title_only")]
		public bool? TitleOnly { get; init; }
		[JsonPropertyName("creator_user_id")]
		public int? CreatorUserId { get; init; }
		[JsonPropertyName("sticky")]
		public bool? Sticky { get; init; }
		[JsonPropertyName("prefix_ids[]")]
		public List<int?>? PrefixIds { get; init; }
		[JsonPropertyName("prefix_ids_not[]")]
		public List<int?>? PrefixIdsNot { get; init; }
		[JsonPropertyName("thread_tag_id")]
		public int? ThreadTagId { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
		[JsonPropertyName("order")]
		public string? Order { get; init; }
		[JsonPropertyName("direction")]
		public string? Direction { get; init; }
		[JsonPropertyName("thread_create_date")]
		public int? ThreadCreateDate { get; init; }
		[JsonPropertyName("thread_update_date")]
		public int? ThreadUpdateDate { get; init; }
		[JsonPropertyName("fields_include")]
		public JsonElement? FieldsInclude { get; init; }
	}

	public sealed record ThreadsListResponse(
		[property: JsonPropertyName("threads")] List<Resp_ThreadModel> Threads,
		[property: JsonPropertyName("forum")] JsonElement Forum,
		[property: JsonPropertyName("threads_total")] long ThreadsTotal,
		[property: JsonPropertyName("links")] JsonElement Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsCreateBody
	{
		[JsonPropertyName("post_body")]
		public required string PostBody { get; init; }
		[JsonPropertyName("forum_id")]
		public required int? ForumId { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("title_en")]
		public string? TitleEn { get; init; }
		[JsonPropertyName("prefix_id")]
		public List<int?>? PrefixId { get; init; }
		[JsonPropertyName("tags")]
		public List<string>? Tags { get; init; }
		[JsonPropertyName("hide_contacts")]
		public bool? HideContacts { get; init; }
		[JsonPropertyName("allow_ask_hidden_content")]
		public bool? AllowAskHiddenContent { get; init; }
		[JsonPropertyName("reply_group")]
		public JsonElement? ReplyGroup { get; init; }
		[JsonPropertyName("comment_ignore_group")]
		public bool? CommentIgnoreGroup { get; init; }
		[JsonPropertyName("dont_alert_followers")]
		public bool? DontAlertFollowers { get; init; }
		[JsonPropertyName("schedule_date")]
		public string? ScheduleDate { get; init; }
		[JsonPropertyName("schedule_time")]
		public string? ScheduleTime { get; init; }
		[JsonPropertyName("watch_thread_state")]
		public bool? WatchThreadState { get; init; }
		[JsonPropertyName("watch_thread")]
		public bool? WatchThread { get; init; }
		[JsonPropertyName("watch_thread_email")]
		public bool? WatchThreadEmail { get; init; }
	}

	public sealed record ThreadsCreateResponse(
		[property: JsonPropertyName("thread")] Resp_ThreadModel Thread,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsCreateContestBody
	{
		[JsonPropertyName("post_body")]
		public required string PostBody { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("title_en")]
		public string? TitleEn { get; init; }
		[JsonPropertyName("contest_type")]
		public required string ContestType { get; init; }
		[JsonPropertyName("length_value")]
		public int? LengthValue { get; init; }
		[JsonPropertyName("length_option")]
		public string? LengthOption { get; init; }
		[JsonPropertyName("prize_type")]
		public required string PrizeType { get; init; }
		[JsonPropertyName("count_winners")]
		public int? CountWinners { get; init; }
		[JsonPropertyName("prize_data_money")]
		public double? PrizeDataMoney { get; init; }
		[JsonPropertyName("is_money_places")]
		public bool? IsMoneyPlaces { get; init; }
		[JsonPropertyName("prize_data_places")]
		public List<double?>? PrizeDataPlaces { get; init; }
		[JsonPropertyName("prize_data_upgrade")]
		public JsonElement? PrizeDataUpgrade { get; init; }
		[JsonPropertyName("require_like_count")]
		public required int? RequireLikeCount { get; init; }
		[JsonPropertyName("require_total_like_count")]
		public required int? RequireTotalLikeCount { get; init; }
		[JsonPropertyName("secret_answer")]
		public string? SecretAnswer { get; init; }
		[JsonPropertyName("tags")]
		public List<string>? Tags { get; init; }
		[JsonPropertyName("reply_group")]
		public JsonElement? ReplyGroup { get; init; }
		[JsonPropertyName("comment_ignore_group")]
		public bool? CommentIgnoreGroup { get; init; }
		[JsonPropertyName("dont_alert_followers")]
		public bool? DontAlertFollowers { get; init; }
		[JsonPropertyName("hide_contacts")]
		public bool? HideContacts { get; init; }
		[JsonPropertyName("allow_ask_hidden_content")]
		public bool? AllowAskHiddenContent { get; init; }
		[JsonPropertyName("schedule_date")]
		public string? ScheduleDate { get; init; }
		[JsonPropertyName("schedule_time")]
		public string? ScheduleTime { get; init; }
		[JsonPropertyName("watch_thread_state")]
		public bool? WatchThreadState { get; init; }
		[JsonPropertyName("watch_thread")]
		public bool? WatchThread { get; init; }
		[JsonPropertyName("watch_thread_email")]
		public bool? WatchThreadEmail { get; init; }
	}

	public sealed record ThreadsCreateContestResponse(
		[property: JsonPropertyName("thread")] Resp_ThreadModel Thread,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsClaimBody
	{
		[JsonPropertyName("as_responder")]
		public required string AsResponder { get; init; }
		[JsonPropertyName("as_is_market_deal")]
		public required bool? AsIsMarketDeal { get; init; }
		[JsonPropertyName("as_market_item_id")]
		public int? AsMarketItemId { get; init; }
		[JsonPropertyName("as_data")]
		public string? AsData { get; init; }
		[JsonPropertyName("as_amount")]
		public required double? AsAmount { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("transfer_type")]
		public required string TransferType { get; init; }
		[JsonPropertyName("pay_claim")]
		public string? PayClaim { get; init; }
		[JsonPropertyName("as_funds_receipt")]
		public string? AsFundsReceipt { get; init; }
		[JsonPropertyName("as_tg_login_screenshot")]
		public string? AsTgLoginScreenshot { get; init; }
		[JsonPropertyName("tags")]
		public List<string>? Tags { get; init; }
		[JsonPropertyName("hide_contacts")]
		public bool? HideContacts { get; init; }
		[JsonPropertyName("allow_ask_hidden_content")]
		public bool? AllowAskHiddenContent { get; init; }
		[JsonPropertyName("reply_group")]
		public JsonElement? ReplyGroup { get; init; }
		[JsonPropertyName("comment_ignore_group")]
		public bool? CommentIgnoreGroup { get; init; }
		[JsonPropertyName("dont_alert_followers")]
		public bool? DontAlertFollowers { get; init; }
		[JsonPropertyName("schedule_date")]
		public string? ScheduleDate { get; init; }
		[JsonPropertyName("schedule_time")]
		public string? ScheduleTime { get; init; }
		[JsonPropertyName("watch_thread_state")]
		public bool? WatchThreadState { get; init; }
		[JsonPropertyName("watch_thread")]
		public bool? WatchThread { get; init; }
		[JsonPropertyName("watch_thread_email")]
		public bool? WatchThreadEmail { get; init; }
		[JsonPropertyName("post_body")]
		public required string PostBody { get; init; }
	}

	public sealed record ThreadsClaimResponse(
		[property: JsonPropertyName("thread")] Resp_ThreadModel Thread,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsGetParams
	{
		[JsonPropertyName("fields_include")]
		public JsonElement? FieldsInclude { get; init; }
	}

	public sealed record ThreadsGetResponse(
		[property: JsonPropertyName("thread")] Resp_ThreadModel Thread,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsEditBody
	{
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("title_en")]
		public string? TitleEn { get; init; }
		[JsonPropertyName("prefix_id")]
		public List<int?>? PrefixId { get; init; }
		[JsonPropertyName("tags")]
		public List<string>? Tags { get; init; }
		[JsonPropertyName("discussion_open")]
		public bool? DiscussionOpen { get; init; }
		[JsonPropertyName("hide_contacts")]
		public bool? HideContacts { get; init; }
		[JsonPropertyName("allow_ask_hidden_content")]
		public bool? AllowAskHiddenContent { get; init; }
		[JsonPropertyName("reply_group")]
		public JsonElement? ReplyGroup { get; init; }
		[JsonPropertyName("comment_ignore_group")]
		public bool? CommentIgnoreGroup { get; init; }
	}

	public sealed record ThreadsEditResponse(
		[property: JsonPropertyName("thread")] Resp_ThreadModel Thread,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsDeleteBody
	{
		[JsonPropertyName("reason")]
		public string? Reason { get; init; }
	}

	public sealed record ThreadsDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ThreadsMoveBody
	{
		[JsonPropertyName("node_id")]
		public required string NodeId { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("title_en")]
		public string? TitleEn { get; init; }
		[JsonPropertyName("prefix_id")]
		public List<int?>? PrefixId { get; init; }
		[JsonPropertyName("apply_thread_prefix")]
		public bool? ApplyThreadPrefix { get; init; }
		[JsonPropertyName("send_alert")]
		public bool? SendAlert { get; init; }
	}

	public sealed record ThreadsMoveResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ThreadsBumpResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsHideResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsStarResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ThreadsUnstarResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ThreadsFollowersResponse(
		[property: JsonPropertyName("users")] List<JsonElement> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsFollowBody
	{
		[JsonPropertyName("email")]
		public bool? Email { get; init; }
	}

	public sealed record ThreadsFollowResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ThreadsUnfollowResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ThreadsFollowedParams
	{
		[JsonPropertyName("total")]
		public bool? Total { get; init; }
		[JsonPropertyName("fields_include")]
		public JsonElement? FieldsInclude { get; init; }
	}

	public sealed record ThreadsFollowedResponse(
		[property: JsonPropertyName("threads")] List<JsonElement> Threads,
		[property: JsonPropertyName("threads_total")] long ThreadsTotal,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsNavigationResponse(
		[property: JsonPropertyName("elements")] List<JsonElement> Elements,
		[property: JsonPropertyName("elements_count")] long ElementsCount,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsPollGetResponse(
		[property: JsonPropertyName("poll")] JsonElement Poll,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsPollVoteBody
	{
		[JsonPropertyName("response_id")]
		public int? ResponseId { get; init; }
		[JsonPropertyName("response_ids")]
		public List<int?>? ResponseIds { get; init; }
	}

	public sealed record ThreadsPollVoteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ThreadsUnreadParams
	{
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
		[JsonPropertyName("forum_id")]
		public int? ForumId { get; init; }
		[JsonPropertyName("data_limit")]
		public int? DataLimit { get; init; }
	}

	public sealed record ThreadsUnreadResponse(
		[property: JsonPropertyName("threads")] List<Resp_ThreadModel> Threads,
		[property: JsonPropertyName("data")] List<JsonElement> Data,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsRecentParams
	{
		[JsonPropertyName("days")]
		public int? Days { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
		[JsonPropertyName("forum_id")]
		public int? ForumId { get; init; }
		[JsonPropertyName("data_limit")]
		public int? DataLimit { get; init; }
	}

	public sealed record ThreadsRecentResponse(
		[property: JsonPropertyName("threads")] List<Resp_ThreadModel> Threads,
		[property: JsonPropertyName("data")] List<JsonElement> Data,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsFinishResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── PostsApi Types ────────────────────────────────────────

public static class PostsApiTypes
{
	public sealed record PostsListParams
	{
		[JsonPropertyName("thread_id")]
		public int? ThreadId { get; init; }
		[JsonPropertyName("page_of_post_id")]
		public int? PageOfPostId { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
		[JsonPropertyName("order")]
		public string? Order { get; init; }
	}

	public sealed record PostsListResponse(
		[property: JsonPropertyName("posts")] List<Resp_ThreadModel> Posts,
		[property: JsonPropertyName("thread")] Resp_ThreadModel Thread,
		[property: JsonPropertyName("posts_total")] long PostsTotal,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PostsCreateBody
	{
		[JsonPropertyName("post_body")]
		public required string PostBody { get; init; }
		[JsonPropertyName("thread_id")]
		public int? ThreadId { get; init; }
		[JsonPropertyName("quote_post_id")]
		public int? QuotePostId { get; init; }
	}

	public sealed record PostsCreateResponse(
		[property: JsonPropertyName("post")] Resp_PostModel Post,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PostsGetResponse(
		[property: JsonPropertyName("post")] Resp_PostModel Post,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PostsEditBody
	{
		[JsonPropertyName("post_body")]
		public string? PostBody { get; init; }
	}

	public sealed record PostsEditResponse(
		[property: JsonPropertyName("post")] Resp_PostModel Post,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PostsDeleteBody
	{
		[JsonPropertyName("reason")]
		public string? Reason { get; init; }
	}

	public sealed record PostsDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record PostsLikesParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record PostsLikesResponse(
		[property: JsonPropertyName("users")] List<JsonElement> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PostsLikeResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record PostsUnlikeResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record PostsReportReasonsResponse(
		[property: JsonPropertyName("reasons")] List<string> Reasons,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PostsReportBody
	{
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}

	public sealed record PostsReportResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record PostsCommentsGetParams
	{
		[JsonPropertyName("post_id")]
		public int? PostId { get; init; }
		[JsonPropertyName("before")]
		public int? Before { get; init; }
		[JsonPropertyName("before_comment")]
		public int? BeforeComment { get; init; }
	}

	public sealed record PostsCommentsGetResponse(
		[property: JsonPropertyName("comments")] List<Resp_PostCommentModel> Comments,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PostsCommentsCreateBody
	{
		[JsonPropertyName("post_id")]
		public required int? PostId { get; init; }
		[JsonPropertyName("comment_body")]
		public required string CommentBody { get; init; }
	}

	public sealed record PostsCommentsCreateResponse(
		[property: JsonPropertyName("comment")] JsonElement Comment,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PostsCommentsEditBody
	{
		[JsonPropertyName("post_comment_id")]
		public required int? PostCommentId { get; init; }
		[JsonPropertyName("comment_body")]
		public required string CommentBody { get; init; }
	}

	public sealed record PostsCommentsEditResponse(
		[property: JsonPropertyName("comment")] JsonElement Comment,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PostsCommentsDeleteBody
	{
		[JsonPropertyName("post_comment_id")]
		public required int? PostCommentId { get; init; }
		[JsonPropertyName("reason")]
		public string? Reason { get; init; }
	}

	public sealed record PostsCommentsDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record PostsCommentsReportBody
	{
		[JsonPropertyName("post_comment_id")]
		public required int? PostCommentId { get; init; }
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}

	public sealed record PostsCommentsReportResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── UsersApi Types ────────────────────────────────────────

public static class UsersApiTypes
{
	public sealed record UsersListParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
		[JsonPropertyName("fields_include")]
		public JsonElement? FieldsInclude { get; init; }
	}

	public sealed record UsersListResponse(
		[property: JsonPropertyName("users")] List<Resp_UserModel> Users,
		[property: JsonPropertyName("users_total")] long UsersTotal,
		[property: JsonPropertyName("links")] JsonElement Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersFieldsResponse(
		[property: JsonPropertyName("fields")] List<JsonElement> Fields,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersFindParams
	{
		[JsonPropertyName("username")]
		public string? Username { get; init; }
		[JsonPropertyName("custom_fields")]
		public JsonElement? CustomFields { get; init; }
		[JsonPropertyName("fields_include")]
		public JsonElement? FieldsInclude { get; init; }
	}

	public sealed record UsersFindResponse(
		[property: JsonPropertyName("users")] List<Resp_UserModel> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersGetParams
	{
		[JsonPropertyName("fields_include")]
		public JsonElement? FieldsInclude { get; init; }
	}

	public sealed record UsersGetResponse(
		[property: JsonPropertyName("user")] Resp_UserModel User,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersEditBody
	{
		[JsonPropertyName("username")]
		public string? Username { get; init; }
		[JsonPropertyName("user_title")]
		public string? UserTitle { get; init; }
		[JsonPropertyName("display_group_id")]
		public int? DisplayGroupId { get; init; }
		[JsonPropertyName("display_icon_group_id")]
		public int? DisplayIconGroupId { get; init; }
		[JsonPropertyName("display_banner_id")]
		public int? DisplayBannerId { get; init; }
		[JsonPropertyName("conv_welcome_message")]
		public string? ConvWelcomeMessage { get; init; }
		[JsonPropertyName("user_dob_day")]
		public int? UserDobDay { get; init; }
		[JsonPropertyName("user_dob_month")]
		public int? UserDobMonth { get; init; }
		[JsonPropertyName("user_dob_year")]
		public int? UserDobYear { get; init; }
		[JsonPropertyName("secret_answer")]
		public string? SecretAnswer { get; init; }
		[JsonPropertyName("secret_answer_type")]
		public int? SecretAnswerType { get; init; }
		[JsonPropertyName("short_link")]
		public string? ShortLink { get; init; }
		[JsonPropertyName("language_id")]
		public JsonElement? LanguageId { get; init; }
		[JsonPropertyName("gender")]
		public string? Gender { get; init; }
		[JsonPropertyName("timezone")]
		public string? Timezone { get; init; }
		[JsonPropertyName("receive_admin_email")]
		public bool? ReceiveAdminEmail { get; init; }
		[JsonPropertyName("activity_visible")]
		public bool? ActivityVisible { get; init; }
		[JsonPropertyName("show_dob_date")]
		public bool? ShowDobDate { get; init; }
		[JsonPropertyName("show_dob_year")]
		public bool? ShowDobYear { get; init; }
		[JsonPropertyName("hide_username_change_logs")]
		public bool? HideUsernameChangeLogs { get; init; }
		[JsonPropertyName("allow_view_profile")]
		public string? AllowViewProfile { get; init; }
		[JsonPropertyName("allow_post_profile")]
		public string? AllowPostProfile { get; init; }
		[JsonPropertyName("allow_send_personal_conversation")]
		public string? AllowSendPersonalConversation { get; init; }
		[JsonPropertyName("allow_invite_group")]
		public string? AllowInviteGroup { get; init; }
		[JsonPropertyName("allow_receive_news_feed")]
		public string? AllowReceiveNewsFeed { get; init; }
		[JsonPropertyName("alert")]
		public JsonElement? Alert { get; init; }
		[JsonPropertyName("fields")]
		public JsonElement? Fields { get; init; }
	}

	public sealed record UsersEditResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record UsersClaimsParams
	{
		[JsonPropertyName("type")]
		public string? Type { get; init; }
		[JsonPropertyName("claim_state")]
		public string? ClaimState { get; init; }
	}

	public sealed record UsersClaimsResponse(
		[property: JsonPropertyName("claims")] List<JsonElement> Claims,
		[property: JsonPropertyName("stats")] JsonElement Stats,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersAvatarUploadBody
	{
		public required byte[] Avatar { get; init; }
		public int? X { get; init; }
		public int? Y { get; init; }
		public int? Crop { get; init; }
	}

	public sealed record UsersAvatarUploadResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersAvatarDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record UsersAvatarCropBody
	{
		[JsonPropertyName("x")]
		public int? X { get; init; }
		[JsonPropertyName("y")]
		public int? Y { get; init; }
		[JsonPropertyName("crop")]
		public int? Crop { get; init; }
	}

	public sealed record UsersAvatarCropResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersBackgroundUploadBody
	{
		public required byte[] Background { get; init; }
		public int? X { get; init; }
		public int? Y { get; init; }
		public int? Crop { get; init; }
	}

	public sealed record UsersBackgroundUploadResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersBackgroundDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record UsersBackgroundCropBody
	{
		[JsonPropertyName("x")]
		public int? X { get; init; }
		[JsonPropertyName("y")]
		public int? Y { get; init; }
		[JsonPropertyName("crop")]
		public int? Crop { get; init; }
	}

	public sealed record UsersBackgroundCropResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersFollowersParams
	{
		[JsonPropertyName("order")]
		public string? Order { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record UsersFollowersResponse(
		[property: JsonPropertyName("users")] List<JsonElement> Users,
		[property: JsonPropertyName("users_total")] long UsersTotal,
		[property: JsonPropertyName("links")] JsonElement Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersFollowResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record UsersUnfollowResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record UsersFollowingsParams
	{
		[JsonPropertyName("order")]
		public string? Order { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record UsersFollowingsResponse(
		[property: JsonPropertyName("users")] List<JsonElement> Users,
		[property: JsonPropertyName("users_total")] long UsersTotal,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersLikesParams
	{
		[JsonPropertyName("node_id")]
		public int? NodeId { get; init; }
		[JsonPropertyName("like_type")]
		public string? LikeType { get; init; }
		[JsonPropertyName("type")]
		public string? Type { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("content_type")]
		public string? ContentType { get; init; }
		[JsonPropertyName("search_user_id")]
		public int? SearchUserId { get; init; }
		[JsonPropertyName("stats")]
		public bool? Stats { get; init; }
	}

	public sealed record UsersLikesResponse(
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("contentType")] string ContentType,
		[property: JsonPropertyName("totalLikes")] long TotalLikes,
		[property: JsonPropertyName("likes")] JsonElement Likes,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersIgnoredParams
	{
		[JsonPropertyName("total")]
		public bool? Total { get; init; }
	}

	public sealed record UsersIgnoredResponse(
		[property: JsonPropertyName("users")] List<JsonElement> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersIgnoreResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record UsersIgnoreEditParams
	{
		[JsonPropertyName("ignore_conversations")]
		public bool? IgnoreConversations { get; init; }
		[JsonPropertyName("ignore_content")]
		public bool? IgnoreContent { get; init; }
		[JsonPropertyName("restrict_view_profile")]
		public bool? RestrictViewProfile { get; init; }
	}

	public sealed record UsersIgnoreEditResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record UsersUnignoreResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record UsersContentsParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record UsersContentsResponse(
		[property: JsonPropertyName("data")] List<JsonElement> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("user")] Resp_UserModel User,
		[property: JsonPropertyName("links")] JsonElement Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersTrophiesResponse(
		[property: JsonPropertyName("trophies")] List<JsonElement> Trophies,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersSecretAnswerTypesResponse(
		[property: JsonPropertyName("data")] List<JsonElement> Data,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersSaResetResponse(
		[property: JsonPropertyName("success")] bool Success,
		[property: JsonPropertyName("waiting_time")] string WaitingTime,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersSaCancelResetResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── ProfilePostsApi Types ────────────────────────────────────────

public static class ProfilePostsApiTypes
{
	public sealed record ProfilePostsListParams
	{
		[JsonPropertyName("posts_user_id")]
		public int? PostsUserId { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
		[JsonPropertyName("fields_include")]
		public JsonElement? FieldsInclude { get; init; }
	}

	public sealed record ProfilePostsListResponse(
		[property: JsonPropertyName("profile_posts")] List<Resp_ProfilePostModel> ProfilePosts,
		[property: JsonPropertyName("totalProfilePosts")] long TotalProfilePosts,
		[property: JsonPropertyName("canPostOnProfile")] bool CanPostOnProfile,
		[property: JsonPropertyName("links")] JsonElement Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsGetResponse(
		[property: JsonPropertyName("profile_post")] Resp_ProfilePostModel ProfilePost,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsEditBody
	{
		[JsonPropertyName("post_body")]
		public string? PostBody { get; init; }
		[JsonPropertyName("disable_comments")]
		public bool? DisableComments { get; init; }
	}

	public sealed record ProfilePostsEditResponse(
		[property: JsonPropertyName("profile_post")] JsonElement ProfilePost,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsDeleteParams
	{
		[JsonPropertyName("reason")]
		public string? Reason { get; init; }
	}

	public sealed record ProfilePostsDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ProfilePostsReportReasonsResponse(
		[property: JsonPropertyName("reasons")] List<string> Reasons,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsReportBody
	{
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}

	public sealed record ProfilePostsReportResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ProfilePostsCreateBody
	{
		[JsonPropertyName("user_id")]
		public required JsonElement UserId { get; init; }
		[JsonPropertyName("post_body")]
		public required string PostBody { get; init; }
	}

	public sealed record ProfilePostsCreateResponse(
		[property: JsonPropertyName("profile_post")] JsonElement ProfilePost,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsStickResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ProfilePostsUnstickResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ProfilePostsLikesResponse(
		[property: JsonPropertyName("users")] List<JsonElement> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsLikeResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ProfilePostsUnlikeResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ProfilePostsCommentsListParams
	{
		[JsonPropertyName("profile_post_id")]
		public int? ProfilePostId { get; init; }
		[JsonPropertyName("before")]
		public int? Before { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record ProfilePostsCommentsListResponse(
		[property: JsonPropertyName("comments")] List<Resp_ProfilePostCommentModel> Comments,
		[property: JsonPropertyName("comments_total")] long CommentsTotal,
		[property: JsonPropertyName("profile_post")] JsonElement ProfilePost,
		[property: JsonPropertyName("timeline_user")] Resp_UserModel TimelineUser,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsCommentsCreateBody
	{
		[JsonPropertyName("profile_post_id")]
		public required int? ProfilePostId { get; init; }
		[JsonPropertyName("comment_body")]
		public required string CommentBody { get; init; }
	}

	public sealed record ProfilePostsCommentsCreateResponse(
		[property: JsonPropertyName("comment")] JsonElement Comment,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsCommentsEditBody
	{
		[JsonPropertyName("comment_id")]
		public required int? CommentId { get; init; }
		[JsonPropertyName("comment_body")]
		public required string CommentBody { get; init; }
	}

	public sealed record ProfilePostsCommentsEditResponse(
		[property: JsonPropertyName("comment")] JsonElement Comment,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsCommentsDeleteBody
	{
		[JsonPropertyName("comment_id")]
		public required int? CommentId { get; init; }
	}

	public sealed record ProfilePostsCommentsDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ProfilePostsCommentsGetResponse(
		[property: JsonPropertyName("comment")] Resp_ProfilePostCommentModel Comment,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsCommentsReportBody
	{
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}

	public sealed record ProfilePostsCommentsReportResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── ConversationsApi Types ────────────────────────────────────────

public static class ConversationsApiTypes
{
	public sealed record ConversationsListParams
	{
		[JsonPropertyName("folder")]
		public string? Folder { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record ConversationsListResponse(
		[property: JsonPropertyName("conversations")] List<Resp_ConversationModel> Conversations,
		[property: JsonPropertyName("can_start")] bool CanStart,
		[property: JsonPropertyName("folders")] List<JsonElement> Folders,
		[property: JsonPropertyName("links")] JsonElement Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ConversationsCreateBody
	{
		[JsonPropertyName("recipient_id")]
		public int? RecipientId { get; init; }
		[JsonPropertyName("recipients")]
		public List<string>? Recipients { get; init; }
		[JsonPropertyName("is_group")]
		public bool? IsGroup { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("open_invite")]
		public bool? OpenInvite { get; init; }
		[JsonPropertyName("allow_edit_messages")]
		public bool? AllowEditMessages { get; init; }
		[JsonPropertyName("allow_sticky_messages")]
		public bool? AllowStickyMessages { get; init; }
		[JsonPropertyName("allow_delete_own_messages")]
		public bool? AllowDeleteOwnMessages { get; init; }
		[JsonPropertyName("message_body")]
		public string? MessageBody { get; init; }
	}

	public sealed record ConversationsCreateResponse(
		[property: JsonPropertyName("conversation")] Resp_ConversationModel Conversation,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ConversationsUpdateBody
	{
		[JsonPropertyName("conversation_id")]
		public required int? ConversationId { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("open_invite")]
		public bool? OpenInvite { get; init; }
		[JsonPropertyName("history_open")]
		public bool? HistoryOpen { get; init; }
		[JsonPropertyName("allow_edit_messages")]
		public bool? AllowEditMessages { get; init; }
		[JsonPropertyName("allow_sticky_messages")]
		public bool? AllowStickyMessages { get; init; }
		[JsonPropertyName("allow_delete_own_messages")]
		public bool? AllowDeleteOwnMessages { get; init; }
	}

	public sealed record ConversationsUpdateResponse(
		[property: JsonPropertyName("conversation")] Resp_ConversationModel Conversation,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ConversationsDeleteBody
	{
		[JsonPropertyName("conversation_id")]
		public required int? ConversationId { get; init; }
		[JsonPropertyName("delete_type")]
		public required string DeleteType { get; init; }
	}

	public sealed record ConversationsDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ConversationsStartBody
	{
		[JsonPropertyName("user_id")]
		public required JsonElement UserId { get; init; }
	}

	public sealed record ConversationsStartResponse(
		[property: JsonPropertyName("conversation")] Resp_ConversationModel Conversation,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ConversationsSaveBody
	{
		[JsonPropertyName("link")]
		public required string Link { get; init; }
	}

	public sealed record ConversationsSaveResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ConversationsGetResponse(
		[property: JsonPropertyName("conversation")] Resp_ConversationModel Conversation,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ConversationsMessagesListParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
		[JsonPropertyName("order")]
		public string? Order { get; init; }
		[JsonPropertyName("before")]
		public int? Before { get; init; }
		[JsonPropertyName("after")]
		public int? After { get; init; }
	}

	public sealed record ConversationsMessagesListResponse(
		[property: JsonPropertyName("messages")] List<Resp_ConversationMessageModel> Messages,
		[property: JsonPropertyName("messages_total")] long MessagesTotal,
		[property: JsonPropertyName("links")] JsonElement Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ConversationsMessagesCreateBody
	{
		[JsonPropertyName("reply_message_id")]
		public int? ReplyMessageId { get; init; }
		[JsonPropertyName("message_body")]
		public required string MessageBody { get; init; }
	}

	public sealed record ConversationsMessagesCreateResponse(
		[property: JsonPropertyName("message")] Resp_ConversationMessageModel Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ConversationsSearchBody
	{
		[JsonPropertyName("q")]
		public string? Q { get; init; }
		[JsonPropertyName("conversation_id")]
		public int? ConversationId { get; init; }
		[JsonPropertyName("search_recipients")]
		public bool? SearchRecipients { get; init; }
	}

	public sealed record ConversationsSearchResponse(
		[property: JsonPropertyName("conversations")] List<Resp_ConversationModel> Conversations,
		[property: JsonPropertyName("recipients")] bool Recipients,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ConversationsMessagesGetResponse(
		[property: JsonPropertyName("message")] Resp_ConversationModel Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ConversationsMessagesEditBody
	{
		[JsonPropertyName("message_body")]
		public required string MessageBody { get; init; }
	}

	public sealed record ConversationsMessagesEditResponse(
		[property: JsonPropertyName("message")] Resp_ConversationModel Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ConversationsMessagesDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ConversationsInviteBody
	{
		[JsonPropertyName("recipients")]
		public required List<string> Recipients { get; init; }
	}

	public sealed record ConversationsInviteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ConversationsKickBody
	{
		[JsonPropertyName("user_id")]
		public required int? UserId { get; init; }
	}

	public sealed record ConversationsKickResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ConversationsReadResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ConversationsReadAllResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ConversationsMessagesStickResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ConversationsMessagesUnstickResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ConversationsStarResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ConversationsUnstarResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ConversationsAlertsEnableResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ConversationsAlertsDisableResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);
}

// ─── NotificationsApi Types ────────────────────────────────────────

public static class NotificationsApiTypes
{
	public sealed record NotificationsListParams
	{
		[JsonPropertyName("type")]
		public string? Type { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record NotificationsListResponse(
		[property: JsonPropertyName("notifications")] List<Resp_NotificationModel> Notifications,
		[property: JsonPropertyName("notifications_total")] long NotificationsTotal,
		[property: JsonPropertyName("links")] JsonElement Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record NotificationsGetResponse(
		[property: JsonPropertyName("notification_id")] long NotificationId,
		[property: JsonPropertyName("notification")] Resp_NotificationModel Notification,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record NotificationsReadBody
	{
		[JsonPropertyName("notification_id")]
		public int? NotificationId { get; init; }
	}

	public sealed record NotificationsReadResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── TagsApi Types ────────────────────────────────────────

public static class TagsApiTypes
{
	public sealed record TagsPopularResponse(
		[property: JsonPropertyName("tags")] JsonElement Tags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record TagsListParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record TagsListResponse(
		[property: JsonPropertyName("tags")] JsonElement Tags,
		[property: JsonPropertyName("tags_total")] long TagsTotal,
		[property: JsonPropertyName("links")] JsonElement Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record TagsGetParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record TagsGetResponse(
		[property: JsonPropertyName("tag")] JsonElement Tag,
		[property: JsonPropertyName("tagged")] List<JsonElement> Tagged,
		[property: JsonPropertyName("tagged_total")] long TaggedTotal,
		[property: JsonPropertyName("links")] JsonElement Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record TagsFindParams
	{
		[JsonPropertyName("tag")]
		public string? Tag { get; init; }
	}

	public sealed record TagsFindResponse(
		[property: JsonPropertyName("tags")] List<string> Tags,
		[property: JsonPropertyName("ids")] List<long> Ids,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);
}

// ─── SearchApi Types ────────────────────────────────────────

public static class SearchApiTypes
{
	public sealed record SearchAllBody
	{
		[JsonPropertyName("q")]
		public string? Q { get; init; }
		[JsonPropertyName("tag")]
		public string? Tag { get; init; }
		[JsonPropertyName("forum_id")]
		public int? ForumId { get; init; }
		[JsonPropertyName("user_id")]
		public JsonElement? UserId { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record SearchAllResponse(
		[property: JsonPropertyName("data")] List<JsonElement> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("users")] List<Resp_UserModel> Users,
		[property: JsonPropertyName("links")] JsonElement Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record SearchThreadsBody
	{
		[JsonPropertyName("q")]
		public string? Q { get; init; }
		[JsonPropertyName("tag")]
		public string? Tag { get; init; }
		[JsonPropertyName("forum_id")]
		public int? ForumId { get; init; }
		[JsonPropertyName("user_id")]
		public JsonElement? UserId { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
		[JsonPropertyName("data_limit")]
		public int? DataLimit { get; init; }
	}

	public sealed record SearchThreadsResponse(
		[property: JsonPropertyName("data")] List<JsonElement> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("links")] JsonElement Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record SearchPostsBody
	{
		[JsonPropertyName("q")]
		public string? Q { get; init; }
		[JsonPropertyName("tag")]
		public string? Tag { get; init; }
		[JsonPropertyName("forum_id")]
		public int? ForumId { get; init; }
		[JsonPropertyName("user_id")]
		public JsonElement? UserId { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
		[JsonPropertyName("data_limit")]
		public int? DataLimit { get; init; }
	}

	public sealed record SearchPostsResponse(
		[property: JsonPropertyName("data")] List<JsonElement> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("links")] JsonElement Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record SearchUsersBody
	{
		[JsonPropertyName("q")]
		public string? Q { get; init; }
	}

	public sealed record SearchUsersResponse(
		[property: JsonPropertyName("users")] List<Resp_UserModel> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record SearchProfilePostsBody
	{
		[JsonPropertyName("q")]
		public string? Q { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record SearchProfilePostsResponse(
		[property: JsonPropertyName("data")] List<JsonElement> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("links")] JsonElement Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record SearchTaggedBody
	{
		[JsonPropertyName("tag")]
		public string? Tag { get; init; }
		[JsonPropertyName("tags")]
		public List<string>? Tags { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record SearchTaggedResponse(
		[property: JsonPropertyName("data")] List<JsonElement> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("search_tags")] JsonElement SearchTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record SearchResultsParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record SearchResultsResponse(
		[property: JsonPropertyName("data")] List<JsonElement> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("search_tags")] JsonElement SearchTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);
}

// ─── BatchApi Types ────────────────────────────────────────

public static class BatchApiTypes
{
	public sealed record BatchExecuteResponse(
		[property: JsonPropertyName("jobs")] JsonElement Jobs
	);
}

// ─── ChatboxApi Types ────────────────────────────────────────

public static class ChatboxApiTypes
{
	public sealed record ChatboxIndexParams
	{
		[JsonPropertyName("room_id")]
		public JsonElement? RoomId { get; init; }
	}

	public sealed record ChatboxIndexResponse(
		[property: JsonPropertyName("rooms")] List<JsonElement> Rooms,
		[property: JsonPropertyName("ban")] JsonElement Ban,
		[property: JsonPropertyName("ignore")] List<JsonElement> Ignore,
		[property: JsonPropertyName("permissions")] JsonElement Permissions,
		[property: JsonPropertyName("commands")] List<string> Commands,
		[property: JsonPropertyName("roomsOnline")] JsonElement RoomsOnline,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ChatboxGetMessagesParams
	{
		[JsonPropertyName("room_id")]
		public JsonElement? RoomId { get; init; }
		[JsonPropertyName("before_message_id")]
		public int? BeforeMessageId { get; init; }
	}

	public sealed record ChatboxGetMessagesResponse(
		[property: JsonPropertyName("messages")] List<Resp_ChatboxMessageModel> Messages,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ChatboxPostMessageBody
	{
		[JsonPropertyName("room_id")]
		public required JsonElement RoomId { get; init; }
		[JsonPropertyName("reply_message_id")]
		public int? ReplyMessageId { get; init; }
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}

	public sealed record ChatboxPostMessageResponse(
		[property: JsonPropertyName("message")] Resp_ChatboxMessageModel Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ChatboxEditMessageBody
	{
		[JsonPropertyName("message_id")]
		public required int? MessageId { get; init; }
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}

	public sealed record ChatboxEditMessageResponse(
		[property: JsonPropertyName("message")] Resp_ChatboxMessageModel Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ChatboxDeleteMessageBody
	{
		[JsonPropertyName("message_id")]
		public required int? MessageId { get; init; }
	}

	public sealed record ChatboxDeleteMessageResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ChatboxOnlineParams
	{
		[JsonPropertyName("room_id")]
		public JsonElement? RoomId { get; init; }
	}

	public sealed record ChatboxOnlineResponse(
		[property: JsonPropertyName("users")] List<JsonElement> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ChatboxReportReasonsParams
	{
		[JsonPropertyName("message_id")]
		public int? MessageId { get; init; }
	}

	public sealed record ChatboxReportReasonsResponse(
		[property: JsonPropertyName("reasons")] List<string> Reasons,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ChatboxReportBody
	{
		[JsonPropertyName("message_id")]
		public required int? MessageId { get; init; }
		[JsonPropertyName("reason")]
		public required string Reason { get; init; }
	}

	public sealed record ChatboxReportResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ChatboxGetLeaderboardParams
	{
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public sealed record ChatboxGetLeaderboardResponse(
		[property: JsonPropertyName("leaderboard")] List<JsonElement> Leaderboard,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ChatboxGetIgnoreResponse(
		[property: JsonPropertyName("ignored")] List<JsonElement> Ignored,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ChatboxPostIgnoreBody
	{
		[JsonPropertyName("user_id")]
		public required JsonElement UserId { get; init; }
	}

	public sealed record ChatboxPostIgnoreResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ChatboxDeleteIgnoreBody
	{
		[JsonPropertyName("user_id")]
		public required JsonElement UserId { get; init; }
	}

	public sealed record ChatboxDeleteIgnoreResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── FormsApi Types ────────────────────────────────────────

public static class FormsApiTypes
{
	public sealed record FormsListParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
	}

	public sealed record FormsListResponse(
		[property: JsonPropertyName("forms")] List<JsonElement> Forms,
		[property: JsonPropertyName("formsPerPage")] long FormsPerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("totalForms")] long TotalForms,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record FormsCreateBody
	{
		[JsonPropertyName("form_id")]
		public string? FormId { get; init; }
		[JsonPropertyName("fields")]
		public JsonElement? Fields { get; init; }
	}

	public sealed record FormsCreateResponse(
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("content")] JsonElement Content,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);
}

