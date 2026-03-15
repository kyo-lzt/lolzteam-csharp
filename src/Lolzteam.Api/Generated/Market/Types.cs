// Auto-generated. Do not edit manually.

using System.Text.Json.Serialization;
using System.Text.Json;

namespace Lolzteam.Api.Generated.Market;

// ─── Component Schemas ────────────────────────────────────────

public sealed record DiscountModel(
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("discount_id")] long DiscountId,
	[property: JsonPropertyName("discount_percent")] long DiscountPercent,
	[property: JsonPropertyName("discount_user_id")] long DiscountUserId,
	[property: JsonPropertyName("max_price")] long MaxPrice,
	[property: JsonPropertyName("min_price")] long MinPrice,
	[property: JsonPropertyName("user_id")] long UserId
);

public sealed record CategoryIDModel(
);

public sealed record UserModel(
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("activity_visible")] bool ActivityVisible,
	[property: JsonPropertyName("age")] long Age,
	[property: JsonPropertyName("balance")] string Balance,
	[property: JsonPropertyName("balances")] List<JsonElement> Balances,
	[property: JsonPropertyName("bump_item_period")] long BumpItemPeriod,
	[property: JsonPropertyName("can_edit")] bool CanEdit,
	[property: JsonPropertyName("can_follow")] bool CanFollow,
	[property: JsonPropertyName("can_ignore")] bool CanIgnore,
	[property: JsonPropertyName("can_post_profile")] bool CanPostProfile,
	[property: JsonPropertyName("can_view_profile")] bool CanViewProfile,
	[property: JsonPropertyName("can_view_profile_posts")] bool CanViewProfilePosts,
	[property: JsonPropertyName("can_warn")] bool CanWarn,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("conv_welcome_message")] string ConvWelcomeMessage,
	[property: JsonPropertyName("convertedBalance")] long ConvertedBalance,
	[property: JsonPropertyName("convertedDeposit")] long ConvertedDeposit,
	[property: JsonPropertyName("convertedHold")] long ConvertedHold,
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("currencyPhrase")] string CurrencyPhrase,
	[property: JsonPropertyName("custom_account_download_format")] string CustomAccountDownloadFormat,
	[property: JsonPropertyName("custom_fields")] JsonElement CustomFields,
	[property: JsonPropertyName("custom_title")] string CustomTitle,
	[property: JsonPropertyName("deposit")] long Deposit,
	[property: JsonPropertyName("dob")] JsonElement Dob,
	[property: JsonPropertyName("feedback_data")] JsonElement FeedbackData,
	[property: JsonPropertyName("hold")] string Hold,
	[property: JsonPropertyName("homepage")] string Homepage,
	[property: JsonPropertyName("imap_data")] JsonElement ImapData,
	[property: JsonPropertyName("is_admin")] bool IsAdmin,
	[property: JsonPropertyName("is_banned")] bool IsBanned,
	[property: JsonPropertyName("is_followed")] bool IsFollowed,
	[property: JsonPropertyName("is_ignored")] bool IsIgnored,
	[property: JsonPropertyName("is_moderator")] bool IsModerator,
	[property: JsonPropertyName("is_staff")] bool IsStaff,
	[property: JsonPropertyName("is_super_admin")] bool IsSuperAdmin,
	[property: JsonPropertyName("joined_date")] long JoinedDate,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("like2_count")] long Like2Count,
	[property: JsonPropertyName("like_count")] long LikeCount,
	[property: JsonPropertyName("location")] string Location,
	[property: JsonPropertyName("market_custom_title")] string MarketCustomTitle,
	[property: JsonPropertyName("max_discount_percent")] long MaxDiscountPercent,
	[property: JsonPropertyName("message_count")] long MessageCount,
	[property: JsonPropertyName("paid_mail_left")] long PaidMailLeft,
	[property: JsonPropertyName("public_tags")] List<JsonElement> PublicTags,
	[property: JsonPropertyName("register_date")] long RegisterDate,
	[property: JsonPropertyName("rendered")] JsonElement Rendered,
	[property: JsonPropertyName("restore_count")] long RestoreCount,
	[property: JsonPropertyName("restore_data")] JsonElement RestoreData,
	[property: JsonPropertyName("short_link")] string ShortLink,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("telegram_client")] JsonElement TelegramClient,
	[property: JsonPropertyName("trophy_points")] long TrophyPoints,
	[property: JsonPropertyName("user_allow_ask_discount")] bool UserAllowAskDiscount,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("user_title")] string UserTitle,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("view_url")] string ViewUrl,
	[property: JsonPropertyName("visible")] bool Visible,
	[property: JsonPropertyName("warning_points")] long WarningPoints
);

public sealed record BalanceModel(
	[property: JsonPropertyName("balance")] string Balance,
	[property: JsonPropertyName("balance_id")] long BalanceId,
	[property: JsonPropertyName("custom_title")] JsonElement CustomTitle,
	[property: JsonPropertyName("fullTitle")] string FullTitle,
	[property: JsonPropertyName("merchant_id")] long MerchantId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("user_id")] long UserId
);

public sealed record ExtraModel(
	[property: JsonPropertyName("proxy")] string? Proxy,
	[property: JsonPropertyName("close_item")] bool? CloseItem,
	[property: JsonPropertyName("region")] string? Region,
	[property: JsonPropertyName("service")] string? Service,
	[property: JsonPropertyName("system")] string? System,
	[property: JsonPropertyName("confirmationCode")] string? ConfirmationCode,
	[property: JsonPropertyName("cookies")] string? Cookies,
	[property: JsonPropertyName("login_without_cookies")] bool? LoginWithoutCookies,
	[property: JsonPropertyName("cookie_login")] bool? CookieLogin,
	[property: JsonPropertyName("mfa_file")] string? MfaFile,
	[property: JsonPropertyName("dota2_mmr")] long? Dota2Mmr,
	[property: JsonPropertyName("ea_games")] bool? EaGames,
	[property: JsonPropertyName("uplay_games")] bool? UplayGames,
	[property: JsonPropertyName("the_quarry")] bool? TheQuarry,
	[property: JsonPropertyName("warframe")] bool? Warframe,
	[property: JsonPropertyName("ark")] bool? Ark,
	[property: JsonPropertyName("ark_ascended")] bool? ArkAscended,
	[property: JsonPropertyName("genshin_currency")] long? GenshinCurrency,
	[property: JsonPropertyName("honkai_currency")] long? HonkaiCurrency,
	[property: JsonPropertyName("zenless_currency")] long? ZenlessCurrency,
	[property: JsonPropertyName("password")] string? Password,
	[property: JsonPropertyName("telegramClient")] string? TelegramClient,
	[property: JsonPropertyName("telegramJson")] string? TelegramJson,
	[property: JsonPropertyName("checkChannels")] bool? CheckChannels,
	[property: JsonPropertyName("checkSpam")] bool? CheckSpam,
	[property: JsonPropertyName("checkHypixelBan")] bool? CheckHypixelBan
);

public sealed record ConfirmationCodeModel(
	[property: JsonPropertyName("item")] ItemModel Item,
	[property: JsonPropertyName("codeData")] JsonElement CodeData
);

public sealed record CurrencyModel(
);

public sealed record DatePeriodModel(
);

public sealed record YesNoNoMatterScheme(
);

public sealed record ItemListModel(
	[property: JsonPropertyName("items")] List<ItemFromListModel> Items,
	[property: JsonPropertyName("totalItems")] long TotalItems,
	[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
	[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
	[property: JsonPropertyName("perPage")] long PerPage,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("searchUrl")] string SearchUrl,
	[property: JsonPropertyName("stickyItems")] List<ItemFromListModel> StickyItems,
	[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
);

public sealed record ItemFromListModel(
	[property: JsonPropertyName("item_id")] long? ItemId,
	[property: JsonPropertyName("item_state")] string? ItemState,
	[property: JsonPropertyName("category_id")] long? CategoryId,
	[property: JsonPropertyName("published_date")] long? PublishedDate,
	[property: JsonPropertyName("title")] string? Title,
	[property: JsonPropertyName("description")] string? Description,
	[property: JsonPropertyName("price")] long? Price,
	[property: JsonPropertyName("update_stat_date")] long? UpdateStatDate,
	[property: JsonPropertyName("refreshed_date")] long? RefreshedDate,
	[property: JsonPropertyName("view_count")] long? ViewCount,
	[property: JsonPropertyName("is_sticky")] long? IsSticky,
	[property: JsonPropertyName("item_origin")] string? ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long? ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long? Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long? AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string? TitleEn,
	[property: JsonPropertyName("description_en")] string? DescriptionEn,
	[property: JsonPropertyName("item_domain")] string? ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string? ResaleItemOrigin,
	[property: JsonPropertyName("isIgnored")] long? IsIgnored,
	[property: JsonPropertyName("guarantee")] bool? Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool? CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool? CanUpdateItemStats,
	[property: JsonPropertyName("canViewEmailLoginData")] bool? CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool? ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool? CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool? CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool? CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool? CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool? CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool? CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] JsonElement? BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool? CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool? CanBuyItem,
	[property: JsonPropertyName("rub_price")] long? RubPrice,
	[property: JsonPropertyName("price_currency")] string? PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool? CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool? CanResellItemAfterPurchase,
	[property: JsonPropertyName("canViewAccountLink")] bool? CanViewAccountLink,
	[property: JsonPropertyName("itemOriginPhrase")] string? ItemOriginPhrase,
	[property: JsonPropertyName("tags")] List<string>? Tags,
	[property: JsonPropertyName("note_text")] string? NoteText,
	[property: JsonPropertyName("description_html")] string? DescriptionHtml,
	[property: JsonPropertyName("description_html_en")] string? DescriptionHtmlEn,
	[property: JsonPropertyName("seller")] JsonElement? Seller
);

public sealed record ItemModel(
	[property: JsonPropertyName("item_id")] long ItemId,
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("published_date")] long PublishedDate,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("price")] long Price,
	[property: JsonPropertyName("update_stat_date")] long UpdateStatDate,
	[property: JsonPropertyName("refreshed_date")] long RefreshedDate,
	[property: JsonPropertyName("edit_date")] long EditDate,
	[property: JsonPropertyName("pending_deletion_date")] long PendingDeletionDate,
	[property: JsonPropertyName("login")] string Login,
	[property: JsonPropertyName("temp_email")] string TempEmail,
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("information")] string Information,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("information_en")] string InformationEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("note_text")] string NoteText,
	[property: JsonPropertyName("content_type")] JsonElement ContentType,
	[property: JsonPropertyName("content_id")] JsonElement ContentId,
	[property: JsonPropertyName("delete_date")] long DeleteDate,
	[property: JsonPropertyName("delete_user_id")] long DeleteUserId,
	[property: JsonPropertyName("delete_username")] string DeleteUsername,
	[property: JsonPropertyName("delete_reason")] string DeleteReason,
	[property: JsonPropertyName("user_allow_ask_discount")] long UserAllowAskDiscount,
	[property: JsonPropertyName("max_discount_percent")] long MaxDiscountPercent,
	[property: JsonPropertyName("market_custom_title")] string MarketCustomTitle,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("buyer_display_icon_group_id")] long BuyerDisplayIconGroupId,
	[property: JsonPropertyName("buyer_uniq_banner")] string BuyerUniqBanner,
	[property: JsonPropertyName("buyer_avatar_date")] long BuyerAvatarDate,
	[property: JsonPropertyName("buyer_user_group_id")] long BuyerUserGroupId,
	[property: JsonPropertyName("is_fave")] JsonElement IsFave,
	[property: JsonPropertyName("in_cart")] JsonElement InCart,
	[property: JsonPropertyName("cart_price")] JsonElement CartPrice,
	[property: JsonPropertyName("canResellItem")] bool CanResellItem,
	[property: JsonPropertyName("priceWithSellerFee")] double PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewItemViews")] bool CanViewItemViews,
	[property: JsonPropertyName("loginData")] JsonElement LoginData,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("copyFormatData")] JsonElement CopyFormatData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("getEmailCodeDisplayLogin")] JsonElement GetEmailCodeDisplayLogin,
	[property: JsonPropertyName("buyer")] JsonElement Buyer,
	[property: JsonPropertyName("isPersonalAccount")] bool IsPersonalAccount,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("priceWithSellerFeeLabel")] string PriceWithSellerFeeLabel,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("isSmallExf")] bool IsSmallExf,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<JsonElement> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("imagePreviewLinks")] List<string> ImagePreviewLinks,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("canChangeEmailPassword")] bool CanChangeEmailPassword,
	[property: JsonPropertyName("uniqueKeyExists")] bool UniqueKeyExists,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("visitorIsAuthor")] bool VisitorIsAuthor,
	[property: JsonPropertyName("canAskDiscount")] bool CanAskDiscount,
	[property: JsonPropertyName("tags")] JsonElement Tags,
	[property: JsonPropertyName("customFields")] JsonElement CustomFields,
	[property: JsonPropertyName("externalAuth")] List<JsonElement> ExternalAuth,
	[property: JsonPropertyName("isTrusted")] bool IsTrusted,
	[property: JsonPropertyName("isBirthdayToday")] bool IsBirthdayToday,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("deposit")] long Deposit,
	[property: JsonPropertyName("extraPrices")] List<JsonElement> ExtraPrices,
	[property: JsonPropertyName("canViewAccountLoginAndTempEmail")] bool CanViewAccountLoginAndTempEmail,
	[property: JsonPropertyName("bumpSettings")] JsonElement BumpSettings,
	[property: JsonPropertyName("canCheckGuarantee")] bool CanCheckGuarantee,
	[property: JsonPropertyName("canShareItem")] bool CanShareItem,
	[property: JsonPropertyName("canCheckAiPrice")] bool CanCheckAiPrice,
	[property: JsonPropertyName("aiPrice")] long AiPrice,
	[property: JsonPropertyName("aiPriceCheckDate")] long AiPriceCheckDate,
	[property: JsonPropertyName("needToRequireVideoToViewLoginData")] bool NeedToRequireVideoToViewLoginData,
	[property: JsonPropertyName("canCheckAutoBuyPrice")] bool CanCheckAutoBuyPrice,
	[property: JsonPropertyName("autoBuyPrice")] long AutoBuyPrice,
	[property: JsonPropertyName("autoBuyPriceCheckDate")] long AutoBuyPriceCheckDate,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] JsonElement Seller
);

public sealed record ItemIDModel(
);

public sealed record InvoiceModel(
	[property: JsonPropertyName("additional_data")] string AdditionalData,
	[property: JsonPropertyName("amount")] long Amount,
	[property: JsonPropertyName("comment")] string Comment,
	[property: JsonPropertyName("expires_at")] long ExpiresAt,
	[property: JsonPropertyName("invoice_date")] long InvoiceDate,
	[property: JsonPropertyName("invoice_id")] long InvoiceId,
	[property: JsonPropertyName("is_test")] bool IsTest,
	[property: JsonPropertyName("merchant_id")] long MerchantId,
	[property: JsonPropertyName("paid_date")] long PaidDate,
	[property: JsonPropertyName("payer_user_id")] long PayerUserId,
	[property: JsonPropertyName("payment_id")] string PaymentId,
	[property: JsonPropertyName("resend_attempts")] long ResendAttempts,
	[property: JsonPropertyName("status")] string Status,
	[property: JsonPropertyName("url")] string Url,
	[property: JsonPropertyName("url_callback")] string UrlCallback,
	[property: JsonPropertyName("url_success")] string UrlSuccess,
	[property: JsonPropertyName("user_id")] long UserId
);

public sealed record Resp_SystemInfo(
	[property: JsonPropertyName("visitor_id")] long VisitorId,
	[property: JsonPropertyName("time")] long Time,
	[property: JsonPropertyName("log_id")] long LogId
);

// ─── CategoryApi Types ────────────────────────────────────────

public static class CategoryApiTypes
{
	public sealed record CategoryAllParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
	}

	public sealed record CategoryAllResponse(
		[property: JsonPropertyName("items")] List<ItemFromListModel> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<ItemFromListModel> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategorySteamParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("game[]")]
		public List<int?>? Game { get; init; }
		[JsonPropertyName("hours_played")]
		public JsonElement? HoursPlayed { get; init; }
		[JsonPropertyName("hours_played_max")]
		public JsonElement? HoursPlayedMax { get; init; }
		[JsonPropertyName("eg")]
		public JsonElement? Eg { get; init; }
		[JsonPropertyName("vac[]")]
		public List<int?>? Vac { get; init; }
		[JsonPropertyName("vac_skip_game_check")]
		public bool? VacSkipGameCheck { get; init; }
		[JsonPropertyName("rt")]
		public string? Rt { get; init; }
		[JsonPropertyName("trade_ban")]
		public string? TradeBan { get; init; }
		[JsonPropertyName("trade_limit")]
		public string? TradeLimit { get; init; }
		[JsonPropertyName("daybreak")]
		public int? Daybreak { get; init; }
		[JsonPropertyName("limit")]
		public string? Limit { get; init; }
		[JsonPropertyName("mafile")]
		public string? Mafile { get; init; }
		[JsonPropertyName("reg")]
		public int? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public string? RegPeriod { get; init; }
		[JsonPropertyName("lmin")]
		public int? Lmin { get; init; }
		[JsonPropertyName("lmax")]
		public int? Lmax { get; init; }
		[JsonPropertyName("rmin")]
		public int? Rmin { get; init; }
		[JsonPropertyName("rmax")]
		public int? Rmax { get; init; }
		[JsonPropertyName("wingman_rmin")]
		public int? WingmanRmin { get; init; }
		[JsonPropertyName("wingman_rmax")]
		public int? WingmanRmax { get; init; }
		[JsonPropertyName("no_vac")]
		public bool? NoVac { get; init; }
		[JsonPropertyName("mm_ban")]
		public string? MmBan { get; init; }
		[JsonPropertyName("balance_min")]
		public int? BalanceMin { get; init; }
		[JsonPropertyName("balance_max")]
		public int? BalanceMax { get; init; }
		[JsonPropertyName("inv_game")]
		public int? InvGame { get; init; }
		[JsonPropertyName("inv_min")]
		public double? InvMin { get; init; }
		[JsonPropertyName("inv_max")]
		public double? InvMax { get; init; }
		[JsonPropertyName("friends_min")]
		public int? FriendsMin { get; init; }
		[JsonPropertyName("friends_max")]
		public int? FriendsMax { get; init; }
		[JsonPropertyName("gmin")]
		public int? Gmin { get; init; }
		[JsonPropertyName("gmax")]
		public int? Gmax { get; init; }
		[JsonPropertyName("win_count_min")]
		public int? WinCountMin { get; init; }
		[JsonPropertyName("win_count_max")]
		public int? WinCountMax { get; init; }
		[JsonPropertyName("medal_id[]")]
		public JsonElement? MedalId { get; init; }
		[JsonPropertyName("medal_operator_or")]
		public bool? MedalOperatorOr { get; init; }
		[JsonPropertyName("medal_min")]
		public int? MedalMin { get; init; }
		[JsonPropertyName("medal_max")]
		public int? MedalMax { get; init; }
		[JsonPropertyName("gift[]")]
		public JsonElement? Gift { get; init; }
		[JsonPropertyName("gift_min")]
		public int? GiftMin { get; init; }
		[JsonPropertyName("gift_max")]
		public int? GiftMax { get; init; }
		[JsonPropertyName("recently_hours_min")]
		public int? RecentlyHoursMin { get; init; }
		[JsonPropertyName("recently_hours_max")]
		public int? RecentlyHoursMax { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("cs2_profile_rank_min")]
		public int? Cs2ProfileRankMin { get; init; }
		[JsonPropertyName("cs2_profile_rank_max")]
		public int? Cs2ProfileRankMax { get; init; }
		[JsonPropertyName("solommr_min")]
		public int? SolommrMin { get; init; }
		[JsonPropertyName("solommr_max")]
		public int? SolommrMax { get; init; }
		[JsonPropertyName("d2_game_count_min")]
		public int? D2GameCountMin { get; init; }
		[JsonPropertyName("d2_game_count_max")]
		public int? D2GameCountMax { get; init; }
		[JsonPropertyName("d2_win_count_min")]
		public int? D2WinCountMin { get; init; }
		[JsonPropertyName("d2_win_count_max")]
		public int? D2WinCountMax { get; init; }
		[JsonPropertyName("d2_behavior_min")]
		public int? D2BehaviorMin { get; init; }
		[JsonPropertyName("d2_behavior_max")]
		public int? D2BehaviorMax { get; init; }
		[JsonPropertyName("faceit_lvl_min")]
		public int? FaceitLvlMin { get; init; }
		[JsonPropertyName("faceit_lvl_max")]
		public int? FaceitLvlMax { get; init; }
		[JsonPropertyName("points_min")]
		public int? PointsMin { get; init; }
		[JsonPropertyName("points_max")]
		public int? PointsMax { get; init; }
		[JsonPropertyName("relevant_gmin")]
		public int? RelevantGmin { get; init; }
		[JsonPropertyName("relevant_gmax")]
		public int? RelevantGmax { get; init; }
		[JsonPropertyName("last_trans_date")]
		public int? LastTransDate { get; init; }
		[JsonPropertyName("last_trans_date_period")]
		public string? LastTransDatePeriod { get; init; }
		[JsonPropertyName("last_trans_date_later")]
		public int? LastTransDateLater { get; init; }
		[JsonPropertyName("last_trans_date_period_later")]
		public string? LastTransDatePeriodLater { get; init; }
		[JsonPropertyName("no_trans")]
		public bool? NoTrans { get; init; }
		[JsonPropertyName("trans")]
		public bool? Trans { get; init; }
		[JsonPropertyName("gifts_purchase_min")]
		public double? GiftsPurchaseMin { get; init; }
		[JsonPropertyName("gifts_purchase_max")]
		public double? GiftsPurchaseMax { get; init; }
		[JsonPropertyName("refunds_purchase_min")]
		public double? RefundsPurchaseMin { get; init; }
		[JsonPropertyName("refunds_purchase_max")]
		public double? RefundsPurchaseMax { get; init; }
		[JsonPropertyName("ingame_purchase_min")]
		public double? IngamePurchaseMin { get; init; }
		[JsonPropertyName("ingame_purchase_max")]
		public double? IngamePurchaseMax { get; init; }
		[JsonPropertyName("games_purchase_min")]
		public double? GamesPurchaseMin { get; init; }
		[JsonPropertyName("games_purchase_max")]
		public double? GamesPurchaseMax { get; init; }
		[JsonPropertyName("purchase_min")]
		public double? PurchaseMin { get; init; }
		[JsonPropertyName("purchase_max")]
		public double? PurchaseMax { get; init; }
		[JsonPropertyName("has_activated_keys")]
		public string? HasActivatedKeys { get; init; }
		[JsonPropertyName("elo_min")]
		public int? EloMin { get; init; }
		[JsonPropertyName("elo_max")]
		public int? EloMax { get; init; }
		[JsonPropertyName("cs2_map_rank")]
		public JsonElement? Cs2MapRank { get; init; }
		[JsonPropertyName("cs2_map_rmin")]
		public int? Cs2MapRmin { get; init; }
		[JsonPropertyName("cs2_map_rmax")]
		public int? Cs2MapRmax { get; init; }
		[JsonPropertyName("has_faceit")]
		public string? HasFaceit { get; init; }
		[JsonPropertyName("faceit_csgo_lvl_min")]
		public int? FaceitCsgoLvlMin { get; init; }
		[JsonPropertyName("faceit_csgo_lvl_max")]
		public int? FaceitCsgoLvlMax { get; init; }
		[JsonPropertyName("rust_deaths_min")]
		public int? RustDeathsMin { get; init; }
		[JsonPropertyName("rust_deaths_max")]
		public int? RustDeathsMax { get; init; }
		[JsonPropertyName("rust_kills_min")]
		public int? RustKillsMin { get; init; }
		[JsonPropertyName("rust_kills_max")]
		public int? RustKillsMax { get; init; }
		[JsonPropertyName("d2_last_match_date")]
		public int? D2LastMatchDate { get; init; }
		[JsonPropertyName("d2_last_match_date_period")]
		public string? D2LastMatchDatePeriod { get; init; }
		[JsonPropertyName("cards_min")]
		public int? CardsMin { get; init; }
		[JsonPropertyName("cards_max")]
		public int? CardsMax { get; init; }
		[JsonPropertyName("cards_games_min")]
		public int? CardsGamesMin { get; init; }
		[JsonPropertyName("cards_games_max")]
		public int? CardsGamesMax { get; init; }
		[JsonPropertyName("skip_vac_inv")]
		public bool? SkipVacInv { get; init; }
	}

	public sealed record CategorySteamResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryFortniteParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("temp_email")]
		public string? TempEmail { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("eg")]
		public JsonElement? Eg { get; init; }
		[JsonPropertyName("smin")]
		public int? Smin { get; init; }
		[JsonPropertyName("smax")]
		public int? Smax { get; init; }
		[JsonPropertyName("vbmin")]
		public int? Vbmin { get; init; }
		[JsonPropertyName("vbmax")]
		public int? Vbmax { get; init; }
		[JsonPropertyName("skin[]")]
		public JsonElement? Skin { get; init; }
		[JsonPropertyName("pickaxe[]")]
		public JsonElement? Pickaxe { get; init; }
		[JsonPropertyName("glider[]")]
		public JsonElement? Glider { get; init; }
		[JsonPropertyName("dance[]")]
		public JsonElement? Dance { get; init; }
		[JsonPropertyName("change_email")]
		public string? ChangeEmail { get; init; }
		[JsonPropertyName("platform[]")]
		public JsonElement? Platform { get; init; }
		[JsonPropertyName("skins_shop_min")]
		public int? SkinsShopMin { get; init; }
		[JsonPropertyName("skins_shop_max")]
		public int? SkinsShopMax { get; init; }
		[JsonPropertyName("pickaxes_shop_min")]
		public int? PickaxesShopMin { get; init; }
		[JsonPropertyName("pickaxes_shop_max")]
		public int? PickaxesShopMax { get; init; }
		[JsonPropertyName("dances_shop_min")]
		public int? DancesShopMin { get; init; }
		[JsonPropertyName("dances_shop_max")]
		public int? DancesShopMax { get; init; }
		[JsonPropertyName("gliders_shop_min")]
		public int? GlidersShopMin { get; init; }
		[JsonPropertyName("gliders_shop_max")]
		public int? GlidersShopMax { get; init; }
		[JsonPropertyName("skins_shop_vbmin")]
		public int? SkinsShopVbmin { get; init; }
		[JsonPropertyName("skins_shop_vbmax")]
		public int? SkinsShopVbmax { get; init; }
		[JsonPropertyName("pickaxes_shop_vbmin")]
		public int? PickaxesShopVbmin { get; init; }
		[JsonPropertyName("pickaxes_shop_vbmax")]
		public int? PickaxesShopVbmax { get; init; }
		[JsonPropertyName("dances_shop_vbmin")]
		public int? DancesShopVbmin { get; init; }
		[JsonPropertyName("dances_shop_vbmax")]
		public int? DancesShopVbmax { get; init; }
		[JsonPropertyName("gliders_shop_vbmin")]
		public int? GlidersShopVbmin { get; init; }
		[JsonPropertyName("gliders_shop_vbmax")]
		public int? GlidersShopVbmax { get; init; }
		[JsonPropertyName("bp")]
		public string? Bp { get; init; }
		[JsonPropertyName("lmin")]
		public int? Lmin { get; init; }
		[JsonPropertyName("lmax")]
		public int? Lmax { get; init; }
		[JsonPropertyName("bp_lmin")]
		public int? BpLmin { get; init; }
		[JsonPropertyName("bp_lmax")]
		public int? BpLmax { get; init; }
		[JsonPropertyName("last_trans_date")]
		public int? LastTransDate { get; init; }
		[JsonPropertyName("last_trans_date_period")]
		public string? LastTransDatePeriod { get; init; }
		[JsonPropertyName("no_trans")]
		public bool? NoTrans { get; init; }
		[JsonPropertyName("xbox_linkable")]
		public string? XboxLinkable { get; init; }
		[JsonPropertyName("psn_linkable")]
		public string? PsnLinkable { get; init; }
		[JsonPropertyName("daybreak")]
		public int? Daybreak { get; init; }
		[JsonPropertyName("rl_purchases")]
		public bool? RlPurchases { get; init; }
		[JsonPropertyName("reg")]
		public int? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public string? RegPeriod { get; init; }
		[JsonPropertyName("refund_credits_min")]
		public int? RefundCreditsMin { get; init; }
		[JsonPropertyName("refund_credits_max")]
		public int? RefundCreditsMax { get; init; }
		[JsonPropertyName("pickaxe_min")]
		public int? PickaxeMin { get; init; }
		[JsonPropertyName("pickaxe_max")]
		public int? PickaxeMax { get; init; }
		[JsonPropertyName("dmin")]
		public int? Dmin { get; init; }
		[JsonPropertyName("dmax")]
		public int? Dmax { get; init; }
		[JsonPropertyName("gmin")]
		public int? Gmin { get; init; }
		[JsonPropertyName("gmax")]
		public int? Gmax { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
	}

	public sealed record CategoryFortniteResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryMihoyoParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("email")]
		public string? Email { get; init; }
		[JsonPropertyName("ea")]
		public string? Ea { get; init; }
		[JsonPropertyName("region")]
		public JsonElement? Region { get; init; }
		[JsonPropertyName("not_region")]
		public JsonElement? NotRegion { get; init; }
		[JsonPropertyName("genshin_character[]")]
		public JsonElement? GenshinCharacter { get; init; }
		[JsonPropertyName("genshin_character_constellations")]
		public JsonElement? GenshinCharacterConstellations { get; init; }
		[JsonPropertyName("genshin_character_constellations_max")]
		public JsonElement? GenshinCharacterConstellationsMax { get; init; }
		[JsonPropertyName("genshin_weapon[]")]
		public JsonElement? GenshinWeapon { get; init; }
		[JsonPropertyName("genshin_char_min")]
		public int? GenshinCharMin { get; init; }
		[JsonPropertyName("genshin_char_max")]
		public int? GenshinCharMax { get; init; }
		[JsonPropertyName("genshin_legendary_min")]
		public int? GenshinLegendaryMin { get; init; }
		[JsonPropertyName("genshin_legendary_max")]
		public int? GenshinLegendaryMax { get; init; }
		[JsonPropertyName("genshin_level_min")]
		public int? GenshinLevelMin { get; init; }
		[JsonPropertyName("genshin_level_max")]
		public int? GenshinLevelMax { get; init; }
		[JsonPropertyName("genshin_legendary_weapon_min")]
		public int? GenshinLegendaryWeaponMin { get; init; }
		[JsonPropertyName("genshin_legendary_weapon_max")]
		public int? GenshinLegendaryWeaponMax { get; init; }
		[JsonPropertyName("constellations_min")]
		public int? ConstellationsMin { get; init; }
		[JsonPropertyName("constellations_max")]
		public int? ConstellationsMax { get; init; }
		[JsonPropertyName("genshin_achievement_min")]
		public int? GenshinAchievementMin { get; init; }
		[JsonPropertyName("genshin_achievement_max")]
		public int? GenshinAchievementMax { get; init; }
		[JsonPropertyName("genshin_currency_min")]
		public int? GenshinCurrencyMin { get; init; }
		[JsonPropertyName("genshin_currency_max")]
		public int? GenshinCurrencyMax { get; init; }
		[JsonPropertyName("honkai_character[]")]
		public JsonElement? HonkaiCharacter { get; init; }
		[JsonPropertyName("honkai_character_eidolons")]
		public JsonElement? HonkaiCharacterEidolons { get; init; }
		[JsonPropertyName("honkai_character_eidolons_max")]
		public JsonElement? HonkaiCharacterEidolonsMax { get; init; }
		[JsonPropertyName("honkai_weapon[]")]
		public JsonElement? HonkaiWeapon { get; init; }
		[JsonPropertyName("honkai_char_min")]
		public int? HonkaiCharMin { get; init; }
		[JsonPropertyName("honkai_char_max")]
		public int? HonkaiCharMax { get; init; }
		[JsonPropertyName("honkai_legendary_min")]
		public int? HonkaiLegendaryMin { get; init; }
		[JsonPropertyName("honkai_legendary_max")]
		public int? HonkaiLegendaryMax { get; init; }
		[JsonPropertyName("honkai_level_min")]
		public int? HonkaiLevelMin { get; init; }
		[JsonPropertyName("honkai_level_max")]
		public int? HonkaiLevelMax { get; init; }
		[JsonPropertyName("honkai_legendary_weapon_min")]
		public int? HonkaiLegendaryWeaponMin { get; init; }
		[JsonPropertyName("honkai_legendary_weapon_max")]
		public int? HonkaiLegendaryWeaponMax { get; init; }
		[JsonPropertyName("eidolons_min")]
		public int? EidolonsMin { get; init; }
		[JsonPropertyName("eidolons_max")]
		public int? EidolonsMax { get; init; }
		[JsonPropertyName("honkai_achievement_min")]
		public int? HonkaiAchievementMin { get; init; }
		[JsonPropertyName("honkai_achievement_max")]
		public int? HonkaiAchievementMax { get; init; }
		[JsonPropertyName("honkai_currency_min")]
		public int? HonkaiCurrencyMin { get; init; }
		[JsonPropertyName("honkai_currency_max")]
		public int? HonkaiCurrencyMax { get; init; }
		[JsonPropertyName("zenless_character[]")]
		public JsonElement? ZenlessCharacter { get; init; }
		[JsonPropertyName("zenless_character_cinemas")]
		public JsonElement? ZenlessCharacterCinemas { get; init; }
		[JsonPropertyName("zenless_character_cinemas_max")]
		public JsonElement? ZenlessCharacterCinemasMax { get; init; }
		[JsonPropertyName("zenless_weapon[]")]
		public JsonElement? ZenlessWeapon { get; init; }
		[JsonPropertyName("zenless_legendary_min")]
		public int? ZenlessLegendaryMin { get; init; }
		[JsonPropertyName("zenless_legendary_max")]
		public int? ZenlessLegendaryMax { get; init; }
		[JsonPropertyName("cinemas_min")]
		public int? CinemasMin { get; init; }
		[JsonPropertyName("cinemas_max")]
		public int? CinemasMax { get; init; }
		[JsonPropertyName("zenless_legendary_weapon_min")]
		public int? ZenlessLegendaryWeaponMin { get; init; }
		[JsonPropertyName("zenless_legendary_weapon_max")]
		public int? ZenlessLegendaryWeaponMax { get; init; }
		[JsonPropertyName("zenless_char_min")]
		public int? ZenlessCharMin { get; init; }
		[JsonPropertyName("zenless_char_max")]
		public int? ZenlessCharMax { get; init; }
		[JsonPropertyName("zenless_level_min")]
		public int? ZenlessLevelMin { get; init; }
		[JsonPropertyName("zenless_level_max")]
		public int? ZenlessLevelMax { get; init; }
		[JsonPropertyName("zenless_achievement_min")]
		public int? ZenlessAchievementMin { get; init; }
		[JsonPropertyName("zenless_achievement_max")]
		public int? ZenlessAchievementMax { get; init; }
		[JsonPropertyName("zenless_currency_min")]
		public int? ZenlessCurrencyMin { get; init; }
		[JsonPropertyName("zenless_currency_max")]
		public int? ZenlessCurrencyMax { get; init; }
		[JsonPropertyName("daybreak")]
		public int? Daybreak { get; init; }
	}

	public sealed record CategoryMihoyoResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryRiotParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("rmin")]
		public int? Rmin { get; init; }
		[JsonPropertyName("rmax")]
		public int? Rmax { get; init; }
		[JsonPropertyName("last_rmin")]
		public int? LastRmin { get; init; }
		[JsonPropertyName("last_rmax")]
		public int? LastRmax { get; init; }
		[JsonPropertyName("previous_rmin")]
		public int? PreviousRmin { get; init; }
		[JsonPropertyName("previous_rmax")]
		public int? PreviousRmax { get; init; }
		[JsonPropertyName("weaponSkin[]")]
		public List<string>? WeaponSkin { get; init; }
		[JsonPropertyName("buddy[]")]
		public List<string>? Buddy { get; init; }
		[JsonPropertyName("agent[]")]
		public List<string>? Agent { get; init; }
		[JsonPropertyName("champion[]")]
		public List<string>? Champion { get; init; }
		[JsonPropertyName("skin[]")]
		public List<string>? Skin { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("daybreak")]
		public int? Daybreak { get; init; }
		[JsonPropertyName("valorant_level_min")]
		public int? ValorantLevelMin { get; init; }
		[JsonPropertyName("valorant_level_max")]
		public int? ValorantLevelMax { get; init; }
		[JsonPropertyName("lol_level_min")]
		public int? LolLevelMin { get; init; }
		[JsonPropertyName("lol_level_max")]
		public int? LolLevelMax { get; init; }
		[JsonPropertyName("inv_min")]
		public int? InvMin { get; init; }
		[JsonPropertyName("inv_max")]
		public int? InvMax { get; init; }
		[JsonPropertyName("vp_min")]
		public int? VpMin { get; init; }
		[JsonPropertyName("vp_max")]
		public int? VpMax { get; init; }
		[JsonPropertyName("valorant_smin")]
		public int? ValorantSmin { get; init; }
		[JsonPropertyName("valorant_smax")]
		public int? ValorantSmax { get; init; }
		[JsonPropertyName("valorant_rank_type[]")]
		public JsonElement? ValorantRankType { get; init; }
		[JsonPropertyName("amin")]
		public int? Amin { get; init; }
		[JsonPropertyName("amax")]
		public int? Amax { get; init; }
		[JsonPropertyName("valorant_region[]")]
		public List<string>? ValorantRegion { get; init; }
		[JsonPropertyName("valorant_not_region[]")]
		public List<string>? ValorantNotRegion { get; init; }
		[JsonPropertyName("lol_region[]")]
		public List<string>? LolRegion { get; init; }
		[JsonPropertyName("lol_not_region[]")]
		public List<string>? LolNotRegion { get; init; }
		[JsonPropertyName("knife")]
		public bool? Knife { get; init; }
		[JsonPropertyName("lol_smin")]
		public int? LolSmin { get; init; }
		[JsonPropertyName("lol_smax")]
		public int? LolSmax { get; init; }
		[JsonPropertyName("champion_min")]
		public int? ChampionMin { get; init; }
		[JsonPropertyName("champion_max")]
		public int? ChampionMax { get; init; }
		[JsonPropertyName("win_rate_min")]
		public int? WinRateMin { get; init; }
		[JsonPropertyName("win_rate_max")]
		public int? WinRateMax { get; init; }
		[JsonPropertyName("blue_min")]
		public int? BlueMin { get; init; }
		[JsonPropertyName("blue_max")]
		public int? BlueMax { get; init; }
		[JsonPropertyName("orange_min")]
		public int? OrangeMin { get; init; }
		[JsonPropertyName("orange_max")]
		public int? OrangeMax { get; init; }
		[JsonPropertyName("mythic_min")]
		public int? MythicMin { get; init; }
		[JsonPropertyName("mythic_max")]
		public int? MythicMax { get; init; }
		[JsonPropertyName("riot_min")]
		public int? RiotMin { get; init; }
		[JsonPropertyName("riot_max")]
		public int? RiotMax { get; init; }
		[JsonPropertyName("email")]
		public string? Email { get; init; }
		[JsonPropertyName("tel")]
		public string? Tel { get; init; }
		[JsonPropertyName("valorant_knife_min")]
		public int? ValorantKnifeMin { get; init; }
		[JsonPropertyName("valorant_knife_max")]
		public int? ValorantKnifeMax { get; init; }
		[JsonPropertyName("rp_min")]
		public int? RpMin { get; init; }
		[JsonPropertyName("rp_max")]
		public int? RpMax { get; init; }
		[JsonPropertyName("fa_min")]
		public int? FaMin { get; init; }
		[JsonPropertyName("fa_max")]
		public int? FaMax { get; init; }
		[JsonPropertyName("lol_rank[]")]
		public JsonElement? LolRank { get; init; }
	}

	public sealed record CategoryRiotResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryTelegramParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("spam")]
		public string? Spam { get; init; }
		[JsonPropertyName("password")]
		public string? Password { get; init; }
		[JsonPropertyName("premium")]
		public string? Premium { get; init; }
		[JsonPropertyName("premium_expiration")]
		public int? PremiumExpiration { get; init; }
		[JsonPropertyName("premium_expiration_period")]
		public string? PremiumExpirationPeriod { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("daybreak")]
		public int? Daybreak { get; init; }
		[JsonPropertyName("min_channels")]
		public int? MinChannels { get; init; }
		[JsonPropertyName("max_channels")]
		public int? MaxChannels { get; init; }
		[JsonPropertyName("min_chats")]
		public int? MinChats { get; init; }
		[JsonPropertyName("max_chats")]
		public int? MaxChats { get; init; }
		[JsonPropertyName("min_conversations")]
		public int? MinConversations { get; init; }
		[JsonPropertyName("max_conversations")]
		public int? MaxConversations { get; init; }
		[JsonPropertyName("min_admin")]
		public int? MinAdmin { get; init; }
		[JsonPropertyName("max_admin")]
		public int? MaxAdmin { get; init; }
		[JsonPropertyName("min_admin_sub")]
		public int? MinAdminSub { get; init; }
		[JsonPropertyName("max_admin_sub")]
		public int? MaxAdminSub { get; init; }
		[JsonPropertyName("dig_min")]
		public int? DigMin { get; init; }
		[JsonPropertyName("dig_max")]
		public int? DigMax { get; init; }
		[JsonPropertyName("min_contacts")]
		public int? MinContacts { get; init; }
		[JsonPropertyName("max_contacts")]
		public int? MaxContacts { get; init; }
		[JsonPropertyName("min_stars")]
		public int? MinStars { get; init; }
		[JsonPropertyName("max_stars")]
		public int? MaxStars { get; init; }
		[JsonPropertyName("birthday")]
		public int? Birthday { get; init; }
		[JsonPropertyName("birthday_period")]
		public string? BirthdayPeriod { get; init; }
		[JsonPropertyName("birthday_after")]
		public int? BirthdayAfter { get; init; }
		[JsonPropertyName("birthday_after_period")]
		public string? BirthdayAfterPeriod { get; init; }
		[JsonPropertyName("min_id")]
		public int? MinId { get; init; }
		[JsonPropertyName("max_id")]
		public int? MaxId { get; init; }
		[JsonPropertyName("allow_geo_spamblock")]
		public bool? AllowGeoSpamblock { get; init; }
		[JsonPropertyName("min_gifts")]
		public int? MinGifts { get; init; }
		[JsonPropertyName("max_gifts")]
		public int? MaxGifts { get; init; }
		[JsonPropertyName("min_nft_gifts")]
		public int? MinNftGifts { get; init; }
		[JsonPropertyName("max_nft_gifts")]
		public int? MaxNftGifts { get; init; }
		[JsonPropertyName("min_gifts_stars")]
		public int? MinGiftsStars { get; init; }
		[JsonPropertyName("max_gifts_stars")]
		public int? MaxGiftsStars { get; init; }
		[JsonPropertyName("min_gifts_convert_stars")]
		public int? MinGiftsConvertStars { get; init; }
		[JsonPropertyName("max_gifts_convert_stars")]
		public int? MaxGiftsConvertStars { get; init; }
		[JsonPropertyName("dc_id[]")]
		public List<int?>? DcId { get; init; }
		[JsonPropertyName("not_dc_id[]")]
		public List<int?>? NotDcId { get; init; }
		[JsonPropertyName("email")]
		public string? Email { get; init; }
		[JsonPropertyName("min_bots")]
		public int? MinBots { get; init; }
		[JsonPropertyName("max_bots")]
		public int? MaxBots { get; init; }
		[JsonPropertyName("min_bot_active_users")]
		public int? MinBotActiveUsers { get; init; }
		[JsonPropertyName("max_bot_active_users")]
		public int? MaxBotActiveUsers { get; init; }
	}

	public sealed record CategoryTelegramResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategorySupercellParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("daybreak")]
		public int? Daybreak { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("eg")]
		public JsonElement? Eg { get; init; }
		[JsonPropertyName("tel")]
		public string? Tel { get; init; }
		[JsonPropertyName("brawl_level_min")]
		public int? BrawlLevelMin { get; init; }
		[JsonPropertyName("brawl_level_max")]
		public int? BrawlLevelMax { get; init; }
		[JsonPropertyName("brawl_cup_min")]
		public int? BrawlCupMin { get; init; }
		[JsonPropertyName("brawl_cup_max")]
		public int? BrawlCupMax { get; init; }
		[JsonPropertyName("brawl_wins_min")]
		public int? BrawlWinsMin { get; init; }
		[JsonPropertyName("brawl_wins_max")]
		public int? BrawlWinsMax { get; init; }
		[JsonPropertyName("brawl_pass")]
		public string? BrawlPass { get; init; }
		[JsonPropertyName("brawler[]")]
		public JsonElement? Brawler { get; init; }
		[JsonPropertyName("brawlers_min")]
		public int? BrawlersMin { get; init; }
		[JsonPropertyName("brawlers_max")]
		public int? BrawlersMax { get; init; }
		[JsonPropertyName("legendary_brawlers_min")]
		public int? LegendaryBrawlersMin { get; init; }
		[JsonPropertyName("legendary_brawlers_max")]
		public int? LegendaryBrawlersMax { get; init; }
		[JsonPropertyName("royale_level_min")]
		public int? RoyaleLevelMin { get; init; }
		[JsonPropertyName("royale_level_max")]
		public int? RoyaleLevelMax { get; init; }
		[JsonPropertyName("royale_cup_min")]
		public int? RoyaleCupMin { get; init; }
		[JsonPropertyName("royale_cup_max")]
		public int? RoyaleCupMax { get; init; }
		[JsonPropertyName("royale_wins_min")]
		public int? RoyaleWinsMin { get; init; }
		[JsonPropertyName("royale_wins_max")]
		public int? RoyaleWinsMax { get; init; }
		[JsonPropertyName("king_level_min")]
		public int? KingLevelMin { get; init; }
		[JsonPropertyName("king_level_max")]
		public int? KingLevelMax { get; init; }
		[JsonPropertyName("royale_pass")]
		public string? RoyalePass { get; init; }
		[JsonPropertyName("clash_level_min")]
		public int? ClashLevelMin { get; init; }
		[JsonPropertyName("clash_level_max")]
		public int? ClashLevelMax { get; init; }
		[JsonPropertyName("clash_cup_min")]
		public int? ClashCupMin { get; init; }
		[JsonPropertyName("clash_cup_max")]
		public int? ClashCupMax { get; init; }
		[JsonPropertyName("clash_wins_min")]
		public int? ClashWinsMin { get; init; }
		[JsonPropertyName("clash_wins_max")]
		public int? ClashWinsMax { get; init; }
		[JsonPropertyName("clash_pass")]
		public string? ClashPass { get; init; }
		[JsonPropertyName("total_heroes_level_min")]
		public int? TotalHeroesLevelMin { get; init; }
		[JsonPropertyName("total_heroes_level_max")]
		public int? TotalHeroesLevelMax { get; init; }
		[JsonPropertyName("total_troops_level_min")]
		public int? TotalTroopsLevelMin { get; init; }
		[JsonPropertyName("total_troops_level_max")]
		public int? TotalTroopsLevelMax { get; init; }
		[JsonPropertyName("total_spells_level_min")]
		public int? TotalSpellsLevelMin { get; init; }
		[JsonPropertyName("total_spells_level_max")]
		public int? TotalSpellsLevelMax { get; init; }
		[JsonPropertyName("total_builder_heroes_level_min")]
		public int? TotalBuilderHeroesLevelMin { get; init; }
		[JsonPropertyName("total_builder_heroes_level_max")]
		public int? TotalBuilderHeroesLevelMax { get; init; }
		[JsonPropertyName("total_builder_troops_level_min")]
		public int? TotalBuilderTroopsLevelMin { get; init; }
		[JsonPropertyName("total_builder_troops_level_max")]
		public int? TotalBuilderTroopsLevelMax { get; init; }
		[JsonPropertyName("town_hall_level_min")]
		public int? TownHallLevelMin { get; init; }
		[JsonPropertyName("town_hall_level_max")]
		public int? TownHallLevelMax { get; init; }
		[JsonPropertyName("builder_hall_level_min")]
		public int? BuilderHallLevelMin { get; init; }
		[JsonPropertyName("builder_hall_level_max")]
		public int? BuilderHallLevelMax { get; init; }
		[JsonPropertyName("builder_hall_cup_min")]
		public int? BuilderHallCupMin { get; init; }
		[JsonPropertyName("builder_hall_cup_max")]
		public int? BuilderHallCupMax { get; init; }
		[JsonPropertyName("creation_year_min")]
		public int? CreationYearMin { get; init; }
		[JsonPropertyName("creation_year_max")]
		public int? CreationYearMax { get; init; }
	}

	public sealed record CategorySupercellResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryEaParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("game[]")]
		public List<string>? Game { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("gmin")]
		public int? Gmin { get; init; }
		[JsonPropertyName("gmax")]
		public int? Gmax { get; init; }
		[JsonPropertyName("al_rank_min")]
		public int? AlRankMin { get; init; }
		[JsonPropertyName("al_rank_max")]
		public int? AlRankMax { get; init; }
		[JsonPropertyName("al_level_min")]
		public int? AlLevelMin { get; init; }
		[JsonPropertyName("al_level_max")]
		public int? AlLevelMax { get; init; }
		[JsonPropertyName("has_ban")]
		public string? HasBan { get; init; }
		[JsonPropertyName("xbox_connected")]
		public string? XboxConnected { get; init; }
		[JsonPropertyName("steam_connected")]
		public string? SteamConnected { get; init; }
		[JsonPropertyName("psn_connected")]
		public string? PsnConnected { get; init; }
		[JsonPropertyName("subscription")]
		public string? Subscription { get; init; }
		[JsonPropertyName("subscription_length")]
		public int? SubscriptionLength { get; init; }
		[JsonPropertyName("subscription_period")]
		public string? SubscriptionPeriod { get; init; }
		[JsonPropertyName("hours_played")]
		public JsonElement? HoursPlayed { get; init; }
		[JsonPropertyName("hours_played_max")]
		public JsonElement? HoursPlayedMax { get; init; }
		[JsonPropertyName("transactions")]
		public string? Transactions { get; init; }
	}

	public sealed record CategoryEaResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryWotParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("tel")]
		public string? Tel { get; init; }
		[JsonPropertyName("daybreak")]
		public int? Daybreak { get; init; }
		[JsonPropertyName("battles_min")]
		public int? BattlesMin { get; init; }
		[JsonPropertyName("battles_max")]
		public int? BattlesMax { get; init; }
		[JsonPropertyName("gold_min")]
		public int? GoldMin { get; init; }
		[JsonPropertyName("gold_max")]
		public int? GoldMax { get; init; }
		[JsonPropertyName("silver_min")]
		public int? SilverMin { get; init; }
		[JsonPropertyName("silver_max")]
		public int? SilverMax { get; init; }
		[JsonPropertyName("top_min")]
		public int? TopMin { get; init; }
		[JsonPropertyName("top_max")]
		public int? TopMax { get; init; }
		[JsonPropertyName("prem_min")]
		public int? PremMin { get; init; }
		[JsonPropertyName("prem_max")]
		public int? PremMax { get; init; }
		[JsonPropertyName("top_prem_min")]
		public int? TopPremMin { get; init; }
		[JsonPropertyName("top_prem_max")]
		public int? TopPremMax { get; init; }
		[JsonPropertyName("win_pmin")]
		public int? WinPmin { get; init; }
		[JsonPropertyName("win_pmax")]
		public int? WinPmax { get; init; }
		[JsonPropertyName("tank[]")]
		public List<int?>? Tank { get; init; }
		[JsonPropertyName("region[]")]
		public JsonElement? Region { get; init; }
		[JsonPropertyName("not_region[]")]
		public JsonElement? NotRegion { get; init; }
		[JsonPropertyName("premium")]
		public string? Premium { get; init; }
		[JsonPropertyName("premium_expiration")]
		public int? PremiumExpiration { get; init; }
		[JsonPropertyName("premium_expiration_period")]
		public string? PremiumExpirationPeriod { get; init; }
		[JsonPropertyName("clan")]
		public string? Clan { get; init; }
		[JsonPropertyName("clan_role[]")]
		public JsonElement? ClanRole { get; init; }
		[JsonPropertyName("not_clan_role[]")]
		public JsonElement? NotClanRole { get; init; }
		[JsonPropertyName("clan_gold_min")]
		public int? ClanGoldMin { get; init; }
		[JsonPropertyName("clan_gold_max")]
		public int? ClanGoldMax { get; init; }
		[JsonPropertyName("clan_credits_min")]
		public int? ClanCreditsMin { get; init; }
		[JsonPropertyName("clan_credits_max")]
		public int? ClanCreditsMax { get; init; }
		[JsonPropertyName("clan_crystal_min")]
		public int? ClanCrystalMin { get; init; }
		[JsonPropertyName("clan_crystal_max")]
		public int? ClanCrystalMax { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
	}

	public sealed record CategoryWotResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryWotBlitzParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("tel")]
		public string? Tel { get; init; }
		[JsonPropertyName("daybreak")]
		public int? Daybreak { get; init; }
		[JsonPropertyName("battles_min")]
		public int? BattlesMin { get; init; }
		[JsonPropertyName("battles_max")]
		public int? BattlesMax { get; init; }
		[JsonPropertyName("gold_min")]
		public int? GoldMin { get; init; }
		[JsonPropertyName("gold_max")]
		public int? GoldMax { get; init; }
		[JsonPropertyName("silver_min")]
		public int? SilverMin { get; init; }
		[JsonPropertyName("silver_max")]
		public int? SilverMax { get; init; }
		[JsonPropertyName("top_min")]
		public int? TopMin { get; init; }
		[JsonPropertyName("top_max")]
		public int? TopMax { get; init; }
		[JsonPropertyName("prem_min")]
		public int? PremMin { get; init; }
		[JsonPropertyName("prem_max")]
		public int? PremMax { get; init; }
		[JsonPropertyName("top_prem_min")]
		public int? TopPremMin { get; init; }
		[JsonPropertyName("top_prem_max")]
		public int? TopPremMax { get; init; }
		[JsonPropertyName("win_pmin")]
		public int? WinPmin { get; init; }
		[JsonPropertyName("win_pmax")]
		public int? WinPmax { get; init; }
		[JsonPropertyName("tank[]")]
		public List<int?>? Tank { get; init; }
		[JsonPropertyName("region[]")]
		public JsonElement? Region { get; init; }
		[JsonPropertyName("not_region[]")]
		public JsonElement? NotRegion { get; init; }
		[JsonPropertyName("premium")]
		public string? Premium { get; init; }
		[JsonPropertyName("premium_expiration")]
		public int? PremiumExpiration { get; init; }
		[JsonPropertyName("premium_expiration_period")]
		public string? PremiumExpirationPeriod { get; init; }
		[JsonPropertyName("clan")]
		public string? Clan { get; init; }
		[JsonPropertyName("clan_role[]")]
		public JsonElement? ClanRole { get; init; }
		[JsonPropertyName("not_clan_role[]")]
		public JsonElement? NotClanRole { get; init; }
		[JsonPropertyName("clan_gold_min")]
		public int? ClanGoldMin { get; init; }
		[JsonPropertyName("clan_gold_max")]
		public int? ClanGoldMax { get; init; }
		[JsonPropertyName("clan_credits_min")]
		public int? ClanCreditsMin { get; init; }
		[JsonPropertyName("clan_credits_max")]
		public int? ClanCreditsMax { get; init; }
		[JsonPropertyName("clan_crystal_min")]
		public int? ClanCrystalMin { get; init; }
		[JsonPropertyName("clan_crystal_max")]
		public int? ClanCrystalMax { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
	}

	public sealed record CategoryWotBlitzResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryGiftsParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("subscription")]
		public string? Subscription { get; init; }
		[JsonPropertyName("subscription_length")]
		public int? SubscriptionLength { get; init; }
		[JsonPropertyName("subscription_period")]
		public string? SubscriptionPeriod { get; init; }
	}

	public sealed record CategoryGiftsResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryEpicGamesParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("eg")]
		public JsonElement? Eg { get; init; }
		[JsonPropertyName("game[]")]
		public List<string>? Game { get; init; }
		[JsonPropertyName("change_email")]
		public string? ChangeEmail { get; init; }
		[JsonPropertyName("rl_purchases")]
		public bool? RlPurchases { get; init; }
		[JsonPropertyName("balance_min")]
		public double? BalanceMin { get; init; }
		[JsonPropertyName("balance_max")]
		public double? BalanceMax { get; init; }
		[JsonPropertyName("rewards_balance_min")]
		public double? RewardsBalanceMin { get; init; }
		[JsonPropertyName("rewards_balance_max")]
		public double? RewardsBalanceMax { get; init; }
		[JsonPropertyName("gmin")]
		public int? Gmin { get; init; }
		[JsonPropertyName("gmax")]
		public int? Gmax { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("daybreak")]
		public int? Daybreak { get; init; }
		[JsonPropertyName("hours_played")]
		public JsonElement? HoursPlayed { get; init; }
		[JsonPropertyName("hours_played_max")]
		public JsonElement? HoursPlayedMax { get; init; }
	}

	public sealed record CategoryEpicGamesResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryEscapeFromTarkovParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("region")]
		public string? Region { get; init; }
		[JsonPropertyName("version[]")]
		public JsonElement? Version { get; init; }
		[JsonPropertyName("reg")]
		public int? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public string? RegPeriod { get; init; }
		[JsonPropertyName("level_min")]
		public int? LevelMin { get; init; }
		[JsonPropertyName("level_max")]
		public int? LevelMax { get; init; }
		[JsonPropertyName("pve")]
		public string? Pve { get; init; }
		[JsonPropertyName("side")]
		public string? Side { get; init; }
	}

	public sealed record CategoryEscapeFromTarkovResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategorySocialClubParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("daybreak")]
		public int? Daybreak { get; init; }
		[JsonPropertyName("level_min")]
		public int? LevelMin { get; init; }
		[JsonPropertyName("level_max")]
		public int? LevelMax { get; init; }
		[JsonPropertyName("cash_min")]
		public int? CashMin { get; init; }
		[JsonPropertyName("cash_max")]
		public int? CashMax { get; init; }
		[JsonPropertyName("bank_cash_min")]
		public int? BankCashMin { get; init; }
		[JsonPropertyName("bank_cash_max")]
		public int? BankCashMax { get; init; }
		[JsonPropertyName("game[]")]
		public List<string>? Game { get; init; }
	}

	public sealed record CategorySocialClubResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryUplayParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("game[]")]
		public List<string>? Game { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("daybreak")]
		public int? Daybreak { get; init; }
		[JsonPropertyName("gmin")]
		public int? Gmin { get; init; }
		[JsonPropertyName("gmax")]
		public int? Gmax { get; init; }
		[JsonPropertyName("subscription")]
		public string? Subscription { get; init; }
		[JsonPropertyName("subscription_length")]
		public int? SubscriptionLength { get; init; }
		[JsonPropertyName("subscription_period")]
		public string? SubscriptionPeriod { get; init; }
		[JsonPropertyName("r6_level_min")]
		public int? R6LevelMin { get; init; }
		[JsonPropertyName("r6_level_max")]
		public int? R6LevelMax { get; init; }
		[JsonPropertyName("r6_rank_min")]
		public int? R6RankMin { get; init; }
		[JsonPropertyName("r6_rank_max")]
		public int? R6RankMax { get; init; }
		[JsonPropertyName("r6_operators_min")]
		public int? R6OperatorsMin { get; init; }
		[JsonPropertyName("r6_operators_max")]
		public int? R6OperatorsMax { get; init; }
		[JsonPropertyName("r6_ban")]
		public string? R6Ban { get; init; }
		[JsonPropertyName("r6_smin")]
		public int? R6Smin { get; init; }
		[JsonPropertyName("r6_smax")]
		public int? R6Smax { get; init; }
		[JsonPropertyName("r6_skin[]")]
		public List<string>? R6Skin { get; init; }
		[JsonPropertyName("r6_operator[]")]
		public List<string>? R6Operator { get; init; }
		[JsonPropertyName("xbox_connected")]
		public string? XboxConnected { get; init; }
		[JsonPropertyName("psn_connected")]
		public string? PsnConnected { get; init; }
		[JsonPropertyName("steam_connected")]
		public string? SteamConnected { get; init; }
		[JsonPropertyName("balance_min")]
		public double? BalanceMin { get; init; }
		[JsonPropertyName("balance_max")]
		public double? BalanceMax { get; init; }
		[JsonPropertyName("transactions")]
		public string? Transactions { get; init; }
		[JsonPropertyName("reg")]
		public int? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public string? RegPeriod { get; init; }
	}

	public sealed record CategoryUplayResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryDiscordParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("tel")]
		public string? Tel { get; init; }
		[JsonPropertyName("nitro")]
		public string? Nitro { get; init; }
		[JsonPropertyName("nitro_type[]")]
		public JsonElement? NitroType { get; init; }
		[JsonPropertyName("nitro_length")]
		public int? NitroLength { get; init; }
		[JsonPropertyName("nitro_period")]
		public string? NitroPeriod { get; init; }
		[JsonPropertyName("boosts_min")]
		public int? BoostsMin { get; init; }
		[JsonPropertyName("boosts_max")]
		public int? BoostsMax { get; init; }
		[JsonPropertyName("billing")]
		public string? Billing { get; init; }
		[JsonPropertyName("gifts")]
		public string? Gifts { get; init; }
		[JsonPropertyName("transactions")]
		public string? Transactions { get; init; }
		[JsonPropertyName("badge[]")]
		public JsonElement? Badge { get; init; }
		[JsonPropertyName("condition[]")]
		public JsonElement? Condition { get; init; }
		[JsonPropertyName("chat_min")]
		public int? ChatMin { get; init; }
		[JsonPropertyName("chat_max")]
		public int? ChatMax { get; init; }
		[JsonPropertyName("min_admin_members")]
		public int? MinAdminMembers { get; init; }
		[JsonPropertyName("max_admin_members")]
		public int? MaxAdminMembers { get; init; }
		[JsonPropertyName("min_admin")]
		public int? MinAdmin { get; init; }
		[JsonPropertyName("max_admin")]
		public int? MaxAdmin { get; init; }
		[JsonPropertyName("reg")]
		public int? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public string? RegPeriod { get; init; }
		[JsonPropertyName("language[]")]
		public List<string>? Language { get; init; }
		[JsonPropertyName("not_language[]")]
		public List<string>? NotLanguage { get; init; }
		[JsonPropertyName("clans")]
		public string? Clans { get; init; }
		[JsonPropertyName("min_admin_clans")]
		public int? MinAdminClans { get; init; }
		[JsonPropertyName("max_admin_clans")]
		public int? MaxAdminClans { get; init; }
		[JsonPropertyName("min_owner_clans")]
		public int? MinOwnerClans { get; init; }
		[JsonPropertyName("max_owner_clans")]
		public int? MaxOwnerClans { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("min_servers")]
		public int? MinServers { get; init; }
		[JsonPropertyName("max_servers")]
		public int? MaxServers { get; init; }
		[JsonPropertyName("2fa")]
		public string? _2fa { get; init; }
		[JsonPropertyName("min_full_credits")]
		public int? MinFullCredits { get; init; }
		[JsonPropertyName("max_full_credits")]
		public int? MaxFullCredits { get; init; }
		[JsonPropertyName("min_basic_credits")]
		public int? MinBasicCredits { get; init; }
		[JsonPropertyName("max_basic_credits")]
		public int? MaxBasicCredits { get; init; }
		[JsonPropertyName("min_orbs")]
		public int? MinOrbs { get; init; }
		[JsonPropertyName("max_orbs")]
		public int? MaxOrbs { get; init; }
	}

	public sealed record CategoryDiscordResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryTikTokParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("tel")]
		public string? Tel { get; init; }
		[JsonPropertyName("reg")]
		public int? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public string? RegPeriod { get; init; }
		[JsonPropertyName("followers_min")]
		public int? FollowersMin { get; init; }
		[JsonPropertyName("followers_max")]
		public int? FollowersMax { get; init; }
		[JsonPropertyName("post_min")]
		public int? PostMin { get; init; }
		[JsonPropertyName("post_max")]
		public int? PostMax { get; init; }
		[JsonPropertyName("like_min")]
		public int? LikeMin { get; init; }
		[JsonPropertyName("like_max")]
		public int? LikeMax { get; init; }
		[JsonPropertyName("coins_min")]
		public int? CoinsMin { get; init; }
		[JsonPropertyName("coins_max")]
		public int? CoinsMax { get; init; }
		[JsonPropertyName("cookie_login")]
		public string? CookieLogin { get; init; }
		[JsonPropertyName("verified")]
		public string? Verified { get; init; }
		[JsonPropertyName("email")]
		public string? Email { get; init; }
	}

	public sealed record CategoryTikTokResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryInstagramParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("tel")]
		public string? Tel { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("cookies")]
		public string? Cookies { get; init; }
		[JsonPropertyName("login_without_cookies")]
		public string? LoginWithoutCookies { get; init; }
		[JsonPropertyName("followers_min")]
		public int? FollowersMin { get; init; }
		[JsonPropertyName("followers_max")]
		public int? FollowersMax { get; init; }
		[JsonPropertyName("post_min")]
		public int? PostMin { get; init; }
		[JsonPropertyName("post_max")]
		public int? PostMax { get; init; }
		[JsonPropertyName("reg")]
		public int? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public string? RegPeriod { get; init; }
	}

	public sealed record CategoryInstagramResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryBattleNetParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("eg")]
		public JsonElement? Eg { get; init; }
		[JsonPropertyName("game[]")]
		public List<int?>? Game { get; init; }
		[JsonPropertyName("daybreak")]
		public int? Daybreak { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("tel")]
		public string? Tel { get; init; }
		[JsonPropertyName("edit_btag")]
		public string? EditBtag { get; init; }
		[JsonPropertyName("changeable_fn")]
		public string? ChangeableFn { get; init; }
		[JsonPropertyName("real_id")]
		public string? RealId { get; init; }
		[JsonPropertyName("parent_control")]
		public string? ParentControl { get; init; }
		[JsonPropertyName("no_bans")]
		public string? NoBans { get; init; }
		[JsonPropertyName("balance_min")]
		public int? BalanceMin { get; init; }
		[JsonPropertyName("balance_max")]
		public int? BalanceMax { get; init; }
	}

	public sealed record CategoryBattleNetResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryChatGPTParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("subscription[]")]
		public JsonElement? Subscription { get; init; }
		[JsonPropertyName("subscription_length")]
		public int? SubscriptionLength { get; init; }
		[JsonPropertyName("subscription_period")]
		public string? SubscriptionPeriod { get; init; }
		[JsonPropertyName("autorenewal")]
		public string? Autorenewal { get; init; }
		[JsonPropertyName("tel")]
		public string? Tel { get; init; }
		[JsonPropertyName("transactions")]
		public string? Transactions { get; init; }
		[JsonPropertyName("reg")]
		public int? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public string? RegPeriod { get; init; }
		[JsonPropertyName("openai_tier[]")]
		public JsonElement? OpenaiTier { get; init; }
		[JsonPropertyName("openai_balance_min")]
		public int? OpenaiBalanceMin { get; init; }
		[JsonPropertyName("openai_balance_max")]
		public int? OpenaiBalanceMax { get; init; }
	}

	public sealed record CategoryChatGPTResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryVpnParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("service[]")]
		public JsonElement? Service { get; init; }
		[JsonPropertyName("subscription_length")]
		public int? SubscriptionLength { get; init; }
		[JsonPropertyName("subscription_period")]
		public string? SubscriptionPeriod { get; init; }
		[JsonPropertyName("autorenewal")]
		public string? Autorenewal { get; init; }
	}

	public sealed record CategoryVpnResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryRobloxParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email")]
		public string? Email { get; init; }
		[JsonPropertyName("robux_min")]
		public int? RobuxMin { get; init; }
		[JsonPropertyName("robux_max")]
		public int? RobuxMax { get; init; }
		[JsonPropertyName("friends_min")]
		public int? FriendsMin { get; init; }
		[JsonPropertyName("friends_max")]
		public int? FriendsMax { get; init; }
		[JsonPropertyName("followers_min")]
		public int? FollowersMin { get; init; }
		[JsonPropertyName("followers_max")]
		public int? FollowersMax { get; init; }
		[JsonPropertyName("country")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("reg")]
		public int? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public string? RegPeriod { get; init; }
		[JsonPropertyName("subscription")]
		public string? Subscription { get; init; }
		[JsonPropertyName("subscription_length")]
		public int? SubscriptionLength { get; init; }
		[JsonPropertyName("subscription_period")]
		public string? SubscriptionPeriod { get; init; }
		[JsonPropertyName("autorenewal")]
		public string? Autorenewal { get; init; }
		[JsonPropertyName("xbox_connected")]
		public string? XboxConnected { get; init; }
		[JsonPropertyName("psn_connected")]
		public string? PsnConnected { get; init; }
		[JsonPropertyName("verified")]
		public string? Verified { get; init; }
		[JsonPropertyName("age_verified")]
		public string? AgeVerified { get; init; }
		[JsonPropertyName("incoming_robux_total_min")]
		public int? IncomingRobuxTotalMin { get; init; }
		[JsonPropertyName("incoming_robux_total_max")]
		public int? IncomingRobuxTotalMax { get; init; }
		[JsonPropertyName("limited_price_min")]
		public int? LimitedPriceMin { get; init; }
		[JsonPropertyName("limited_price_max")]
		public int? LimitedPriceMax { get; init; }
		[JsonPropertyName("gamepass_min")]
		public int? GamepassMin { get; init; }
		[JsonPropertyName("gamepass_max")]
		public int? GamepassMax { get; init; }
		[JsonPropertyName("game_donations")]
		public string? GameDonations { get; init; }
		[JsonPropertyName("inv_min")]
		public int? InvMin { get; init; }
		[JsonPropertyName("inv_max")]
		public int? InvMax { get; init; }
		[JsonPropertyName("ugc_limited_price_min")]
		public int? UgcLimitedPriceMin { get; init; }
		[JsonPropertyName("ugc_limited_price_max")]
		public int? UgcLimitedPriceMax { get; init; }
		[JsonPropertyName("credit_balance_min")]
		public int? CreditBalanceMin { get; init; }
		[JsonPropertyName("credit_balance_max")]
		public int? CreditBalanceMax { get; init; }
		[JsonPropertyName("offsale_min")]
		public int? OffsaleMin { get; init; }
		[JsonPropertyName("offsale_max")]
		public int? OffsaleMax { get; init; }
		[JsonPropertyName("voice")]
		public string? Voice { get; init; }
		[JsonPropertyName("age_group[]")]
		public List<string>? AgeGroup { get; init; }
		[JsonPropertyName("not_age_group[]")]
		public List<string>? NotAgeGroup { get; init; }
	}

	public sealed record CategoryRobloxResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryWarfaceParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("rank_min")]
		public int? RankMin { get; init; }
		[JsonPropertyName("rank_max")]
		public int? RankMax { get; init; }
		[JsonPropertyName("bonus_rank_min")]
		public int? BonusRankMin { get; init; }
		[JsonPropertyName("bonus_rank_max")]
		public int? BonusRankMax { get; init; }
		[JsonPropertyName("tel")]
		public string? Tel { get; init; }
		[JsonPropertyName("daybreak")]
		public int? Daybreak { get; init; }
		[JsonPropertyName("kredits_min")]
		public int? KreditsMin { get; init; }
		[JsonPropertyName("kredits_max")]
		public int? KreditsMax { get; init; }
		[JsonPropertyName("total_kredits_min")]
		public int? TotalKreditsMin { get; init; }
		[JsonPropertyName("total_kredits_max")]
		public int? TotalKreditsMax { get; init; }
	}

	public sealed record CategoryWarfaceResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryMinecraftParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("subscription")]
		public string? Subscription { get; init; }
		[JsonPropertyName("subscription_length")]
		public int? SubscriptionLength { get; init; }
		[JsonPropertyName("subscription_period")]
		public string? SubscriptionPeriod { get; init; }
		[JsonPropertyName("autorenewal")]
		public string? Autorenewal { get; init; }
		[JsonPropertyName("java")]
		public string? Java { get; init; }
		[JsonPropertyName("bedrock")]
		public string? Bedrock { get; init; }
		[JsonPropertyName("dungeons")]
		public string? Dungeons { get; init; }
		[JsonPropertyName("legends")]
		public string? Legends { get; init; }
		[JsonPropertyName("change_nickname")]
		public string? ChangeNickname { get; init; }
		[JsonPropertyName("capes[]")]
		public List<string>? Capes { get; init; }
		[JsonPropertyName("capes_min")]
		public int? CapesMin { get; init; }
		[JsonPropertyName("capes_max")]
		public int? CapesMax { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("hypixel_ban")]
		public string? HypixelBan { get; init; }
		[JsonPropertyName("hypixel_skyblock_api_enabled")]
		public string? HypixelSkyblockApiEnabled { get; init; }
		[JsonPropertyName("rank_hypixel[]")]
		public JsonElement? RankHypixel { get; init; }
		[JsonPropertyName("level_hypixel_min")]
		public int? LevelHypixelMin { get; init; }
		[JsonPropertyName("level_hypixel_max")]
		public int? LevelHypixelMax { get; init; }
		[JsonPropertyName("achievement_hypixel_min")]
		public int? AchievementHypixelMin { get; init; }
		[JsonPropertyName("achievement_hypixel_max")]
		public int? AchievementHypixelMax { get; init; }
		[JsonPropertyName("level_hypixel_skyblock_min")]
		public int? LevelHypixelSkyblockMin { get; init; }
		[JsonPropertyName("level_hypixel_skyblock_max")]
		public int? LevelHypixelSkyblockMax { get; init; }
		[JsonPropertyName("net_worth_hypixel_skyblock_min")]
		public int? NetWorthHypixelSkyblockMin { get; init; }
		[JsonPropertyName("net_worth_hypixel_skyblock_max")]
		public int? NetWorthHypixelSkyblockMax { get; init; }
		[JsonPropertyName("reg")]
		public int? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public string? RegPeriod { get; init; }
		[JsonPropertyName("last_login_hypixel")]
		public int? LastLoginHypixel { get; init; }
		[JsonPropertyName("last_login_hypixel_period")]
		public string? LastLoginHypixelPeriod { get; init; }
		[JsonPropertyName("can_change_details")]
		public string? CanChangeDetails { get; init; }
		[JsonPropertyName("nickname_length_min")]
		public int? NicknameLengthMin { get; init; }
		[JsonPropertyName("nickname_length_max")]
		public int? NicknameLengthMax { get; init; }
		[JsonPropertyName("hypixel_ban_parsed")]
		public string? HypixelBanParsed { get; init; }
		[JsonPropertyName("minecoins_min")]
		public int? MinecoinsMin { get; init; }
		[JsonPropertyName("minecoins_max")]
		public int? MinecoinsMax { get; init; }
	}

	public sealed record CategoryMinecraftResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryHytaleParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("edition[]")]
		public JsonElement? Edition { get; init; }
		[JsonPropertyName("profiles_min")]
		public int? ProfilesMin { get; init; }
		[JsonPropertyName("profiles_max")]
		public int? ProfilesMax { get; init; }
	}

	public sealed record CategoryHytaleResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryListParams
	{
		[JsonPropertyName("top_queries")]
		public bool? TopQueries { get; init; }
	}

	public sealed record CategoryListResponse(
		[property: JsonPropertyName("category")] JsonElement Category,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryParamsResponse(
		[property: JsonPropertyName("category")] JsonElement? Category,
		[property: JsonPropertyName("params")] List<JsonElement>? Params,
		[property: JsonPropertyName("base_params")] JsonElement? BaseParams,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record CategoryGamesResponse(
		[property: JsonPropertyName("games")] List<JsonElement>? Games,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── ListApi Types ────────────────────────────────────────

public static class ListApiTypes
{
	public sealed record ListUserParams
	{
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("category_id")]
		public JsonElement? CategoryId { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("show")]
		public string? Show { get; init; }
		[JsonPropertyName("delete_reason")]
		public string? DeleteReason { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("login")]
		public string? Login { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("username")]
		public string? Username { get; init; }
		[JsonPropertyName("published_startDate")]
		public string? PublishedStartDate { get; init; }
		[JsonPropertyName("published_endDate")]
		public string? PublishedEndDate { get; init; }
		[JsonPropertyName("filter_by_published_date")]
		public bool? FilterByPublishedDate { get; init; }
		[JsonPropertyName("paid_startDate")]
		public string? PaidStartDate { get; init; }
		[JsonPropertyName("paid_endDate")]
		public string? PaidEndDate { get; init; }
		[JsonPropertyName("filter_by_buyer_operation_date")]
		public bool? FilterByBuyerOperationDate { get; init; }
		[JsonPropertyName("delete_startDate")]
		public string? DeleteStartDate { get; init; }
		[JsonPropertyName("delete_endDate")]
		public string? DeleteEndDate { get; init; }
		[JsonPropertyName("filter_by_delete_date")]
		public bool? FilterByDeleteDate { get; init; }
	}

	public sealed record ListUserResponse(
		[property: JsonPropertyName("items")] List<ItemFromListModel> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<ItemFromListModel> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ListOrdersParams
	{
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("category_id")]
		public JsonElement? CategoryId { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("show")]
		public string? Show { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("login")]
		public string? Login { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
	}

	public sealed record ListOrdersResponse(
		[property: JsonPropertyName("items")] List<ItemFromListModel> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<ItemFromListModel> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ListStatesParams
	{
		[JsonPropertyName("user_id")]
		public JsonElement? UserId { get; init; }
	}

	public sealed record ListStatesResponse(
		[property: JsonPropertyName("userItemStates")] JsonElement UserItemStates,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ListDownloadParams
	{
		[JsonPropertyName("format")]
		public string? Format { get; init; }
		[JsonPropertyName("custom_format")]
		public string? CustomFormat { get; init; }
		[JsonPropertyName("category_id")]
		public JsonElement? CategoryId { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("show")]
		public string? Show { get; init; }
		[JsonPropertyName("delete_reason")]
		public string? DeleteReason { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("username")]
		public string? Username { get; init; }
		[JsonPropertyName("published_startDate")]
		public string? PublishedStartDate { get; init; }
		[JsonPropertyName("published_endDate")]
		public string? PublishedEndDate { get; init; }
		[JsonPropertyName("filter_by_published_date")]
		public bool? FilterByPublishedDate { get; init; }
		[JsonPropertyName("paid_startDate")]
		public string? PaidStartDate { get; init; }
		[JsonPropertyName("paid_endDate")]
		public string? PaidEndDate { get; init; }
		[JsonPropertyName("filter_by_buyer_operation_date")]
		public bool? FilterByBuyerOperationDate { get; init; }
		[JsonPropertyName("delete_startDate")]
		public string? DeleteStartDate { get; init; }
		[JsonPropertyName("delete_endDate")]
		public string? DeleteEndDate { get; init; }
		[JsonPropertyName("filter_by_delete_date")]
		public bool? FilterByDeleteDate { get; init; }
	}

	public sealed record ListDownloadResponse(JsonElement Data);

	public sealed record ListFavoritesParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("show")]
		public string? Show { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
	}

	public sealed record ListFavoritesResponse(
		[property: JsonPropertyName("items")] List<ItemFromListModel> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<ItemFromListModel> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ListViewedParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("show")]
		public string? Show { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
	}

	public sealed record ListViewedResponse(
		[property: JsonPropertyName("items")] List<ItemFromListModel> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<ItemFromListModel> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);
}

// ─── ManagingApi Types ────────────────────────────────────────

public static class ManagingApiTypes
{
	public sealed record ManagingGetParams
	{
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
	}

	public sealed record ManagingGetResponse(
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("canStickItem")] bool CanStickItem,
		[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
		[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
		[property: JsonPropertyName("cannotBuyItemError")] string CannotBuyItemError,
		[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
		[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
		[property: JsonPropertyName("canReportItem")] bool CanReportItem,
		[property: JsonPropertyName("canEditItem")] bool CanEditItem,
		[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
		[property: JsonPropertyName("canCancelConfirmedBuy")] bool CanCancelConfirmedBuy,
		[property: JsonPropertyName("canViewItemHistory")] bool CanViewItemHistory,
		[property: JsonPropertyName("faveCount")] bool FaveCount,
		[property: JsonPropertyName("isVisibleItem")] bool IsVisibleItem,
		[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
		[property: JsonPropertyName("showToFavouritesButton")] bool ShowToFavouritesButton,
		[property: JsonPropertyName("itemLink")] string ItemLink,
		[property: JsonPropertyName("canChangeOwner")] bool CanChangeOwner,
		[property: JsonPropertyName("sameItemsIds")] List<long> SameItemsIds,
		[property: JsonPropertyName("sameItemsCount")] long SameItemsCount,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingDeleteBody
	{
		[JsonPropertyName("reason")]
		public required string Reason { get; init; }
	}

	public sealed record ManagingDeleteResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingCreateClaimBody
	{
		[JsonPropertyName("item_id")]
		public required int? ItemId { get; init; }
		[JsonPropertyName("post_body")]
		public required string PostBody { get; init; }
	}

	public sealed record ManagingCreateClaimResponse(
		[property: JsonPropertyName("thread")] JsonElement Thread,
		[property: JsonPropertyName("system_info")] JsonElement SystemInfo
	);

	public sealed record ManagingBulkGetBody
	{
		[JsonPropertyName("item_id")]
		public List<int?>? ItemId { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
	}

	public sealed record ManagingBulkGetResponse(
		[property: JsonPropertyName("items")] List<JsonElement> Items,
		[property: JsonPropertyName("left_item_id")] List<long> LeftItemId,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingSteamInventoryValueParams
	{
		[JsonPropertyName("app_id")]
		public JsonElement? AppId { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("ignore_cache")]
		public bool? IgnoreCache { get; init; }
	}

	public sealed record ManagingSteamInventoryValueResponse(
		[property: JsonPropertyName("query")] string? Query,
		[property: JsonPropertyName("data")] JsonElement? Data,
		[property: JsonPropertyName("appId")] long? AppId,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ManagingSteamValueParams
	{
		[JsonPropertyName("link")]
		public string? Link { get; init; }
		[JsonPropertyName("app_id")]
		public JsonElement? AppId { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("ignore_cache")]
		public bool? IgnoreCache { get; init; }
	}

	public sealed record ManagingSteamValueResponse(
		[property: JsonPropertyName("query")] string? Query,
		[property: JsonPropertyName("data")] JsonElement? Data,
		[property: JsonPropertyName("appId")] long? AppId,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ManagingSteamPreviewParams
	{
		[JsonPropertyName("type")]
		public string? Type { get; init; }
	}

	public sealed record ManagingSteamPreviewResponse(JsonElement Data);

	public sealed record ManagingEditBody
	{
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("title_en")]
		public string? TitleEn { get; init; }
		[JsonPropertyName("price")]
		public int? Price { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("item_origin")]
		public string? ItemOrigin { get; init; }
		[JsonPropertyName("email_login_data")]
		public string? EmailLoginData { get; init; }
		[JsonPropertyName("email_type")]
		public string? EmailType { get; init; }
		[JsonPropertyName("allow_ask_discount")]
		public bool? AllowAskDiscount { get; init; }
		[JsonPropertyName("proxy_id")]
		public int? ProxyId { get; init; }
		[JsonPropertyName("description")]
		public string? Description { get; init; }
		[JsonPropertyName("information")]
		public string? Information { get; init; }
	}

	public sealed record ManagingEditResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ManagingAIPriceResponse(
		[property: JsonPropertyName("price")] long Price,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingAutoBuyPriceResponse(
		[property: JsonPropertyName("price")] long Price,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingNoteBody
	{
		[JsonPropertyName("text")]
		public string? Text { get; init; }
	}

	public sealed record ManagingNoteResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingSteamUpdateValueBody
	{
		[JsonPropertyName("all")]
		public bool? All { get; init; }
		[JsonPropertyName("app_id")]
		public JsonElement? AppId { get; init; }
		[JsonPropertyName("authorize")]
		public bool? Authorize { get; init; }
	}

	public sealed record ManagingSteamUpdateValueResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingBumpResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingAutoBumpBody
	{
		[JsonPropertyName("hour")]
		public required int? Hour { get; init; }
	}

	public sealed record ManagingAutoBumpResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingAutoBumpDisableResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingOpenResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingCloseResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingImageParams
	{
		[JsonPropertyName("type")]
		public string? Type { get; init; }
	}

	public sealed record ManagingImageResponse(
		[property: JsonPropertyName("base64")] string Base64,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingEmailCodeResponse(
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("codeData")] JsonElement CodeData
	);

	public sealed record ManagingGetLetters2Params
	{
		[JsonPropertyName("email_password")]
		public string? EmailPassword { get; init; }
		[JsonPropertyName("email")]
		public string? Email { get; init; }
		[JsonPropertyName("password")]
		public string? Password { get; init; }
		[JsonPropertyName("limit")]
		public int? Limit { get; init; }
	}

	public sealed record ManagingGetLetters2Response(
		[property: JsonPropertyName("email")] string Email,
		[property: JsonPropertyName("letters")] List<JsonElement> Letters,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingSteamGetMafileResponse(
		[property: JsonPropertyName("maFile")] JsonElement MaFile,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingSteamAddMafileResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingSteamRemoveMafileResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingSteamMafileCodeResponse(
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("codeData")] JsonElement CodeData
	);

	public sealed record ManagingSteamSDABody
	{
		[JsonPropertyName("id")]
		public int? Id { get; init; }
		[JsonPropertyName("nonce")]
		public int? Nonce { get; init; }
	}

	public sealed record ManagingSteamSDAResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingTelegramCodeResponse(
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("codes")] JsonElement Codes
	);

	public sealed record ManagingTelegramResetAuthResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ManagingRefuseGuaranteeResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ManagingDeclineVideoRecordingBody
	{
		[JsonPropertyName("i_voluntarily_and_with_full_awareness_of_my_actions_waive_any_claims_regarding_this_item")]
		public required bool? IVoluntarilyAndWithFullAwarenessOfMyActionsWaiveAnyClaimsRegardingThisItem { get; init; }
	}

	public sealed record ManagingDeclineVideoRecordingResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ManagingCheckGuaranteeResponse(
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingChangePasswordBody
	{
		[JsonPropertyName("_cancel")]
		public string? Cancel { get; init; }
	}

	public sealed record ManagingChangePasswordResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("new_password")] string NewPassword
	);

	public sealed record ManagingTempEmailPasswordResponse(
		[property: JsonPropertyName("item")] JsonElement Item
	);

	public sealed record ManagingTagBody
	{
		[JsonPropertyName("tag_id")]
		public required int? TagId { get; init; }
	}

	public sealed record ManagingTagResponse(
		[property: JsonPropertyName("itemId")] long ItemId,
		[property: JsonPropertyName("tag")] JsonElement Tag,
		[property: JsonPropertyName("addedTagId")] long AddedTagId,
		[property: JsonPropertyName("deleteTags")] List<long> DeleteTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingUntagBody
	{
		[JsonPropertyName("tag_id")]
		public required int? TagId { get; init; }
	}

	public sealed record ManagingUntagResponse(
		[property: JsonPropertyName("itemId")] long ItemId,
		[property: JsonPropertyName("tag")] JsonElement Tag,
		[property: JsonPropertyName("addedTagId")] long AddedTagId,
		[property: JsonPropertyName("deleteTags")] List<long> DeleteTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingPublicTagBody
	{
		[JsonPropertyName("tag_id")]
		public required int? TagId { get; init; }
	}

	public sealed record ManagingPublicTagResponse(
		[property: JsonPropertyName("itemId")] long ItemId,
		[property: JsonPropertyName("tag")] JsonElement Tag,
		[property: JsonPropertyName("addedTagId")] long AddedTagId,
		[property: JsonPropertyName("deleteTags")] List<long> DeleteTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingPublicUntagBody
	{
		[JsonPropertyName("tag_id")]
		public required int? TagId { get; init; }
	}

	public sealed record ManagingPublicUntagResponse(
		[property: JsonPropertyName("itemId")] long ItemId,
		[property: JsonPropertyName("tag")] JsonElement Tag,
		[property: JsonPropertyName("addedTagId")] long AddedTagId,
		[property: JsonPropertyName("deleteTags")] List<long> DeleteTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingFavoriteResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingUnfavoriteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ManagingStickResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ManagingUnstickResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ManagingTransferBody
	{
		[JsonPropertyName("username")]
		public required string Username { get; init; }
		[JsonPropertyName("secret_answer")]
		public required string SecretAnswer { get; init; }
	}

	public sealed record ManagingTransferResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── ProfileApi Types ────────────────────────────────────────

public static class ProfileApiTypes
{
	public sealed record ProfileClaimsParams
	{
		[JsonPropertyName("type")]
		public string? Type { get; init; }
		[JsonPropertyName("claim_state")]
		public string? ClaimState { get; init; }
	}

	public sealed record ProfileClaimsResponse(
		[property: JsonPropertyName("claims")] List<JsonElement> Claims,
		[property: JsonPropertyName("stats")] JsonElement Stats,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfileGetParams
	{
		[JsonPropertyName("fields_include")]
		public JsonElement? FieldsInclude { get; init; }
	}

	public sealed record ProfileGetResponse(
		[property: JsonPropertyName("user")] UserModel User,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfileEditBody
	{
		[JsonPropertyName("user")]
		public JsonElement? User { get; init; }
		[JsonPropertyName("option")]
		public JsonElement? Option { get; init; }
		[JsonPropertyName("allow_accept_accounts")]
		public List<string>? AllowAcceptAccounts { get; init; }
		[JsonPropertyName("telegram_api_id")]
		public string? TelegramApiId { get; init; }
		[JsonPropertyName("telegram_api_hash")]
		public string? TelegramApiHash { get; init; }
		[JsonPropertyName("telegram_device_model")]
		public string? TelegramDeviceModel { get; init; }
		[JsonPropertyName("telegram_system_version")]
		public string? TelegramSystemVersion { get; init; }
		[JsonPropertyName("telegram_app_version")]
		public string? TelegramAppVersion { get; init; }
		[JsonPropertyName("telegram_lang_pack")]
		public string? TelegramLangPack { get; init; }
		[JsonPropertyName("telegram_lang_code")]
		public string? TelegramLangCode { get; init; }
		[JsonPropertyName("telegram_system_lang_code")]
		public string? TelegramSystemLangCode { get; init; }
		[JsonPropertyName("clear_telegram_client")]
		public bool? ClearTelegramClient { get; init; }
	}

	public sealed record ProfileEditResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── CartApi Types ────────────────────────────────────────

public static class CartApiTypes
{
	public sealed record CartGetParams
	{
		[JsonPropertyName("category_id")]
		public JsonElement? CategoryId { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public string? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<int?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<int?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<int?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<int?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public string? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
	}

	public sealed record CartGetResponse(
		[property: JsonPropertyName("items")] List<ItemFromListModel> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("stickyItems")] List<ItemFromListModel> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CartAddBody
	{
		[JsonPropertyName("item_id")]
		public required int? ItemId { get; init; }
	}

	public sealed record CartAddResponse(
		[property: JsonPropertyName("success")] bool Success,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CartDeleteBody
	{
		[JsonPropertyName("item_id")]
		public int? ItemId { get; init; }
	}

	public sealed record CartDeleteResponse(
		[property: JsonPropertyName("success")] bool Success,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);
}

// ─── PurchasingApi Types ────────────────────────────────────────

public static class PurchasingApiTypes
{
	public sealed record PurchasingFastBuyBody
	{
		[JsonPropertyName("price")]
		public double? Price { get; init; }
		[JsonPropertyName("balance_id")]
		public int? BalanceId { get; init; }
	}

	public sealed record PurchasingFastBuyResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("item")] JsonElement Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PurchasingCheckResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("item")] JsonElement Item,
		[property: JsonPropertyName("requireVideoRecording")] bool RequireVideoRecording,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PurchasingConfirmBody
	{
		[JsonPropertyName("price")]
		public int? Price { get; init; }
		[JsonPropertyName("balance_id")]
		public int? BalanceId { get; init; }
	}

	public sealed record PurchasingConfirmResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("item")] JsonElement Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PurchasingDiscountRequestBody
	{
		[JsonPropertyName("discount_price")]
		public required double? DiscountPrice { get; init; }
		[JsonPropertyName("message")]
		public string? Message { get; init; }
	}

	public sealed record PurchasingDiscountRequestResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record PurchasingDiscountCancelResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── CustomDiscountsApi Types ────────────────────────────────────────

public static class CustomDiscountsApiTypes
{
	public sealed record CustomDiscountsGetResponse(
		[property: JsonPropertyName("discounts")] List<DiscountModel> Discounts,
		[property: JsonPropertyName("total")] long Total,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CustomDiscountsCreateBody
	{
		[JsonPropertyName("user_id")]
		public required int? UserId { get; init; }
		[JsonPropertyName("category_id")]
		public required JsonElement CategoryId { get; init; }
		[JsonPropertyName("discount_percent")]
		public required double? DiscountPercent { get; init; }
		[JsonPropertyName("min_price")]
		public required double? MinPrice { get; init; }
		[JsonPropertyName("max_price")]
		public double? MaxPrice { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
	}

	public sealed record CustomDiscountsCreateResponse(
		[property: JsonPropertyName("discount")] DiscountModel Discount,
		[property: JsonPropertyName("total")] long Total,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CustomDiscountsEditBody
	{
		[JsonPropertyName("discount_id")]
		public required int? DiscountId { get; init; }
		[JsonPropertyName("discount_percent")]
		public double? DiscountPercent { get; init; }
		[JsonPropertyName("min_price")]
		public double? MinPrice { get; init; }
		[JsonPropertyName("max_price")]
		public double? MaxPrice { get; init; }
	}

	public sealed record CustomDiscountsEditResponse(
		[property: JsonPropertyName("discounts")] List<DiscountModel> Discounts,
		[property: JsonPropertyName("total")] long Total,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CustomDiscountsDeleteBody
	{
		[JsonPropertyName("discount_id")]
		public required int? DiscountId { get; init; }
	}

	public sealed record CustomDiscountsDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── PublishingApi Types ────────────────────────────────────────

public static class PublishingApiTypes
{
	public sealed record PublishingFastSellBody
	{
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("title_en")]
		public string? TitleEn { get; init; }
		[JsonPropertyName("price")]
		public required double? Price { get; init; }
		[JsonPropertyName("category_id")]
		public required JsonElement CategoryId { get; init; }
		[JsonPropertyName("currency")]
		public required string Currency { get; init; }
		[JsonPropertyName("item_origin")]
		public required string ItemOrigin { get; init; }
		[JsonPropertyName("extended_guarantee")]
		public JsonElement? ExtendedGuarantee { get; init; }
		[JsonPropertyName("allow_ask_discount")]
		public bool? AllowAskDiscount { get; init; }
		[JsonPropertyName("proxy_id")]
		public int? ProxyId { get; init; }
		[JsonPropertyName("random_proxy")]
		public bool? RandomProxy { get; init; }
		[JsonPropertyName("description")]
		public string? Description { get; init; }
		[JsonPropertyName("information")]
		public string? Information { get; init; }
		[JsonPropertyName("login")]
		public string? Login { get; init; }
		[JsonPropertyName("password")]
		public string? Password { get; init; }
		[JsonPropertyName("login_password")]
		public string? LoginPassword { get; init; }
		[JsonPropertyName("has_email_login_data")]
		public bool? HasEmailLoginData { get; init; }
		[JsonPropertyName("email_login_data")]
		public string? EmailLoginData { get; init; }
		[JsonPropertyName("email_type")]
		public string? EmailType { get; init; }
		[JsonPropertyName("extra")]
		public JsonElement? Extra { get; init; }
	}

	public sealed record PublishingFastSellResponse(
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("itemLink")] string ItemLink,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PublishingAddBody
	{
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("title_en")]
		public string? TitleEn { get; init; }
		[JsonPropertyName("price")]
		public required double? Price { get; init; }
		[JsonPropertyName("category_id")]
		public required JsonElement CategoryId { get; init; }
		[JsonPropertyName("currency")]
		public required string Currency { get; init; }
		[JsonPropertyName("item_origin")]
		public required string ItemOrigin { get; init; }
		[JsonPropertyName("extended_guarantee")]
		public JsonElement? ExtendedGuarantee { get; init; }
		[JsonPropertyName("description")]
		public string? Description { get; init; }
		[JsonPropertyName("information")]
		public string? Information { get; init; }
		[JsonPropertyName("forceTempEmail")]
		public bool? ForceTempEmail { get; init; }
		[JsonPropertyName("resell_item_id")]
		public int? ResellItemId { get; init; }
		[JsonPropertyName("has_email_login_data")]
		public bool? HasEmailLoginData { get; init; }
		[JsonPropertyName("email_login_data")]
		public string? EmailLoginData { get; init; }
		[JsonPropertyName("email_type")]
		public string? EmailType { get; init; }
		[JsonPropertyName("allow_ask_discount")]
		public bool? AllowAskDiscount { get; init; }
		[JsonPropertyName("proxy_id")]
		public int? ProxyId { get; init; }
		[JsonPropertyName("random_proxy")]
		public bool? RandomProxy { get; init; }
	}

	public sealed record PublishingAddResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PublishingCheckBody
	{
		[JsonPropertyName("resell_item_id")]
		public int? ResellItemId { get; init; }
		[JsonPropertyName("random_proxy")]
		public bool? RandomProxy { get; init; }
		[JsonPropertyName("login")]
		public string? Login { get; init; }
		[JsonPropertyName("password")]
		public string? Password { get; init; }
		[JsonPropertyName("login_password")]
		public string? LoginPassword { get; init; }
		[JsonPropertyName("has_email_login_data")]
		public bool? HasEmailLoginData { get; init; }
		[JsonPropertyName("email_login_data")]
		public string? EmailLoginData { get; init; }
		[JsonPropertyName("email_type")]
		public string? EmailType { get; init; }
		[JsonPropertyName("extra")]
		public JsonElement? Extra { get; init; }
	}

	public sealed record PublishingCheckResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("item")] JsonElement Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PublishingExternalBody
	{
		[JsonPropertyName("type")]
		public required string Type { get; init; }
		[JsonPropertyName("login")]
		public string? Login { get; init; }
		[JsonPropertyName("email_login_data")]
		public string? EmailLoginData { get; init; }
		[JsonPropertyName("cookies")]
		public string? Cookies { get; init; }
	}

	public sealed record PublishingExternalResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── PaymentsApi Types ────────────────────────────────────────

public static class PaymentsApiTypes
{
	public sealed record PaymentsInvoiceGetParams
	{
		[JsonPropertyName("invoice_id")]
		public int? InvoiceId { get; init; }
		[JsonPropertyName("payment_id")]
		public string? PaymentId { get; init; }
	}

	public sealed record PaymentsInvoiceGetResponse(
		[property: JsonPropertyName("invoice")] InvoiceModel Invoice,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsInvoiceCreateBody
	{
		[JsonPropertyName("currency")]
		public required string Currency { get; init; }
		[JsonPropertyName("amount")]
		public required double? Amount { get; init; }
		[JsonPropertyName("payment_id")]
		public required string PaymentId { get; init; }
		[JsonPropertyName("comment")]
		public required string Comment { get; init; }
		[JsonPropertyName("url_success")]
		public required string UrlSuccess { get; init; }
		[JsonPropertyName("url_callback")]
		public string? UrlCallback { get; init; }
		[JsonPropertyName("merchant_id")]
		public required int? MerchantId { get; init; }
		[JsonPropertyName("required_telegram_id")]
		public int? RequiredTelegramId { get; init; }
		[JsonPropertyName("required_telegram_username")]
		public string? RequiredTelegramUsername { get; init; }
		[JsonPropertyName("lifetime")]
		public double? Lifetime { get; init; }
		[JsonPropertyName("additional_data")]
		public string? AdditionalData { get; init; }
		[JsonPropertyName("is_test")]
		public bool? IsTest { get; init; }
	}

	public sealed record PaymentsInvoiceCreateResponse(
		[property: JsonPropertyName("invoice")] InvoiceModel Invoice,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsInvoiceListParams
	{
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("status")]
		public string? Status { get; init; }
		[JsonPropertyName("amount")]
		public double? Amount { get; init; }
		[JsonPropertyName("merchant_id")]
		public int? MerchantId { get; init; }
	}

	public sealed record PaymentsInvoiceListResponse(
		[property: JsonPropertyName("invoices")] List<InvoiceModel> Invoices,
		[property: JsonPropertyName("count")] long Count,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsCurrencyResponse(
		[property: JsonPropertyName("currencyList")] JsonElement CurrencyList,
		[property: JsonPropertyName("lastUpdate")] long LastUpdate,
		[property: JsonPropertyName("visitorCurrency")] string VisitorCurrency,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsBalanceListResponse(
		[property: JsonPropertyName("from")] JsonElement From,
		[property: JsonPropertyName("to")] JsonElement To,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsBalanceExchangeBody
	{
		[JsonPropertyName("from_balance")]
		public required string FromBalance { get; init; }
		[JsonPropertyName("to_balance")]
		public required string ToBalance { get; init; }
		[JsonPropertyName("amount")]
		public required int? Amount { get; init; }
	}

	public sealed record PaymentsBalanceExchangeResponse(
		[property: JsonPropertyName("from")] JsonElement From,
		[property: JsonPropertyName("to")] JsonElement To,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsTransferBody
	{
		[JsonPropertyName("user_id")]
		public int? UserId { get; init; }
		[JsonPropertyName("username")]
		public string? Username { get; init; }
		[JsonPropertyName("amount")]
		public required int? Amount { get; init; }
		[JsonPropertyName("currency")]
		public required string Currency { get; init; }
		[JsonPropertyName("comment")]
		public string? Comment { get; init; }
		[JsonPropertyName("telegram_deal")]
		public bool? TelegramDeal { get; init; }
		[JsonPropertyName("telegram_username")]
		public string? TelegramUsername { get; init; }
		[JsonPropertyName("transfer_hold")]
		public bool? TransferHold { get; init; }
		[JsonPropertyName("hold_length_value")]
		public int? HoldLengthValue { get; init; }
		[JsonPropertyName("hold_length_option")]
		public string? HoldLengthOption { get; init; }
	}

	public sealed record PaymentsTransferResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsFeeParams
	{
		[JsonPropertyName("amount")]
		public double? Amount { get; init; }
	}

	public sealed record PaymentsFeeResponse(
		[property: JsonPropertyName("commission_percentage")] long CommissionPercentage,
		[property: JsonPropertyName("spentCurrentMonth")] long SpentCurrentMonth,
		[property: JsonPropertyName("calculator")] JsonElement Calculator,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsCancelBody
	{
		[JsonPropertyName("payment_id")]
		public required int? PaymentId { get; init; }
	}

	public sealed record PaymentsCancelResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsHistoryParams
	{
		[JsonPropertyName("type")]
		public string? Type { get; init; }
		[JsonPropertyName("pmin")]
		public int? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public int? Pmax { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("page")]
		public int? Page { get; init; }
		[JsonPropertyName("operation_id_lt")]
		public int? OperationIdLt { get; init; }
		[JsonPropertyName("receiver")]
		public string? Receiver { get; init; }
		[JsonPropertyName("sender")]
		public string? Sender { get; init; }
		[JsonPropertyName("is_api")]
		public bool? IsApi { get; init; }
		[JsonPropertyName("startDate")]
		public string? StartDate { get; init; }
		[JsonPropertyName("endDate")]
		public string? EndDate { get; init; }
		[JsonPropertyName("wallet")]
		public string? Wallet { get; init; }
		[JsonPropertyName("comment")]
		public string? Comment { get; init; }
		[JsonPropertyName("is_hold")]
		public bool? IsHold { get; init; }
		[JsonPropertyName("show_payment_stats")]
		public bool? ShowPaymentStats { get; init; }
	}

	public sealed record PaymentsHistoryResponse(
		[property: JsonPropertyName("payments")] JsonElement Payments,
		[property: JsonPropertyName("perPage")] string PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("pageNavLink")] string PageNavLink,
		[property: JsonPropertyName("pageNavParams")] JsonElement PageNavParams,
		[property: JsonPropertyName("periodLabel")] string PeriodLabel,
		[property: JsonPropertyName("periodLabelPhrase")] string PeriodLabelPhrase,
		[property: JsonPropertyName("filterDatesDefault")] bool FilterDatesDefault,
		[property: JsonPropertyName("input")] JsonElement Input,
		[property: JsonPropertyName("paymentStats")] JsonElement PaymentStats,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("lastOperationId")] long LastOperationId,
		[property: JsonPropertyName("nextPageHref")] string NextPageHref,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsPayoutServicesResponse(
		[property: JsonPropertyName("systems")] List<JsonElement> Systems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsPayoutBody
	{
		[JsonPropertyName("payment_system")]
		public required string PaymentSystem { get; init; }
		[JsonPropertyName("wallet")]
		public required string Wallet { get; init; }
		[JsonPropertyName("amount")]
		public required double? Amount { get; init; }
		[JsonPropertyName("currency")]
		public required string Currency { get; init; }
		[JsonPropertyName("include_fee")]
		public bool? IncludeFee { get; init; }
		[JsonPropertyName("extra")]
		public JsonElement? Extra { get; init; }
	}

	public sealed record PaymentsPayoutResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── AutoPaymentsApi Types ────────────────────────────────────────

public static class AutoPaymentsApiTypes
{
	public sealed record AutoPaymentsListResponse(
		[property: JsonPropertyName("payments")] JsonElement Payments,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record AutoPaymentsCreateBody
	{
		[JsonPropertyName("secret_answer")]
		public string? SecretAnswer { get; init; }
		[JsonPropertyName("username_receiver")]
		public required string UsernameReceiver { get; init; }
		[JsonPropertyName("day")]
		public required JsonElement Day { get; init; }
		[JsonPropertyName("amount")]
		public required double? Amount { get; init; }
		[JsonPropertyName("currency")]
		public string? Currency { get; init; }
		[JsonPropertyName("description")]
		public string? Description { get; init; }
	}

	public sealed record AutoPaymentsCreateResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("auto_payment_id")] long AutoPaymentId,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record AutoPaymentsDeleteBody
	{
		[JsonPropertyName("auto_payment_id")]
		public required int? AutoPaymentId { get; init; }
	}

	public sealed record AutoPaymentsDeleteResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);
}

// ─── ProxyApi Types ────────────────────────────────────────

public static class ProxyApiTypes
{
	public sealed record ProxyGetResponse(
		[property: JsonPropertyName("proxies")] List<JsonElement> Proxies,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProxyAddBody
	{
		[JsonPropertyName("proxy_ip")]
		public string? ProxyIp { get; init; }
		[JsonPropertyName("proxy_port")]
		public int? ProxyPort { get; init; }
		[JsonPropertyName("proxy_user")]
		public string? ProxyUser { get; init; }
		[JsonPropertyName("proxy_pass")]
		public string? ProxyPass { get; init; }
		[JsonPropertyName("proxy_row")]
		public string? ProxyRow { get; init; }
	}

	public sealed record ProxyAddResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ProxyDeleteBody
	{
		[JsonPropertyName("proxy_id")]
		public int? ProxyId { get; init; }
		[JsonPropertyName("delete_all")]
		public bool? DeleteAll { get; init; }
	}

	public sealed record ProxyDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── ImapApi Types ────────────────────────────────────────

public static class ImapApiTypes
{
	public sealed record ImapCreateBody
	{
		[JsonPropertyName("domain")]
		public required string Domain { get; init; }
		[JsonPropertyName("imap_server")]
		public required string ImapServer { get; init; }
		[JsonPropertyName("port")]
		public required int? Port { get; init; }
		[JsonPropertyName("secure")]
		public required bool? Secure { get; init; }
	}

	public sealed record ImapCreateResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ImapDeleteBody
	{
		[JsonPropertyName("domain")]
		public required string Domain { get; init; }
	}

	public sealed record ImapDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── BatchApi Types ────────────────────────────────────────

public static class BatchApiTypes
{
	public sealed record BatchBatchResponse(
		[property: JsonPropertyName("jobs")] JsonElement Jobs,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

