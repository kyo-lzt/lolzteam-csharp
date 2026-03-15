// Auto-generated. Do not edit manually.

using System.Text.Json.Serialization;
using System.Text.Json;

namespace Lolzteam.Api.Generated.Forum;

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
}

// ─── AssetsApi Types ────────────────────────────────────────

public static class AssetsApiTypes
{
	public sealed record AssetsCssParams
	{
		[JsonPropertyName("css")]
		public List<string>? Css { get; init; }
	}
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

	public sealed record ForumsFollowedParams
	{
		[JsonPropertyName("total")]
		public bool? Total { get; init; }
	}

	public sealed record ForumsEditFeedOptionsBody
	{
		[JsonPropertyName("node_ids")]
		public List<int?>? NodeIds { get; init; }
		[JsonPropertyName("keywords")]
		public List<string>? Keywords { get; init; }
	}
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
}

// ─── NavigationApi Types ────────────────────────────────────────

public static class NavigationApiTypes
{
	public sealed record NavigationListParams
	{
		[JsonPropertyName("parent")]
		public int? Parent { get; init; }
	}
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

	public sealed record ThreadsGetParams
	{
		[JsonPropertyName("fields_include")]
		public JsonElement? FieldsInclude { get; init; }
	}

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

	public sealed record ThreadsDeleteBody
	{
		[JsonPropertyName("reason")]
		public string? Reason { get; init; }
	}

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

	public sealed record ThreadsFollowBody
	{
		[JsonPropertyName("email")]
		public bool? Email { get; init; }
	}

	public sealed record ThreadsFollowedParams
	{
		[JsonPropertyName("total")]
		public bool? Total { get; init; }
		[JsonPropertyName("fields_include")]
		public JsonElement? FieldsInclude { get; init; }
	}

	public sealed record ThreadsPollVoteBody
	{
		[JsonPropertyName("response_id")]
		public int? ResponseId { get; init; }
		[JsonPropertyName("response_ids")]
		public List<int?>? ResponseIds { get; init; }
	}

	public sealed record ThreadsUnreadParams
	{
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
		[JsonPropertyName("forum_id")]
		public int? ForumId { get; init; }
		[JsonPropertyName("data_limit")]
		public int? DataLimit { get; init; }
	}

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

	public sealed record PostsCreateBody
	{
		[JsonPropertyName("post_body")]
		public required string PostBody { get; init; }
		[JsonPropertyName("thread_id")]
		public int? ThreadId { get; init; }
		[JsonPropertyName("quote_post_id")]
		public int? QuotePostId { get; init; }
	}

	public sealed record PostsEditBody
	{
		[JsonPropertyName("post_body")]
		public string? PostBody { get; init; }
	}

	public sealed record PostsDeleteBody
	{
		[JsonPropertyName("reason")]
		public string? Reason { get; init; }
	}

	public sealed record PostsLikesParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record PostsReportBody
	{
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}

	public sealed record PostsCommentsGetParams
	{
		[JsonPropertyName("post_id")]
		public int? PostId { get; init; }
		[JsonPropertyName("before")]
		public int? Before { get; init; }
		[JsonPropertyName("before_comment")]
		public int? BeforeComment { get; init; }
	}

	public sealed record PostsCommentsCreateBody
	{
		[JsonPropertyName("post_id")]
		public required int? PostId { get; init; }
		[JsonPropertyName("comment_body")]
		public required string CommentBody { get; init; }
	}

	public sealed record PostsCommentsEditBody
	{
		[JsonPropertyName("post_comment_id")]
		public required int? PostCommentId { get; init; }
		[JsonPropertyName("comment_body")]
		public required string CommentBody { get; init; }
	}

	public sealed record PostsCommentsDeleteBody
	{
		[JsonPropertyName("post_comment_id")]
		public required int? PostCommentId { get; init; }
		[JsonPropertyName("reason")]
		public string? Reason { get; init; }
	}

	public sealed record PostsCommentsReportBody
	{
		[JsonPropertyName("post_comment_id")]
		public required int? PostCommentId { get; init; }
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}
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

	public sealed record UsersFindParams
	{
		[JsonPropertyName("username")]
		public string? Username { get; init; }
		[JsonPropertyName("custom_fields")]
		public JsonElement? CustomFields { get; init; }
		[JsonPropertyName("fields_include")]
		public JsonElement? FieldsInclude { get; init; }
	}

	public sealed record UsersGetParams
	{
		[JsonPropertyName("fields_include")]
		public JsonElement? FieldsInclude { get; init; }
	}

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

	public sealed record UsersClaimsParams
	{
		[JsonPropertyName("type")]
		public string? Type { get; init; }
		[JsonPropertyName("claim_state")]
		public string? ClaimState { get; init; }
	}

	public sealed record UsersAvatarUploadBody
	{
		public required byte[] Avatar { get; init; }
		public int? X { get; init; }
		public int? Y { get; init; }
		public int? Crop { get; init; }
	}

	public sealed record UsersAvatarCropBody
	{
		[JsonPropertyName("x")]
		public int? X { get; init; }
		[JsonPropertyName("y")]
		public int? Y { get; init; }
		[JsonPropertyName("crop")]
		public int? Crop { get; init; }
	}

	public sealed record UsersBackgroundUploadBody
	{
		public required byte[] Background { get; init; }
		public int? X { get; init; }
		public int? Y { get; init; }
		public int? Crop { get; init; }
	}

	public sealed record UsersBackgroundCropBody
	{
		[JsonPropertyName("x")]
		public int? X { get; init; }
		[JsonPropertyName("y")]
		public int? Y { get; init; }
		[JsonPropertyName("crop")]
		public int? Crop { get; init; }
	}

	public sealed record UsersFollowersParams
	{
		[JsonPropertyName("order")]
		public string? Order { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record UsersFollowingsParams
	{
		[JsonPropertyName("order")]
		public string? Order { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

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

	public sealed record UsersIgnoredParams
	{
		[JsonPropertyName("total")]
		public bool? Total { get; init; }
	}

	public sealed record UsersIgnoreEditParams
	{
		[JsonPropertyName("ignore_conversations")]
		public bool? IgnoreConversations { get; init; }
		[JsonPropertyName("ignore_content")]
		public bool? IgnoreContent { get; init; }
		[JsonPropertyName("restrict_view_profile")]
		public bool? RestrictViewProfile { get; init; }
	}

	public sealed record UsersContentsParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}
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

	public sealed record ProfilePostsEditBody
	{
		[JsonPropertyName("post_body")]
		public string? PostBody { get; init; }
		[JsonPropertyName("disable_comments")]
		public bool? DisableComments { get; init; }
	}

	public sealed record ProfilePostsDeleteParams
	{
		[JsonPropertyName("reason")]
		public string? Reason { get; init; }
	}

	public sealed record ProfilePostsReportBody
	{
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}

	public sealed record ProfilePostsCreateBody
	{
		[JsonPropertyName("user_id")]
		public required JsonElement UserId { get; init; }
		[JsonPropertyName("post_body")]
		public required string PostBody { get; init; }
	}

	public sealed record ProfilePostsCommentsListParams
	{
		[JsonPropertyName("profile_post_id")]
		public int? ProfilePostId { get; init; }
		[JsonPropertyName("before")]
		public int? Before { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record ProfilePostsCommentsCreateBody
	{
		[JsonPropertyName("profile_post_id")]
		public required int? ProfilePostId { get; init; }
		[JsonPropertyName("comment_body")]
		public required string CommentBody { get; init; }
	}

	public sealed record ProfilePostsCommentsEditBody
	{
		[JsonPropertyName("comment_id")]
		public required int? CommentId { get; init; }
		[JsonPropertyName("comment_body")]
		public required string CommentBody { get; init; }
	}

	public sealed record ProfilePostsCommentsDeleteBody
	{
		[JsonPropertyName("comment_id")]
		public required int? CommentId { get; init; }
	}

	public sealed record ProfilePostsCommentsReportBody
	{
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}
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

	public sealed record ConversationsDeleteBody
	{
		[JsonPropertyName("conversation_id")]
		public required int? ConversationId { get; init; }
		[JsonPropertyName("delete_type")]
		public required string DeleteType { get; init; }
	}

	public sealed record ConversationsStartBody
	{
		[JsonPropertyName("user_id")]
		public required JsonElement UserId { get; init; }
	}

	public sealed record ConversationsSaveBody
	{
		[JsonPropertyName("link")]
		public required string Link { get; init; }
	}

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

	public sealed record ConversationsMessagesCreateBody
	{
		[JsonPropertyName("reply_message_id")]
		public int? ReplyMessageId { get; init; }
		[JsonPropertyName("message_body")]
		public required string MessageBody { get; init; }
	}

	public sealed record ConversationsSearchBody
	{
		[JsonPropertyName("q")]
		public string? Q { get; init; }
		[JsonPropertyName("conversation_id")]
		public int? ConversationId { get; init; }
		[JsonPropertyName("search_recipients")]
		public bool? SearchRecipients { get; init; }
	}

	public sealed record ConversationsMessagesEditBody
	{
		[JsonPropertyName("message_body")]
		public required string MessageBody { get; init; }
	}

	public sealed record ConversationsInviteBody
	{
		[JsonPropertyName("recipients")]
		public required List<string> Recipients { get; init; }
	}

	public sealed record ConversationsKickBody
	{
		[JsonPropertyName("user_id")]
		public required int? UserId { get; init; }
	}
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

	public sealed record NotificationsReadBody
	{
		[JsonPropertyName("notification_id")]
		public int? NotificationId { get; init; }
	}
}

// ─── TagsApi Types ────────────────────────────────────────

public static class TagsApiTypes
{
	public sealed record TagsListParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record TagsGetParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record TagsFindParams
	{
		[JsonPropertyName("tag")]
		public string? Tag { get; init; }
	}
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

	public sealed record SearchUsersBody
	{
		[JsonPropertyName("q")]
		public string? Q { get; init; }
	}

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

	public sealed record SearchResultsParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}
}

// ─── ChatboxApi Types ────────────────────────────────────────

public static class ChatboxApiTypes
{
	public sealed record ChatboxIndexParams
	{
		[JsonPropertyName("room_id")]
		public JsonElement? RoomId { get; init; }
	}

	public sealed record ChatboxGetMessagesParams
	{
		[JsonPropertyName("room_id")]
		public JsonElement? RoomId { get; init; }
		[JsonPropertyName("before_message_id")]
		public int? BeforeMessageId { get; init; }
	}

	public sealed record ChatboxPostMessageBody
	{
		[JsonPropertyName("room_id")]
		public required JsonElement RoomId { get; init; }
		[JsonPropertyName("reply_message_id")]
		public int? ReplyMessageId { get; init; }
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}

	public sealed record ChatboxEditMessageBody
	{
		[JsonPropertyName("message_id")]
		public required int? MessageId { get; init; }
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}

	public sealed record ChatboxDeleteMessageBody
	{
		[JsonPropertyName("message_id")]
		public required int? MessageId { get; init; }
	}

	public sealed record ChatboxOnlineParams
	{
		[JsonPropertyName("room_id")]
		public JsonElement? RoomId { get; init; }
	}

	public sealed record ChatboxReportReasonsParams
	{
		[JsonPropertyName("message_id")]
		public int? MessageId { get; init; }
	}

	public sealed record ChatboxReportBody
	{
		[JsonPropertyName("message_id")]
		public required int? MessageId { get; init; }
		[JsonPropertyName("reason")]
		public required string Reason { get; init; }
	}

	public sealed record ChatboxGetLeaderboardParams
	{
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public sealed record ChatboxPostIgnoreBody
	{
		[JsonPropertyName("user_id")]
		public required JsonElement UserId { get; init; }
	}

	public sealed record ChatboxDeleteIgnoreBody
	{
		[JsonPropertyName("user_id")]
		public required JsonElement UserId { get; init; }
	}
}

// ─── FormsApi Types ────────────────────────────────────────

public static class FormsApiTypes
{
	public sealed record FormsListParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
	}

	public sealed record FormsCreateBody
	{
		[JsonPropertyName("form_id")]
		public string? FormId { get; init; }
		[JsonPropertyName("fields")]
		public JsonElement? Fields { get; init; }
	}
}

