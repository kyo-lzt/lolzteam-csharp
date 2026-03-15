// Auto-generated. Do not edit manually.

using System.Text.Json.Serialization;
using System.Text.Json;

namespace Lolzteam.Api.Generated.Forum;

// ─── Enums ────────────────────────────────────────────────────

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<AllowInviteGroup>))]
public enum AllowInviteGroup
{
	[Lolzteam.Api.Runtime.EnumValue("none")] None,
	[Lolzteam.Api.Runtime.EnumValue("members")] Members,
	[Lolzteam.Api.Runtime.EnumValue("followed")] Followed,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<AllowPostProfile>))]
public enum AllowPostProfile
{
	[Lolzteam.Api.Runtime.EnumValue("none")] None,
	[Lolzteam.Api.Runtime.EnumValue("members")] Members,
	[Lolzteam.Api.Runtime.EnumValue("followed")] Followed,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<AllowReceiveNewsFeed>))]
public enum AllowReceiveNewsFeed
{
	[Lolzteam.Api.Runtime.EnumValue("none")] None,
	[Lolzteam.Api.Runtime.EnumValue("members")] Members,
	[Lolzteam.Api.Runtime.EnumValue("followed")] Followed,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<AllowSendPersonalConversation>))]
public enum AllowSendPersonalConversation
{
	[Lolzteam.Api.Runtime.EnumValue("none")] None,
	[Lolzteam.Api.Runtime.EnumValue("members")] Members,
	[Lolzteam.Api.Runtime.EnumValue("followed")] Followed,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<AllowViewProfile>))]
public enum AllowViewProfile
{
	[Lolzteam.Api.Runtime.EnumValue("none")] None,
	[Lolzteam.Api.Runtime.EnumValue("members")] Members,
	[Lolzteam.Api.Runtime.EnumValue("followed")] Followed,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<CategoriesOrder>))]
public enum CategoriesOrder
{
	[Lolzteam.Api.Runtime.EnumValue("natural")] Natural,
	[Lolzteam.Api.Runtime.EnumValue("list")] List,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ClaimState>))]
public enum ClaimState
{
	[Lolzteam.Api.Runtime.EnumValue("active")] Active,
	[Lolzteam.Api.Runtime.EnumValue("solved")] Solved,
	[Lolzteam.Api.Runtime.EnumValue("rejected")] Rejected,
	[Lolzteam.Api.Runtime.EnumValue("settled")] Settled,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ContentType>))]
public enum ContentType
{
	[Lolzteam.Api.Runtime.EnumValue("post")] Post,
	[Lolzteam.Api.Runtime.EnumValue("post_comment")] PostComment,
	[Lolzteam.Api.Runtime.EnumValue("profile_post")] ProfilePost,
	[Lolzteam.Api.Runtime.EnumValue("profile_post_comment")] ProfilePostComment,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ContestType>))]
public enum ContestType
{
	[Lolzteam.Api.Runtime.EnumValue("by_finish_date")] ByFinishDate,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ConversationsOrder>))]
public enum ConversationsOrder
{
	[Lolzteam.Api.Runtime.EnumValue("natural")] Natural,
	[Lolzteam.Api.Runtime.EnumValue("natural_reverse")] NaturalReverse,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Currency>))]
public enum Currency
{
	[Lolzteam.Api.Runtime.EnumValue("rub")] Rub,
	[Lolzteam.Api.Runtime.EnumValue("uah")] Uah,
	[Lolzteam.Api.Runtime.EnumValue("kzt")] Kzt,
	[Lolzteam.Api.Runtime.EnumValue("byn")] Byn,
	[Lolzteam.Api.Runtime.EnumValue("usd")] Usd,
	[Lolzteam.Api.Runtime.EnumValue("eur")] Eur,
	[Lolzteam.Api.Runtime.EnumValue("gbp")] Gbp,
	[Lolzteam.Api.Runtime.EnumValue("cny")] Cny,
	[Lolzteam.Api.Runtime.EnumValue("try")] Try,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<DeleteType>))]
public enum DeleteType
{
	[Lolzteam.Api.Runtime.EnumValue("delete")] Delete,
	[Lolzteam.Api.Runtime.EnumValue("delete_ignore")] DeleteIgnore,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Direction>))]
public enum Direction
{
	[Lolzteam.Api.Runtime.EnumValue("asc")] Asc,
	[Lolzteam.Api.Runtime.EnumValue("desc")] Desc,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Duration>))]
public enum Duration
{
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("week")] Week,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Folder>))]
public enum Folder
{
	[Lolzteam.Api.Runtime.EnumValue("all")] All,
	[Lolzteam.Api.Runtime.EnumValue("unread")] Unread,
	[Lolzteam.Api.Runtime.EnumValue("groups")] Groups,
	[Lolzteam.Api.Runtime.EnumValue("market")] Market,
	[Lolzteam.Api.Runtime.EnumValue("market_replacements")] MarketReplacements,
	[Lolzteam.Api.Runtime.EnumValue("staff")] Staff,
	[Lolzteam.Api.Runtime.EnumValue("giveaways")] Giveaways,
	[Lolzteam.Api.Runtime.EnumValue("p2p")] P2p,
}

public enum FormId : long
{
	V1 = 1,
	V3 = 3,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Gender>))]
public enum Gender
{
	[Lolzteam.Api.Runtime.EnumValue("")] None,
	[Lolzteam.Api.Runtime.EnumValue("male")] Male,
	[Lolzteam.Api.Runtime.EnumValue("female")] Female,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<GrantType>))]
public enum GrantType
{
	[Lolzteam.Api.Runtime.EnumValue("client_credentials")] ClientCredentials,
	[Lolzteam.Api.Runtime.EnumValue("authorization_code")] AuthorizationCode,
	[Lolzteam.Api.Runtime.EnumValue("refresh_token")] RefreshToken,
	[Lolzteam.Api.Runtime.EnumValue("password")] Password,
}

public enum LanguageId : long
{
	V1 = 1,
	V2 = 2,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<LengthOption>))]
public enum LengthOption
{
	[Lolzteam.Api.Runtime.EnumValue("minutes")] Minutes,
	[Lolzteam.Api.Runtime.EnumValue("hours")] Hours,
	[Lolzteam.Api.Runtime.EnumValue("days")] Days,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<LikeType>))]
public enum LikeType
{
	[Lolzteam.Api.Runtime.EnumValue("like")] Like,
	[Lolzteam.Api.Runtime.EnumValue("like2")] Like2,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<NotificationsType>))]
public enum NotificationsType
{
	[Lolzteam.Api.Runtime.EnumValue("market")] Market,
	[Lolzteam.Api.Runtime.EnumValue("nomarket")] Nomarket,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<PayClaim>))]
public enum PayClaim
{
	[Lolzteam.Api.Runtime.EnumValue("now")] Now,
	[Lolzteam.Api.Runtime.EnumValue("later")] Later,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Period>))]
public enum Period
{
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("week")] Week,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
	[Lolzteam.Api.Runtime.EnumValue("year")] Year,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<PostsOrder>))]
public enum PostsOrder
{
	[Lolzteam.Api.Runtime.EnumValue("natural")] Natural,
	[Lolzteam.Api.Runtime.EnumValue("natural_reverse")] NaturalReverse,
	[Lolzteam.Api.Runtime.EnumValue("post_likes")] PostLikes,
	[Lolzteam.Api.Runtime.EnumValue("post_likes_reverse")] PostLikesReverse,
}

public enum PrizeDataUpgrade : long
{
	V1 = 1,
	V6 = 6,
	V12 = 12,
	V14 = 14,
	V17 = 17,
	V19 = 19,
	V20 = 20,
	V21 = 21,
	V22 = 22,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<PrizeType>))]
public enum PrizeType
{
	[Lolzteam.Api.Runtime.EnumValue("money")] Money,
	[Lolzteam.Api.Runtime.EnumValue("upgrades")] Upgrades,
}

public enum ReplyGroup : long
{
	V0 = 0,
	V2 = 2,
	V21 = 21,
	V22 = 22,
	V23 = 23,
	V60 = 60,
	V351 = 351,
}

public enum RoomId : long
{
	V1 = 1,
	V2 = 2,
	V3 = 3,
	V4 = 4,
	V13 = 13,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<State>))]
public enum State
{
	[Lolzteam.Api.Runtime.EnumValue("active")] Active,
	[Lolzteam.Api.Runtime.EnumValue("closed")] Closed,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ThreadsOrder>))]
public enum ThreadsOrder
{
	[Lolzteam.Api.Runtime.EnumValue("post_date")] PostDate,
	[Lolzteam.Api.Runtime.EnumValue("last_post_date")] LastPostDate,
	[Lolzteam.Api.Runtime.EnumValue("reply_count")] ReplyCount,
	[Lolzteam.Api.Runtime.EnumValue("reply_count_asc")] ReplyCountAsc,
	[Lolzteam.Api.Runtime.EnumValue("first_post_likes")] FirstPostLikes,
	[Lolzteam.Api.Runtime.EnumValue("vote_count")] VoteCount,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Timezone>))]
public enum Timezone
{
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Midway")] PacificMidway,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Honolulu")] PacificHonolulu,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Marquesas")] PacificMarquesas,
	[Lolzteam.Api.Runtime.EnumValue("America/Anchorage")] AmericaAnchorage,
	[Lolzteam.Api.Runtime.EnumValue("America/Los_Angeles")] AmericaLosAngeles,
	[Lolzteam.Api.Runtime.EnumValue("America/Santa_Isabel")] AmericaSantaIsabel,
	[Lolzteam.Api.Runtime.EnumValue("America/Tijuana")] AmericaTijuana,
	[Lolzteam.Api.Runtime.EnumValue("America/Denver")] AmericaDenver,
	[Lolzteam.Api.Runtime.EnumValue("America/Chihuahua")] AmericaChihuahua,
	[Lolzteam.Api.Runtime.EnumValue("America/Phoenix")] AmericaPhoenix,
	[Lolzteam.Api.Runtime.EnumValue("America/Chicago")] AmericaChicago,
	[Lolzteam.Api.Runtime.EnumValue("America/Belize")] AmericaBelize,
	[Lolzteam.Api.Runtime.EnumValue("America/Mexico_City")] AmericaMexicoCity,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Easter")] PacificEaster,
	[Lolzteam.Api.Runtime.EnumValue("America/New_York")] AmericaNewYork,
	[Lolzteam.Api.Runtime.EnumValue("America/Havana")] AmericaHavana,
	[Lolzteam.Api.Runtime.EnumValue("America/Bogota")] AmericaBogota,
	[Lolzteam.Api.Runtime.EnumValue("America/Caracas")] AmericaCaracas,
	[Lolzteam.Api.Runtime.EnumValue("America/Halifax")] AmericaHalifax,
	[Lolzteam.Api.Runtime.EnumValue("America/Goose_Bay")] AmericaGooseBay,
	[Lolzteam.Api.Runtime.EnumValue("America/Asuncion")] AmericaAsuncion,
	[Lolzteam.Api.Runtime.EnumValue("America/Santiago")] AmericaSantiago,
	[Lolzteam.Api.Runtime.EnumValue("America/Cuiaba")] AmericaCuiaba,
	[Lolzteam.Api.Runtime.EnumValue("America/La_Paz")] AmericaLaPaz,
	[Lolzteam.Api.Runtime.EnumValue("America/St_Johns")] AmericaStJohns,
	[Lolzteam.Api.Runtime.EnumValue("America/Argentina/Buenos_Aires")] AmericaArgentinaBuenosAires,
	[Lolzteam.Api.Runtime.EnumValue("America/Argentina/San_Luis")] AmericaArgentinaSanLuis,
	[Lolzteam.Api.Runtime.EnumValue("America/Argentina/Mendoza")] AmericaArgentinaMendoza,
	[Lolzteam.Api.Runtime.EnumValue("Atlantic/Stanley")] AtlanticStanley,
	[Lolzteam.Api.Runtime.EnumValue("America/Godthab")] AmericaGodthab,
	[Lolzteam.Api.Runtime.EnumValue("America/Montevideo")] AmericaMontevideo,
	[Lolzteam.Api.Runtime.EnumValue("America/Sao_Paulo")] AmericaSaoPaulo,
	[Lolzteam.Api.Runtime.EnumValue("America/Miquelon")] AmericaMiquelon,
	[Lolzteam.Api.Runtime.EnumValue("America/Noronha")] AmericaNoronha,
	[Lolzteam.Api.Runtime.EnumValue("Atlantic/Cape_Verde")] AtlanticCapeVerde,
	[Lolzteam.Api.Runtime.EnumValue("Atlantic/Azores")] AtlanticAzores,
	[Lolzteam.Api.Runtime.EnumValue("Europe/London")] EuropeLondon,
	[Lolzteam.Api.Runtime.EnumValue("Africa/Casablanca")] AfricaCasablanca,
	[Lolzteam.Api.Runtime.EnumValue("Atlantic/Reykjavik")] AtlanticReykjavik,
	[Lolzteam.Api.Runtime.EnumValue("Europe/Amsterdam")] EuropeAmsterdam,
	[Lolzteam.Api.Runtime.EnumValue("Africa/Algiers")] AfricaAlgiers,
	[Lolzteam.Api.Runtime.EnumValue("Africa/Windhoek")] AfricaWindhoek,
	[Lolzteam.Api.Runtime.EnumValue("Africa/Tunis")] AfricaTunis,
	[Lolzteam.Api.Runtime.EnumValue("Europe/Athens")] EuropeAthens,
	[Lolzteam.Api.Runtime.EnumValue("Africa/Johannesburg")] AfricaJohannesburg,
	[Lolzteam.Api.Runtime.EnumValue("Europe/Kaliningrad")] EuropeKaliningrad,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Amman")] AsiaAmman,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Beirut")] AsiaBeirut,
	[Lolzteam.Api.Runtime.EnumValue("Africa/Cairo")] AfricaCairo,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Jerusalem")] AsiaJerusalem,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Gaza")] AsiaGaza,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Damascus")] AsiaDamascus,
	[Lolzteam.Api.Runtime.EnumValue("Europe/Moscow")] EuropeMoscow,
	[Lolzteam.Api.Runtime.EnumValue("Europe/Minsk")] EuropeMinsk,
	[Lolzteam.Api.Runtime.EnumValue("Africa/Nairobi")] AfricaNairobi,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Tehran")] AsiaTehran,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Dubai")] AsiaDubai,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Yerevan")] AsiaYerevan,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Baku")] AsiaBaku,
	[Lolzteam.Api.Runtime.EnumValue("Indian/Mauritius")] IndianMauritius,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Kabul")] AsiaKabul,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Yekaterinburg")] AsiaYekaterinburg,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Tashkent")] AsiaTashkent,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Kolkata")] AsiaKolkata,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Kathmandu")] AsiaKathmandu,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Novosibirsk")] AsiaNovosibirsk,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Dhaka")] AsiaDhaka,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Almaty")] AsiaAlmaty,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Rangoon")] AsiaRangoon,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Krasnoyarsk")] AsiaKrasnoyarsk,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Bangkok")] AsiaBangkok,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Irkutsk")] AsiaIrkutsk,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Hong_Kong")] AsiaHongKong,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Singapore")] AsiaSingapore,
	[Lolzteam.Api.Runtime.EnumValue("Australia/Perth")] AustraliaPerth,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Yakutsk")] AsiaYakutsk,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Tokyo")] AsiaTokyo,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Seoul")] AsiaSeoul,
	[Lolzteam.Api.Runtime.EnumValue("Australia/Adelaide")] AustraliaAdelaide,
	[Lolzteam.Api.Runtime.EnumValue("Australia/Darwin")] AustraliaDarwin,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Vladivostok")] AsiaVladivostok,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Magadan")] AsiaMagadan,
	[Lolzteam.Api.Runtime.EnumValue("Australia/Brisbane")] AustraliaBrisbane,
	[Lolzteam.Api.Runtime.EnumValue("Australia/Sydney")] AustraliaSydney,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Noumea")] PacificNoumea,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Norfolk")] PacificNorfolk,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Anadyr")] AsiaAnadyr,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Auckland")] PacificAuckland,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Fiji")] PacificFiji,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Chatham")] PacificChatham,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Tongatapu")] PacificTongatapu,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Apia")] PacificApia,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Kiritimati")] PacificKiritimati,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<TransferType>))]
public enum TransferType
{
	[Lolzteam.Api.Runtime.EnumValue("guarantor")] Guarantor,
	[Lolzteam.Api.Runtime.EnumValue("safe")] Safe,
	[Lolzteam.Api.Runtime.EnumValue("notsafe")] Notsafe,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<UsersOrder>))]
public enum UsersOrder
{
	[Lolzteam.Api.Runtime.EnumValue("natural")] Natural,
	[Lolzteam.Api.Runtime.EnumValue("follow_date")] FollowDate,
	[Lolzteam.Api.Runtime.EnumValue("follow_date_reverse")] FollowDateReverse,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<UsersType>))]
public enum UsersType
{
	[Lolzteam.Api.Runtime.EnumValue("gotten")] Gotten,
	[Lolzteam.Api.Runtime.EnumValue("given")] Given,
}

// ─── Component Schemas ────────────────────────────────────────

public sealed record Resp_ChatboxMessageModel(
	[property: JsonPropertyName("can_report")] bool CanReport,
	[property: JsonPropertyName("date")] long Date,
	[property: JsonPropertyName("is_deleted")] bool IsDeleted,
	[property: JsonPropertyName("message")] string Message,
	[property: JsonPropertyName("message_id")] long MessageId,
	[property: JsonPropertyName("messageJson")] string MessageJson,
	[property: JsonPropertyName("messageRaw")] string MessageRaw,
	[property: JsonPropertyName("room")] Resp_ChatboxMessageModelRoom Room,
	[property: JsonPropertyName("user")] Resp_ChatboxMessageModelUser User
);

public sealed record Resp_ChatboxMessageModelRoom(
	[property: JsonPropertyName("can_report")] bool CanReport,
	[property: JsonPropertyName("eng")] bool Eng,
	[property: JsonPropertyName("market")] bool Market,
	[property: JsonPropertyName("room_id")] long RoomId,
	[property: JsonPropertyName("title")] string Title
);

public sealed record Resp_ChatboxMessageModelUserRenderedAvatars(
	[property: JsonPropertyName("l")] string L,
	[property: JsonPropertyName("m")] string M,
	[property: JsonPropertyName("s")] string S
);

public sealed record Resp_ChatboxMessageModelUserRendered(
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatars")] Resp_ChatboxMessageModelUserRenderedAvatars Avatars,
	[property: JsonPropertyName("link")] string Link
);

public sealed record Resp_ChatboxMessageModelUserUniqBanner(
	[property: JsonPropertyName("banner_css")] string BannerCss,
	[property: JsonPropertyName("banner_text")] string BannerText,
	[property: JsonPropertyName("banner_icon")] string BannerIcon,
	[property: JsonPropertyName("username_icon")] string UsernameIcon
);

public sealed record Resp_ChatboxMessageModelUser(
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("background_date")] long BackgroundDate,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("custom_title")] string CustomTitle,
	[property: JsonPropertyName("display_banner_id")] long DisplayBannerId,
	[property: JsonPropertyName("display_icon_group_id")] long DisplayIconGroupId,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("is_admin")] bool IsAdmin,
	[property: JsonPropertyName("is_banned")] bool IsBanned,
	[property: JsonPropertyName("is_moderator")] bool IsModerator,
	[property: JsonPropertyName("is_staff")] bool IsStaff,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("like2_count")] long Like2Count,
	[property: JsonPropertyName("like_count")] long LikeCount,
	[property: JsonPropertyName("message_count")] long MessageCount,
	[property: JsonPropertyName("register_date")] long RegisterDate,
	[property: JsonPropertyName("rendered")] Resp_ChatboxMessageModelUserRendered Rendered,
	[property: JsonPropertyName("short_link")] string ShortLink,
	[property: JsonPropertyName("trophy_points")] long TrophyPoints,
	[property: JsonPropertyName("uniq_banner")] Resp_ChatboxMessageModelUserUniqBanner UniqBanner,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username
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
	[property: JsonPropertyName("links")] Resp_ConversationMessageModelLinks Links,
	[property: JsonPropertyName("permissions")] Resp_ConversationMessageModelPermissions Permissions
);

public sealed record Resp_ConversationMessageModelLinks(
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("conversation")] string Conversation,
	[property: JsonPropertyName("creator")] string Creator,
	[property: JsonPropertyName("creator_avatar")] string CreatorAvatar
);

public sealed record Resp_ConversationMessageModelPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("stick-unstick")] bool StickUnstick
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
	[property: JsonPropertyName("permissions")] Resp_ConversationModelPermissions Permissions,
	[property: JsonPropertyName("conversation_message_count")] long ConversationMessageCount,
	[property: JsonPropertyName("conversation_is_new")] bool ConversationIsNew,
	[property: JsonPropertyName("creator_is_ignored")] bool CreatorIsIgnored,
	[property: JsonPropertyName("conversation_is_open")] bool ConversationIsOpen,
	[property: JsonPropertyName("conversation_is_deleted")] bool ConversationIsDeleted,
	[property: JsonPropertyName("recipient")] Resp_ConversationModelRecipient Recipient,
	[property: JsonPropertyName("recipients")] List<Resp_ConversationModelRecipients> Recipients,
	[property: JsonPropertyName("links")] Resp_ConversationModelLinks Links
);

public sealed record Resp_ConversationModelPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("invite")] bool Invite,
	[property: JsonPropertyName("manage_invite_links")] bool ManageInviteLinks,
	[property: JsonPropertyName("kick")] bool Kick,
	[property: JsonPropertyName("upload_avatar")] bool UploadAvatar,
	[property: JsonPropertyName("editOwnPost")] bool EditOwnPost,
	[property: JsonPropertyName("stickyMessages")] bool StickyMessages
);

public sealed record Resp_ConversationModelRecipient(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("username_html")] string UsernameHtml,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("is_online")] bool IsOnline,
	[property: JsonPropertyName("contacts_changed")] bool ContactsChanged,
	[property: JsonPropertyName("avatar")] string Avatar
);

public sealed record Resp_ConversationModelRecipients(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("username_html")] string UsernameHtml,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("is_online")] bool IsOnline,
	[property: JsonPropertyName("contacts_changed")] bool ContactsChanged,
	[property: JsonPropertyName("avatar")] string Avatar
);

public sealed record Resp_ConversationModelLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("messages")] string Messages,
	[property: JsonPropertyName("avatar")] string Avatar
);

public sealed record Resp_LinkModel(
	[property: JsonPropertyName("link_id")] long LinkId,
	[property: JsonPropertyName("link_title")] string LinkTitle,
	[property: JsonPropertyName("link_description")] string LinkDescription,
	[property: JsonPropertyName("links")] Resp_LinkModelLinks Links,
	[property: JsonPropertyName("permissions")] Resp_LinkModelPermissions Permissions
);

public sealed record Resp_LinkModelLinks(
	[property: JsonPropertyName("target")] string Target,
	[property: JsonPropertyName("detail")] string Detail
);

public sealed record Resp_LinkModelPermissions(
	[property: JsonPropertyName("view")] bool View
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
	[property: JsonPropertyName("links")] Resp_NotificationModelLinks Links,
	[property: JsonPropertyName("notification_html")] string NotificationHtml
);

public sealed record Resp_NotificationModelLinks(
	[property: JsonPropertyName("content")] string Content,
	[property: JsonPropertyName("creator_avatar")] string CreatorAvatar
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
	[property: JsonPropertyName("links")] Resp_PostCommentModelLinks Links,
	[property: JsonPropertyName("permissions")] Resp_PostCommentModelPermissions Permissions
);

public sealed record Resp_PostCommentModelLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("post")] string Post,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

public sealed record Resp_PostCommentModelPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report
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
	[property: JsonPropertyName("links")] Resp_PostModelLinks Links,
	[property: JsonPropertyName("permissions")] Resp_PostModelPermissions Permissions,
	[property: JsonPropertyName("thread_is_deleted")] bool ThreadIsDeleted
);

public sealed record Resp_PostModelLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

public sealed record Resp_PostModelPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report
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
	[property: JsonPropertyName("links")] Resp_ProfilePostCommentModelLinks Links,
	[property: JsonPropertyName("permissions")] Resp_ProfilePostCommentModelPermissions Permissions
);

public sealed record Resp_ProfilePostCommentModelLinks(
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("profile_post")] string ProfilePost,
	[property: JsonPropertyName("timeline")] string Timeline,
	[property: JsonPropertyName("timeline_user")] string TimelineUser,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

public sealed record Resp_ProfilePostCommentModelPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete
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
	[property: JsonPropertyName("links")] Resp_ProfilePostModelLinks Links,
	[property: JsonPropertyName("permissions")] Resp_ProfilePostModelPermissions Permissions,
	[property: JsonPropertyName("timeline_user")] Resp_UserModel TimelineUser
);

public sealed record Resp_ProfilePostModelLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("timeline")] string Timeline,
	[property: JsonPropertyName("timeline_user")] string TimelineUser,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("comments")] string Comments,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

public sealed record Resp_ProfilePostModelPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("comment")] bool Comment,
	[property: JsonPropertyName("report")] bool Report,
	[property: JsonPropertyName("stick")] bool Stick
);

public sealed record Resp_SystemInfo(
	[property: JsonPropertyName("visitor_id")] long VisitorId,
	[property: JsonPropertyName("time")] long Time
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
	[property: JsonPropertyName("first_post")] Resp_ThreadModelFirstPost FirstPost,
	[property: JsonPropertyName("thread_prefixes")] List<JsonElement> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] Resp_ThreadModelThreadTags ThreadTags,
	[property: JsonPropertyName("links")] Resp_ThreadModelLinks Links,
	[property: JsonPropertyName("permissions")] Resp_ThreadModelPermissions Permissions,
	[property: JsonPropertyName("node_title")] string NodeTitle,
	[property: JsonPropertyName("restrictions")] Resp_ThreadModelRestrictions Restrictions,
	[property: JsonPropertyName("last_post")] Resp_ThreadModelLastPost LastPost,
	[property: JsonPropertyName("contest")] Resp_ThreadModelContest Contest
);

public sealed record Resp_ThreadModelFirstPostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

public sealed record Resp_ThreadModelFirstPostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report
);

public sealed record Resp_ThreadModelFirstPost(
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
	[property: JsonPropertyName("post_is_liked")] bool PostIsLiked,
	[property: JsonPropertyName("links")] Resp_ThreadModelFirstPostLinks Links,
	[property: JsonPropertyName("permissions")] Resp_ThreadModelFirstPostPermissions Permissions,
	[property: JsonPropertyName("thread_is_deleted")] bool ThreadIsDeleted
);

public sealed record Resp_ThreadModelThreadTags(
	[property: JsonPropertyName("97491")] string _97491,
	[property: JsonPropertyName("193431")] string _193431,
	[property: JsonPropertyName("206")] string _206
);

public sealed record Resp_ThreadModelLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("forum")] string Forum,
	[property: JsonPropertyName("posts")] string Posts,
	[property: JsonPropertyName("first_poster")] string FirstPoster,
	[property: JsonPropertyName("first_poster_avatar")] string FirstPosterAvatar,
	[property: JsonPropertyName("first_post")] string FirstPost,
	[property: JsonPropertyName("last_post")] string LastPost
);

public sealed record Resp_ThreadModelPermissionsBump(
	[property: JsonPropertyName("can")] bool Can,
	[property: JsonPropertyName("available_count")] long AvailableCount,
	[property: JsonPropertyName("error")] JsonElement Error,
	[property: JsonPropertyName("next_available_time")] JsonElement NextAvailableTime
);

public sealed record Resp_ThreadModelPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("edit_title")] bool EditTitle,
	[property: JsonPropertyName("edit_tags")] bool EditTags,
	[property: JsonPropertyName("bump")] Resp_ThreadModelPermissionsBump Bump
);

public sealed record Resp_ThreadModelRestrictions(
	[property: JsonPropertyName("reply_delay")] long ReplyDelay,
	[property: JsonPropertyName("max_reply_count")] long MaxReplyCount
);

public sealed record Resp_ThreadModelLastPostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

public sealed record Resp_ThreadModelLastPostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report
);

public sealed record Resp_ThreadModelLastPost(
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
	[property: JsonPropertyName("post_is_liked")] bool PostIsLiked,
	[property: JsonPropertyName("links")] Resp_ThreadModelLastPostLinks Links,
	[property: JsonPropertyName("permissions")] Resp_ThreadModelLastPostPermissions Permissions,
	[property: JsonPropertyName("thread_is_deleted")] bool ThreadIsDeleted
);

public sealed record Resp_ThreadModelContestPermissions(
	[property: JsonPropertyName("can_finish")] bool CanFinish,
	[property: JsonPropertyName("can_participate")] bool CanParticipate,
	[property: JsonPropertyName("can_participate_error")] string CanParticipateError,
	[property: JsonPropertyName("can_view_user_list")] bool CanViewUserList
);

public sealed record Resp_ThreadModelContest(
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("finish_date")] long FinishDate,
	[property: JsonPropertyName("now_count_members")] long NowCountMembers,
	[property: JsonPropertyName("needed_members")] long NeededMembers,
	[property: JsonPropertyName("is_finished")] long IsFinished,
	[property: JsonPropertyName("count_winners")] long CountWinners,
	[property: JsonPropertyName("require_like_count")] long RequireLikeCount,
	[property: JsonPropertyName("require_total_like_count")] long RequireTotalLikeCount,
	[property: JsonPropertyName("prize_type")] string PrizeType,
	[property: JsonPropertyName("prize_type_phrase")] string PrizeTypePhrase,
	[property: JsonPropertyName("prize_data")] long PrizeData,
	[property: JsonPropertyName("is_money_places")] long IsMoneyPlaces,
	[property: JsonPropertyName("chance_to_win")] double ChanceToWin,
	[property: JsonPropertyName("winners")] List<long> Winners,
	[property: JsonPropertyName("already_participate")] bool AlreadyParticipate,
	[property: JsonPropertyName("permissions")] Resp_ThreadModelContestPermissions Permissions
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
	[property: JsonPropertyName("links")] Resp_UserModelLinks Links,
	[property: JsonPropertyName("permissions")] Resp_UserModelPermissions Permissions,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("user_is_visitor")] bool UserIsVisitor,
	[property: JsonPropertyName("user_group_id")] long UserGroupId,
	[property: JsonPropertyName("curator_titles")] List<string> CuratorTitles,
	[property: JsonPropertyName("user_groups")] List<Resp_UserModelUserGroups> UserGroups,
	[property: JsonPropertyName("fields")] List<Resp_UserModelFields> Fields,
	[property: JsonPropertyName("user_timezone_offset")] long UserTimezoneOffset,
	[property: JsonPropertyName("user_external_authentications")] List<Resp_UserModelUserExternalAuthentications> UserExternalAuthentications,
	[property: JsonPropertyName("self_permissions")] Resp_UserModelSelfPermissions SelfPermissions,
	[property: JsonPropertyName("edit_permissions")] Resp_UserModelEditPermissions EditPermissions,
	[property: JsonPropertyName("birthday")] Resp_UserModelBirthday Birthday,
	[property: JsonPropertyName("secret_answer_rendered")] string SecretAnswerRendered,
	[property: JsonPropertyName("secret_answer_first_letter")] string SecretAnswerFirstLetter,
	[property: JsonPropertyName("user_following")] Resp_UserModelUserFollowing UserFollowing,
	[property: JsonPropertyName("user_followers")] Resp_UserModelUserFollowers UserFollowers,
	[property: JsonPropertyName("banner")] string Banner
);

public sealed record Resp_UserModelLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("avatar")] string Avatar,
	[property: JsonPropertyName("avatar_big")] string AvatarBig,
	[property: JsonPropertyName("avatar_small")] string AvatarSmall,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("followings")] string Followings,
	[property: JsonPropertyName("ignore")] string Ignore,
	[property: JsonPropertyName("background_l")] string BackgroundL,
	[property: JsonPropertyName("background_m")] string BackgroundM,
	[property: JsonPropertyName("status")] string Status,
	[property: JsonPropertyName("timeline")] string Timeline
);

public sealed record Resp_UserModelPermissions(
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("ignore")] bool Ignore,
	[property: JsonPropertyName("profile_post")] bool ProfilePost
);

public sealed record Resp_UserModelUserGroups(
	[property: JsonPropertyName("user_group_id")] long UserGroupId,
	[property: JsonPropertyName("user_group_title")] string UserGroupTitle,
	[property: JsonPropertyName("user_group_title_en")] string UserGroupTitleEn,
	[property: JsonPropertyName("user_group_banner_css_class")] string UserGroupBannerCssClass,
	[property: JsonPropertyName("user_group_banner_text")] string UserGroupBannerText,
	[property: JsonPropertyName("user_group_banner_text_en")] string UserGroupBannerTextEn,
	[property: JsonPropertyName("display_group_selectable")] bool DisplayGroupSelectable,
	[property: JsonPropertyName("display_banner_selectable")] bool DisplayBannerSelectable,
	[property: JsonPropertyName("display_icon_selectable")] bool DisplayIconSelectable,
	[property: JsonPropertyName("is_primary_group")] bool IsPrimaryGroup,
	[property: JsonPropertyName("user_group_icon_class")] string UserGroupIconClass
);

public sealed record Resp_UserModelFieldsChoices(
	[property: JsonPropertyName("key")] string Key,
	[property: JsonPropertyName("value")] string Value
);

public sealed record Resp_UserModelFields(
	[property: JsonPropertyName("id")] string Id,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("position")] string Position,
	[property: JsonPropertyName("is_required")] bool IsRequired,
	[property: JsonPropertyName("value")] string? Value,
	[property: JsonPropertyName("is_multi_choice")] bool IsMultiChoice,
	[property: JsonPropertyName("choices")] List<Resp_UserModelFieldsChoices> Choices,
	[property: JsonPropertyName("values")] List<JsonElement> Values
);

public sealed record Resp_UserModelUserExternalAuthentications(
	[property: JsonPropertyName("provider")] string Provider,
	[property: JsonPropertyName("provider_key")] string ProviderKey
);

public sealed record Resp_UserModelSelfPermissions(
	[property: JsonPropertyName("create_conversation")] bool CreateConversation
);

public sealed record Resp_UserModelEditPermissions(
	[property: JsonPropertyName("password")] bool Password,
	[property: JsonPropertyName("user_email")] bool UserEmail,
	[property: JsonPropertyName("username")] bool Username,
	[property: JsonPropertyName("user_title")] bool UserTitle,
	[property: JsonPropertyName("short_link")] bool ShortLink,
	[property: JsonPropertyName("hide_username_logs")] bool HideUsernameLogs,
	[property: JsonPropertyName("primary_group_id")] bool PrimaryGroupId,
	[property: JsonPropertyName("secondary_group_ids")] bool SecondaryGroupIds,
	[property: JsonPropertyName("user_dob_day")] bool UserDobDay,
	[property: JsonPropertyName("user_dob_month")] bool UserDobMonth,
	[property: JsonPropertyName("user_dob_year")] bool UserDobYear,
	[property: JsonPropertyName("fields")] bool Fields
);

public sealed record Resp_UserModelBirthdayTimeStamp(
	[property: JsonPropertyName("date")] string Date,
	[property: JsonPropertyName("timezone_type")] long TimezoneType,
	[property: JsonPropertyName("timezone")] string Timezone
);

public sealed record Resp_UserModelBirthday(
	[property: JsonPropertyName("age")] long Age,
	[property: JsonPropertyName("timeStamp")] Resp_UserModelBirthdayTimeStamp TimeStamp,
	[property: JsonPropertyName("format")] string Format
);

public sealed record Resp_UserModelUserFollowingUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("username_html")] string UsernameHtml,
	[property: JsonPropertyName("avatar")] string Avatar
);

public sealed record Resp_UserModelUserFollowing(
	[property: JsonPropertyName("users")] List<Resp_UserModelUserFollowingUsers> Users,
	[property: JsonPropertyName("count")] long Count
);

public sealed record Resp_UserModelUserFollowersUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("username_html")] string UsernameHtml,
	[property: JsonPropertyName("avatar")] string Avatar
);

public sealed record Resp_UserModelUserFollowers(
	[property: JsonPropertyName("users")] List<Resp_UserModelUserFollowersUsers> Users,
	[property: JsonPropertyName("count")] long Count
);

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

// ─── BatchApi Types ────────────────────────────────────────

public static class BatchApiTypes
{
	public sealed record BatchExecuteResponse(
		[property: JsonPropertyName("jobs")] BatchExecuteResponseJobs Jobs
	);

	public sealed record BatchExecuteResponseJobs(
	[property: JsonPropertyName("job_id")] JsonElement JobId
);
}

// ─── CategoriesApi Types ────────────────────────────────────────

public static class CategoriesApiTypes
{
	public sealed record CategoriesListParams
	{
		[JsonPropertyName("parent_category_id")]
		public long? ParentCategoryId { get; init; }
		[JsonPropertyName("parent_forum_id")]
		public long? ParentForumId { get; init; }
		[JsonPropertyName("order")]
		public CategoriesOrder? Order { get; init; }
	}

	public sealed record CategoriesListResponse(
		[property: JsonPropertyName("categories")] List<CategoriesListResponseCategories> Categories,
		[property: JsonPropertyName("categories_total")] long CategoriesTotal,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoriesListResponseCategoriesLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums
);

	public sealed record CategoriesListResponseCategoriesPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete
);

	public sealed record CategoriesListResponseCategories(
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("category_title")] string CategoryTitle,
	[property: JsonPropertyName("category_description")] string CategoryDescription,
	[property: JsonPropertyName("links")] CategoriesListResponseCategoriesLinks Links,
	[property: JsonPropertyName("permissions")] CategoriesListResponseCategoriesPermissions Permissions
);

	public sealed record CategoriesGetResponse(
		[property: JsonPropertyName("category")] CategoriesGetResponseCategory Category,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoriesGetResponseCategoryLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums
);

	public sealed record CategoriesGetResponseCategoryPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete
);

	public sealed record CategoriesGetResponseCategory(
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("category_title")] string CategoryTitle,
	[property: JsonPropertyName("category_description")] string CategoryDescription,
	[property: JsonPropertyName("links")] CategoriesGetResponseCategoryLinks Links,
	[property: JsonPropertyName("permissions")] CategoriesGetResponseCategoryPermissions Permissions
);
}

// ─── ChatboxApi Types ────────────────────────────────────────

public static class ChatboxApiTypes
{
	public sealed record ChatboxIndexParams
	{
		[JsonPropertyName("room_id")]
		public RoomId? RoomId { get; init; }
	}

	public sealed record ChatboxIndexResponse(
		[property: JsonPropertyName("rooms")] List<ChatboxIndexResponseRooms> Rooms,
		[property: JsonPropertyName("ban")] JsonElement Ban,
		[property: JsonPropertyName("ignore")] List<ChatboxIndexResponseIgnore> Ignore,
		[property: JsonPropertyName("permissions")] ChatboxIndexResponsePermissions Permissions,
		[property: JsonPropertyName("commands")] List<string> Commands,
		[property: JsonPropertyName("roomsOnline")] ChatboxIndexResponseRoomsOnline RoomsOnline,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ChatboxIndexResponseRooms(
	[property: JsonPropertyName("can_report")] bool CanReport,
	[property: JsonPropertyName("eng")] bool Eng,
	[property: JsonPropertyName("market")] bool Market,
	[property: JsonPropertyName("room_id")] long RoomId,
	[property: JsonPropertyName("title")] string Title
);

	public sealed record ChatboxIndexResponseIgnoreRenderedAvatars(
	[property: JsonPropertyName("l")] string L,
	[property: JsonPropertyName("m")] string M,
	[property: JsonPropertyName("s")] string S
);

	public sealed record ChatboxIndexResponseIgnoreRendered(
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatars")] ChatboxIndexResponseIgnoreRenderedAvatars Avatars,
	[property: JsonPropertyName("link")] string Link
);

	public sealed record ChatboxIndexResponseIgnore(
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("background_date")] long BackgroundDate,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("custom_title")] string CustomTitle,
	[property: JsonPropertyName("display_banner_id")] long DisplayBannerId,
	[property: JsonPropertyName("display_icon_group_id")] long DisplayIconGroupId,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("is_admin")] bool IsAdmin,
	[property: JsonPropertyName("is_banned")] bool IsBanned,
	[property: JsonPropertyName("is_moderator")] bool IsModerator,
	[property: JsonPropertyName("is_staff")] bool IsStaff,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("like2_count")] long Like2Count,
	[property: JsonPropertyName("like_count")] long LikeCount,
	[property: JsonPropertyName("message_count")] long MessageCount,
	[property: JsonPropertyName("register_date")] long RegisterDate,
	[property: JsonPropertyName("rendered")] ChatboxIndexResponseIgnoreRendered Rendered,
	[property: JsonPropertyName("short_link")] JsonElement ShortLink,
	[property: JsonPropertyName("trophy_points")] long TrophyPoints,
	[property: JsonPropertyName("uniq_banner")] JsonElement UniqBanner,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username
);

	public sealed record ChatboxIndexResponsePermissions(
	[property: JsonPropertyName("deleteAnyMessage")] bool DeleteAnyMessage,
	[property: JsonPropertyName("editAnyMessage")] bool EditAnyMessage,
	[property: JsonPropertyName("viewAnyMessage")] bool ViewAnyMessage,
	[property: JsonPropertyName("viewMessages")] bool ViewMessages,
	[property: JsonPropertyName("postMessage")] bool PostMessage,
	[property: JsonPropertyName("ban")] bool Ban
);

	public sealed record ChatboxIndexResponseRoomsOnline(
	[property: JsonPropertyName("chat:0")] long Chat_0
);

	public sealed record ChatboxGetMessagesParams
	{
		[JsonPropertyName("room_id")]
		public RoomId? RoomId { get; init; }
		[JsonPropertyName("before_message_id")]
		public long? BeforeMessageId { get; init; }
	}

	public sealed record ChatboxGetMessagesResponse(
		[property: JsonPropertyName("messages")] List<Resp_ChatboxMessageModel> Messages,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ChatboxPostMessageBody
	{
		[JsonPropertyName("room_id")]
		public required RoomId RoomId { get; init; }
		[JsonPropertyName("reply_message_id")]
		public long? ReplyMessageId { get; init; }
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
		public required long? MessageId { get; init; }
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
		public required long? MessageId { get; init; }
	}

	public sealed record ChatboxDeleteMessageResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ChatboxOnlineParams
	{
		[JsonPropertyName("room_id")]
		public RoomId? RoomId { get; init; }
	}

	public sealed record ChatboxOnlineResponse(
		[property: JsonPropertyName("users")] List<ChatboxOnlineResponseUsers> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ChatboxOnlineResponseUsersRenderedAvatars(
	[property: JsonPropertyName("l")] string L,
	[property: JsonPropertyName("m")] string M,
	[property: JsonPropertyName("s")] string S
);

	public sealed record ChatboxOnlineResponseUsersRendered(
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatars")] ChatboxOnlineResponseUsersRenderedAvatars Avatars,
	[property: JsonPropertyName("link")] string Link
);

	public sealed record ChatboxOnlineResponseUsersUniqBanner(
	[property: JsonPropertyName("banner_css")] string BannerCss,
	[property: JsonPropertyName("banner_text")] string BannerText,
	[property: JsonPropertyName("banner_icon")] string BannerIcon,
	[property: JsonPropertyName("username_icon")] string UsernameIcon
);

	public sealed record ChatboxOnlineResponseUsers(
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("background_date")] long BackgroundDate,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("custom_title")] string CustomTitle,
	[property: JsonPropertyName("display_banner_id")] long DisplayBannerId,
	[property: JsonPropertyName("display_icon_group_id")] long DisplayIconGroupId,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("is_admin")] bool IsAdmin,
	[property: JsonPropertyName("is_banned")] bool IsBanned,
	[property: JsonPropertyName("is_moderator")] bool IsModerator,
	[property: JsonPropertyName("is_staff")] bool IsStaff,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("like2_count")] long Like2Count,
	[property: JsonPropertyName("like_count")] long LikeCount,
	[property: JsonPropertyName("message_count")] long MessageCount,
	[property: JsonPropertyName("register_date")] long RegisterDate,
	[property: JsonPropertyName("rendered")] ChatboxOnlineResponseUsersRendered Rendered,
	[property: JsonPropertyName("short_link")] string ShortLink,
	[property: JsonPropertyName("trophy_points")] long TrophyPoints,
	[property: JsonPropertyName("uniq_banner")] ChatboxOnlineResponseUsersUniqBanner UniqBanner,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username
);

	public sealed record ChatboxReportReasonsParams
	{
		[JsonPropertyName("message_id")]
		public long? MessageId { get; init; }
	}

	public sealed record ChatboxReportReasonsResponse(
		[property: JsonPropertyName("reasons")] List<string> Reasons,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ChatboxReportBody
	{
		[JsonPropertyName("message_id")]
		public required long? MessageId { get; init; }
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
		public Duration? Duration { get; init; }
	}

	public sealed record ChatboxGetLeaderboardResponse(
		[property: JsonPropertyName("leaderboard")] List<ChatboxGetLeaderboardResponseLeaderboard> Leaderboard,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ChatboxGetLeaderboardResponseLeaderboardRenderedAvatars(
	[property: JsonPropertyName("l")] string L,
	[property: JsonPropertyName("m")] string M,
	[property: JsonPropertyName("s")] string S
);

	public sealed record ChatboxGetLeaderboardResponseLeaderboardRendered(
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatars")] ChatboxGetLeaderboardResponseLeaderboardRenderedAvatars Avatars,
	[property: JsonPropertyName("link")] string Link
);

	public sealed record ChatboxGetLeaderboardResponseLeaderboardUniqBanner(
	[property: JsonPropertyName("banner_css")] string BannerCss,
	[property: JsonPropertyName("banner_text")] string BannerText,
	[property: JsonPropertyName("banner_icon")] string BannerIcon
);

	public sealed record ChatboxGetLeaderboardResponseLeaderboard(
	[property: JsonPropertyName("count")] long Count,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("background_date")] long BackgroundDate,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("custom_title")] string CustomTitle,
	[property: JsonPropertyName("display_banner_id")] long DisplayBannerId,
	[property: JsonPropertyName("display_icon_group_id")] long DisplayIconGroupId,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("is_banned")] bool IsBanned,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("like2_count")] long Like2Count,
	[property: JsonPropertyName("like_count")] long LikeCount,
	[property: JsonPropertyName("message_count")] long MessageCount,
	[property: JsonPropertyName("register_date")] long RegisterDate,
	[property: JsonPropertyName("rendered")] ChatboxGetLeaderboardResponseLeaderboardRendered Rendered,
	[property: JsonPropertyName("short_link")] JsonElement ShortLink,
	[property: JsonPropertyName("trophy_points")] long TrophyPoints,
	[property: JsonPropertyName("uniq_banner")] ChatboxGetLeaderboardResponseLeaderboardUniqBanner UniqBanner,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss,
	[property: JsonPropertyName("username")] string Username
);

	public sealed record ChatboxGetIgnoreResponse(
		[property: JsonPropertyName("ignored")] List<ChatboxGetIgnoreResponseIgnored> Ignored,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ChatboxGetIgnoreResponseIgnoredRenderedAvatars(
	[property: JsonPropertyName("l")] string L,
	[property: JsonPropertyName("m")] string M,
	[property: JsonPropertyName("s")] string S
);

	public sealed record ChatboxGetIgnoreResponseIgnoredRendered(
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatars")] ChatboxGetIgnoreResponseIgnoredRenderedAvatars Avatars,
	[property: JsonPropertyName("link")] string Link
);

	public sealed record ChatboxGetIgnoreResponseIgnored(
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("background_date")] long BackgroundDate,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("custom_title")] string CustomTitle,
	[property: JsonPropertyName("display_banner_id")] long DisplayBannerId,
	[property: JsonPropertyName("display_icon_group_id")] long DisplayIconGroupId,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("is_banned")] bool IsBanned,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("like2_count")] long Like2Count,
	[property: JsonPropertyName("like_count")] long LikeCount,
	[property: JsonPropertyName("message_count")] long MessageCount,
	[property: JsonPropertyName("register_date")] long RegisterDate,
	[property: JsonPropertyName("rendered")] ChatboxGetIgnoreResponseIgnoredRendered Rendered,
	[property: JsonPropertyName("short_link")] JsonElement ShortLink,
	[property: JsonPropertyName("trophy_points")] long TrophyPoints,
	[property: JsonPropertyName("uniq_banner")] JsonElement UniqBanner,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username
);

	public sealed record ChatboxPostIgnoreBody
	{
		[JsonPropertyName("user_id")]
		public required Lolzteam.Api.Runtime.StringOrLong UserId { get; init; }
	}

	public sealed record ChatboxPostIgnoreResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ChatboxDeleteIgnoreBody
	{
		[JsonPropertyName("user_id")]
		public required Lolzteam.Api.Runtime.StringOrLong UserId { get; init; }
	}

	public sealed record ChatboxDeleteIgnoreResponse(
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
		public Folder? Folder { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record ConversationsListResponse(
		[property: JsonPropertyName("conversations")] List<Resp_ConversationModel> Conversations,
		[property: JsonPropertyName("can_start")] bool CanStart,
		[property: JsonPropertyName("folders")] List<ConversationsListResponseFolders> Folders,
		[property: JsonPropertyName("links")] ConversationsListResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ConversationsListResponseFolders(
	[property: JsonPropertyName("id")] string Id,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("name")] string Name
);

	public sealed record ConversationsListResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
);

	public sealed record ConversationsCreateBody
	{
		[JsonPropertyName("recipient_id")]
		public long? RecipientId { get; init; }
		[JsonPropertyName("recipients")]
		public List<string>? Recipients { get; init; }
		/// <summary>Default: false</summary>
		[JsonPropertyName("is_group")]
		public bool? IsGroup { get; init; } = false;
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
		public required long? ConversationId { get; init; }
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
		public required long? ConversationId { get; init; }
		[JsonPropertyName("delete_type")]
		public required DeleteType DeleteType { get; init; }
	}

	public sealed record ConversationsDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ConversationsStartBody
	{
		[JsonPropertyName("user_id")]
		public required Lolzteam.Api.Runtime.StringOrLong UserId { get; init; }
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
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		[JsonPropertyName("order")]
		public ConversationsOrder? Order { get; init; }
		[JsonPropertyName("before")]
		public long? Before { get; init; }
		[JsonPropertyName("after")]
		public long? After { get; init; }
	}

	public sealed record ConversationsMessagesListResponse(
		[property: JsonPropertyName("messages")] List<Resp_ConversationMessageModel> Messages,
		[property: JsonPropertyName("messages_total")] long MessagesTotal,
		[property: JsonPropertyName("links")] ConversationsMessagesListResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ConversationsMessagesListResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
);

	public sealed record ConversationsMessagesCreateBody
	{
		[JsonPropertyName("reply_message_id")]
		public long? ReplyMessageId { get; init; }
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
		public long? ConversationId { get; init; }
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
		public required long? UserId { get; init; }
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

// ─── FormsApi Types ────────────────────────────────────────

public static class FormsApiTypes
{
	public sealed record FormsListParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
	}

	public sealed record FormsListResponse(
		[property: JsonPropertyName("forms")] List<FormsListResponseForms> Forms,
		[property: JsonPropertyName("formsPerPage")] long FormsPerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("totalForms")] long TotalForms,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record FormsListResponseFormsFieldsFieldChoices(
	[property: JsonPropertyName("buy")] string Buy,
	[property: JsonPropertyName("sell")] string Sell
);

	public sealed record FormsListResponseFormsFields(
	[property: JsonPropertyName("field_id")] long FieldId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("fieldChoices")] FormsListResponseFormsFieldsFieldChoices FieldChoices,
	[property: JsonPropertyName("required")] long Required,
	[property: JsonPropertyName("max_length")] long MaxLength,
	[property: JsonPropertyName("default_value")] string DefaultValue
);

	public sealed record FormsListResponseForms(
	[property: JsonPropertyName("form_id")] long FormId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("fields")] List<FormsListResponseFormsFields> Fields
);

	[JsonDerivedType(typeof(FormsCreateBodyP2PTrade), "1")]
	[JsonDerivedType(typeof(FormsCreateBodyComplaint), "3")]
	public abstract record FormsCreateBody;

	public sealed record FormsCreateBodyP2PTrade : FormsCreateBody
	{
		[JsonPropertyName("form_id")]
		public long FormId => 1;
		[JsonPropertyName("fields")]
		public required JsonElement Fields { get; init; }
	}
	public sealed record FormsCreateBodyComplaint : FormsCreateBody
	{
		[JsonPropertyName("form_id")]
		public long FormId => 3;
		[JsonPropertyName("fields")]
		public required JsonElement Fields { get; init; }
	}

	public sealed record FormsCreateResponse(
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("content")] FormsCreateResponseContent Content,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record FormsCreateResponseContentLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("forum")] string Forum,
	[property: JsonPropertyName("posts")] string Posts,
	[property: JsonPropertyName("first_poster")] string FirstPoster,
	[property: JsonPropertyName("first_poster_avatar")] string FirstPosterAvatar,
	[property: JsonPropertyName("first_post")] string FirstPost
);

	public sealed record FormsCreateResponseContentPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post
);

	public sealed record FormsCreateResponseContent(
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
	[property: JsonPropertyName("thread_prefixes")] List<JsonElement> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] List<JsonElement> ThreadTags,
	[property: JsonPropertyName("links")] FormsCreateResponseContentLinks Links,
	[property: JsonPropertyName("permissions")] FormsCreateResponseContentPermissions Permissions,
	[property: JsonPropertyName("node_title")] string NodeTitle
);
}

// ─── ForumsApi Types ────────────────────────────────────────

public static class ForumsApiTypes
{
	public sealed record ForumsListParams
	{
		[JsonPropertyName("parent_category_id")]
		public long? ParentCategoryId { get; init; }
		[JsonPropertyName("parent_forum_id")]
		public long? ParentForumId { get; init; }
		[JsonPropertyName("order")]
		public CategoriesOrder? Order { get; init; }
	}

	public sealed record ForumsListResponse(
		[property: JsonPropertyName("forums")] List<ForumsListResponseForums> Forums,
		[property: JsonPropertyName("forums_total")] long ForumsTotal,
		[property: JsonPropertyName("tabs")] List<ForumsListResponseTabs> Tabs,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ForumsListResponseForumsForumPrefixesGroupPrefixes(
	[property: JsonPropertyName("prefix_id")] long PrefixId,
	[property: JsonPropertyName("prefix_title")] string PrefixTitle
);

	public sealed record ForumsListResponseForumsForumPrefixes(
	[property: JsonPropertyName("group_title")] string GroupTitle,
	[property: JsonPropertyName("group_prefixes")] List<ForumsListResponseForumsForumPrefixesGroupPrefixes> GroupPrefixes
);

	public sealed record ForumsListResponseForumsLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
);

	public sealed record ForumsListResponseForumsPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
);

	public sealed record ForumsListResponseForums(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<ForumsListResponseForumsForumPrefixes> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] ForumsListResponseForumsLinks Links,
	[property: JsonPropertyName("permissions")] ForumsListResponseForumsPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
);

	public sealed record ForumsListResponseTabs(
	[property: JsonPropertyName("link_title")] string LinkTitle,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isHidden")] bool IsHidden
);

	public sealed record ForumsGroupedResponse(
		[property: JsonPropertyName("data")] ForumsGroupedResponseData Data,
		[property: JsonPropertyName("tabs")] List<ForumsGroupedResponseTabs> Tabs,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ForumsGroupedResponseData00Links(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
);

	public sealed record ForumsGroupedResponseData00Permissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
);

	public sealed record ForumsGroupedResponseData00(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("parent_node_id")] long ParentNodeId,
	[property: JsonPropertyName("links")] ForumsGroupedResponseData00Links Links,
	[property: JsonPropertyName("permissions")] ForumsGroupedResponseData00Permissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
);

	public sealed record ForumsGroupedResponseData0(
	[property: JsonPropertyName("0")] ForumsGroupedResponseData00 _0
);

	public sealed record ForumsGroupedResponseData(
	[property: JsonPropertyName("0")] ForumsGroupedResponseData0 _0
);

	public sealed record ForumsGroupedResponseTabs(
	[property: JsonPropertyName("link_title")] string LinkTitle,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isHidden")] bool IsHidden
);

	public sealed record ForumsGetResponse(
		[property: JsonPropertyName("forum")] ForumsGetResponseForum Forum,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ForumsGetResponseForumForumPrefixesGroupPrefixes(
	[property: JsonPropertyName("prefix_id")] long PrefixId,
	[property: JsonPropertyName("prefix_title")] string PrefixTitle
);

	public sealed record ForumsGetResponseForumForumPrefixes(
	[property: JsonPropertyName("group_title")] string GroupTitle,
	[property: JsonPropertyName("group_prefixes")] List<ForumsGetResponseForumForumPrefixesGroupPrefixes> GroupPrefixes
);

	public sealed record ForumsGetResponseForumLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
);

	public sealed record ForumsGetResponseForumPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
);

	public sealed record ForumsGetResponseForum(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<ForumsGetResponseForumForumPrefixes> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] ForumsGetResponseForumLinks Links,
	[property: JsonPropertyName("permissions")] ForumsGetResponseForumPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
);

	public sealed record ForumsFollowersResponse(
		[property: JsonPropertyName("users")] List<ForumsFollowersResponseUsers> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ForumsFollowersResponseUsersFollow(
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("alert")] bool Alert,
	[property: JsonPropertyName("email")] bool Email
);

	public sealed record ForumsFollowersResponseUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("follow")] ForumsFollowersResponseUsersFollow Follow
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
		public List<long?>? PrefixIds { get; init; }
		[JsonPropertyName("minimal_contest_amount")]
		public long? MinimalContestAmount { get; init; }
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
		[property: JsonPropertyName("forums")] List<ForumsFollowedResponseForums> Forums,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ForumsFollowedResponseForumsForumPrefixesGroupPrefixes(
	[property: JsonPropertyName("prefix_id")] long PrefixId,
	[property: JsonPropertyName("prefix_title")] string PrefixTitle
);

	public sealed record ForumsFollowedResponseForumsForumPrefixes(
	[property: JsonPropertyName("group_title")] string GroupTitle,
	[property: JsonPropertyName("group_prefixes")] List<ForumsFollowedResponseForumsForumPrefixesGroupPrefixes> GroupPrefixes
);

	public sealed record ForumsFollowedResponseForumsLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
);

	public sealed record ForumsFollowedResponseForumsPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
);

	public sealed record ForumsFollowedResponseForumsFollow(
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("alert")] bool Alert,
	[property: JsonPropertyName("email")] bool Email
);

	public sealed record ForumsFollowedResponseForums(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<ForumsFollowedResponseForumsForumPrefixes> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] ForumsFollowedResponseForumsLinks Links,
	[property: JsonPropertyName("permissions")] ForumsFollowedResponseForumsPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed,
	[property: JsonPropertyName("follow")] ForumsFollowedResponseForumsFollow Follow
);

	public sealed record ForumsGetFeedOptionsResponse(
		[property: JsonPropertyName("forums")] List<ForumsGetFeedOptionsResponseForums> Forums,
		[property: JsonPropertyName("excluded_forums_ids")] List<long> ExcludedForumsIds,
		[property: JsonPropertyName("default_excluded_forums_ids")] List<long> DefaultExcludedForumsIds,
		[property: JsonPropertyName("keywords")] string Keywords,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ForumsGetFeedOptionsResponseForumsLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
);

	public sealed record ForumsGetFeedOptionsResponseForumsPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
);

	public sealed record ForumsGetFeedOptionsResponseForums(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("parent_node_id")] long ParentNodeId,
	[property: JsonPropertyName("links")] ForumsGetFeedOptionsResponseForumsLinks Links,
	[property: JsonPropertyName("permissions")] ForumsGetFeedOptionsResponseForumsPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed,
	[property: JsonPropertyName("has_children")] bool HasChildren
);

	public sealed record ForumsEditFeedOptionsBody
	{
		[JsonPropertyName("node_ids")]
		public List<long?>? NodeIds { get; init; }
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

// ─── NavigationApi Types ────────────────────────────────────────

public static class NavigationApiTypes
{
	public sealed record NavigationListParams
	{
		[JsonPropertyName("parent")]
		public long? Parent { get; init; }
	}

	public sealed record NavigationListResponse(
		[property: JsonPropertyName("elements")] List<NavigationListResponseElements> Elements,
		[property: JsonPropertyName("elements_count")] long ElementsCount,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record NavigationListResponseElementsLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("sub-elements")] string SubElements
);

	public sealed record NavigationListResponseElementsPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete
);

	public sealed record NavigationListResponseElements(
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("category_title")] string CategoryTitle,
	[property: JsonPropertyName("category_description")] string CategoryDescription,
	[property: JsonPropertyName("links")] NavigationListResponseElementsLinks Links,
	[property: JsonPropertyName("permissions")] NavigationListResponseElementsPermissions Permissions,
	[property: JsonPropertyName("navigation_type")] string NavigationType,
	[property: JsonPropertyName("navigation_id")] long NavigationId,
	[property: JsonPropertyName("navigation_parent_id")] long NavigationParentId,
	[property: JsonPropertyName("has_sub_elements")] bool HasSubElements
);
}

// ─── NotificationsApi Types ────────────────────────────────────────

public static class NotificationsApiTypes
{
	public sealed record NotificationsListParams
	{
		[JsonPropertyName("type")]
		public NotificationsType? Type { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record NotificationsListResponse(
		[property: JsonPropertyName("notifications")] List<Resp_NotificationModel> Notifications,
		[property: JsonPropertyName("notifications_total")] long NotificationsTotal,
		[property: JsonPropertyName("links")] NotificationsListResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record NotificationsListResponseLinks(
	[property: JsonPropertyName("read")] string Read,
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
);

	public sealed record NotificationsGetResponse(
		[property: JsonPropertyName("notification_id")] long NotificationId,
		[property: JsonPropertyName("notification")] Resp_NotificationModel Notification,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record NotificationsReadBody
	{
		[JsonPropertyName("notification_id")]
		public long? NotificationId { get; init; }
	}

	public sealed record NotificationsReadResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);
}

// ─── OAuthApi Types ────────────────────────────────────────

public static class OAuthApiTypes
{
	[JsonDerivedType(typeof(OAuthTokenBodyClientCredentials), "client_credentials")]
	[JsonDerivedType(typeof(OAuthTokenBodyAuthorizationCode), "authorization_code")]
	[JsonDerivedType(typeof(OAuthTokenBodyRefreshToken), "refresh_token")]
	[JsonDerivedType(typeof(OAuthTokenBodyPassword), "password")]
	public abstract record OAuthTokenBody;

	public sealed record OAuthTokenBodyClientCredentials : OAuthTokenBody
	{
		[JsonPropertyName("grant_type")]
		public string GrantType => "client_credentials";
		[JsonPropertyName("client_id")]
		public required string ClientId { get; init; }
		[JsonPropertyName("client_secret")]
		public required string ClientSecret { get; init; }
		[JsonPropertyName("scope")]
		public required JsonElement Scope { get; init; }
	}
	public sealed record OAuthTokenBodyAuthorizationCode : OAuthTokenBody
	{
		[JsonPropertyName("grant_type")]
		public string GrantType => "authorization_code";
		[JsonPropertyName("code")]
		public required string Code { get; init; }
		[JsonPropertyName("client_id")]
		public required string ClientId { get; init; }
		[JsonPropertyName("client_secret")]
		public required string ClientSecret { get; init; }
		[JsonPropertyName("redirect_uri")]
		public required string RedirectUri { get; init; }
		[JsonPropertyName("scope")]
		public required JsonElement Scope { get; init; }
	}
	public sealed record OAuthTokenBodyRefreshToken : OAuthTokenBody
	{
		[JsonPropertyName("grant_type")]
		public string GrantType => "refresh_token";
		[JsonPropertyName("refresh_token")]
		public required string RefreshToken { get; init; }
		[JsonPropertyName("client_id")]
		public required string ClientId { get; init; }
		[JsonPropertyName("client_secret")]
		public required string ClientSecret { get; init; }
	}
	public sealed record OAuthTokenBodyPassword : OAuthTokenBody
	{
		[JsonPropertyName("grant_type")]
		public string GrantType => "password";
		[JsonPropertyName("username")]
		public required string Username { get; init; }
		[JsonPropertyName("password")]
		public required string Password { get; init; }
		[JsonPropertyName("client_id")]
		public required string ClientId { get; init; }
		[JsonPropertyName("client_secret")]
		public required string ClientSecret { get; init; }
		[JsonPropertyName("scope")]
		public required JsonElement Scope { get; init; }
	}

	public sealed record OAuthTokenResponse(
		[property: JsonPropertyName("access_token")] string AccessToken,
		[property: JsonPropertyName("token_type")] string TokenType,
		[property: JsonPropertyName("expires_in")] long ExpiresIn,
		[property: JsonPropertyName("refresh_token")] string? RefreshToken,
		[property: JsonPropertyName("scope")] string? Scope
	);
}

// ─── PagesApi Types ────────────────────────────────────────

public static class PagesApiTypes
{
	public sealed record PagesListParams
	{
		[JsonPropertyName("parent_page_id")]
		public long? ParentPageId { get; init; }
		[JsonPropertyName("order")]
		public CategoriesOrder? Order { get; init; }
	}

	public sealed record PagesListResponse(
		[property: JsonPropertyName("pages")] List<PagesListResponsePages> Pages,
		[property: JsonPropertyName("pages_total")] long PagesTotal,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PagesListResponsePagesLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-pages")] string SubPages
);

	public sealed record PagesListResponsePagesPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete
);

	public sealed record PagesListResponsePages(
	[property: JsonPropertyName("page_id")] long PageId,
	[property: JsonPropertyName("page_title")] string PageTitle,
	[property: JsonPropertyName("page_description")] string PageDescription,
	[property: JsonPropertyName("links")] PagesListResponsePagesLinks Links,
	[property: JsonPropertyName("permissions")] PagesListResponsePagesPermissions Permissions
);

	public sealed record PagesGetResponse(
		[property: JsonPropertyName("page")] PagesGetResponsePage Page,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PagesGetResponsePageLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-pages")] string SubPages
);

	public sealed record PagesGetResponsePagePermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete
);

	public sealed record PagesGetResponsePage(
	[property: JsonPropertyName("page_id")] long PageId,
	[property: JsonPropertyName("page_title")] string PageTitle,
	[property: JsonPropertyName("page_description")] string PageDescription,
	[property: JsonPropertyName("page_view_count")] long PageViewCount,
	[property: JsonPropertyName("links")] PagesGetResponsePageLinks Links,
	[property: JsonPropertyName("permissions")] PagesGetResponsePagePermissions Permissions,
	[property: JsonPropertyName("page_html")] string PageHtml
);
}

// ─── PostsApi Types ────────────────────────────────────────

public static class PostsApiTypes
{
	public sealed record PostsListParams
	{
		[JsonPropertyName("thread_id")]
		public long? ThreadId { get; init; }
		[JsonPropertyName("page_of_post_id")]
		public long? PageOfPostId { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		[JsonPropertyName("order")]
		public PostsOrder? Order { get; init; }
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
		public long? ThreadId { get; init; }
		[JsonPropertyName("quote_post_id")]
		public long? QuotePostId { get; init; }
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
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record PostsLikesResponse(
		[property: JsonPropertyName("users")] List<PostsLikesResponseUsers> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PostsLikesResponseUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username
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
		public long? PostId { get; init; }
		[JsonPropertyName("before")]
		public long? Before { get; init; }
		[JsonPropertyName("before_comment")]
		public long? BeforeComment { get; init; }
	}

	public sealed record PostsCommentsGetResponse(
		[property: JsonPropertyName("comments")] List<Resp_PostCommentModel> Comments,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PostsCommentsCreateBody
	{
		[JsonPropertyName("post_id")]
		public required long? PostId { get; init; }
		[JsonPropertyName("comment_body")]
		public required string CommentBody { get; init; }
	}

	public sealed record PostsCommentsCreateResponse(
		[property: JsonPropertyName("comment")] PostsCommentsCreateResponseComment Comment,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PostsCommentsCreateResponseCommentLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("post")] string Post,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record PostsCommentsCreateResponseCommentPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report
);

	public sealed record PostsCommentsCreateResponseComment(
	[property: JsonPropertyName("post_comment_id")] long PostCommentId,
	[property: JsonPropertyName("post_id")] long PostId,
	[property: JsonPropertyName("thread_id")] long ThreadId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("poster_username_html")] string PosterUsernameHtml,
	[property: JsonPropertyName("post_comment_body")] string PostCommentBody,
	[property: JsonPropertyName("post_comment_body_html")] string PostCommentBodyHtml,
	[property: JsonPropertyName("post_comment_body_plain_text")] string PostCommentBodyPlainText,
	[property: JsonPropertyName("post_comment_like_count")] long PostCommentLikeCount,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_comment_is_published")] bool PostCommentIsPublished,
	[property: JsonPropertyName("post_comment_is_deleted")] bool PostCommentIsDeleted,
	[property: JsonPropertyName("post_comment_update_date")] long PostCommentUpdateDate,
	[property: JsonPropertyName("links")] PostsCommentsCreateResponseCommentLinks Links,
	[property: JsonPropertyName("permissions")] PostsCommentsCreateResponseCommentPermissions Permissions
);

	public sealed record PostsCommentsEditBody
	{
		[JsonPropertyName("post_comment_id")]
		public required long? PostCommentId { get; init; }
		[JsonPropertyName("comment_body")]
		public required string CommentBody { get; init; }
	}

	public sealed record PostsCommentsEditResponse(
		[property: JsonPropertyName("comment")] PostsCommentsEditResponseComment Comment,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PostsCommentsEditResponseCommentLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("post")] string Post,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record PostsCommentsEditResponseCommentPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report
);

	public sealed record PostsCommentsEditResponseComment(
	[property: JsonPropertyName("post_comment_id")] long PostCommentId,
	[property: JsonPropertyName("post_id")] long PostId,
	[property: JsonPropertyName("thread_id")] long ThreadId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("poster_username_html")] string PosterUsernameHtml,
	[property: JsonPropertyName("post_comment_body")] string PostCommentBody,
	[property: JsonPropertyName("post_comment_body_html")] string PostCommentBodyHtml,
	[property: JsonPropertyName("post_comment_body_plain_text")] string PostCommentBodyPlainText,
	[property: JsonPropertyName("post_comment_like_count")] long PostCommentLikeCount,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_comment_is_published")] bool PostCommentIsPublished,
	[property: JsonPropertyName("post_comment_is_deleted")] bool PostCommentIsDeleted,
	[property: JsonPropertyName("post_comment_update_date")] long PostCommentUpdateDate,
	[property: JsonPropertyName("links")] PostsCommentsEditResponseCommentLinks Links,
	[property: JsonPropertyName("permissions")] PostsCommentsEditResponseCommentPermissions Permissions
);

	public sealed record PostsCommentsDeleteBody
	{
		[JsonPropertyName("post_comment_id")]
		public required long? PostCommentId { get; init; }
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
		public required long? PostCommentId { get; init; }
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}

	public sealed record PostsCommentsReportResponse(
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
		public long? PostsUserId { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		[JsonPropertyName("fields_include")]
		public JsonElement? FieldsInclude { get; init; }
	}

	public sealed record ProfilePostsListResponse(
		[property: JsonPropertyName("profile_posts")] List<Resp_ProfilePostModel> ProfilePosts,
		[property: JsonPropertyName("totalProfilePosts")] long TotalProfilePosts,
		[property: JsonPropertyName("canPostOnProfile")] bool CanPostOnProfile,
		[property: JsonPropertyName("links")] ProfilePostsListResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsListResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
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
		[property: JsonPropertyName("profile_post")] ProfilePostsEditResponseProfilePost ProfilePost,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsEditResponseProfilePostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("timeline")] string Timeline,
	[property: JsonPropertyName("timeline_user")] string TimelineUser,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("comments")] string Comments,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record ProfilePostsEditResponseProfilePostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("comment")] bool Comment,
	[property: JsonPropertyName("report")] bool Report
);

	public sealed record ProfilePostsEditResponseProfilePost(
	[property: JsonPropertyName("profile_post_id")] long ProfilePostId,
	[property: JsonPropertyName("timeline_user_id")] long TimelineUserId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("poster_username_html")] string PosterUsernameHtml,
	[property: JsonPropertyName("post_create_date")] long PostCreateDate,
	[property: JsonPropertyName("post_body")] string PostBody,
	[property: JsonPropertyName("post_like_count")] long PostLikeCount,
	[property: JsonPropertyName("post_comment_count")] long PostCommentCount,
	[property: JsonPropertyName("timeline_username")] string TimelineUsername,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("links")] ProfilePostsEditResponseProfilePostLinks Links,
	[property: JsonPropertyName("permissions")] ProfilePostsEditResponseProfilePostPermissions Permissions
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
		public required Lolzteam.Api.Runtime.StringOrLong UserId { get; init; }
		[JsonPropertyName("post_body")]
		public required string PostBody { get; init; }
	}

	public sealed record ProfilePostsCreateResponse(
		[property: JsonPropertyName("profile_post")] ProfilePostsCreateResponseProfilePost ProfilePost,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsCreateResponseProfilePostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("timeline")] string Timeline,
	[property: JsonPropertyName("timeline_user")] string TimelineUser,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("comments")] string Comments,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record ProfilePostsCreateResponseProfilePostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("comment")] bool Comment,
	[property: JsonPropertyName("report")] bool Report
);

	public sealed record ProfilePostsCreateResponseProfilePost(
	[property: JsonPropertyName("profile_post_id")] long ProfilePostId,
	[property: JsonPropertyName("timeline_user_id")] long TimelineUserId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("poster_username_html")] string PosterUsernameHtml,
	[property: JsonPropertyName("post_create_date")] long PostCreateDate,
	[property: JsonPropertyName("post_body")] string PostBody,
	[property: JsonPropertyName("post_like_count")] long PostLikeCount,
	[property: JsonPropertyName("post_comment_count")] long PostCommentCount,
	[property: JsonPropertyName("timeline_username")] string TimelineUsername,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("links")] ProfilePostsCreateResponseProfilePostLinks Links,
	[property: JsonPropertyName("permissions")] ProfilePostsCreateResponseProfilePostPermissions Permissions
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
		[property: JsonPropertyName("users")] List<ProfilePostsLikesResponseUsers> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsLikesResponseUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username
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
		public long? ProfilePostId { get; init; }
		[JsonPropertyName("before")]
		public long? Before { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record ProfilePostsCommentsListResponse(
		[property: JsonPropertyName("comments")] List<Resp_ProfilePostCommentModel> Comments,
		[property: JsonPropertyName("comments_total")] long CommentsTotal,
		[property: JsonPropertyName("profile_post")] ProfilePostsCommentsListResponseProfilePost ProfilePost,
		[property: JsonPropertyName("timeline_user")] Resp_UserModel TimelineUser,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsCommentsListResponseProfilePostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("timeline")] string Timeline,
	[property: JsonPropertyName("timeline_user")] string TimelineUser,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("comments")] string Comments,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record ProfilePostsCommentsListResponseProfilePostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("comment")] bool Comment,
	[property: JsonPropertyName("report")] bool Report
);

	public sealed record ProfilePostsCommentsListResponseProfilePost(
	[property: JsonPropertyName("profile_post_id")] long ProfilePostId,
	[property: JsonPropertyName("timeline_user_id")] long TimelineUserId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("poster_username_html")] string PosterUsernameHtml,
	[property: JsonPropertyName("post_create_date")] long PostCreateDate,
	[property: JsonPropertyName("post_body")] string PostBody,
	[property: JsonPropertyName("post_like_count")] long PostLikeCount,
	[property: JsonPropertyName("post_comment_count")] long PostCommentCount,
	[property: JsonPropertyName("timeline_username")] string TimelineUsername,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("links")] ProfilePostsCommentsListResponseProfilePostLinks Links,
	[property: JsonPropertyName("permissions")] ProfilePostsCommentsListResponseProfilePostPermissions Permissions
);

	public sealed record ProfilePostsCommentsCreateBody
	{
		[JsonPropertyName("profile_post_id")]
		public required long? ProfilePostId { get; init; }
		[JsonPropertyName("comment_body")]
		public required string CommentBody { get; init; }
	}

	public sealed record ProfilePostsCommentsCreateResponse(
		[property: JsonPropertyName("comment")] ProfilePostsCommentsCreateResponseComment Comment,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsCommentsCreateResponseCommentLinks(
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("profile_post")] string ProfilePost,
	[property: JsonPropertyName("timeline")] string Timeline,
	[property: JsonPropertyName("timeline_user")] string TimelineUser,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record ProfilePostsCommentsCreateResponseCommentPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete
);

	public sealed record ProfilePostsCommentsCreateResponseComment(
	[property: JsonPropertyName("comment_id")] long CommentId,
	[property: JsonPropertyName("profile_post_id")] long ProfilePostId,
	[property: JsonPropertyName("comment_user_id")] long CommentUserId,
	[property: JsonPropertyName("comment_username")] string CommentUsername,
	[property: JsonPropertyName("comment_username_html")] string CommentUsernameHtml,
	[property: JsonPropertyName("comment_create_date")] long CommentCreateDate,
	[property: JsonPropertyName("comment_body")] string CommentBody,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("timeline_user_id")] long TimelineUserId,
	[property: JsonPropertyName("links")] ProfilePostsCommentsCreateResponseCommentLinks Links,
	[property: JsonPropertyName("permissions")] ProfilePostsCommentsCreateResponseCommentPermissions Permissions
);

	public sealed record ProfilePostsCommentsEditBody
	{
		[JsonPropertyName("comment_id")]
		public required long? CommentId { get; init; }
		[JsonPropertyName("comment_body")]
		public required string CommentBody { get; init; }
	}

	public sealed record ProfilePostsCommentsEditResponse(
		[property: JsonPropertyName("comment")] ProfilePostsCommentsEditResponseComment Comment,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfilePostsCommentsEditResponseCommentLinks(
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("profile_post")] string ProfilePost,
	[property: JsonPropertyName("timeline")] string Timeline,
	[property: JsonPropertyName("timeline_user")] string TimelineUser,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record ProfilePostsCommentsEditResponseCommentPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete
);

	public sealed record ProfilePostsCommentsEditResponseComment(
	[property: JsonPropertyName("comment_id")] long CommentId,
	[property: JsonPropertyName("profile_post_id")] long ProfilePostId,
	[property: JsonPropertyName("comment_user_id")] long CommentUserId,
	[property: JsonPropertyName("comment_username")] string CommentUsername,
	[property: JsonPropertyName("comment_username_html")] string CommentUsernameHtml,
	[property: JsonPropertyName("comment_create_date")] long CommentCreateDate,
	[property: JsonPropertyName("comment_body")] string CommentBody,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("timeline_user_id")] long TimelineUserId,
	[property: JsonPropertyName("links")] ProfilePostsCommentsEditResponseCommentLinks Links,
	[property: JsonPropertyName("permissions")] ProfilePostsCommentsEditResponseCommentPermissions Permissions
);

	public sealed record ProfilePostsCommentsDeleteBody
	{
		[JsonPropertyName("comment_id")]
		public required long? CommentId { get; init; }
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
		public long? ForumId { get; init; }
		[JsonPropertyName("user_id")]
		public Lolzteam.Api.Runtime.StringOrLong? UserId { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record SearchAllResponse(
		[property: JsonPropertyName("data")] List<SearchAllResponseData> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("users")] List<Resp_UserModel> Users,
		[property: JsonPropertyName("links")] SearchAllResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record SearchAllResponseDataFirstPostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record SearchAllResponseDataFirstPostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report
);

	public sealed record SearchAllResponseDataFirstPost(
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
	[property: JsonPropertyName("post_is_liked")] bool PostIsLiked,
	[property: JsonPropertyName("links")] SearchAllResponseDataFirstPostLinks Links,
	[property: JsonPropertyName("permissions")] SearchAllResponseDataFirstPostPermissions Permissions,
	[property: JsonPropertyName("thread_is_deleted")] bool ThreadIsDeleted
);

	public sealed record SearchAllResponseDataLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("forum")] string Forum,
	[property: JsonPropertyName("posts")] string Posts,
	[property: JsonPropertyName("first_poster")] string FirstPoster,
	[property: JsonPropertyName("first_poster_avatar")] string FirstPosterAvatar,
	[property: JsonPropertyName("first_post")] string FirstPost,
	[property: JsonPropertyName("last_poster")] string LastPoster,
	[property: JsonPropertyName("last_post")] string LastPost
);

	public sealed record SearchAllResponseDataPermissionsBump(
	[property: JsonPropertyName("can")] bool Can,
	[property: JsonPropertyName("available_count")] long AvailableCount,
	[property: JsonPropertyName("error")] JsonElement Error,
	[property: JsonPropertyName("next_available_time")] JsonElement NextAvailableTime
);

	public sealed record SearchAllResponseDataPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("bump")] SearchAllResponseDataPermissionsBump Bump
);

	public sealed record SearchAllResponseDataForumLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
);

	public sealed record SearchAllResponseDataForumPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
);

	public sealed record SearchAllResponseDataForum(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("parent_node_id")] long ParentNodeId,
	[property: JsonPropertyName("forum_prefixes")] List<JsonElement> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] SearchAllResponseDataForumLinks Links,
	[property: JsonPropertyName("permissions")] SearchAllResponseDataForumPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
);

	public sealed record SearchAllResponseDataLastPostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record SearchAllResponseDataLastPostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report
);

	public sealed record SearchAllResponseDataLastPost(
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
	[property: JsonPropertyName("post_is_liked")] bool PostIsLiked,
	[property: JsonPropertyName("links")] SearchAllResponseDataLastPostLinks Links,
	[property: JsonPropertyName("permissions")] SearchAllResponseDataLastPostPermissions Permissions,
	[property: JsonPropertyName("thread_is_deleted")] bool ThreadIsDeleted
);

	public sealed record SearchAllResponseData(
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] string ContentId,
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
	[property: JsonPropertyName("first_post")] SearchAllResponseDataFirstPost FirstPost,
	[property: JsonPropertyName("thread_prefixes")] List<JsonElement> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] List<JsonElement> ThreadTags,
	[property: JsonPropertyName("links")] SearchAllResponseDataLinks Links,
	[property: JsonPropertyName("permissions")] SearchAllResponseDataPermissions Permissions,
	[property: JsonPropertyName("node_title")] string NodeTitle,
	[property: JsonPropertyName("forum")] SearchAllResponseDataForum Forum,
	[property: JsonPropertyName("last_post")] SearchAllResponseDataLastPost LastPost
);

	public sealed record SearchAllResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
);

	public sealed record SearchThreadsBody
	{
		[JsonPropertyName("q")]
		public string? Q { get; init; }
		[JsonPropertyName("tag")]
		public string? Tag { get; init; }
		[JsonPropertyName("forum_id")]
		public long? ForumId { get; init; }
		[JsonPropertyName("user_id")]
		public Lolzteam.Api.Runtime.StringOrLong? UserId { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		[JsonPropertyName("data_limit")]
		public long? DataLimit { get; init; }
	}

	public sealed record SearchThreadsResponse(
		[property: JsonPropertyName("data")] List<SearchThreadsResponseData> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("links")] SearchThreadsResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record SearchThreadsResponseDataFirstPostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("attachments")] string Attachments,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record SearchThreadsResponseDataFirstPostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment
);

	public sealed record SearchThreadsResponseDataFirstPost(
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
	[property: JsonPropertyName("post_attachment_count")] long PostAttachmentCount,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("links")] SearchThreadsResponseDataFirstPostLinks Links,
	[property: JsonPropertyName("permissions")] SearchThreadsResponseDataFirstPostPermissions Permissions
);

	public sealed record SearchThreadsResponseDataLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("forum")] string Forum,
	[property: JsonPropertyName("posts")] string Posts,
	[property: JsonPropertyName("first_poster")] string FirstPoster,
	[property: JsonPropertyName("first_poster_avatar")] string FirstPosterAvatar,
	[property: JsonPropertyName("first_post")] string FirstPost,
	[property: JsonPropertyName("last_post")] string LastPost
);

	public sealed record SearchThreadsResponseDataPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("edit")] bool Edit
);

	public sealed record SearchThreadsResponseDataForumLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
);

	public sealed record SearchThreadsResponseDataForumPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
);

	public sealed record SearchThreadsResponseDataForum(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<JsonElement> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] SearchThreadsResponseDataForumLinks Links,
	[property: JsonPropertyName("permissions")] SearchThreadsResponseDataForumPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
);

	public sealed record SearchThreadsResponseData(
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
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
	[property: JsonPropertyName("thread_is_followed")] bool ThreadIsFollowed,
	[property: JsonPropertyName("first_post")] SearchThreadsResponseDataFirstPost FirstPost,
	[property: JsonPropertyName("thread_prefixes")] List<JsonElement> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] List<JsonElement> ThreadTags,
	[property: JsonPropertyName("links")] SearchThreadsResponseDataLinks Links,
	[property: JsonPropertyName("permissions")] SearchThreadsResponseDataPermissions Permissions,
	[property: JsonPropertyName("forum")] SearchThreadsResponseDataForum Forum
);

	public sealed record SearchThreadsResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
);

	public sealed record SearchPostsBody
	{
		[JsonPropertyName("q")]
		public string? Q { get; init; }
		[JsonPropertyName("tag")]
		public string? Tag { get; init; }
		[JsonPropertyName("forum_id")]
		public long? ForumId { get; init; }
		[JsonPropertyName("user_id")]
		public Lolzteam.Api.Runtime.StringOrLong? UserId { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		[JsonPropertyName("data_limit")]
		public long? DataLimit { get; init; }
	}

	public sealed record SearchPostsResponse(
		[property: JsonPropertyName("data")] List<SearchPostsResponseData> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("links")] SearchPostsResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record SearchPostsResponseDataFirstPostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("attachments")] string Attachments,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record SearchPostsResponseDataFirstPostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment
);

	public sealed record SearchPostsResponseDataFirstPost(
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
	[property: JsonPropertyName("post_attachment_count")] long PostAttachmentCount,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("links")] SearchPostsResponseDataFirstPostLinks Links,
	[property: JsonPropertyName("permissions")] SearchPostsResponseDataFirstPostPermissions Permissions
);

	public sealed record SearchPostsResponseDataLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("forum")] string Forum,
	[property: JsonPropertyName("posts")] string Posts,
	[property: JsonPropertyName("first_poster")] string FirstPoster,
	[property: JsonPropertyName("first_poster_avatar")] string FirstPosterAvatar,
	[property: JsonPropertyName("first_post")] string FirstPost,
	[property: JsonPropertyName("last_post")] string LastPost
);

	public sealed record SearchPostsResponseDataPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("edit")] bool Edit
);

	public sealed record SearchPostsResponseDataForumLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
);

	public sealed record SearchPostsResponseDataForumPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
);

	public sealed record SearchPostsResponseDataForum(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<JsonElement> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] SearchPostsResponseDataForumLinks Links,
	[property: JsonPropertyName("permissions")] SearchPostsResponseDataForumPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
);

	public sealed record SearchPostsResponseData(
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
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
	[property: JsonPropertyName("thread_is_followed")] bool ThreadIsFollowed,
	[property: JsonPropertyName("first_post")] SearchPostsResponseDataFirstPost FirstPost,
	[property: JsonPropertyName("thread_prefixes")] List<JsonElement> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] List<JsonElement> ThreadTags,
	[property: JsonPropertyName("links")] SearchPostsResponseDataLinks Links,
	[property: JsonPropertyName("permissions")] SearchPostsResponseDataPermissions Permissions,
	[property: JsonPropertyName("forum")] SearchPostsResponseDataForum Forum
);

	public sealed record SearchPostsResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
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
		public long? UserId { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record SearchProfilePostsResponse(
		[property: JsonPropertyName("data")] List<SearchProfilePostsResponseData> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("links")] SearchProfilePostsResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record SearchProfilePostsResponseDataLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("timeline")] string Timeline,
	[property: JsonPropertyName("timeline_user")] string TimelineUser,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("comments")] string Comments,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record SearchProfilePostsResponseDataPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("comment")] bool Comment,
	[property: JsonPropertyName("report")] bool Report
);

	public sealed record SearchProfilePostsResponseData(
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
	[property: JsonPropertyName("profile_post_id")] long ProfilePostId,
	[property: JsonPropertyName("timeline_user_id")] long TimelineUserId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("poster_username_html")] string PosterUsernameHtml,
	[property: JsonPropertyName("post_create_date")] long PostCreateDate,
	[property: JsonPropertyName("post_body")] string PostBody,
	[property: JsonPropertyName("post_like_count")] long PostLikeCount,
	[property: JsonPropertyName("post_comment_count")] long PostCommentCount,
	[property: JsonPropertyName("timeline_username")] string TimelineUsername,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("links")] SearchProfilePostsResponseDataLinks Links,
	[property: JsonPropertyName("permissions")] SearchProfilePostsResponseDataPermissions Permissions,
	[property: JsonPropertyName("timeline_user")] Resp_UserModel TimelineUser
);

	public sealed record SearchProfilePostsResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
);

	public sealed record SearchTaggedBody
	{
		[JsonPropertyName("tag")]
		public string? Tag { get; init; }
		[JsonPropertyName("tags")]
		public List<string>? Tags { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record SearchTaggedResponse(
		[property: JsonPropertyName("data")] List<SearchTaggedResponseData> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("search_tags")] SearchTaggedResponseSearchTags SearchTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record SearchTaggedResponseDataFirstPostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("attachments")] string Attachments,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record SearchTaggedResponseDataFirstPostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment
);

	public sealed record SearchTaggedResponseDataFirstPost(
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
	[property: JsonPropertyName("post_attachment_count")] long PostAttachmentCount,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("links")] SearchTaggedResponseDataFirstPostLinks Links,
	[property: JsonPropertyName("permissions")] SearchTaggedResponseDataFirstPostPermissions Permissions
);

	public sealed record SearchTaggedResponseDataThreadTags(
	[property: JsonPropertyName("160179")] string _160179
);

	public sealed record SearchTaggedResponseDataLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("forum")] string Forum,
	[property: JsonPropertyName("posts")] string Posts,
	[property: JsonPropertyName("first_poster")] string FirstPoster,
	[property: JsonPropertyName("first_poster_avatar")] string FirstPosterAvatar,
	[property: JsonPropertyName("first_post")] string FirstPost,
	[property: JsonPropertyName("last_post")] string LastPost
);

	public sealed record SearchTaggedResponseDataPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("edit_title")] bool EditTitle,
	[property: JsonPropertyName("edit_tags")] bool EditTags
);

	public sealed record SearchTaggedResponseDataForumForumPrefixesGroupPrefixes(
	[property: JsonPropertyName("prefix_id")] long PrefixId,
	[property: JsonPropertyName("prefix_title")] string PrefixTitle
);

	public sealed record SearchTaggedResponseDataForumForumPrefixes(
	[property: JsonPropertyName("group_title")] string GroupTitle,
	[property: JsonPropertyName("group_prefixes")] List<SearchTaggedResponseDataForumForumPrefixesGroupPrefixes> GroupPrefixes
);

	public sealed record SearchTaggedResponseDataForumLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
);

	public sealed record SearchTaggedResponseDataForumPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
);

	public sealed record SearchTaggedResponseDataForum(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<SearchTaggedResponseDataForumForumPrefixes> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] SearchTaggedResponseDataForumLinks Links,
	[property: JsonPropertyName("permissions")] SearchTaggedResponseDataForumPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
);

	public sealed record SearchTaggedResponseData(
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
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
	[property: JsonPropertyName("thread_is_followed")] bool ThreadIsFollowed,
	[property: JsonPropertyName("first_post")] SearchTaggedResponseDataFirstPost FirstPost,
	[property: JsonPropertyName("thread_prefixes")] List<JsonElement> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] SearchTaggedResponseDataThreadTags ThreadTags,
	[property: JsonPropertyName("links")] SearchTaggedResponseDataLinks Links,
	[property: JsonPropertyName("permissions")] SearchTaggedResponseDataPermissions Permissions,
	[property: JsonPropertyName("forum")] SearchTaggedResponseDataForum Forum
);

	public sealed record SearchTaggedResponseSearchTags(
	[property: JsonPropertyName("160179")] string _160179
);

	public sealed record SearchResultsParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record SearchResultsResponse(
		[property: JsonPropertyName("data")] List<SearchResultsResponseData> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("search_tags")] SearchResultsResponseSearchTags SearchTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record SearchResultsResponseDataFirstPostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("attachments")] string Attachments,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record SearchResultsResponseDataFirstPostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment
);

	public sealed record SearchResultsResponseDataFirstPost(
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
	[property: JsonPropertyName("post_attachment_count")] long PostAttachmentCount,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("links")] SearchResultsResponseDataFirstPostLinks Links,
	[property: JsonPropertyName("permissions")] SearchResultsResponseDataFirstPostPermissions Permissions
);

	public sealed record SearchResultsResponseDataThreadTags(
	[property: JsonPropertyName("160179")] string _160179
);

	public sealed record SearchResultsResponseDataLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("forum")] string Forum,
	[property: JsonPropertyName("posts")] string Posts,
	[property: JsonPropertyName("first_poster")] string FirstPoster,
	[property: JsonPropertyName("first_poster_avatar")] string FirstPosterAvatar,
	[property: JsonPropertyName("first_post")] string FirstPost,
	[property: JsonPropertyName("last_post")] string LastPost
);

	public sealed record SearchResultsResponseDataPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("edit_title")] bool EditTitle,
	[property: JsonPropertyName("edit_tags")] bool EditTags
);

	public sealed record SearchResultsResponseDataForumForumPrefixesGroupPrefixes(
	[property: JsonPropertyName("prefix_id")] long PrefixId,
	[property: JsonPropertyName("prefix_title")] string PrefixTitle
);

	public sealed record SearchResultsResponseDataForumForumPrefixes(
	[property: JsonPropertyName("group_title")] string GroupTitle,
	[property: JsonPropertyName("group_prefixes")] List<SearchResultsResponseDataForumForumPrefixesGroupPrefixes> GroupPrefixes
);

	public sealed record SearchResultsResponseDataForumLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
);

	public sealed record SearchResultsResponseDataForumPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
);

	public sealed record SearchResultsResponseDataForum(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<SearchResultsResponseDataForumForumPrefixes> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] SearchResultsResponseDataForumLinks Links,
	[property: JsonPropertyName("permissions")] SearchResultsResponseDataForumPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
);

	public sealed record SearchResultsResponseData(
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
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
	[property: JsonPropertyName("thread_is_followed")] bool ThreadIsFollowed,
	[property: JsonPropertyName("first_post")] SearchResultsResponseDataFirstPost FirstPost,
	[property: JsonPropertyName("thread_prefixes")] List<JsonElement> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] SearchResultsResponseDataThreadTags ThreadTags,
	[property: JsonPropertyName("links")] SearchResultsResponseDataLinks Links,
	[property: JsonPropertyName("permissions")] SearchResultsResponseDataPermissions Permissions,
	[property: JsonPropertyName("forum")] SearchResultsResponseDataForum Forum
);

	public sealed record SearchResultsResponseSearchTags(
	[property: JsonPropertyName("160179")] string _160179
);
}

// ─── TagsApi Types ────────────────────────────────────────

public static class TagsApiTypes
{
	public sealed record TagsPopularResponse(
		[property: JsonPropertyName("tags")] TagsPopularResponseTags Tags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record TagsPopularResponseTags(
	[property: JsonPropertyName("000")] string _000
);

	public sealed record TagsListParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record TagsListResponse(
		[property: JsonPropertyName("tags")] TagsListResponseTags Tags,
		[property: JsonPropertyName("tags_total")] long TagsTotal,
		[property: JsonPropertyName("links")] TagsListResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record TagsListResponseTags(
	[property: JsonPropertyName("1")] string _1,
	[property: JsonPropertyName("2")] string _2,
	[property: JsonPropertyName("3")] string _3,
	[property: JsonPropertyName("4")] string _4,
	[property: JsonPropertyName("5")] string _5,
	[property: JsonPropertyName("6")] string _6,
	[property: JsonPropertyName("7")] string _7,
	[property: JsonPropertyName("8")] string _8,
	[property: JsonPropertyName("9")] string _9,
	[property: JsonPropertyName("10")] string _10,
	[property: JsonPropertyName("11")] string _11,
	[property: JsonPropertyName("12")] string _12,
	[property: JsonPropertyName("14")] string _14,
	[property: JsonPropertyName("15")] string _15,
	[property: JsonPropertyName("16")] string _16,
	[property: JsonPropertyName("17")] string _17,
	[property: JsonPropertyName("18")] string _18,
	[property: JsonPropertyName("19")] string _19,
	[property: JsonPropertyName("20")] string _20
);

	public sealed record TagsListResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
);

	public sealed record TagsGetParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record TagsGetResponse(
		[property: JsonPropertyName("tag")] TagsGetResponseTag Tag,
		[property: JsonPropertyName("tagged")] List<TagsGetResponseTagged> Tagged,
		[property: JsonPropertyName("tagged_total")] long TaggedTotal,
		[property: JsonPropertyName("links")] TagsGetResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record TagsGetResponseTagLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail
);

	public sealed record TagsGetResponseTag(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("tag_text")] string TagText,
	[property: JsonPropertyName("tag_use_count")] long TagUseCount,
	[property: JsonPropertyName("links")] TagsGetResponseTagLinks Links
);

	public sealed record TagsGetResponseTaggedFirstPostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("attachments")] string Attachments,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record TagsGetResponseTaggedFirstPostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment
);

	public sealed record TagsGetResponseTaggedFirstPost(
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
	[property: JsonPropertyName("post_attachment_count")] long PostAttachmentCount,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("links")] TagsGetResponseTaggedFirstPostLinks Links,
	[property: JsonPropertyName("permissions")] TagsGetResponseTaggedFirstPostPermissions Permissions
);

	public sealed record TagsGetResponseTaggedThreadPrefixes(
	[property: JsonPropertyName("prefix_id")] long PrefixId,
	[property: JsonPropertyName("prefix_title")] string PrefixTitle
);

	public sealed record TagsGetResponseTaggedThreadTags(
	[property: JsonPropertyName("1")] string _1,
	[property: JsonPropertyName("654")] string _654
);

	public sealed record TagsGetResponseTaggedLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("forum")] string Forum,
	[property: JsonPropertyName("posts")] string Posts,
	[property: JsonPropertyName("first_poster")] string FirstPoster,
	[property: JsonPropertyName("first_poster_avatar")] string FirstPosterAvatar,
	[property: JsonPropertyName("first_post")] string FirstPost,
	[property: JsonPropertyName("last_poster")] string LastPoster,
	[property: JsonPropertyName("last_post")] string LastPost
);

	public sealed record TagsGetResponseTaggedPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("edit")] bool Edit
);

	public sealed record TagsGetResponseTaggedForumForumPrefixesGroupPrefixes(
	[property: JsonPropertyName("prefix_id")] long PrefixId,
	[property: JsonPropertyName("prefix_title")] string PrefixTitle
);

	public sealed record TagsGetResponseTaggedForumForumPrefixes(
	[property: JsonPropertyName("group_title")] string GroupTitle,
	[property: JsonPropertyName("group_prefixes")] List<TagsGetResponseTaggedForumForumPrefixesGroupPrefixes> GroupPrefixes
);

	public sealed record TagsGetResponseTaggedForumLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
);

	public sealed record TagsGetResponseTaggedForumPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
);

	public sealed record TagsGetResponseTaggedForum(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<TagsGetResponseTaggedForumForumPrefixes> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] TagsGetResponseTaggedForumLinks Links,
	[property: JsonPropertyName("permissions")] TagsGetResponseTaggedForumPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
);

	public sealed record TagsGetResponseTagged(
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
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
	[property: JsonPropertyName("thread_is_followed")] bool ThreadIsFollowed,
	[property: JsonPropertyName("first_post")] TagsGetResponseTaggedFirstPost FirstPost,
	[property: JsonPropertyName("thread_prefixes")] List<TagsGetResponseTaggedThreadPrefixes> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] TagsGetResponseTaggedThreadTags ThreadTags,
	[property: JsonPropertyName("links")] TagsGetResponseTaggedLinks Links,
	[property: JsonPropertyName("permissions")] TagsGetResponseTaggedPermissions Permissions,
	[property: JsonPropertyName("forum")] TagsGetResponseTaggedForum Forum
);

	public sealed record TagsGetResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
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

// ─── ThreadsApi Types ────────────────────────────────────────

public static class ThreadsApiTypes
{
	public sealed record ThreadsListParams
	{
		[JsonPropertyName("forum_id")]
		public long? ForumId { get; init; }
		[JsonPropertyName("tab")]
		public string? Tab { get; init; }
		[JsonPropertyName("state")]
		public State? State { get; init; }
		[JsonPropertyName("period")]
		public Period? Period { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("title_only")]
		public bool? TitleOnly { get; init; }
		[JsonPropertyName("creator_user_id")]
		public long? CreatorUserId { get; init; }
		[JsonPropertyName("sticky")]
		public bool? Sticky { get; init; }
		[JsonPropertyName("prefix_ids[]")]
		public List<long?>? PrefixIds { get; init; }
		[JsonPropertyName("prefix_ids_not[]")]
		public List<long?>? PrefixIdsNot { get; init; }
		[JsonPropertyName("thread_tag_id")]
		public long? ThreadTagId { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		[JsonPropertyName("order")]
		public ThreadsOrder? Order { get; init; }
		[JsonPropertyName("direction")]
		public Direction? Direction { get; init; }
		[JsonPropertyName("thread_create_date")]
		public long? ThreadCreateDate { get; init; }
		[JsonPropertyName("thread_update_date")]
		public long? ThreadUpdateDate { get; init; }
		[JsonPropertyName("fields_include")]
		public JsonElement? FieldsInclude { get; init; }
	}

	public sealed record ThreadsListResponse(
		[property: JsonPropertyName("threads")] List<Resp_ThreadModel> Threads,
		[property: JsonPropertyName("forum")] ThreadsListResponseForum Forum,
		[property: JsonPropertyName("threads_total")] long ThreadsTotal,
		[property: JsonPropertyName("links")] ThreadsListResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsListResponseForumLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
);

	public sealed record ThreadsListResponseForumPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
);

	public sealed record ThreadsListResponseForum(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<JsonElement> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] ThreadsListResponseForumLinks Links,
	[property: JsonPropertyName("permissions")] ThreadsListResponseForumPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
);

	public sealed record ThreadsListResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
);

	public sealed record ThreadsCreateBody
	{
		[JsonPropertyName("post_body")]
		public required string PostBody { get; init; }
		[JsonPropertyName("forum_id")]
		public required long? ForumId { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("title_en")]
		public string? TitleEn { get; init; }
		[JsonPropertyName("prefix_id")]
		public List<long?>? PrefixId { get; init; }
		[JsonPropertyName("tags")]
		public List<string>? Tags { get; init; }
		[JsonPropertyName("hide_contacts")]
		public bool? HideContacts { get; init; }
		[JsonPropertyName("allow_ask_hidden_content")]
		public bool? AllowAskHiddenContent { get; init; }
		/// <summary>Default: 2</summary>
		[JsonPropertyName("reply_group")]
		public ReplyGroup? ReplyGroup { get; init; }
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
		/// <summary>Default: by_finish_date</summary>
		[JsonPropertyName("contest_type")]
		public required ContestType ContestType { get; init; }
		[JsonPropertyName("length_value")]
		public long? LengthValue { get; init; }
		[JsonPropertyName("length_option")]
		public LengthOption? LengthOption { get; init; }
		[JsonPropertyName("prize_type")]
		public required PrizeType PrizeType { get; init; }
		[JsonPropertyName("count_winners")]
		public long? CountWinners { get; init; }
		[JsonPropertyName("prize_data_money")]
		public double? PrizeDataMoney { get; init; }
		[JsonPropertyName("is_money_places")]
		public bool? IsMoneyPlaces { get; init; }
		[JsonPropertyName("prize_data_places")]
		public List<double?>? PrizeDataPlaces { get; init; }
		[JsonPropertyName("prize_data_upgrade")]
		public PrizeDataUpgrade? PrizeDataUpgrade { get; init; }
		[JsonPropertyName("require_like_count")]
		public required long? RequireLikeCount { get; init; }
		[JsonPropertyName("require_total_like_count")]
		public required long? RequireTotalLikeCount { get; init; }
		[JsonPropertyName("secret_answer")]
		public string? SecretAnswer { get; init; }
		[JsonPropertyName("tags")]
		public List<string>? Tags { get; init; }
		/// <summary>Default: 2</summary>
		[JsonPropertyName("reply_group")]
		public ReplyGroup? ReplyGroup { get; init; }
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
		public long? AsMarketItemId { get; init; }
		[JsonPropertyName("as_data")]
		public string? AsData { get; init; }
		[JsonPropertyName("as_amount")]
		public required double? AsAmount { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("transfer_type")]
		public required TransferType TransferType { get; init; }
		[JsonPropertyName("pay_claim")]
		public PayClaim? PayClaim { get; init; }
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
		/// <summary>Default: 2</summary>
		[JsonPropertyName("reply_group")]
		public ReplyGroup? ReplyGroup { get; init; }
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
		public List<long?>? PrefixId { get; init; }
		[JsonPropertyName("tags")]
		public List<string>? Tags { get; init; }
		[JsonPropertyName("discussion_open")]
		public bool? DiscussionOpen { get; init; }
		[JsonPropertyName("hide_contacts")]
		public bool? HideContacts { get; init; }
		[JsonPropertyName("allow_ask_hidden_content")]
		public bool? AllowAskHiddenContent { get; init; }
		[JsonPropertyName("reply_group")]
		public ReplyGroup? ReplyGroup { get; init; }
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
		public List<long?>? PrefixId { get; init; }
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
		[property: JsonPropertyName("users")] List<ThreadsFollowersResponseUsers> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsFollowersResponseUsersFollow(
	[property: JsonPropertyName("alert")] bool Alert,
	[property: JsonPropertyName("email")] bool Email
);

	public sealed record ThreadsFollowersResponseUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("follow")] ThreadsFollowersResponseUsersFollow Follow
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
		[property: JsonPropertyName("threads")] List<ThreadsFollowedResponseThreads> Threads,
		[property: JsonPropertyName("threads_total")] long ThreadsTotal,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsFollowedResponseThreadsFirstPostLikeUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss
);

	public sealed record ThreadsFollowedResponseThreadsFirstPostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("attachments")] string Attachments,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record ThreadsFollowedResponseThreadsFirstPostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment
);

	public sealed record ThreadsFollowedResponseThreadsFirstPost(
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
	[property: JsonPropertyName("post_attachment_count")] long PostAttachmentCount,
	[property: JsonPropertyName("like_users")] List<ThreadsFollowedResponseThreadsFirstPostLikeUsers> LikeUsers,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("links")] ThreadsFollowedResponseThreadsFirstPostLinks Links,
	[property: JsonPropertyName("permissions")] ThreadsFollowedResponseThreadsFirstPostPermissions Permissions
);

	public sealed record ThreadsFollowedResponseThreadsThreadTags(
	[property: JsonPropertyName("1403")] string _1403,
	[property: JsonPropertyName("8176")] string _8176,
	[property: JsonPropertyName("38")] string _38,
	[property: JsonPropertyName("1953")] string _1953,
	[property: JsonPropertyName("523")] string _523
);

	public sealed record ThreadsFollowedResponseThreadsLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("forum")] string Forum,
	[property: JsonPropertyName("posts")] string Posts,
	[property: JsonPropertyName("first_poster")] string FirstPoster,
	[property: JsonPropertyName("first_poster_avatar")] string FirstPosterAvatar,
	[property: JsonPropertyName("first_post")] string FirstPost,
	[property: JsonPropertyName("last_post")] string LastPost
);

	public sealed record ThreadsFollowedResponseThreadsPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("edit_title")] bool EditTitle,
	[property: JsonPropertyName("edit_tags")] bool EditTags
);

	public sealed record ThreadsFollowedResponseThreadsForumLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
);

	public sealed record ThreadsFollowedResponseThreadsForumPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
);

	public sealed record ThreadsFollowedResponseThreadsForum(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<JsonElement> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] ThreadsFollowedResponseThreadsForumLinks Links,
	[property: JsonPropertyName("permissions")] ThreadsFollowedResponseThreadsForumPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
);

	public sealed record ThreadsFollowedResponseThreadsFollow(
	[property: JsonPropertyName("alert")] bool Alert,
	[property: JsonPropertyName("email")] bool Email
);

	public sealed record ThreadsFollowedResponseThreads(
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
	[property: JsonPropertyName("thread_is_followed")] bool ThreadIsFollowed,
	[property: JsonPropertyName("first_post")] ThreadsFollowedResponseThreadsFirstPost FirstPost,
	[property: JsonPropertyName("thread_prefixes")] List<JsonElement> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] ThreadsFollowedResponseThreadsThreadTags ThreadTags,
	[property: JsonPropertyName("links")] ThreadsFollowedResponseThreadsLinks Links,
	[property: JsonPropertyName("permissions")] ThreadsFollowedResponseThreadsPermissions Permissions,
	[property: JsonPropertyName("forum")] ThreadsFollowedResponseThreadsForum Forum,
	[property: JsonPropertyName("follow")] ThreadsFollowedResponseThreadsFollow Follow
);

	public sealed record ThreadsNavigationResponse(
		[property: JsonPropertyName("elements")] List<ThreadsNavigationResponseElements> Elements,
		[property: JsonPropertyName("elements_count")] long ElementsCount,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsNavigationResponseElementsLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("sub-elements")] string SubElements
);

	public sealed record ThreadsNavigationResponseElementsPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete
);

	public sealed record ThreadsNavigationResponseElements(
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("category_title")] string CategoryTitle,
	[property: JsonPropertyName("category_description")] string CategoryDescription,
	[property: JsonPropertyName("links")] ThreadsNavigationResponseElementsLinks Links,
	[property: JsonPropertyName("permissions")] ThreadsNavigationResponseElementsPermissions Permissions,
	[property: JsonPropertyName("navigation_type")] string NavigationType,
	[property: JsonPropertyName("navigation_id")] long NavigationId,
	[property: JsonPropertyName("navigation_depth")] long NavigationDepth,
	[property: JsonPropertyName("navigation_parent_id")] long NavigationParentId,
	[property: JsonPropertyName("has_sub_elements")] bool HasSubElements
);

	public sealed record ThreadsPollGetResponse(
		[property: JsonPropertyName("poll")] ThreadsPollGetResponsePoll Poll,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsPollGetResponsePollResponses(
	[property: JsonPropertyName("response_id")] long ResponseId,
	[property: JsonPropertyName("response_answer")] string ResponseAnswer,
	[property: JsonPropertyName("response_vote_count")] long ResponseVoteCount
);

	public sealed record ThreadsPollGetResponsePollPermissions(
	[property: JsonPropertyName("vote")] bool Vote,
	[property: JsonPropertyName("result")] bool Result
);

	public sealed record ThreadsPollGetResponsePollLinks(
	[property: JsonPropertyName("vote")] string Vote
);

	public sealed record ThreadsPollGetResponsePoll(
	[property: JsonPropertyName("poll_id")] long PollId,
	[property: JsonPropertyName("poll_question")] string PollQuestion,
	[property: JsonPropertyName("poll_vote_count")] long PollVoteCount,
	[property: JsonPropertyName("poll_max_votes")] long PollMaxVotes,
	[property: JsonPropertyName("poll_is_open")] bool PollIsOpen,
	[property: JsonPropertyName("poll_is_voted")] bool PollIsVoted,
	[property: JsonPropertyName("responses")] List<ThreadsPollGetResponsePollResponses> Responses,
	[property: JsonPropertyName("permissions")] ThreadsPollGetResponsePollPermissions Permissions,
	[property: JsonPropertyName("links")] ThreadsPollGetResponsePollLinks Links
);

	public sealed record ThreadsPollVoteBody
	{
		[JsonPropertyName("response_id")]
		public long? ResponseId { get; init; }
		[JsonPropertyName("response_ids")]
		public List<long?>? ResponseIds { get; init; }
	}

	public sealed record ThreadsPollVoteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ThreadsUnreadParams
	{
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		[JsonPropertyName("forum_id")]
		public long? ForumId { get; init; }
		[JsonPropertyName("data_limit")]
		public long? DataLimit { get; init; }
	}

	public sealed record ThreadsUnreadResponse(
		[property: JsonPropertyName("threads")] List<Resp_ThreadModel> Threads,
		[property: JsonPropertyName("data")] List<ThreadsUnreadResponseData> Data,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsUnreadResponseDataFirstPostLikeUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss
);

	public sealed record ThreadsUnreadResponseDataFirstPostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("attachments")] string Attachments,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record ThreadsUnreadResponseDataFirstPostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment
);

	public sealed record ThreadsUnreadResponseDataFirstPost(
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
	[property: JsonPropertyName("post_attachment_count")] long PostAttachmentCount,
	[property: JsonPropertyName("like_users")] List<ThreadsUnreadResponseDataFirstPostLikeUsers> LikeUsers,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("links")] ThreadsUnreadResponseDataFirstPostLinks Links,
	[property: JsonPropertyName("permissions")] ThreadsUnreadResponseDataFirstPostPermissions Permissions
);

	public sealed record ThreadsUnreadResponseDataLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("forum")] string Forum,
	[property: JsonPropertyName("posts")] string Posts,
	[property: JsonPropertyName("first_poster")] string FirstPoster,
	[property: JsonPropertyName("first_poster_avatar")] string FirstPosterAvatar,
	[property: JsonPropertyName("first_post")] string FirstPost,
	[property: JsonPropertyName("last_poster")] string LastPoster,
	[property: JsonPropertyName("last_post")] string LastPost
);

	public sealed record ThreadsUnreadResponseDataPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("edit")] bool Edit
);

	public sealed record ThreadsUnreadResponseDataForumLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
);

	public sealed record ThreadsUnreadResponseDataForumPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
);

	public sealed record ThreadsUnreadResponseDataForum(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<JsonElement> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] ThreadsUnreadResponseDataForumLinks Links,
	[property: JsonPropertyName("permissions")] ThreadsUnreadResponseDataForumPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
);

	public sealed record ThreadsUnreadResponseData(
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
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
	[property: JsonPropertyName("thread_is_followed")] bool ThreadIsFollowed,
	[property: JsonPropertyName("first_post")] ThreadsUnreadResponseDataFirstPost FirstPost,
	[property: JsonPropertyName("thread_prefixes")] List<JsonElement> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] List<JsonElement> ThreadTags,
	[property: JsonPropertyName("links")] ThreadsUnreadResponseDataLinks Links,
	[property: JsonPropertyName("permissions")] ThreadsUnreadResponseDataPermissions Permissions,
	[property: JsonPropertyName("forum")] ThreadsUnreadResponseDataForum Forum
);

	public sealed record ThreadsRecentParams
	{
		[JsonPropertyName("days")]
		public long? Days { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		[JsonPropertyName("forum_id")]
		public long? ForumId { get; init; }
		[JsonPropertyName("data_limit")]
		public long? DataLimit { get; init; }
	}

	public sealed record ThreadsRecentResponse(
		[property: JsonPropertyName("threads")] List<Resp_ThreadModel> Threads,
		[property: JsonPropertyName("data")] List<ThreadsRecentResponseData> Data,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ThreadsRecentResponseDataFirstPostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("attachments")] string Attachments,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record ThreadsRecentResponseDataFirstPostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment
);

	public sealed record ThreadsRecentResponseDataFirstPost(
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
	[property: JsonPropertyName("post_attachment_count")] long PostAttachmentCount,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("links")] ThreadsRecentResponseDataFirstPostLinks Links,
	[property: JsonPropertyName("permissions")] ThreadsRecentResponseDataFirstPostPermissions Permissions
);

	public sealed record ThreadsRecentResponseDataLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("forum")] string Forum,
	[property: JsonPropertyName("posts")] string Posts,
	[property: JsonPropertyName("first_poster")] string FirstPoster,
	[property: JsonPropertyName("first_poster_avatar")] string FirstPosterAvatar,
	[property: JsonPropertyName("first_post")] string FirstPost,
	[property: JsonPropertyName("last_poster")] string LastPoster,
	[property: JsonPropertyName("last_post")] string LastPost
);

	public sealed record ThreadsRecentResponseDataPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("edit")] bool Edit
);

	public sealed record ThreadsRecentResponseDataForumLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
);

	public sealed record ThreadsRecentResponseDataForumPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
);

	public sealed record ThreadsRecentResponseDataForum(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<JsonElement> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] ThreadsRecentResponseDataForumLinks Links,
	[property: JsonPropertyName("permissions")] ThreadsRecentResponseDataForumPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
);

	public sealed record ThreadsRecentResponseData(
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
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
	[property: JsonPropertyName("thread_is_followed")] bool ThreadIsFollowed,
	[property: JsonPropertyName("first_post")] ThreadsRecentResponseDataFirstPost FirstPost,
	[property: JsonPropertyName("thread_prefixes")] List<JsonElement> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] List<JsonElement> ThreadTags,
	[property: JsonPropertyName("links")] ThreadsRecentResponseDataLinks Links,
	[property: JsonPropertyName("permissions")] ThreadsRecentResponseDataPermissions Permissions,
	[property: JsonPropertyName("forum")] ThreadsRecentResponseDataForum Forum
);

	public sealed record ThreadsFinishResponse(
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
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		[JsonPropertyName("fields_include")]
		public JsonElement? FieldsInclude { get; init; }
	}

	public sealed record UsersListResponse(
		[property: JsonPropertyName("users")] List<Resp_UserModel> Users,
		[property: JsonPropertyName("users_total")] long UsersTotal,
		[property: JsonPropertyName("links")] UsersListResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersListResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
);

	public sealed record UsersFieldsResponse(
		[property: JsonPropertyName("fields")] List<UsersFieldsResponseFields> Fields,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersFieldsResponseFields(
	[property: JsonPropertyName("id")] string Id,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("position")] string Position,
	[property: JsonPropertyName("is_required")] bool IsRequired
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
		public long? DisplayGroupId { get; init; }
		[JsonPropertyName("display_icon_group_id")]
		public long? DisplayIconGroupId { get; init; }
		[JsonPropertyName("display_banner_id")]
		public long? DisplayBannerId { get; init; }
		[JsonPropertyName("conv_welcome_message")]
		public string? ConvWelcomeMessage { get; init; }
		[JsonPropertyName("user_dob_day")]
		public long? UserDobDay { get; init; }
		[JsonPropertyName("user_dob_month")]
		public long? UserDobMonth { get; init; }
		[JsonPropertyName("user_dob_year")]
		public long? UserDobYear { get; init; }
		[JsonPropertyName("secret_answer")]
		public string? SecretAnswer { get; init; }
		[JsonPropertyName("secret_answer_type")]
		public long? SecretAnswerType { get; init; }
		[JsonPropertyName("short_link")]
		public string? ShortLink { get; init; }
		[JsonPropertyName("language_id")]
		public LanguageId? LanguageId { get; init; }
		[JsonPropertyName("gender")]
		public Gender? Gender { get; init; }
		[JsonPropertyName("timezone")]
		public Timezone? Timezone { get; init; }
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
		public AllowViewProfile? AllowViewProfile { get; init; }
		[JsonPropertyName("allow_post_profile")]
		public AllowPostProfile? AllowPostProfile { get; init; }
		[JsonPropertyName("allow_send_personal_conversation")]
		public AllowSendPersonalConversation? AllowSendPersonalConversation { get; init; }
		[JsonPropertyName("allow_invite_group")]
		public AllowInviteGroup? AllowInviteGroup { get; init; }
		[JsonPropertyName("allow_receive_news_feed")]
		public AllowReceiveNewsFeed? AllowReceiveNewsFeed { get; init; }
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
		public NotificationsType? Type { get; init; }
		[JsonPropertyName("claim_state")]
		public ClaimState? ClaimState { get; init; }
	}

	public sealed record UsersClaimsResponse(
		[property: JsonPropertyName("claims")] List<UsersClaimsResponseClaims> Claims,
		[property: JsonPropertyName("stats")] UsersClaimsResponseStats Stats,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersClaimsResponseClaims(
	[property: JsonPropertyName("thread_id")] long ThreadId,
	[property: JsonPropertyName("claim_date")] long ClaimDate,
	[property: JsonPropertyName("claim_state")] string ClaimState,
	[property: JsonPropertyName("message_body")] string MessageBody,
	[property: JsonPropertyName("message_body_html")] string MessageBodyHtml,
	[property: JsonPropertyName("message_body_plain_text")] string MessageBodyPlainText,
	[property: JsonPropertyName("amount")] long Amount,
	[property: JsonPropertyName("amount_formatted")] string AmountFormatted,
	[property: JsonPropertyName("author")] Resp_UserModel Author
);

	public sealed record UsersClaimsResponseStatsMarket(
	[property: JsonPropertyName("total")] long Total,
	[property: JsonPropertyName("solved")] long Solved,
	[property: JsonPropertyName("settled")] long Settled,
	[property: JsonPropertyName("rejected")] long Rejected
);

	public sealed record UsersClaimsResponseStatsNoMarket(
	[property: JsonPropertyName("total")] long Total,
	[property: JsonPropertyName("solved")] long Solved,
	[property: JsonPropertyName("settled")] long Settled,
	[property: JsonPropertyName("rejected")] long Rejected
);

	public sealed record UsersClaimsResponseStats(
	[property: JsonPropertyName("market")] UsersClaimsResponseStatsMarket Market,
	[property: JsonPropertyName("noMarket")] UsersClaimsResponseStatsNoMarket NoMarket
);

	public sealed record UsersAvatarUploadBody
	{
		[JsonPropertyName("avatar")]
		public required byte[] Avatar { get; init; }
		[JsonPropertyName("x")]
		public long? X { get; init; }
		[JsonPropertyName("y")]
		public long? Y { get; init; }
		[JsonPropertyName("crop")]
		public long? Crop { get; init; }
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
		public long? X { get; init; }
		[JsonPropertyName("y")]
		public long? Y { get; init; }
		[JsonPropertyName("crop")]
		public long? Crop { get; init; }
	}

	public sealed record UsersAvatarCropResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersBackgroundUploadBody
	{
		[JsonPropertyName("background")]
		public required byte[] Background { get; init; }
		[JsonPropertyName("x")]
		public long? X { get; init; }
		[JsonPropertyName("y")]
		public long? Y { get; init; }
		[JsonPropertyName("crop")]
		public long? Crop { get; init; }
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
		public long? X { get; init; }
		[JsonPropertyName("y")]
		public long? Y { get; init; }
		[JsonPropertyName("crop")]
		public long? Crop { get; init; }
	}

	public sealed record UsersBackgroundCropResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersFollowersParams
	{
		[JsonPropertyName("order")]
		public UsersOrder? Order { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record UsersFollowersResponse(
		[property: JsonPropertyName("users")] List<UsersFollowersResponseUsers> Users,
		[property: JsonPropertyName("users_total")] long UsersTotal,
		[property: JsonPropertyName("links")] UsersFollowersResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersFollowersResponseUsersLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("avatar")] string Avatar,
	[property: JsonPropertyName("avatar_big")] string AvatarBig,
	[property: JsonPropertyName("avatar_small")] string AvatarSmall,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("followings")] string Followings,
	[property: JsonPropertyName("ignore")] string Ignore,
	[property: JsonPropertyName("timeline")] string Timeline
);

	public sealed record UsersFollowersResponseUsersPermissions(
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("ignore")] bool Ignore,
	[property: JsonPropertyName("profile_post")] bool ProfilePost
);

	public sealed record UsersFollowersResponseUsersCustomFields(
	[property: JsonPropertyName("_4")] string _4,
	[property: JsonPropertyName("lztInnovation20Link")] string LztInnovation20Link,
	[property: JsonPropertyName("lztInnovation30Link")] string LztInnovation30Link,
	[property: JsonPropertyName("lztInnovationLink")] string LztInnovationLink
);

	public sealed record UsersFollowersResponseUsers(
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
	[property: JsonPropertyName("follow_date")] long FollowDate,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("username_html")] string UsernameHtml,
	[property: JsonPropertyName("user_message_count")] long UserMessageCount,
	[property: JsonPropertyName("user_register_date")] long UserRegisterDate,
	[property: JsonPropertyName("user_like_count")] long UserLikeCount,
	[property: JsonPropertyName("user_like2_count")] long UserLike2Count,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("trophy_count")] long TrophyCount,
	[property: JsonPropertyName("custom_title")] string CustomTitle,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("user_title")] string UserTitle,
	[property: JsonPropertyName("user_is_valid")] bool UserIsValid,
	[property: JsonPropertyName("user_is_verified")] bool UserIsVerified,
	[property: JsonPropertyName("user_is_followed")] bool UserIsFollowed,
	[property: JsonPropertyName("user_last_seen_date")] long UserLastSeenDate,
	[property: JsonPropertyName("user_following_count")] long UserFollowingCount,
	[property: JsonPropertyName("user_followers_count")] long UserFollowersCount,
	[property: JsonPropertyName("links")] UsersFollowersResponseUsersLinks Links,
	[property: JsonPropertyName("permissions")] UsersFollowersResponseUsersPermissions Permissions,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("user_is_visitor")] bool UserIsVisitor,
	[property: JsonPropertyName("user_group_id")] long UserGroupId,
	[property: JsonPropertyName("custom_fields")] UsersFollowersResponseUsersCustomFields CustomFields
);

	public sealed record UsersFollowersResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
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
		public UsersOrder? Order { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record UsersFollowingsResponse(
		[property: JsonPropertyName("users")] List<UsersFollowingsResponseUsers> Users,
		[property: JsonPropertyName("users_total")] long UsersTotal,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersFollowingsResponseUsersLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("avatar")] string Avatar,
	[property: JsonPropertyName("avatar_big")] string AvatarBig,
	[property: JsonPropertyName("avatar_small")] string AvatarSmall,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("followings")] string Followings,
	[property: JsonPropertyName("ignore")] string Ignore,
	[property: JsonPropertyName("timeline")] string Timeline
);

	public sealed record UsersFollowingsResponseUsersPermissions(
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("ignore")] bool Ignore,
	[property: JsonPropertyName("profile_post")] bool ProfilePost
);

	public sealed record UsersFollowingsResponseUsersCustomFields(
	[property: JsonPropertyName("_4")] string _4,
	[property: JsonPropertyName("allowSelfUnban")] List<JsonElement> AllowSelfUnban,
	[property: JsonPropertyName("discord")] string Discord,
	[property: JsonPropertyName("github")] string Github,
	[property: JsonPropertyName("jabber")] string Jabber,
	[property: JsonPropertyName("lztAwardUserTrophy")] string LztAwardUserTrophy,
	[property: JsonPropertyName("lztCuratorNodeTitle")] string LztCuratorNodeTitle,
	[property: JsonPropertyName("lztCuratorNodeTitleEn")] string LztCuratorNodeTitleEn,
	[property: JsonPropertyName("lztDeposit")] string LztDeposit,
	[property: JsonPropertyName("lztInnovation20Link")] string LztInnovation20Link,
	[property: JsonPropertyName("lztInnovation30Link")] string LztInnovation30Link,
	[property: JsonPropertyName("lztInnovationLink")] string LztInnovationLink,
	[property: JsonPropertyName("lztLikesIncreasing")] string LztLikesIncreasing,
	[property: JsonPropertyName("lztLikesZeroing")] string LztLikesZeroing,
	[property: JsonPropertyName("lztSympathyIncreasing")] string LztSympathyIncreasing,
	[property: JsonPropertyName("lztSympathyZeroing")] string LztSympathyZeroing,
	[property: JsonPropertyName("maecenasValue")] string MaecenasValue,
	[property: JsonPropertyName("scamURL")] string ScamURL,
	[property: JsonPropertyName("steam")] string Steam,
	[property: JsonPropertyName("telegram")] string Telegram,
	[property: JsonPropertyName("vk")] string Vk
);

	public sealed record UsersFollowingsResponseUsers(
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
	[property: JsonPropertyName("follow_date")] long FollowDate,
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
	[property: JsonPropertyName("user_title")] string UserTitle,
	[property: JsonPropertyName("user_is_valid")] bool UserIsValid,
	[property: JsonPropertyName("user_is_verified")] bool UserIsVerified,
	[property: JsonPropertyName("user_is_followed")] bool UserIsFollowed,
	[property: JsonPropertyName("user_last_seen_date")] long UserLastSeenDate,
	[property: JsonPropertyName("user_following_count")] long UserFollowingCount,
	[property: JsonPropertyName("user_followers_count")] long UserFollowersCount,
	[property: JsonPropertyName("links")] UsersFollowingsResponseUsersLinks Links,
	[property: JsonPropertyName("permissions")] UsersFollowingsResponseUsersPermissions Permissions,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("user_is_visitor")] bool UserIsVisitor,
	[property: JsonPropertyName("user_group_id")] long UserGroupId,
	[property: JsonPropertyName("custom_fields")] UsersFollowingsResponseUsersCustomFields CustomFields
);

	public sealed record UsersLikesParams
	{
		[JsonPropertyName("node_id")]
		public long? NodeId { get; init; }
		[JsonPropertyName("like_type")]
		public LikeType? LikeType { get; init; }
		/// <summary>Default: gotten</summary>
		[JsonPropertyName("type")]
		public NotificationsType? Type { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>Default: post</summary>
		[JsonPropertyName("content_type")]
		public ContentType? ContentType { get; init; }
		[JsonPropertyName("search_user_id")]
		public long? SearchUserId { get; init; }
		[JsonPropertyName("stats")]
		public bool? Stats { get; init; }
	}

	public sealed record UsersLikesResponse(
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("contentType")] string ContentType,
		[property: JsonPropertyName("totalLikes")] long TotalLikes,
		[property: JsonPropertyName("likes")] UsersLikesResponseLikes Likes,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersLikesResponseLikes1234567890(
	[property: JsonPropertyName("like_id")] long LikeId,
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
	[property: JsonPropertyName("like_user_id")] long LikeUserId,
	[property: JsonPropertyName("like_date")] long LikeDate,
	[property: JsonPropertyName("content_user_id")] long ContentUserId,
	[property: JsonPropertyName("content_state")] string ContentState,
	[property: JsonPropertyName("user")] Resp_UserModel User,
	[property: JsonPropertyName("actionUser")] Resp_UserModel ActionUser,
	[property: JsonPropertyName("messageHtml")] string MessageHtml,
	[property: JsonPropertyName("post_date")] long PostDate
);

	public sealed record UsersLikesResponseLikes(
	[property: JsonPropertyName("1234567890")] UsersLikesResponseLikes1234567890 _1234567890
);

	public sealed record UsersIgnoredParams
	{
		[JsonPropertyName("total")]
		public bool? Total { get; init; }
	}

	public sealed record UsersIgnoredResponse(
		[property: JsonPropertyName("users")] List<UsersIgnoredResponseUsers> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersIgnoredResponseUsersCustomFields(
	[property: JsonPropertyName("_4")] string _4,
	[property: JsonPropertyName("scamURL")] JsonElement ScamURL,
	[property: JsonPropertyName("lztLikesZeroing")] JsonElement LztLikesZeroing,
	[property: JsonPropertyName("lztLikesIncreasing")] JsonElement LztLikesIncreasing,
	[property: JsonPropertyName("lztSympathyZeroing")] JsonElement LztSympathyZeroing,
	[property: JsonPropertyName("lztSympathyIncreasing")] JsonElement LztSympathyIncreasing,
	[property: JsonPropertyName("telegram")] JsonElement Telegram,
	[property: JsonPropertyName("vk")] string Vk,
	[property: JsonPropertyName("discord")] string Discord,
	[property: JsonPropertyName("steam")] string Steam,
	[property: JsonPropertyName("matrix")] JsonElement Matrix,
	[property: JsonPropertyName("jabber")] string Jabber,
	[property: JsonPropertyName("github")] string Github
);

	public sealed record UsersIgnoredResponseUsersIgnoredInfo(
	[property: JsonPropertyName("ignore_content")] long IgnoreContent,
	[property: JsonPropertyName("ignore_conversations")] long IgnoreConversations,
	[property: JsonPropertyName("restrict_view_profile")] long RestrictViewProfile
);

	public sealed record UsersIgnoredResponseUsersRenderedAvatars(
	[property: JsonPropertyName("l")] string L,
	[property: JsonPropertyName("m")] string M,
	[property: JsonPropertyName("s")] string S
);

	public sealed record UsersIgnoredResponseUsersRendered(
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatars")] UsersIgnoredResponseUsersRenderedAvatars Avatars,
	[property: JsonPropertyName("backgrounds")] List<JsonElement> Backgrounds,
	[property: JsonPropertyName("link")] string Link
);

	public sealed record UsersIgnoredResponseUsers(
	[property: JsonPropertyName("can_edit")] bool CanEdit,
	[property: JsonPropertyName("can_follow")] bool CanFollow,
	[property: JsonPropertyName("can_ignore")] bool CanIgnore,
	[property: JsonPropertyName("can_post_profile")] bool CanPostProfile,
	[property: JsonPropertyName("can_view_profile")] bool CanViewProfile,
	[property: JsonPropertyName("can_view_profile_posts")] bool CanViewProfilePosts,
	[property: JsonPropertyName("can_warn")] bool CanWarn,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("conv_welcome_message")] string ConvWelcomeMessage,
	[property: JsonPropertyName("convertedDeposit")] long ConvertedDeposit,
	[property: JsonPropertyName("custom_fields")] UsersIgnoredResponseUsersCustomFields CustomFields,
	[property: JsonPropertyName("deposit")] long Deposit,
	[property: JsonPropertyName("homepage")] string Homepage,
	[property: JsonPropertyName("ignored_info")] UsersIgnoredResponseUsersIgnoredInfo IgnoredInfo,
	[property: JsonPropertyName("is_admin")] bool IsAdmin,
	[property: JsonPropertyName("is_banned")] bool IsBanned,
	[property: JsonPropertyName("is_followed")] bool IsFollowed,
	[property: JsonPropertyName("is_ignored")] bool IsIgnored,
	[property: JsonPropertyName("is_moderator")] bool IsModerator,
	[property: JsonPropertyName("is_staff")] bool IsStaff,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("like2_count")] long Like2Count,
	[property: JsonPropertyName("like_count")] long LikeCount,
	[property: JsonPropertyName("location")] string Location,
	[property: JsonPropertyName("message_count")] long MessageCount,
	[property: JsonPropertyName("register_date")] long RegisterDate,
	[property: JsonPropertyName("rendered")] UsersIgnoredResponseUsersRendered Rendered,
	[property: JsonPropertyName("short_link")] string ShortLink,
	[property: JsonPropertyName("trophy_points")] long TrophyPoints,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("user_title")] string UserTitle,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("view_url")] string ViewUrl,
	[property: JsonPropertyName("warning_points")] long WarningPoints
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
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record UsersContentsResponse(
		[property: JsonPropertyName("data")] List<UsersContentsResponseData> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("user")] Resp_UserModel User,
		[property: JsonPropertyName("links")] UsersContentsResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersContentsResponseDataLikeUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss
);

	public sealed record UsersContentsResponseDataLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("attachments")] string Attachments,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record UsersContentsResponseDataPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment
);

	public sealed record UsersContentsResponseDataThreadLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("forum")] string Forum,
	[property: JsonPropertyName("posts")] string Posts,
	[property: JsonPropertyName("first_poster")] string FirstPoster,
	[property: JsonPropertyName("first_poster_avatar")] string FirstPosterAvatar,
	[property: JsonPropertyName("first_post")] string FirstPost,
	[property: JsonPropertyName("last_poster")] string LastPoster,
	[property: JsonPropertyName("last_post")] string LastPost
);

	public sealed record UsersContentsResponseDataThreadPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment
);

	public sealed record UsersContentsResponseDataThread(
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
	[property: JsonPropertyName("thread_is_followed")] bool ThreadIsFollowed,
	[property: JsonPropertyName("thread_prefixes")] List<JsonElement> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] List<JsonElement> ThreadTags,
	[property: JsonPropertyName("links")] UsersContentsResponseDataThreadLinks Links,
	[property: JsonPropertyName("permissions")] UsersContentsResponseDataThreadPermissions Permissions
);

	public sealed record UsersContentsResponseData(
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
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
	[property: JsonPropertyName("post_attachment_count")] long PostAttachmentCount,
	[property: JsonPropertyName("like_users")] List<UsersContentsResponseDataLikeUsers> LikeUsers,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("links")] UsersContentsResponseDataLinks Links,
	[property: JsonPropertyName("permissions")] UsersContentsResponseDataPermissions Permissions,
	[property: JsonPropertyName("thread")] UsersContentsResponseDataThread Thread
);

	public sealed record UsersContentsResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
);

	public sealed record UsersTrophiesResponse(
		[property: JsonPropertyName("trophies")] List<UsersTrophiesResponseTrophies> Trophies,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersTrophiesResponseTrophies(
	[property: JsonPropertyName("trophy_id")] long TrophyId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("trophy_url")] string TrophyUrl
);

	public sealed record UsersSecretAnswerTypesResponse(
		[property: JsonPropertyName("data")] List<UsersSecretAnswerTypesResponseData> Data,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record UsersSecretAnswerTypesResponseData(
	[property: JsonPropertyName("sa_id")] long SaId,
	[property: JsonPropertyName("renderedPhrase")] string RenderedPhrase
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

