// Auto-generated. Do not edit manually.

using System.Text.Json.Serialization;
using System.Text.Json;

namespace Lolzteam.Api.Generated.Market;

// ─── Enums ────────────────────────────────────────────────────

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<AgeVerified>))]
public enum AgeVerified
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

public enum AppId : long
{
	V730 = 730,
	V578080 = 578080,
	V753 = 753,
	V570 = 570,
	V440 = 440,
	V252490 = 252490,
	V304930 = 304930,
	V232090 = 232090,
	V322330 = 322330,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Autorenewal>))]
public enum Autorenewal
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Bedrock>))]
public enum Bedrock
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Billing>))]
public enum Billing
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<BirthdayAfterPeriod>))]
public enum BirthdayAfterPeriod
{
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
	[Lolzteam.Api.Runtime.EnumValue("year")] Year,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<BirthdayPeriod>))]
public enum BirthdayPeriod
{
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
	[Lolzteam.Api.Runtime.EnumValue("year")] Year,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Bp>))]
public enum Bp
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<BrawlPass>))]
public enum BrawlPass
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

public enum Cancel : long
{
	V1 = 1,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<CanChangeDetails>))]
public enum CanChangeDetails
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

public enum CategoryEg : long
{
	Neg1 = -1,
	V0 = 0,
	V1 = 1,
}

public enum CategoryEg2 : long
{
	Neg1 = -1,
	V0 = 0,
	V1 = 1,
	V2 = 2,
}

public enum CategoryEg3 : long
{
	V0 = 0,
	V1 = 1,
}

public enum CategoryId : long
{
	V1 = 1,
	V3 = 3,
	V4 = 4,
	V5 = 5,
	V6 = 6,
	V7 = 7,
	V8 = 8,
	V9 = 9,
	V10 = 10,
	V11 = 11,
	V12 = 12,
	V13 = 13,
	V14 = 14,
	V15 = 15,
	V16 = 16,
	V17 = 17,
	V18 = 18,
	V19 = 19,
	V20 = 20,
	V22 = 22,
	V24 = 24,
	V28 = 28,
	V30 = 30,
	V31 = 31,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<CategorySubscription>))]
public enum CategorySubscription
{
	[Lolzteam.Api.Runtime.EnumValue("EA Play")] EAPlay,
	[Lolzteam.Api.Runtime.EnumValue("EA Play Pro")] EAPlayPro,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<CategorySubscription2>))]
public enum CategorySubscription2
{
	[Lolzteam.Api.Runtime.EnumValue("discord_nitro")] DiscordNitro,
	[Lolzteam.Api.Runtime.EnumValue("discord_nitro_basic")] DiscordNitroBasic,
	[Lolzteam.Api.Runtime.EnumValue("discord_nitro_trial")] DiscordNitroTrial,
	[Lolzteam.Api.Runtime.EnumValue("telegram_premium")] TelegramPremium,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<CategorySubscription3>))]
public enum CategorySubscription3
{
	[Lolzteam.Api.Runtime.EnumValue("basic")] Basic,
	[Lolzteam.Api.Runtime.EnumValue("premium")] Premium,
	[Lolzteam.Api.Runtime.EnumValue("premiumAnywhere")] PremiumAnywhere,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<CategorySubscription4>))]
public enum CategorySubscription4
{
	[Lolzteam.Api.Runtime.EnumValue("RobloxPremium1000")] RobloxPremium1000,
	[Lolzteam.Api.Runtime.EnumValue("RobloxPremium100012Months")] RobloxPremium100012Months,
	[Lolzteam.Api.Runtime.EnumValue("RobloxPremium1000OneMonth")] RobloxPremium1000OneMonth,
	[Lolzteam.Api.Runtime.EnumValue("RobloxPremium2200")] RobloxPremium2200,
	[Lolzteam.Api.Runtime.EnumValue("RobloxPremium2200OneMonth")] RobloxPremium2200OneMonth,
	[Lolzteam.Api.Runtime.EnumValue("RobloxPremium450")] RobloxPremium450,
	[Lolzteam.Api.Runtime.EnumValue("RobloxPremium450OneMonth")] RobloxPremium450OneMonth,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<CategorySubscription5>))]
public enum CategorySubscription5
{
	[Lolzteam.Api.Runtime.EnumValue("PC Game Pass")] PCGamePass,
	[Lolzteam.Api.Runtime.EnumValue("Xbox Game Pass Ultimate")] XboxGamePassUltimate,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ChangeableFn>))]
public enum ChangeableFn
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ChangeEmail>))]
public enum ChangeEmail
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ChangeNickname>))]
public enum ChangeNickname
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ClaimState>))]
public enum ClaimState
{
	[Lolzteam.Api.Runtime.EnumValue("active")] Active,
	[Lolzteam.Api.Runtime.EnumValue("solved")] Solved,
	[Lolzteam.Api.Runtime.EnumValue("rejected")] Rejected,
	[Lolzteam.Api.Runtime.EnumValue("settled")] Settled,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Clan>))]
public enum Clan
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Clans>))]
public enum Clans
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ClashPass>))]
public enum ClashPass
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<CookieLogin>))]
public enum CookieLogin
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Cookies>))]
public enum Cookies
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

public enum Cs2MapRank : long
{
	V1 = 1,
	V2 = 2,
	V3 = 3,
	V4 = 4,
	V5 = 5,
	V6 = 6,
	V7 = 7,
	V8 = 8,
	V9 = 9,
	V10 = 10,
	V11 = 11,
	V12 = 12,
	V13 = 13,
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
	[Lolzteam.Api.Runtime.EnumValue("jpy")] Jpy,
	[Lolzteam.Api.Runtime.EnumValue("brl")] Brl,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<D2LastMatchDatePeriod>))]
public enum D2LastMatchDatePeriod
{
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
	[Lolzteam.Api.Runtime.EnumValue("year")] Year,
}

public enum Day : long
{
	V0 = 0,
	V1 = 1,
	V2 = 2,
	V3 = 3,
	V4 = 4,
	V5 = 5,
	V6 = 6,
	V7 = 7,
	V8 = 8,
	V9 = 9,
	V10 = 10,
	V11 = 11,
	V12 = 12,
	V13 = 13,
	V14 = 14,
	V15 = 15,
	V16 = 16,
	V17 = 17,
	V18 = 18,
	V19 = 19,
	V20 = 20,
	V21 = 21,
	V22 = 22,
	V23 = 23,
	V24 = 24,
	V25 = 25,
	V26 = 26,
	V27 = 27,
	V28 = 28,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Dungeons>))]
public enum Dungeons
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<E2fa>))]
public enum E2fa
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Ea>))]
public enum Ea
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<EditBtag>))]
public enum EditBtag
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Email>))]
public enum Email
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<EmailType>))]
public enum EmailType
{
	[Lolzteam.Api.Runtime.EnumValue("native")] Native,
	[Lolzteam.Api.Runtime.EnumValue("autoreg")] Autoreg,
}

public enum ExtendedGuarantee : long
{
	Neg1 = -1,
	V0 = 0,
	V1 = 1,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Format>))]
public enum Format
{
	[Lolzteam.Api.Runtime.EnumValue("short")] Short,
	[Lolzteam.Api.Runtime.EnumValue("custom")] Custom,
	[Lolzteam.Api.Runtime.EnumValue("mfa_file_steam_id")] MfaFileSteamId,
	[Lolzteam.Api.Runtime.EnumValue("mfa_file_login")] MfaFileLogin,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<GameDonations>))]
public enum GameDonations
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Gifts>))]
public enum Gifts
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<HasActivatedKeys>))]
public enum HasActivatedKeys
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<HasBan>))]
public enum HasBan
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<HasFaceit>))]
public enum HasFaceit
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<HoldLengthOption>))]
public enum HoldLengthOption
{
	[Lolzteam.Api.Runtime.EnumValue("hour")] Hour,
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("week")] Week,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
	[Lolzteam.Api.Runtime.EnumValue("year")] Year,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<HypixelBan>))]
public enum HypixelBan
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<HypixelBanParsed>))]
public enum HypixelBanParsed
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<HypixelSkyblockApiEnabled>))]
public enum HypixelSkyblockApiEnabled
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Java>))]
public enum Java
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<LastLoginHypixelPeriod>))]
public enum LastLoginHypixelPeriod
{
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
	[Lolzteam.Api.Runtime.EnumValue("year")] Year,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<LastTransDatePeriod>))]
public enum LastTransDatePeriod
{
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
	[Lolzteam.Api.Runtime.EnumValue("year")] Year,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<LastTransDatePeriodLater>))]
public enum LastTransDatePeriodLater
{
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
	[Lolzteam.Api.Runtime.EnumValue("year")] Year,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Legends>))]
public enum Legends
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Limit>))]
public enum Limit
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<LoginWithoutCookies>))]
public enum LoginWithoutCookies
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Mafile>))]
public enum Mafile
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ManagingItemOrigin>))]
public enum ManagingItemOrigin
{
	[Lolzteam.Api.Runtime.EnumValue("brute")] Brute,
	[Lolzteam.Api.Runtime.EnumValue("phishing")] Phishing,
	[Lolzteam.Api.Runtime.EnumValue("stealer")] Stealer,
	[Lolzteam.Api.Runtime.EnumValue("personal")] Personal,
	[Lolzteam.Api.Runtime.EnumValue("resale")] Resale,
	[Lolzteam.Api.Runtime.EnumValue("autoreg")] Autoreg,
	[Lolzteam.Api.Runtime.EnumValue("dummy")] Dummy,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ManagingType>))]
public enum ManagingType
{
	[Lolzteam.Api.Runtime.EnumValue("profiles")] Profiles,
	[Lolzteam.Api.Runtime.EnumValue("games")] Games,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ManagingType2>))]
public enum ManagingType2
{
	[Lolzteam.Api.Runtime.EnumValue("skins")] Skins,
	[Lolzteam.Api.Runtime.EnumValue("pickaxes")] Pickaxes,
	[Lolzteam.Api.Runtime.EnumValue("dances")] Dances,
	[Lolzteam.Api.Runtime.EnumValue("gliders")] Gliders,
	[Lolzteam.Api.Runtime.EnumValue("weapons")] Weapons,
	[Lolzteam.Api.Runtime.EnumValue("agents")] Agents,
	[Lolzteam.Api.Runtime.EnumValue("buddies")] Buddies,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<MmBan>))]
public enum MmBan
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Nitro>))]
public enum Nitro
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<NitroPeriod>))]
public enum NitroPeriod
{
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
	[Lolzteam.Api.Runtime.EnumValue("year")] Year,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<NoBans>))]
public enum NoBans
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<NotEmailProvider>))]
public enum NotEmailProvider
{
	[Lolzteam.Api.Runtime.EnumValue("other")] Other,
	[Lolzteam.Api.Runtime.EnumValue("rambler")] Rambler,
	[Lolzteam.Api.Runtime.EnumValue("outlook")] Outlook,
	[Lolzteam.Api.Runtime.EnumValue("firstmail")] Firstmail,
	[Lolzteam.Api.Runtime.EnumValue("notletters")] Notletters,
	[Lolzteam.Api.Runtime.EnumValue("mail_ru")] MailRu,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<OrderBy>))]
public enum OrderBy
{
	[Lolzteam.Api.Runtime.EnumValue("price_to_up")] PriceToUp,
	[Lolzteam.Api.Runtime.EnumValue("price_to_down")] PriceToDown,
	[Lolzteam.Api.Runtime.EnumValue("pdate_to_down")] PdateToDown,
	[Lolzteam.Api.Runtime.EnumValue("pdate_to_up")] PdateToUp,
	[Lolzteam.Api.Runtime.EnumValue("pdate_to_down_upload")] PdateToDownUpload,
	[Lolzteam.Api.Runtime.EnumValue("pdate_to_up_upload")] PdateToUpUpload,
	[Lolzteam.Api.Runtime.EnumValue("edate_to_up")] EdateToUp,
	[Lolzteam.Api.Runtime.EnumValue("edate_to_down")] EdateToDown,
	[Lolzteam.Api.Runtime.EnumValue("ddate_to_up")] DdateToUp,
	[Lolzteam.Api.Runtime.EnumValue("ddate_to_down")] DdateToDown,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ParentControl>))]
public enum ParentControl
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Password>))]
public enum Password
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<PaymentsType>))]
public enum PaymentsType
{
	[Lolzteam.Api.Runtime.EnumValue("paid_item")] PaidItem,
	[Lolzteam.Api.Runtime.EnumValue("sold_item")] SoldItem,
	[Lolzteam.Api.Runtime.EnumValue("withdrawal_balance")] WithdrawalBalance,
	[Lolzteam.Api.Runtime.EnumValue("refilled_balance")] RefilledBalance,
	[Lolzteam.Api.Runtime.EnumValue("internal_purchase")] InternalPurchase,
	[Lolzteam.Api.Runtime.EnumValue("money_transfer")] MoneyTransfer,
	[Lolzteam.Api.Runtime.EnumValue("receiving_money")] ReceivingMoney,
	[Lolzteam.Api.Runtime.EnumValue("claim_hold")] ClaimHold,
	[Lolzteam.Api.Runtime.EnumValue("insurance_deposit")] InsuranceDeposit,
	[Lolzteam.Api.Runtime.EnumValue("paid_mail")] PaidMail,
	[Lolzteam.Api.Runtime.EnumValue("contest")] Contest,
	[Lolzteam.Api.Runtime.EnumValue("invoice")] Invoice,
	[Lolzteam.Api.Runtime.EnumValue("balance_exchange")] BalanceExchange,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Premium>))]
public enum Premium
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<PremiumExpirationPeriod>))]
public enum PremiumExpirationPeriod
{
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
	[Lolzteam.Api.Runtime.EnumValue("year")] Year,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ProfileType>))]
public enum ProfileType
{
	[Lolzteam.Api.Runtime.EnumValue("market")] Market,
	[Lolzteam.Api.Runtime.EnumValue("nomarket")] Nomarket,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<PsnConnected>))]
public enum PsnConnected
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<PsnLinkable>))]
public enum PsnLinkable
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<PublishingItemOrigin>))]
public enum PublishingItemOrigin
{
	[Lolzteam.Api.Runtime.EnumValue("brute")] Brute,
	[Lolzteam.Api.Runtime.EnumValue("phishing")] Phishing,
	[Lolzteam.Api.Runtime.EnumValue("stealer")] Stealer,
	[Lolzteam.Api.Runtime.EnumValue("personal")] Personal,
	[Lolzteam.Api.Runtime.EnumValue("resale")] Resale,
	[Lolzteam.Api.Runtime.EnumValue("autoreg")] Autoreg,
	[Lolzteam.Api.Runtime.EnumValue("dummy")] Dummy,
	[Lolzteam.Api.Runtime.EnumValue("self_registration")] SelfRegistration,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<PublishingType>))]
public enum PublishingType
{
	[Lolzteam.Api.Runtime.EnumValue("socialclub")] Socialclub,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Pve>))]
public enum Pve
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<R6Ban>))]
public enum R6Ban
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<RealId>))]
public enum RealId
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Region>))]
public enum Region
{
	[Lolzteam.Api.Runtime.EnumValue("af")] Af,
	[Lolzteam.Api.Runtime.EnumValue("as")] As,
	[Lolzteam.Api.Runtime.EnumValue("cis")] Cis,
	[Lolzteam.Api.Runtime.EnumValue("eu")] Eu,
	[Lolzteam.Api.Runtime.EnumValue("me")] Me,
	[Lolzteam.Api.Runtime.EnumValue("oc")] Oc,
	[Lolzteam.Api.Runtime.EnumValue("us")] Us,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<RegPeriod>))]
public enum RegPeriod
{
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
	[Lolzteam.Api.Runtime.EnumValue("year")] Year,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<RoyalePass>))]
public enum RoyalePass
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Rt>))]
public enum Rt
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Show>))]
public enum Show
{
	[Lolzteam.Api.Runtime.EnumValue("active")] Active,
	[Lolzteam.Api.Runtime.EnumValue("paid")] Paid,
	[Lolzteam.Api.Runtime.EnumValue("deleted")] Deleted,
	[Lolzteam.Api.Runtime.EnumValue("awaiting")] Awaiting,
	[Lolzteam.Api.Runtime.EnumValue("closed")] Closed,
	[Lolzteam.Api.Runtime.EnumValue("discount_request")] DiscountRequest,
	[Lolzteam.Api.Runtime.EnumValue("stickied")] Stickied,
	[Lolzteam.Api.Runtime.EnumValue("pre_active")] PreActive,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Side>))]
public enum Side
{
	[Lolzteam.Api.Runtime.EnumValue("Bear")] Bear,
	[Lolzteam.Api.Runtime.EnumValue("Savage")] Savage,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Spam>))]
public enum Spam
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Status>))]
public enum Status
{
	[Lolzteam.Api.Runtime.EnumValue("paid")] Paid,
	[Lolzteam.Api.Runtime.EnumValue("not_paid")] NotPaid,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<SteamConnected>))]
public enum SteamConnected
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<SubscriptionPeriod>))]
public enum SubscriptionPeriod
{
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
	[Lolzteam.Api.Runtime.EnumValue("year")] Year,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Tel>))]
public enum Tel
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<TempEmail>))]
public enum TempEmail
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<TradeBan>))]
public enum TradeBan
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<TradeLimit>))]
public enum TradeLimit
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Transactions>))]
public enum Transactions
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Verified>))]
public enum Verified
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Voice>))]
public enum Voice
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<XboxConnected>))]
public enum XboxConnected
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<XboxLinkable>))]
public enum XboxLinkable
{
	[Lolzteam.Api.Runtime.EnumValue("yes")] Yes,
	[Lolzteam.Api.Runtime.EnumValue("no")] No,
	[Lolzteam.Api.Runtime.EnumValue("nomatter")] Nomatter,
}

// ─── Component Schemas ────────────────────────────────────────

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

public sealed record ConfirmationCodeModel(
	[property: JsonPropertyName("item")] ItemModel Item,
	[property: JsonPropertyName("codeData")] ConfirmationCodeModelCodeData CodeData
);

public sealed record ConfirmationCodeModelCodeData(
	[property: JsonPropertyName("code")] string Code,
	[property: JsonPropertyName("date")] long Date,
	[property: JsonPropertyName("textPlain")] string TextPlain
);

public sealed record DiscountModel(
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("discount_id")] long DiscountId,
	[property: JsonPropertyName("discount_percent")] long DiscountPercent,
	[property: JsonPropertyName("discount_user_id")] long DiscountUserId,
	[property: JsonPropertyName("max_price")] long MaxPrice,
	[property: JsonPropertyName("min_price")] long MinPrice,
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
	[property: JsonPropertyName("bumpSettings")] ItemFromListModelBumpSettings? BumpSettings,
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
	[property: JsonPropertyName("seller")] ItemFromListModelSeller? Seller
);

public sealed record ItemFromListModelBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool? CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool? CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] string? ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] string? ErrorPhrase
);

public sealed record ItemFromListModelSeller(
	[property: JsonPropertyName("user_id")] long? UserId,
	[property: JsonPropertyName("sold_items_count")] long? SoldItemsCount,
	[property: JsonPropertyName("active_item_count")] long? ActiveItemCount,
	[property: JsonPropertyName("restore_data")] string? RestoreData,
	[property: JsonPropertyName("username")] string? Username,
	[property: JsonPropertyName("avatar_date")] long? AvatarDate,
	[property: JsonPropertyName("is_banned")] long? IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long? DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long? RestorePercents
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
	[property: JsonPropertyName("guarantee")] ItemModelGuarantee Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewItemViews")] bool CanViewItemViews,
	[property: JsonPropertyName("loginData")] ItemModelLoginData LoginData,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("copyFormatData")] ItemModelCopyFormatData CopyFormatData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("getEmailCodeDisplayLogin")] JsonElement GetEmailCodeDisplayLogin,
	[property: JsonPropertyName("buyer")] ItemModelBuyer Buyer,
	[property: JsonPropertyName("isPersonalAccount")] bool IsPersonalAccount,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("priceWithSellerFeeLabel")] string PriceWithSellerFeeLabel,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("isSmallExf")] bool IsSmallExf,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<ItemModelAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("imagePreviewLinks")] List<string> ImagePreviewLinks,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("canChangeEmailPassword")] bool CanChangeEmailPassword,
	[property: JsonPropertyName("uniqueKeyExists")] bool UniqueKeyExists,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("visitorIsAuthor")] bool VisitorIsAuthor,
	[property: JsonPropertyName("canAskDiscount")] bool CanAskDiscount,
	[property: JsonPropertyName("tags")] ItemModelTags Tags,
	[property: JsonPropertyName("customFields")] ItemModelCustomFields CustomFields,
	[property: JsonPropertyName("externalAuth")] List<JsonElement> ExternalAuth,
	[property: JsonPropertyName("isTrusted")] bool IsTrusted,
	[property: JsonPropertyName("isBirthdayToday")] bool IsBirthdayToday,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("deposit")] long Deposit,
	[property: JsonPropertyName("extraPrices")] List<ItemModelExtraPrices> ExtraPrices,
	[property: JsonPropertyName("canViewAccountLoginAndTempEmail")] bool CanViewAccountLoginAndTempEmail,
	[property: JsonPropertyName("bumpSettings")] ItemModelBumpSettings BumpSettings,
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
	[property: JsonPropertyName("seller")] ItemModelSeller Seller
);

public sealed record ItemModelGuarantee(
	[property: JsonPropertyName("duration")] long Duration,
	[property: JsonPropertyName("class")] string Class,
	[property: JsonPropertyName("durationPhrase")] string DurationPhrase,
	[property: JsonPropertyName("endDate")] long EndDate,
	[property: JsonPropertyName("active")] bool Active,
	[property: JsonPropertyName("cancelled")] bool Cancelled,
	[property: JsonPropertyName("remainingTime")] long RemainingTime,
	[property: JsonPropertyName("remainingTimePhrase")] string RemainingTimePhrase,
	[property: JsonPropertyName("cancelledReason")] string CancelledReason,
	[property: JsonPropertyName("cancelledReasonPhrase")] string CancelledReasonPhrase
);

public sealed record ItemModelLoginData(
	[property: JsonPropertyName("raw")] string Raw,
	[property: JsonPropertyName("encodedRaw")] string EncodedRaw,
	[property: JsonPropertyName("login")] string Login,
	[property: JsonPropertyName("password")] string Password,
	[property: JsonPropertyName("encodedPassword")] string EncodedPassword,
	[property: JsonPropertyName("oldPassword")] string OldPassword,
	[property: JsonPropertyName("encodedOldPassword")] JsonElement EncodedOldPassword
);

public sealed record ItemModelCopyFormatData(
	[property: JsonPropertyName("title_link")] string TitleLink,
	[property: JsonPropertyName("login_data")] string LoginData,
	[property: JsonPropertyName("full")] string Full
);

public sealed record ItemModelBuyer(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("operation_date")] long OperationDate,
	[property: JsonPropertyName("visitorIsBuyer")] bool VisitorIsBuyer,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("display_icon_group_id")] long DisplayIconGroupId,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss,
	[property: JsonPropertyName("uniq_banner")] string UniqBanner,
	[property: JsonPropertyName("user_group_id")] long UserGroupId
);

public sealed record ItemModelAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
);

public sealed record ItemModelTags1234567890(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
);

public sealed record ItemModelTags(
	[property: JsonPropertyName("1234567890")] ItemModelTags1234567890 _1234567890
);

public sealed record ItemModelCustomFields(
	[property: JsonPropertyName("_4")] string _4,
	[property: JsonPropertyName("allowSelfUnban")] List<JsonElement> AllowSelfUnban,
	[property: JsonPropertyName("ban_reason")] string BanReason,
	[property: JsonPropertyName("discord")] string Discord,
	[property: JsonPropertyName("github")] string Github,
	[property: JsonPropertyName("jabber")] string Jabber,
	[property: JsonPropertyName("lztUnbanAmount")] string LztUnbanAmount,
	[property: JsonPropertyName("steam")] string Steam,
	[property: JsonPropertyName("telegram")] string Telegram,
	[property: JsonPropertyName("vk")] string Vk
);

public sealed record ItemModelExtraPrices(
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("price")] string Price,
	[property: JsonPropertyName("priceValue")] double PriceValue
);

public sealed record ItemModelBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("nextAllowedBumpDate")] JsonElement NextAllowedBumpDate,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

public sealed record ItemModelSellerContacts(
	[property: JsonPropertyName("ban_reason")] string BanReason,
	[property: JsonPropertyName("telegram")] string Telegram
);

public sealed record ItemModelSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("joined_date")] long JoinedDate,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("effective_last_activity")] long EffectiveLastActivity,
	[property: JsonPropertyName("restore_percents")] JsonElement RestorePercents,
	[property: JsonPropertyName("isOnline")] bool IsOnline,
	[property: JsonPropertyName("contacts")] ItemModelSellerContacts Contacts
);

public sealed record Resp_SystemInfo(
	[property: JsonPropertyName("visitor_id")] long VisitorId,
	[property: JsonPropertyName("time")] long Time,
	[property: JsonPropertyName("log_id")] long LogId
);

public sealed record UserModel(
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("activity_visible")] bool ActivityVisible,
	[property: JsonPropertyName("age")] long Age,
	[property: JsonPropertyName("balance")] string Balance,
	[property: JsonPropertyName("balances")] List<UserModelBalances> Balances,
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
	[property: JsonPropertyName("custom_fields")] UserModelCustomFields CustomFields,
	[property: JsonPropertyName("custom_title")] string CustomTitle,
	[property: JsonPropertyName("deposit")] long Deposit,
	[property: JsonPropertyName("dob")] UserModelDob Dob,
	[property: JsonPropertyName("feedback_data")] UserModelFeedbackData FeedbackData,
	[property: JsonPropertyName("hold")] string Hold,
	[property: JsonPropertyName("homepage")] string Homepage,
	[property: JsonPropertyName("imap_data")] UserModelImapData ImapData,
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
	[property: JsonPropertyName("public_tags")] List<UserModelPublicTags> PublicTags,
	[property: JsonPropertyName("register_date")] long RegisterDate,
	[property: JsonPropertyName("rendered")] UserModelRendered Rendered,
	[property: JsonPropertyName("restore_count")] long RestoreCount,
	[property: JsonPropertyName("restore_data")] UserModelRestoreData RestoreData,
	[property: JsonPropertyName("short_link")] string ShortLink,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("tags")] List<UserModelTags> Tags,
	[property: JsonPropertyName("telegram_client")] UserModelTelegramClient TelegramClient,
	[property: JsonPropertyName("trophy_points")] long TrophyPoints,
	[property: JsonPropertyName("user_allow_ask_discount")] bool UserAllowAskDiscount,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("user_title")] string UserTitle,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("view_url")] string ViewUrl,
	[property: JsonPropertyName("visible")] bool Visible,
	[property: JsonPropertyName("warning_points")] long WarningPoints
);

public sealed record UserModelBalances(
	[property: JsonPropertyName("balance")] string Balance,
	[property: JsonPropertyName("balance_id")] long BalanceId,
	[property: JsonPropertyName("convertedBalance")] double ConvertedBalance,
	[property: JsonPropertyName("custom_title")] JsonElement CustomTitle,
	[property: JsonPropertyName("fullTitle")] string FullTitle,
	[property: JsonPropertyName("merchant_id")] long MerchantId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("user_id")] long UserId
);

public sealed record UserModelCustomFields(
	[property: JsonPropertyName("_4")] string _4,
	[property: JsonPropertyName("allowSelfUnban")] List<JsonElement> AllowSelfUnban,
	[property: JsonPropertyName("ban_reason")] string BanReason,
	[property: JsonPropertyName("discord")] string Discord,
	[property: JsonPropertyName("github")] string Github,
	[property: JsonPropertyName("jabber")] string Jabber,
	[property: JsonPropertyName("lztAwardUserTrophy")] string LztAwardUserTrophy,
	[property: JsonPropertyName("lztLikesIncreasing")] string LztLikesIncreasing,
	[property: JsonPropertyName("lztLikesZeroing")] string LztLikesZeroing,
	[property: JsonPropertyName("lztSympathyIncreasing")] string LztSympathyIncreasing,
	[property: JsonPropertyName("lztSympathyZeroing")] string LztSympathyZeroing,
	[property: JsonPropertyName("lztUnbanAmount")] string LztUnbanAmount,
	[property: JsonPropertyName("maecenasValue")] string MaecenasValue,
	[property: JsonPropertyName("scamURL")] string ScamURL,
	[property: JsonPropertyName("steam")] string Steam,
	[property: JsonPropertyName("telegram")] string Telegram,
	[property: JsonPropertyName("vk")] string Vk,
	[property: JsonPropertyName("favoritePorn")] string FavoritePorn,
	[property: JsonPropertyName("favoriteVape")] string FavoriteVape,
	[property: JsonPropertyName("favoriteAnime")] string FavoriteAnime,
	[property: JsonPropertyName("matrix")] string Matrix
);

public sealed record UserModelDob(
	[property: JsonPropertyName("year")] long Year,
	[property: JsonPropertyName("month")] long Month,
	[property: JsonPropertyName("day")] long Day
);

public sealed record UserModelFeedbackData12345(
	[property: JsonPropertyName("positive")] long Positive,
	[property: JsonPropertyName("negative")] long Negative
);

public sealed record UserModelFeedbackData(
	[property: JsonPropertyName("12345")] UserModelFeedbackData12345 _12345
);

public sealed record UserModelImapDataDomainZone(
	[property: JsonPropertyName("domain")] string Domain,
	[property: JsonPropertyName("imap_server")] string ImapServer,
	[property: JsonPropertyName("port")] long Port,
	[property: JsonPropertyName("secure")] bool Secure
);

public sealed record UserModelImapData(
	[property: JsonPropertyName("domain.zone")] UserModelImapDataDomainZone DomainZone
);

public sealed record UserModelPublicTags(
	[property: JsonPropertyName("background_color")] string BackgroundColor,
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title
);

public sealed record UserModelRenderedAvatars(
	[property: JsonPropertyName("l")] string L,
	[property: JsonPropertyName("m")] string M,
	[property: JsonPropertyName("s")] string S
);

public sealed record UserModelRenderedBackgrounds(
	[property: JsonPropertyName("l")] string L,
	[property: JsonPropertyName("m")] string M
);

public sealed record UserModelRendered(
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatars")] UserModelRenderedAvatars Avatars,
	[property: JsonPropertyName("backgrounds")] UserModelRenderedBackgrounds Backgrounds,
	[property: JsonPropertyName("link")] string Link
);

public sealed record UserModelRestoreData(
	[property: JsonPropertyName("12345")] long _12345
);

public sealed record UserModelTags(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
);

public sealed record UserModelTelegramClient(
	[property: JsonPropertyName("telegram_api_id")] string TelegramApiId,
	[property: JsonPropertyName("telegram_api_hash")] string TelegramApiHash,
	[property: JsonPropertyName("telegram_device_model")] string TelegramDeviceModel,
	[property: JsonPropertyName("telegram_system_version")] string TelegramSystemVersion,
	[property: JsonPropertyName("telegram_app_version")] string TelegramAppVersion,
	[property: JsonPropertyName("telegram_system_lang_code")] string TelegramSystemLangCode,
	[property: JsonPropertyName("telegram_lang_code")] string TelegramLangCode,
	[property: JsonPropertyName("telegram_lang_pack")] string TelegramLangPack
);

// ─── AutoPaymentsApi Types ────────────────────────────────────────

public static class AutoPaymentsApiTypes
{
	public sealed record AutoPaymentsListResponse(
		[property: JsonPropertyName("payments")] AutoPaymentsListResponsePayments Payments,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record AutoPaymentsListResponsePayments1234567890ReceiverLinks(
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

	public sealed record AutoPaymentsListResponsePayments1234567890ReceiverPermissions(
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("ignore")] bool Ignore,
	[property: JsonPropertyName("profile_post")] bool ProfilePost
);

	public sealed record AutoPaymentsListResponsePayments1234567890ReceiverFields(
	[property: JsonPropertyName("id")] string Id,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("position")] string Position,
	[property: JsonPropertyName("is_required")] bool IsRequired,
	[property: JsonPropertyName("value")] string Value
);

	public sealed record AutoPaymentsListResponsePayments1234567890Receiver(
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
	[property: JsonPropertyName("links")] AutoPaymentsListResponsePayments1234567890ReceiverLinks Links,
	[property: JsonPropertyName("permissions")] AutoPaymentsListResponsePayments1234567890ReceiverPermissions Permissions,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("user_is_visitor")] bool UserIsVisitor,
	[property: JsonPropertyName("user_group_id")] long UserGroupId,
	[property: JsonPropertyName("fields")] List<AutoPaymentsListResponsePayments1234567890ReceiverFields> Fields
);

	public sealed record AutoPaymentsListResponsePayments1234567890(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("receiver_id")] long ReceiverId,
	[property: JsonPropertyName("amount")] string Amount,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("next_payment")] long NextPayment,
	[property: JsonPropertyName("next_alert_date")] long NextAlertDate,
	[property: JsonPropertyName("auto_payment_id")] long AutoPaymentId,
	[property: JsonPropertyName("day")] string Day,
	[property: JsonPropertyName("receiver")] AutoPaymentsListResponsePayments1234567890Receiver Receiver
);

	public sealed record AutoPaymentsListResponsePayments(
	[property: JsonPropertyName("1234567890")] AutoPaymentsListResponsePayments1234567890 _1234567890
);

	public sealed record AutoPaymentsCreateBody
	{
		[JsonPropertyName("secret_answer")]
		public string? SecretAnswer { get; init; }
		[JsonPropertyName("username_receiver")]
		public required string UsernameReceiver { get; init; }
		[JsonPropertyName("day")]
		public required Day Day { get; init; }
		[JsonPropertyName("amount")]
		public required double? Amount { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
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
		public required long? AutoPaymentId { get; init; }
	}

	public sealed record AutoPaymentsDeleteResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);
}

// ─── BatchApi Types ────────────────────────────────────────

public static class BatchApiTypes
{
	public sealed record BatchBatchResponse(
		[property: JsonPropertyName("jobs")] BatchBatchResponseJobs Jobs,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record BatchBatchResponseJobsJobId(
	[property: JsonPropertyName("_job_result")] string? JobResult,
	[property: JsonPropertyName("_job_error")] string? JobError
);

	public sealed record BatchBatchResponseJobs(
	[property: JsonPropertyName("job_id")] BatchBatchResponseJobsJobId JobId
);
}

// ─── CartApi Types ────────────────────────────────────────

public static class CartApiTypes
{
	public sealed record CartGetParams
	{
		[JsonPropertyName("category_id")]
		public CategoryId? CategoryId { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
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
		public required long? ItemId { get; init; }
	}

	public sealed record CartAddResponse(
		[property: JsonPropertyName("success")] bool Success,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CartDeleteBody
	{
		[JsonPropertyName("item_id")]
		public long? ItemId { get; init; }
	}

	public sealed record CartDeleteResponse(
		[property: JsonPropertyName("success")] bool Success,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);
}

// ─── CategoryApi Types ────────────────────────────────────────

public static class CategoryApiTypes
{
	public sealed record CategoryAllParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
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
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("game[]")]
		public List<long?>? Game { get; init; }
		[JsonPropertyName("hours_played")]
		public JsonElement? HoursPlayed { get; init; }
		[JsonPropertyName("hours_played_max")]
		public JsonElement? HoursPlayedMax { get; init; }
		[JsonPropertyName("eg")]
		public CategoryEg? Eg { get; init; }
		[JsonPropertyName("vac[]")]
		public List<long?>? Vac { get; init; }
		[JsonPropertyName("vac_skip_game_check")]
		public bool? VacSkipGameCheck { get; init; }
		/// <summary>Default: no</summary>
		[JsonPropertyName("rt")]
		public Rt? Rt { get; init; }
		[JsonPropertyName("trade_ban")]
		public TradeBan? TradeBan { get; init; }
		[JsonPropertyName("trade_limit")]
		public TradeLimit? TradeLimit { get; init; }
		[JsonPropertyName("daybreak")]
		public long? Daybreak { get; init; }
		[JsonPropertyName("limit")]
		public Limit? Limit { get; init; }
		[JsonPropertyName("mafile")]
		public Mafile? Mafile { get; init; }
		[JsonPropertyName("reg")]
		public long? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public RegPeriod? RegPeriod { get; init; }
		[JsonPropertyName("lmin")]
		public long? Lmin { get; init; }
		[JsonPropertyName("lmax")]
		public long? Lmax { get; init; }
		[JsonPropertyName("rmin")]
		public long? Rmin { get; init; }
		[JsonPropertyName("rmax")]
		public long? Rmax { get; init; }
		[JsonPropertyName("wingman_rmin")]
		public long? WingmanRmin { get; init; }
		[JsonPropertyName("wingman_rmax")]
		public long? WingmanRmax { get; init; }
		[JsonPropertyName("no_vac")]
		public bool? NoVac { get; init; }
		[JsonPropertyName("mm_ban")]
		public MmBan? MmBan { get; init; }
		[JsonPropertyName("balance_min")]
		public long? BalanceMin { get; init; }
		[JsonPropertyName("balance_max")]
		public long? BalanceMax { get; init; }
		[JsonPropertyName("inv_game")]
		public long? InvGame { get; init; }
		[JsonPropertyName("inv_min")]
		public double? InvMin { get; init; }
		[JsonPropertyName("inv_max")]
		public double? InvMax { get; init; }
		[JsonPropertyName("friends_min")]
		public long? FriendsMin { get; init; }
		[JsonPropertyName("friends_max")]
		public long? FriendsMax { get; init; }
		[JsonPropertyName("gmin")]
		public long? Gmin { get; init; }
		[JsonPropertyName("gmax")]
		public long? Gmax { get; init; }
		[JsonPropertyName("win_count_min")]
		public long? WinCountMin { get; init; }
		[JsonPropertyName("win_count_max")]
		public long? WinCountMax { get; init; }
		[JsonPropertyName("medal_id[]")]
		public JsonElement? MedalId { get; init; }
		[JsonPropertyName("medal_operator_or")]
		public bool? MedalOperatorOr { get; init; }
		[JsonPropertyName("medal_min")]
		public long? MedalMin { get; init; }
		[JsonPropertyName("medal_max")]
		public long? MedalMax { get; init; }
		[JsonPropertyName("gift[]")]
		public JsonElement? Gift { get; init; }
		[JsonPropertyName("gift_min")]
		public long? GiftMin { get; init; }
		[JsonPropertyName("gift_max")]
		public long? GiftMax { get; init; }
		[JsonPropertyName("recently_hours_min")]
		public long? RecentlyHoursMin { get; init; }
		[JsonPropertyName("recently_hours_max")]
		public long? RecentlyHoursMax { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("cs2_profile_rank_min")]
		public long? Cs2ProfileRankMin { get; init; }
		[JsonPropertyName("cs2_profile_rank_max")]
		public long? Cs2ProfileRankMax { get; init; }
		[JsonPropertyName("solommr_min")]
		public long? SolommrMin { get; init; }
		[JsonPropertyName("solommr_max")]
		public long? SolommrMax { get; init; }
		[JsonPropertyName("d2_game_count_min")]
		public long? D2GameCountMin { get; init; }
		[JsonPropertyName("d2_game_count_max")]
		public long? D2GameCountMax { get; init; }
		[JsonPropertyName("d2_win_count_min")]
		public long? D2WinCountMin { get; init; }
		[JsonPropertyName("d2_win_count_max")]
		public long? D2WinCountMax { get; init; }
		[JsonPropertyName("d2_behavior_min")]
		public long? D2BehaviorMin { get; init; }
		[JsonPropertyName("d2_behavior_max")]
		public long? D2BehaviorMax { get; init; }
		[JsonPropertyName("faceit_lvl_min")]
		public long? FaceitLvlMin { get; init; }
		[JsonPropertyName("faceit_lvl_max")]
		public long? FaceitLvlMax { get; init; }
		[JsonPropertyName("points_min")]
		public long? PointsMin { get; init; }
		[JsonPropertyName("points_max")]
		public long? PointsMax { get; init; }
		[JsonPropertyName("relevant_gmin")]
		public long? RelevantGmin { get; init; }
		[JsonPropertyName("relevant_gmax")]
		public long? RelevantGmax { get; init; }
		[JsonPropertyName("last_trans_date")]
		public long? LastTransDate { get; init; }
		[JsonPropertyName("last_trans_date_period")]
		public LastTransDatePeriod? LastTransDatePeriod { get; init; }
		[JsonPropertyName("last_trans_date_later")]
		public long? LastTransDateLater { get; init; }
		[JsonPropertyName("last_trans_date_period_later")]
		public LastTransDatePeriodLater? LastTransDatePeriodLater { get; init; }
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
		public HasActivatedKeys? HasActivatedKeys { get; init; }
		[JsonPropertyName("elo_min")]
		public long? EloMin { get; init; }
		[JsonPropertyName("elo_max")]
		public long? EloMax { get; init; }
		[JsonPropertyName("cs2_map_rank")]
		public Cs2MapRank? Cs2MapRank { get; init; }
		[JsonPropertyName("cs2_map_rmin")]
		public long? Cs2MapRmin { get; init; }
		[JsonPropertyName("cs2_map_rmax")]
		public long? Cs2MapRmax { get; init; }
		[JsonPropertyName("has_faceit")]
		public HasFaceit? HasFaceit { get; init; }
		[JsonPropertyName("faceit_csgo_lvl_min")]
		public long? FaceitCsgoLvlMin { get; init; }
		[JsonPropertyName("faceit_csgo_lvl_max")]
		public long? FaceitCsgoLvlMax { get; init; }
		[JsonPropertyName("rust_deaths_min")]
		public long? RustDeathsMin { get; init; }
		[JsonPropertyName("rust_deaths_max")]
		public long? RustDeathsMax { get; init; }
		[JsonPropertyName("rust_kills_min")]
		public long? RustKillsMin { get; init; }
		[JsonPropertyName("rust_kills_max")]
		public long? RustKillsMax { get; init; }
		[JsonPropertyName("d2_last_match_date")]
		public long? D2LastMatchDate { get; init; }
		[JsonPropertyName("d2_last_match_date_period")]
		public D2LastMatchDatePeriod? D2LastMatchDatePeriod { get; init; }
		[JsonPropertyName("cards_min")]
		public long? CardsMin { get; init; }
		[JsonPropertyName("cards_max")]
		public long? CardsMax { get; init; }
		[JsonPropertyName("cards_games_min")]
		public long? CardsGamesMin { get; init; }
		[JsonPropertyName("cards_games_max")]
		public long? CardsGamesMax { get; init; }
		[JsonPropertyName("skip_vac_inv")]
		public bool? SkipVacInv { get; init; }
	}

	public sealed record CategorySteamResponse(
		[property: JsonPropertyName("items")] List<CategorySteamResponseItems> Items,
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

	public sealed record CategorySteamResponseItemsSteamFullGamesList730(
	[property: JsonPropertyName("appid")] long Appid,
	[property: JsonPropertyName("playtime_forever")] double PlaytimeForever,
	[property: JsonPropertyName("internal_game_id")] long InternalGameId,
	[property: JsonPropertyName("abbr")] string Abbr,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("parentGameId")] long ParentGameId,
	[property: JsonPropertyName("img")] string Img
);

	public sealed record CategorySteamResponseItemsSteamFullGamesList(
	[property: JsonPropertyName("730")] CategorySteamResponseItemsSteamFullGamesList730 _730
);

	public sealed record CategorySteamResponseItemsSteamFullGames(
	[property: JsonPropertyName("list")] CategorySteamResponseItemsSteamFullGamesList List,
	[property: JsonPropertyName("total")] long Total
);

	public sealed record CategorySteamResponseItemsGuarantee(
	[property: JsonPropertyName("duration")] long Duration,
	[property: JsonPropertyName("class")] string Class,
	[property: JsonPropertyName("durationPhrase")] string DurationPhrase,
	[property: JsonPropertyName("endDate")] JsonElement EndDate,
	[property: JsonPropertyName("active")] JsonElement Active,
	[property: JsonPropertyName("cancelled")] JsonElement Cancelled,
	[property: JsonPropertyName("remainingTime")] JsonElement RemainingTime
);

	public sealed record CategorySteamResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategorySteamResponseItemsSteamData(
	[property: JsonPropertyName("steam_ban_type_id")] List<JsonElement> SteamBanTypeId
);

	public sealed record CategorySteamResponseItemsSteamTransactions(
	[property: JsonPropertyName("date")] string Date,
	[property: JsonPropertyName("product")] string Product,
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("source")] string Source,
	[property: JsonPropertyName("amount")] string Amount
);

	public sealed record CategorySteamResponseItemsAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
);

	public sealed record CategorySteamResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long RestorePercents
);

	public sealed record CategorySteamResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("steam_item_id")] long SteamItemId,
	[property: JsonPropertyName("steam_country")] string SteamCountry,
	[property: JsonPropertyName("steam_register_date")] long SteamRegisterDate,
	[property: JsonPropertyName("steam_last_activity")] long SteamLastActivity,
	[property: JsonPropertyName("steam_full_games")] CategorySteamResponseItemsSteamFullGames SteamFullGames,
	[property: JsonPropertyName("steam_community_ban")] long SteamCommunityBan,
	[property: JsonPropertyName("steam_bans")] string SteamBans,
	[property: JsonPropertyName("steam_cs2_profile_rank")] long SteamCs2ProfileRank,
	[property: JsonPropertyName("steam_balance")] string SteamBalance,
	[property: JsonPropertyName("steam_cs2_rank_id")] long SteamCs2RankId,
	[property: JsonPropertyName("steam_is_limited")] long SteamIsLimited,
	[property: JsonPropertyName("steam_level")] long SteamLevel,
	[property: JsonPropertyName("steam_friend_count")] long SteamFriendCount,
	[property: JsonPropertyName("steam_cs2_last_activity")] long SteamCs2LastActivity,
	[property: JsonPropertyName("steam_dota2_solo_mmr")] long SteamDota2SoloMmr,
	[property: JsonPropertyName("steam_cs2_ban_date")] long SteamCs2BanDate,
	[property: JsonPropertyName("steam_converted_balance")] long SteamConvertedBalance,
	[property: JsonPropertyName("steam_cards_count")] long SteamCardsCount,
	[property: JsonPropertyName("steam_cards_games")] long SteamCardsGames,
	[property: JsonPropertyName("steam_pubg_inv_value")] long SteamPubgInvValue,
	[property: JsonPropertyName("steam_cs2_inv_value")] long SteamCs2InvValue,
	[property: JsonPropertyName("steam_dota2_inv_value")] long SteamDota2InvValue,
	[property: JsonPropertyName("steam_tf2_inv_value")] long SteamTf2InvValue,
	[property: JsonPropertyName("steam_rust_inv_value")] long SteamRustInvValue,
	[property: JsonPropertyName("steam_cs2_wingman_rank_id")] long SteamCs2WingmanRankId,
	[property: JsonPropertyName("steam_game_count")] long SteamGameCount,
	[property: JsonPropertyName("steam_steam_inv_value")] long SteamSteamInvValue,
	[property: JsonPropertyName("steam_inv_value")] long SteamInvValue,
	[property: JsonPropertyName("steam_cs2_win_count")] long SteamCs2WinCount,
	[property: JsonPropertyName("steam_dota2_game_count")] long SteamDota2GameCount,
	[property: JsonPropertyName("steam_dota2_lose_count")] long SteamDota2LoseCount,
	[property: JsonPropertyName("steam_dota2_win_count")] long SteamDota2WinCount,
	[property: JsonPropertyName("steam_hours_played_recently")] string SteamHoursPlayedRecently,
	[property: JsonPropertyName("steam_faceit_level")] long SteamFaceitLevel,
	[property: JsonPropertyName("steam_points")] long SteamPoints,
	[property: JsonPropertyName("steam_last_transaction_date")] long SteamLastTransactionDate,
	[property: JsonPropertyName("steam_relevant_game_count")] long SteamRelevantGameCount,
	[property: JsonPropertyName("steam_gift_count")] long SteamGiftCount,
	[property: JsonPropertyName("steam_limit_spent")] string SteamLimitSpent,
	[property: JsonPropertyName("steam_dota2_behavior")] long SteamDota2Behavior,
	[property: JsonPropertyName("steam_mfa")] long SteamMfa,
	[property: JsonPropertyName("steam_market")] long SteamMarket,
	[property: JsonPropertyName("steam_market_restrictions")] long SteamMarketRestrictions,
	[property: JsonPropertyName("steam_market_ban_end_date")] long SteamMarketBanEndDate,
	[property: JsonPropertyName("steam_unturned_inv_value")] long SteamUnturnedInvValue,
	[property: JsonPropertyName("steam_cs2_last_launched")] long SteamCs2LastLaunched,
	[property: JsonPropertyName("steam_kf2_inv_value")] long SteamKf2InvValue,
	[property: JsonPropertyName("steam_dst_inv_value")] long SteamDstInvValue,
	[property: JsonPropertyName("steam_cs2_premier_elo")] long SteamCs2PremierElo,
	[property: JsonPropertyName("steam_has_activated_keys")] long SteamHasActivatedKeys,
	[property: JsonPropertyName("steam_cs2_ban_type")] long SteamCs2BanType,
	[property: JsonPropertyName("steam_rust_kill_player")] long SteamRustKillPlayer,
	[property: JsonPropertyName("steam_rust_deaths")] long SteamRustDeaths,
	[property: JsonPropertyName("steam_total_gifts_rub")] long SteamTotalGiftsRub,
	[property: JsonPropertyName("steam_total_refunds_rub")] long SteamTotalRefundsRub,
	[property: JsonPropertyName("steam_total_ingame_rub")] long SteamTotalIngameRub,
	[property: JsonPropertyName("steam_total_games_rub")] long SteamTotalGamesRub,
	[property: JsonPropertyName("steam_total_purchased_rub")] long SteamTotalPurchasedRub,
	[property: JsonPropertyName("steam_dota2_last_match_date")] long SteamDota2LastMatchDate,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] CategorySteamResponseItemsGuarantee Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategorySteamResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("steamData")] CategorySteamResponseItemsSteamData SteamData,
	[property: JsonPropertyName("steamRelevantGameCount")] long SteamRelevantGameCount2,
	[property: JsonPropertyName("isSmallExf")] bool IsSmallExf,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("hasCs2")] bool HasCs2,
	[property: JsonPropertyName("hasDota2")] bool HasDota2,
	[property: JsonPropertyName("hasPubg")] bool HasPubg,
	[property: JsonPropertyName("hasTf2")] bool HasTf2,
	[property: JsonPropertyName("hasRust")] bool HasRust,
	[property: JsonPropertyName("steam_cs2_ban_date_active")] bool SteamCs2BanDateActive,
	[property: JsonPropertyName("dota2CalibrationWarning")] bool Dota2CalibrationWarning,
	[property: JsonPropertyName("displayConvertedBalance")] bool DisplayConvertedBalance,
	[property: JsonPropertyName("inventoryValue")] List<JsonElement> InventoryValue,
	[property: JsonPropertyName("steamCs2Medals")] List<JsonElement> SteamCs2Medals,
	[property: JsonPropertyName("cs2RankExpired")] bool Cs2RankExpired,
	[property: JsonPropertyName("steamDota2WinRate")] long SteamDota2WinRate,
	[property: JsonPropertyName("steamTransactions")] List<CategorySteamResponseItemsSteamTransactions> SteamTransactions,
	[property: JsonPropertyName("hasPossibleBanInDota2")] bool HasPossibleBanInDota2,
	[property: JsonPropertyName("chineseAccount")] bool ChineseAccount,
	[property: JsonPropertyName("cs2MapsRanks")] List<JsonElement> Cs2MapsRanks,
	[property: JsonPropertyName("cs2PremierElo")] List<JsonElement> Cs2PremierElo,
	[property: JsonPropertyName("steamLifetimeTradeBan")] bool SteamLifetimeTradeBan,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<CategorySteamResponseItemsAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategorySteamResponseItemsSeller Seller
);

	public sealed record CategoryFortniteParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("temp_email")]
		public TempEmail? TempEmail { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("eg")]
		public CategoryEg? Eg { get; init; }
		[JsonPropertyName("smin")]
		public long? Smin { get; init; }
		[JsonPropertyName("smax")]
		public long? Smax { get; init; }
		[JsonPropertyName("vbmin")]
		public long? Vbmin { get; init; }
		[JsonPropertyName("vbmax")]
		public long? Vbmax { get; init; }
		[JsonPropertyName("skin[]")]
		public JsonElement? Skin { get; init; }
		[JsonPropertyName("pickaxe[]")]
		public JsonElement? Pickaxe { get; init; }
		[JsonPropertyName("glider[]")]
		public JsonElement? Glider { get; init; }
		[JsonPropertyName("dance[]")]
		public JsonElement? Dance { get; init; }
		[JsonPropertyName("change_email")]
		public ChangeEmail? ChangeEmail { get; init; }
		[JsonPropertyName("platform[]")]
		public JsonElement? Platform { get; init; }
		[JsonPropertyName("skins_shop_min")]
		public long? SkinsShopMin { get; init; }
		[JsonPropertyName("skins_shop_max")]
		public long? SkinsShopMax { get; init; }
		[JsonPropertyName("pickaxes_shop_min")]
		public long? PickaxesShopMin { get; init; }
		[JsonPropertyName("pickaxes_shop_max")]
		public long? PickaxesShopMax { get; init; }
		[JsonPropertyName("dances_shop_min")]
		public long? DancesShopMin { get; init; }
		[JsonPropertyName("dances_shop_max")]
		public long? DancesShopMax { get; init; }
		[JsonPropertyName("gliders_shop_min")]
		public long? GlidersShopMin { get; init; }
		[JsonPropertyName("gliders_shop_max")]
		public long? GlidersShopMax { get; init; }
		[JsonPropertyName("skins_shop_vbmin")]
		public long? SkinsShopVbmin { get; init; }
		[JsonPropertyName("skins_shop_vbmax")]
		public long? SkinsShopVbmax { get; init; }
		[JsonPropertyName("pickaxes_shop_vbmin")]
		public long? PickaxesShopVbmin { get; init; }
		[JsonPropertyName("pickaxes_shop_vbmax")]
		public long? PickaxesShopVbmax { get; init; }
		[JsonPropertyName("dances_shop_vbmin")]
		public long? DancesShopVbmin { get; init; }
		[JsonPropertyName("dances_shop_vbmax")]
		public long? DancesShopVbmax { get; init; }
		[JsonPropertyName("gliders_shop_vbmin")]
		public long? GlidersShopVbmin { get; init; }
		[JsonPropertyName("gliders_shop_vbmax")]
		public long? GlidersShopVbmax { get; init; }
		[JsonPropertyName("bp")]
		public Bp? Bp { get; init; }
		[JsonPropertyName("lmin")]
		public long? Lmin { get; init; }
		[JsonPropertyName("lmax")]
		public long? Lmax { get; init; }
		[JsonPropertyName("bp_lmin")]
		public long? BpLmin { get; init; }
		[JsonPropertyName("bp_lmax")]
		public long? BpLmax { get; init; }
		[JsonPropertyName("last_trans_date")]
		public long? LastTransDate { get; init; }
		[JsonPropertyName("last_trans_date_period")]
		public LastTransDatePeriod? LastTransDatePeriod { get; init; }
		[JsonPropertyName("no_trans")]
		public bool? NoTrans { get; init; }
		[JsonPropertyName("xbox_linkable")]
		public XboxLinkable? XboxLinkable { get; init; }
		[JsonPropertyName("psn_linkable")]
		public PsnLinkable? PsnLinkable { get; init; }
		[JsonPropertyName("daybreak")]
		public long? Daybreak { get; init; }
		[JsonPropertyName("rl_purchases")]
		public bool? RlPurchases { get; init; }
		[JsonPropertyName("reg")]
		public long? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public RegPeriod? RegPeriod { get; init; }
		[JsonPropertyName("refund_credits_min")]
		public long? RefundCreditsMin { get; init; }
		[JsonPropertyName("refund_credits_max")]
		public long? RefundCreditsMax { get; init; }
		[JsonPropertyName("pickaxe_min")]
		public long? PickaxeMin { get; init; }
		[JsonPropertyName("pickaxe_max")]
		public long? PickaxeMax { get; init; }
		[JsonPropertyName("dmin")]
		public long? Dmin { get; init; }
		[JsonPropertyName("dmax")]
		public long? Dmax { get; init; }
		[JsonPropertyName("gmin")]
		public long? Gmin { get; init; }
		[JsonPropertyName("gmax")]
		public long? Gmax { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
	}

	public sealed record CategoryFortniteResponse(
		[property: JsonPropertyName("items")] List<CategoryFortniteResponseItems> Items,
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

	public sealed record CategoryFortniteResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryFortniteResponseItemsFortniteSkins(
	[property: JsonPropertyName("id")] string Id,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rarity")] string Rarity,
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("from_shop")] long FromShop
);

	public sealed record CategoryFortniteResponseItemsFortnitePickaxe(
	[property: JsonPropertyName("id")] string Id,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rarity")] string Rarity,
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("from_shop")] long FromShop
);

	public sealed record CategoryFortniteResponseItemsFortniteDance(
	[property: JsonPropertyName("id")] string Id,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rarity")] string Rarity,
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("from_shop")] long FromShop
);

	public sealed record CategoryFortniteResponseItemsFortniteGliders(
	[property: JsonPropertyName("id")] string Id,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rarity")] string Rarity,
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("from_shop")] long FromShop
);

	public sealed record CategoryFortniteResponseItemsFortnitePastSeasons(
	[property: JsonPropertyName("numWins")] long NumWins,
	[property: JsonPropertyName("seasonXp")] long SeasonXp,
	[property: JsonPropertyName("purchasedVIP")] bool PurchasedVIP,
	[property: JsonPropertyName("survivorPrestige")] long SurvivorPrestige,
	[property: JsonPropertyName("seasonLevel")] long SeasonLevel,
	[property: JsonPropertyName("numLowBracket")] long NumLowBracket,
	[property: JsonPropertyName("bookLevel")] long BookLevel,
	[property: JsonPropertyName("numRoyalRoyales")] long NumRoyalRoyales,
	[property: JsonPropertyName("seasonNumber")] long SeasonNumber,
	[property: JsonPropertyName("survivorTier")] long SurvivorTier,
	[property: JsonPropertyName("numHighBracket")] long NumHighBracket
);

	public sealed record CategoryFortniteResponseItemsFortniteTransactions(
	[property: JsonPropertyName("date")] long Date,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("presentmentTotal")] string PresentmentTotal,
	[property: JsonPropertyName("orderType")] string OrderType
);

	public sealed record CategoryFortniteResponseItemsShopCounts(
	[property: JsonPropertyName("shopSkinsCount")] long ShopSkinsCount,
	[property: JsonPropertyName("shopPickaxesCount")] long ShopPickaxesCount,
	[property: JsonPropertyName("shopDancesCount")] long ShopDancesCount,
	[property: JsonPropertyName("shopGlidersCount")] long ShopGlidersCount
);

	public sealed record CategoryFortniteResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long RestorePercents
);

	public sealed record CategoryFortniteResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("fortnite_item_id")] long FortniteItemId,
	[property: JsonPropertyName("fortnite_platform")] string FortnitePlatform,
	[property: JsonPropertyName("fortnite_register_date")] long FortniteRegisterDate,
	[property: JsonPropertyName("fortnite_last_activity")] long FortniteLastActivity,
	[property: JsonPropertyName("fortnite_book_level")] long FortniteBookLevel,
	[property: JsonPropertyName("fortnite_lifetime_wins")] long FortniteLifetimeWins,
	[property: JsonPropertyName("fortnite_level")] long FortniteLevel,
	[property: JsonPropertyName("fortnite_season_num")] long FortniteSeasonNum,
	[property: JsonPropertyName("fortnite_books_purchased")] long FortniteBooksPurchased,
	[property: JsonPropertyName("fortnite_balance")] long FortniteBalance,
	[property: JsonPropertyName("fortnite_skin_count")] long FortniteSkinCount,
	[property: JsonPropertyName("fortnite_change_email")] long FortniteChangeEmail,
	[property: JsonPropertyName("fortnite_rl_purchases")] long FortniteRlPurchases,
	[property: JsonPropertyName("fortnite_next_change_email_date")] long FortniteNextChangeEmailDate,
	[property: JsonPropertyName("fortnite_last_trans_date")] long FortniteLastTransDate,
	[property: JsonPropertyName("fortnite_xbox_linkable")] long FortniteXboxLinkable,
	[property: JsonPropertyName("fortnite_psn_linkable")] long FortnitePsnLinkable,
	[property: JsonPropertyName("fortnite_shop_skins_count")] long FortniteShopSkinsCount,
	[property: JsonPropertyName("fortnite_shop_pickaxes_count")] long FortniteShopPickaxesCount,
	[property: JsonPropertyName("fortnite_shop_dances_count")] long FortniteShopDancesCount,
	[property: JsonPropertyName("fortnite_shop_gliders_count")] long FortniteShopGlidersCount,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryFortniteResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("fortniteSkins")] List<CategoryFortniteResponseItemsFortniteSkins> FortniteSkins,
	[property: JsonPropertyName("fortnitePickaxe")] List<CategoryFortniteResponseItemsFortnitePickaxe> FortnitePickaxe,
	[property: JsonPropertyName("fortniteDance")] List<CategoryFortniteResponseItemsFortniteDance> FortniteDance,
	[property: JsonPropertyName("fortniteGliders")] List<CategoryFortniteResponseItemsFortniteGliders> FortniteGliders,
	[property: JsonPropertyName("fortnite_pickaxe_count")] long FortnitePickaxeCount,
	[property: JsonPropertyName("fortnite_dance_count")] long FortniteDanceCount,
	[property: JsonPropertyName("fortnite_glider_count")] long FortniteGliderCount,
	[property: JsonPropertyName("fortnitePastSeasons")] List<CategoryFortniteResponseItemsFortnitePastSeasons> FortnitePastSeasons,
	[property: JsonPropertyName("isSmallExf")] bool IsSmallExf,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("fortniteTransactions")] List<CategoryFortniteResponseItemsFortniteTransactions> FortniteTransactions,
	[property: JsonPropertyName("domain")] string Domain,
	[property: JsonPropertyName("shopCounts")] CategoryFortniteResponseItemsShopCounts ShopCounts,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<JsonElement> AccountLinks,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryFortniteResponseItemsSeller Seller
);

	public sealed record CategoryMihoyoParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("email")]
		public Email? Email { get; init; }
		[JsonPropertyName("ea")]
		public Ea? Ea { get; init; }
		[JsonPropertyName("region")]
		public Region? Region { get; init; }
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
		public long? GenshinCharMin { get; init; }
		[JsonPropertyName("genshin_char_max")]
		public long? GenshinCharMax { get; init; }
		[JsonPropertyName("genshin_legendary_min")]
		public long? GenshinLegendaryMin { get; init; }
		[JsonPropertyName("genshin_legendary_max")]
		public long? GenshinLegendaryMax { get; init; }
		[JsonPropertyName("genshin_level_min")]
		public long? GenshinLevelMin { get; init; }
		[JsonPropertyName("genshin_level_max")]
		public long? GenshinLevelMax { get; init; }
		[JsonPropertyName("genshin_legendary_weapon_min")]
		public long? GenshinLegendaryWeaponMin { get; init; }
		[JsonPropertyName("genshin_legendary_weapon_max")]
		public long? GenshinLegendaryWeaponMax { get; init; }
		[JsonPropertyName("constellations_min")]
		public long? ConstellationsMin { get; init; }
		[JsonPropertyName("constellations_max")]
		public long? ConstellationsMax { get; init; }
		[JsonPropertyName("genshin_achievement_min")]
		public long? GenshinAchievementMin { get; init; }
		[JsonPropertyName("genshin_achievement_max")]
		public long? GenshinAchievementMax { get; init; }
		[JsonPropertyName("genshin_currency_min")]
		public long? GenshinCurrencyMin { get; init; }
		[JsonPropertyName("genshin_currency_max")]
		public long? GenshinCurrencyMax { get; init; }
		[JsonPropertyName("honkai_character[]")]
		public JsonElement? HonkaiCharacter { get; init; }
		[JsonPropertyName("honkai_character_eidolons")]
		public JsonElement? HonkaiCharacterEidolons { get; init; }
		[JsonPropertyName("honkai_character_eidolons_max")]
		public JsonElement? HonkaiCharacterEidolonsMax { get; init; }
		[JsonPropertyName("honkai_weapon[]")]
		public JsonElement? HonkaiWeapon { get; init; }
		[JsonPropertyName("honkai_char_min")]
		public long? HonkaiCharMin { get; init; }
		[JsonPropertyName("honkai_char_max")]
		public long? HonkaiCharMax { get; init; }
		[JsonPropertyName("honkai_legendary_min")]
		public long? HonkaiLegendaryMin { get; init; }
		[JsonPropertyName("honkai_legendary_max")]
		public long? HonkaiLegendaryMax { get; init; }
		[JsonPropertyName("honkai_level_min")]
		public long? HonkaiLevelMin { get; init; }
		[JsonPropertyName("honkai_level_max")]
		public long? HonkaiLevelMax { get; init; }
		[JsonPropertyName("honkai_legendary_weapon_min")]
		public long? HonkaiLegendaryWeaponMin { get; init; }
		[JsonPropertyName("honkai_legendary_weapon_max")]
		public long? HonkaiLegendaryWeaponMax { get; init; }
		[JsonPropertyName("eidolons_min")]
		public long? EidolonsMin { get; init; }
		[JsonPropertyName("eidolons_max")]
		public long? EidolonsMax { get; init; }
		[JsonPropertyName("honkai_achievement_min")]
		public long? HonkaiAchievementMin { get; init; }
		[JsonPropertyName("honkai_achievement_max")]
		public long? HonkaiAchievementMax { get; init; }
		[JsonPropertyName("honkai_currency_min")]
		public long? HonkaiCurrencyMin { get; init; }
		[JsonPropertyName("honkai_currency_max")]
		public long? HonkaiCurrencyMax { get; init; }
		[JsonPropertyName("zenless_character[]")]
		public JsonElement? ZenlessCharacter { get; init; }
		[JsonPropertyName("zenless_character_cinemas")]
		public JsonElement? ZenlessCharacterCinemas { get; init; }
		[JsonPropertyName("zenless_character_cinemas_max")]
		public JsonElement? ZenlessCharacterCinemasMax { get; init; }
		[JsonPropertyName("zenless_weapon[]")]
		public JsonElement? ZenlessWeapon { get; init; }
		[JsonPropertyName("zenless_legendary_min")]
		public long? ZenlessLegendaryMin { get; init; }
		[JsonPropertyName("zenless_legendary_max")]
		public long? ZenlessLegendaryMax { get; init; }
		[JsonPropertyName("cinemas_min")]
		public long? CinemasMin { get; init; }
		[JsonPropertyName("cinemas_max")]
		public long? CinemasMax { get; init; }
		[JsonPropertyName("zenless_legendary_weapon_min")]
		public long? ZenlessLegendaryWeaponMin { get; init; }
		[JsonPropertyName("zenless_legendary_weapon_max")]
		public long? ZenlessLegendaryWeaponMax { get; init; }
		[JsonPropertyName("zenless_char_min")]
		public long? ZenlessCharMin { get; init; }
		[JsonPropertyName("zenless_char_max")]
		public long? ZenlessCharMax { get; init; }
		[JsonPropertyName("zenless_level_min")]
		public long? ZenlessLevelMin { get; init; }
		[JsonPropertyName("zenless_level_max")]
		public long? ZenlessLevelMax { get; init; }
		[JsonPropertyName("zenless_achievement_min")]
		public long? ZenlessAchievementMin { get; init; }
		[JsonPropertyName("zenless_achievement_max")]
		public long? ZenlessAchievementMax { get; init; }
		[JsonPropertyName("zenless_currency_min")]
		public long? ZenlessCurrencyMin { get; init; }
		[JsonPropertyName("zenless_currency_max")]
		public long? ZenlessCurrencyMax { get; init; }
		[JsonPropertyName("daybreak")]
		public long? Daybreak { get; init; }
	}

	public sealed record CategoryMihoyoResponse(
		[property: JsonPropertyName("items")] List<CategoryMihoyoResponseItems> Items,
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

	public sealed record CategoryMihoyoResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryMihoyoResponseItemsMihoyoLinkedAccounts(
	[property: JsonPropertyName("links")] List<string> Links,
	[property: JsonPropertyName("legacy")] bool Legacy
);

	public sealed record CategoryMihoyoResponseItemsHonkaiCharactersEquip(
	[property: JsonPropertyName("id")] long Id,
	[property: JsonPropertyName("level")] long Level,
	[property: JsonPropertyName("rank")] long Rank,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("desc")] string Desc,
	[property: JsonPropertyName("icon")] string Icon,
	[property: JsonPropertyName("rarity")] long Rarity
);

	public sealed record CategoryMihoyoResponseItemsHonkaiCharactersRelicsMainProperty(
	[property: JsonPropertyName("property_type")] long PropertyType,
	[property: JsonPropertyName("value")] string Value,
	[property: JsonPropertyName("times")] long Times
);

	public sealed record CategoryMihoyoResponseItemsHonkaiCharactersRelicsProperties(
	[property: JsonPropertyName("property_type")] long PropertyType,
	[property: JsonPropertyName("value")] string Value,
	[property: JsonPropertyName("times")] long Times
);

	public sealed record CategoryMihoyoResponseItemsHonkaiCharactersRelics(
	[property: JsonPropertyName("id")] long Id,
	[property: JsonPropertyName("level")] long Level,
	[property: JsonPropertyName("pos")] long Pos,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("desc")] string Desc,
	[property: JsonPropertyName("icon")] string Icon,
	[property: JsonPropertyName("rarity")] long Rarity,
	[property: JsonPropertyName("main_property")] CategoryMihoyoResponseItemsHonkaiCharactersRelicsMainProperty MainProperty,
	[property: JsonPropertyName("properties")] List<CategoryMihoyoResponseItemsHonkaiCharactersRelicsProperties> Properties
);

	public sealed record CategoryMihoyoResponseItemsHonkaiCharactersOrnamentsMainProperty(
	[property: JsonPropertyName("property_type")] long PropertyType,
	[property: JsonPropertyName("value")] string Value,
	[property: JsonPropertyName("times")] long Times
);

	public sealed record CategoryMihoyoResponseItemsHonkaiCharactersOrnamentsProperties(
	[property: JsonPropertyName("property_type")] long PropertyType,
	[property: JsonPropertyName("value")] string Value,
	[property: JsonPropertyName("times")] long Times
);

	public sealed record CategoryMihoyoResponseItemsHonkaiCharactersOrnaments(
	[property: JsonPropertyName("id")] long Id,
	[property: JsonPropertyName("level")] long Level,
	[property: JsonPropertyName("pos")] long Pos,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("desc")] string Desc,
	[property: JsonPropertyName("icon")] string Icon,
	[property: JsonPropertyName("rarity")] long Rarity,
	[property: JsonPropertyName("main_property")] CategoryMihoyoResponseItemsHonkaiCharactersOrnamentsMainProperty MainProperty,
	[property: JsonPropertyName("properties")] List<CategoryMihoyoResponseItemsHonkaiCharactersOrnamentsProperties> Properties
);

	public sealed record CategoryMihoyoResponseItemsHonkaiCharacters(
	[property: JsonPropertyName("id")] long Id,
	[property: JsonPropertyName("level")] long Level,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("element")] string Element,
	[property: JsonPropertyName("icon")] string Icon,
	[property: JsonPropertyName("rarity")] long Rarity,
	[property: JsonPropertyName("rank")] long Rank,
	[property: JsonPropertyName("image")] string Image,
	[property: JsonPropertyName("equip")] CategoryMihoyoResponseItemsHonkaiCharactersEquip Equip,
	[property: JsonPropertyName("relics")] List<CategoryMihoyoResponseItemsHonkaiCharactersRelics> Relics,
	[property: JsonPropertyName("ornaments")] List<CategoryMihoyoResponseItemsHonkaiCharactersOrnaments> Ornaments,
	[property: JsonPropertyName("base_type")] long BaseType,
	[property: JsonPropertyName("figure_path")] string FigurePath,
	[property: JsonPropertyName("elementImage")] string ElementImage
);

	public sealed record CategoryMihoyoResponseItemsGenshinCharactersWeapon(
	[property: JsonPropertyName("id")] long Id,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("icon")] string Icon,
	[property: JsonPropertyName("type")] long Type,
	[property: JsonPropertyName("rarity")] long Rarity,
	[property: JsonPropertyName("level")] long Level,
	[property: JsonPropertyName("promote_level")] long PromoteLevel,
	[property: JsonPropertyName("type_name")] string TypeName,
	[property: JsonPropertyName("desc")] string Desc,
	[property: JsonPropertyName("affix_level")] long AffixLevel
);

	public sealed record CategoryMihoyoResponseItemsGenshinCharactersReliquaries(
	[property: JsonPropertyName("id")] long Id,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("icon")] string Icon,
	[property: JsonPropertyName("pos")] long Pos,
	[property: JsonPropertyName("rarity")] long Rarity,
	[property: JsonPropertyName("level")] long Level,
	[property: JsonPropertyName("pos_name")] string PosName
);

	public sealed record CategoryMihoyoResponseItemsGenshinCharacters(
	[property: JsonPropertyName("id")] long Id,
	[property: JsonPropertyName("image")] string Image,
	[property: JsonPropertyName("icon")] string Icon,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("element")] string Element,
	[property: JsonPropertyName("fetter")] long Fetter,
	[property: JsonPropertyName("level")] long Level,
	[property: JsonPropertyName("rarity")] long Rarity,
	[property: JsonPropertyName("weapon")] CategoryMihoyoResponseItemsGenshinCharactersWeapon Weapon,
	[property: JsonPropertyName("reliquaries")] List<CategoryMihoyoResponseItemsGenshinCharactersReliquaries> Reliquaries,
	[property: JsonPropertyName("actived_constellation_num")] long ActivedConstellationNum,
	[property: JsonPropertyName("costumes")] List<JsonElement> Costumes,
	[property: JsonPropertyName("external")] JsonElement External,
	[property: JsonPropertyName("background")] string Background
);

	public sealed record CategoryMihoyoResponseItemsZenlessCharactersWeaponProperties(
	[property: JsonPropertyName("property_name")] string PropertyName,
	[property: JsonPropertyName("property_id")] long PropertyId,
	[property: JsonPropertyName("base")] string Base
);

	public sealed record CategoryMihoyoResponseItemsZenlessCharactersWeaponMainProperties(
	[property: JsonPropertyName("property_name")] string PropertyName,
	[property: JsonPropertyName("property_id")] long PropertyId,
	[property: JsonPropertyName("base")] string Base
);

	public sealed record CategoryMihoyoResponseItemsZenlessCharactersWeapon(
	[property: JsonPropertyName("id")] long Id,
	[property: JsonPropertyName("level")] long Level,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("star")] long Star,
	[property: JsonPropertyName("icon")] string Icon,
	[property: JsonPropertyName("rarity")] long Rarity,
	[property: JsonPropertyName("properties")] List<CategoryMihoyoResponseItemsZenlessCharactersWeaponProperties> Properties,
	[property: JsonPropertyName("main_properties")] List<CategoryMihoyoResponseItemsZenlessCharactersWeaponMainProperties> MainProperties,
	[property: JsonPropertyName("talent_title")] string TalentTitle,
	[property: JsonPropertyName("talent_content")] string TalentContent,
	[property: JsonPropertyName("profession")] long Profession,
	[property: JsonPropertyName("starIcon")] string StarIcon,
	[property: JsonPropertyName("rarityIcon")] string RarityIcon
);

	public sealed record CategoryMihoyoResponseItemsZenlessCharacters(
	[property: JsonPropertyName("id")] long Id,
	[property: JsonPropertyName("level")] long Level,
	[property: JsonPropertyName("name_mi18n")] string NameMi18n,
	[property: JsonPropertyName("full_name_mi18n")] string FullNameMi18n,
	[property: JsonPropertyName("element_type")] long ElementType,
	[property: JsonPropertyName("camp_name_mi18n")] string CampNameMi18n,
	[property: JsonPropertyName("avatar_profession")] long AvatarProfession,
	[property: JsonPropertyName("rarity")] long Rarity,
	[property: JsonPropertyName("weapon")] CategoryMihoyoResponseItemsZenlessCharactersWeapon Weapon,
	[property: JsonPropertyName("rank")] long Rank,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("rarityIcon")] string RarityIcon,
	[property: JsonPropertyName("elementIcon")] string ElementIcon,
	[property: JsonPropertyName("professionIcon")] string ProfessionIcon
);

	public sealed record CategoryMihoyoResponseItemsAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
);

	public sealed record CategoryMihoyoResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long RestorePercents
);

	public sealed record CategoryMihoyoResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("mihoyo_item_id")] long MihoyoItemId,
	[property: JsonPropertyName("mihoyo_id")] long MihoyoId,
	[property: JsonPropertyName("mihoyo_email")] long MihoyoEmail,
	[property: JsonPropertyName("mihoyo_has_linked_accounts")] long MihoyoHasLinkedAccounts,
	[property: JsonPropertyName("mihoyo_region")] string MihoyoRegion,
	[property: JsonPropertyName("mihoyo_last_activity")] long MihoyoLastActivity,
	[property: JsonPropertyName("mihoyo_genshin_level")] long MihoyoGenshinLevel,
	[property: JsonPropertyName("mihoyo_genshin_character_count")] long MihoyoGenshinCharacterCount,
	[property: JsonPropertyName("mihoyo_genshin_achievement_count")] long MihoyoGenshinAchievementCount,
	[property: JsonPropertyName("mihoyo_genshin_abyss_process")] string MihoyoGenshinAbyssProcess,
	[property: JsonPropertyName("mihoyo_genshin_legendary_characters_count")] long MihoyoGenshinLegendaryCharactersCount,
	[property: JsonPropertyName("mihoyo_genshin_constellations_count")] long MihoyoGenshinConstellationsCount,
	[property: JsonPropertyName("mihoyo_genshin_legendary_weapons_count")] long MihoyoGenshinLegendaryWeaponsCount,
	[property: JsonPropertyName("mihoyo_genshin_activity_days")] long MihoyoGenshinActivityDays,
	[property: JsonPropertyName("mihoyo_genshin_currency")] long MihoyoGenshinCurrency,
	[property: JsonPropertyName("mihoyo_honkai_level")] long MihoyoHonkaiLevel,
	[property: JsonPropertyName("mihoyo_honkai_character_count")] long MihoyoHonkaiCharacterCount,
	[property: JsonPropertyName("mihoyo_honkai_achievement_count")] long MihoyoHonkaiAchievementCount,
	[property: JsonPropertyName("mihoyo_honkai_abyss_process")] string MihoyoHonkaiAbyssProcess,
	[property: JsonPropertyName("mihoyo_honkai_legendary_characters_count")] long MihoyoHonkaiLegendaryCharactersCount,
	[property: JsonPropertyName("mihoyo_honkai_eidolons_count")] long MihoyoHonkaiEidolonsCount,
	[property: JsonPropertyName("mihoyo_honkai_legendary_weapons_count")] long MihoyoHonkaiLegendaryWeaponsCount,
	[property: JsonPropertyName("mihoyo_honkai_activity_days")] long MihoyoHonkaiActivityDays,
	[property: JsonPropertyName("mihoyo_honkai_currency")] long MihoyoHonkaiCurrency,
	[property: JsonPropertyName("mihoyo_zenless_level")] long MihoyoZenlessLevel,
	[property: JsonPropertyName("mihoyo_zenless_character_count")] long MihoyoZenlessCharacterCount,
	[property: JsonPropertyName("mihoyo_zenless_achievement_count")] long MihoyoZenlessAchievementCount,
	[property: JsonPropertyName("mihoyo_zenless_abyss_process")] string MihoyoZenlessAbyssProcess,
	[property: JsonPropertyName("mihoyo_zenless_legendary_characters_count")] long MihoyoZenlessLegendaryCharactersCount,
	[property: JsonPropertyName("mihoyo_zenless_cinemas_count")] long MihoyoZenlessCinemasCount,
	[property: JsonPropertyName("mihoyo_zenless_legendary_weapons_count")] long MihoyoZenlessLegendaryWeaponsCount,
	[property: JsonPropertyName("mihoyo_zenless_activity_days")] long MihoyoZenlessActivityDays,
	[property: JsonPropertyName("mihoyo_zenless_currency")] long MihoyoZenlessCurrency,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryMihoyoResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("mihoyoRegionPhrase")] string MihoyoRegionPhrase,
	[property: JsonPropertyName("mihoyoLinkedAccounts")] CategoryMihoyoResponseItemsMihoyoLinkedAccounts MihoyoLinkedAccounts,
	[property: JsonPropertyName("mihoyoLinkedAccountsString")] string MihoyoLinkedAccountsString,
	[property: JsonPropertyName("honkaiCharacters")] List<CategoryMihoyoResponseItemsHonkaiCharacters> HonkaiCharacters,
	[property: JsonPropertyName("genshinCharacters")] List<CategoryMihoyoResponseItemsGenshinCharacters> GenshinCharacters,
	[property: JsonPropertyName("zenlessCharacters")] List<CategoryMihoyoResponseItemsZenlessCharacters> ZenlessCharacters,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<CategoryMihoyoResponseItemsAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryMihoyoResponseItemsSeller Seller
);

	public sealed record CategoryRiotParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("rmin")]
		public long? Rmin { get; init; }
		[JsonPropertyName("rmax")]
		public long? Rmax { get; init; }
		[JsonPropertyName("last_rmin")]
		public long? LastRmin { get; init; }
		[JsonPropertyName("last_rmax")]
		public long? LastRmax { get; init; }
		[JsonPropertyName("previous_rmin")]
		public long? PreviousRmin { get; init; }
		[JsonPropertyName("previous_rmax")]
		public long? PreviousRmax { get; init; }
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
		public long? Daybreak { get; init; }
		[JsonPropertyName("valorant_level_min")]
		public long? ValorantLevelMin { get; init; }
		[JsonPropertyName("valorant_level_max")]
		public long? ValorantLevelMax { get; init; }
		[JsonPropertyName("lol_level_min")]
		public long? LolLevelMin { get; init; }
		[JsonPropertyName("lol_level_max")]
		public long? LolLevelMax { get; init; }
		[JsonPropertyName("inv_min")]
		public long? InvMin { get; init; }
		[JsonPropertyName("inv_max")]
		public long? InvMax { get; init; }
		[JsonPropertyName("vp_min")]
		public long? VpMin { get; init; }
		[JsonPropertyName("vp_max")]
		public long? VpMax { get; init; }
		[JsonPropertyName("valorant_smin")]
		public long? ValorantSmin { get; init; }
		[JsonPropertyName("valorant_smax")]
		public long? ValorantSmax { get; init; }
		[JsonPropertyName("valorant_rank_type[]")]
		public JsonElement? ValorantRankType { get; init; }
		[JsonPropertyName("amin")]
		public long? Amin { get; init; }
		[JsonPropertyName("amax")]
		public long? Amax { get; init; }
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
		public long? LolSmin { get; init; }
		[JsonPropertyName("lol_smax")]
		public long? LolSmax { get; init; }
		[JsonPropertyName("champion_min")]
		public long? ChampionMin { get; init; }
		[JsonPropertyName("champion_max")]
		public long? ChampionMax { get; init; }
		[JsonPropertyName("win_rate_min")]
		public long? WinRateMin { get; init; }
		[JsonPropertyName("win_rate_max")]
		public long? WinRateMax { get; init; }
		[JsonPropertyName("blue_min")]
		public long? BlueMin { get; init; }
		[JsonPropertyName("blue_max")]
		public long? BlueMax { get; init; }
		[JsonPropertyName("orange_min")]
		public long? OrangeMin { get; init; }
		[JsonPropertyName("orange_max")]
		public long? OrangeMax { get; init; }
		[JsonPropertyName("mythic_min")]
		public long? MythicMin { get; init; }
		[JsonPropertyName("mythic_max")]
		public long? MythicMax { get; init; }
		[JsonPropertyName("riot_min")]
		public long? RiotMin { get; init; }
		[JsonPropertyName("riot_max")]
		public long? RiotMax { get; init; }
		[JsonPropertyName("email")]
		public Email? Email { get; init; }
		[JsonPropertyName("tel")]
		public Tel? Tel { get; init; }
		[JsonPropertyName("valorant_knife_min")]
		public long? ValorantKnifeMin { get; init; }
		[JsonPropertyName("valorant_knife_max")]
		public long? ValorantKnifeMax { get; init; }
		[JsonPropertyName("rp_min")]
		public long? RpMin { get; init; }
		[JsonPropertyName("rp_max")]
		public long? RpMax { get; init; }
		[JsonPropertyName("fa_min")]
		public long? FaMin { get; init; }
		[JsonPropertyName("fa_max")]
		public long? FaMax { get; init; }
		[JsonPropertyName("lol_rank[]")]
		public JsonElement? LolRank { get; init; }
	}

	public sealed record CategoryRiotResponse(
		[property: JsonPropertyName("items")] List<CategoryRiotResponseItems> Items,
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

	public sealed record CategoryRiotResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryRiotResponseItemsValorantInventory(
	[property: JsonPropertyName("WeaponSkins")] List<string> WeaponSkins,
	[property: JsonPropertyName("Agent")] List<string> Agent,
	[property: JsonPropertyName("Buddy")] List<string> Buddy
);

	public sealed record CategoryRiotResponseItemsLolInventory(
	[property: JsonPropertyName("Champion")] List<long> Champion,
	[property: JsonPropertyName("Skin")] List<long> Skin
);

	public sealed record CategoryRiotResponseItemsAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
);

	public sealed record CategoryRiotResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long RestorePercents
);

	public sealed record CategoryRiotResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("riot_item_id")] long RiotItemId,
	[property: JsonPropertyName("riot_id")] string RiotId,
	[property: JsonPropertyName("riot_account_verified")] long RiotAccountVerified,
	[property: JsonPropertyName("riot_email_verified")] long RiotEmailVerified,
	[property: JsonPropertyName("riot_country")] string RiotCountry,
	[property: JsonPropertyName("riot_password_change")] long RiotPasswordChange,
	[property: JsonPropertyName("riot_phone_verified")] long RiotPhoneVerified,
	[property: JsonPropertyName("riot_last_activity")] long RiotLastActivity,
	[property: JsonPropertyName("riot_valorant_wallet_vp")] long RiotValorantWalletVp,
	[property: JsonPropertyName("riot_valorant_wallet_rp")] long RiotValorantWalletRp,
	[property: JsonPropertyName("riot_valorant_wallet_fa")] long RiotValorantWalletFa,
	[property: JsonPropertyName("riot_valorant_level")] long RiotValorantLevel,
	[property: JsonPropertyName("riot_username")] string RiotUsername,
	[property: JsonPropertyName("riot_valorant_rank")] long RiotValorantRank,
	[property: JsonPropertyName("riot_valorant_region")] string RiotValorantRegion,
	[property: JsonPropertyName("riot_valorant_skin_count")] long RiotValorantSkinCount,
	[property: JsonPropertyName("riot_valorant_agent_count")] long RiotValorantAgentCount,
	[property: JsonPropertyName("riot_valorant_previous_rank")] long RiotValorantPreviousRank,
	[property: JsonPropertyName("riot_valorant_last_rank")] long RiotValorantLastRank,
	[property: JsonPropertyName("riot_valorant_rank_type")] string RiotValorantRankType,
	[property: JsonPropertyName("riot_valorant_inventory_value")] long RiotValorantInventoryValue,
	[property: JsonPropertyName("riot_valorant_knife")] long RiotValorantKnife,
	[property: JsonPropertyName("riot_lol_region")] string RiotLolRegion,
	[property: JsonPropertyName("riot_lol_skin_count")] long RiotLolSkinCount,
	[property: JsonPropertyName("riot_lol_champion_count")] long RiotLolChampionCount,
	[property: JsonPropertyName("riot_lol_level")] long RiotLolLevel,
	[property: JsonPropertyName("riot_lol_wallet_blue")] long RiotLolWalletBlue,
	[property: JsonPropertyName("riot_lol_wallet_orange")] long RiotLolWalletOrange,
	[property: JsonPropertyName("riot_lol_wallet_mythic")] long RiotLolWalletMythic,
	[property: JsonPropertyName("riot_lol_wallet_riot")] long RiotLolWalletRiot,
	[property: JsonPropertyName("riot_lol_rank")] string RiotLolRank,
	[property: JsonPropertyName("riot_lol_rank_win_rate")] long RiotLolRankWinRate,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryRiotResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("valorantRegionPhrase")] string ValorantRegionPhrase,
	[property: JsonPropertyName("valorantRankTitle")] string ValorantRankTitle,
	[property: JsonPropertyName("valorantRankImgPath")] string ValorantRankImgPath,
	[property: JsonPropertyName("valorantPreviousRankTitle")] string ValorantPreviousRankTitle,
	[property: JsonPropertyName("valorantLastRankTitle")] string ValorantLastRankTitle,
	[property: JsonPropertyName("lolRegionPhrase")] string LolRegionPhrase,
	[property: JsonPropertyName("isSmallExf")] bool IsSmallExf,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("valorantInventory")] CategoryRiotResponseItemsValorantInventory ValorantInventory,
	[property: JsonPropertyName("lolInventory")] CategoryRiotResponseItemsLolInventory LolInventory,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<CategoryRiotResponseItemsAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryRiotResponseItemsSeller Seller
);

	public sealed record CategoryTelegramParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("spam")]
		public Spam? Spam { get; init; }
		[JsonPropertyName("password")]
		public Password? Password { get; init; }
		[JsonPropertyName("premium")]
		public Premium? Premium { get; init; }
		[JsonPropertyName("premium_expiration")]
		public long? PremiumExpiration { get; init; }
		[JsonPropertyName("premium_expiration_period")]
		public PremiumExpirationPeriod? PremiumExpirationPeriod { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("daybreak")]
		public long? Daybreak { get; init; }
		[JsonPropertyName("min_channels")]
		public long? MinChannels { get; init; }
		[JsonPropertyName("max_channels")]
		public long? MaxChannels { get; init; }
		[JsonPropertyName("min_chats")]
		public long? MinChats { get; init; }
		[JsonPropertyName("max_chats")]
		public long? MaxChats { get; init; }
		[JsonPropertyName("min_conversations")]
		public long? MinConversations { get; init; }
		[JsonPropertyName("max_conversations")]
		public long? MaxConversations { get; init; }
		[JsonPropertyName("min_admin")]
		public long? MinAdmin { get; init; }
		[JsonPropertyName("max_admin")]
		public long? MaxAdmin { get; init; }
		[JsonPropertyName("min_admin_sub")]
		public long? MinAdminSub { get; init; }
		[JsonPropertyName("max_admin_sub")]
		public long? MaxAdminSub { get; init; }
		[JsonPropertyName("dig_min")]
		public long? DigMin { get; init; }
		[JsonPropertyName("dig_max")]
		public long? DigMax { get; init; }
		[JsonPropertyName("min_contacts")]
		public long? MinContacts { get; init; }
		[JsonPropertyName("max_contacts")]
		public long? MaxContacts { get; init; }
		[JsonPropertyName("min_stars")]
		public long? MinStars { get; init; }
		[JsonPropertyName("max_stars")]
		public long? MaxStars { get; init; }
		[JsonPropertyName("birthday")]
		public long? Birthday { get; init; }
		[JsonPropertyName("birthday_period")]
		public BirthdayPeriod? BirthdayPeriod { get; init; }
		[JsonPropertyName("birthday_after")]
		public long? BirthdayAfter { get; init; }
		[JsonPropertyName("birthday_after_period")]
		public BirthdayAfterPeriod? BirthdayAfterPeriod { get; init; }
		[JsonPropertyName("min_id")]
		public long? MinId { get; init; }
		[JsonPropertyName("max_id")]
		public long? MaxId { get; init; }
		[JsonPropertyName("allow_geo_spamblock")]
		public bool? AllowGeoSpamblock { get; init; }
		[JsonPropertyName("min_gifts")]
		public long? MinGifts { get; init; }
		[JsonPropertyName("max_gifts")]
		public long? MaxGifts { get; init; }
		[JsonPropertyName("min_nft_gifts")]
		public long? MinNftGifts { get; init; }
		[JsonPropertyName("max_nft_gifts")]
		public long? MaxNftGifts { get; init; }
		[JsonPropertyName("min_gifts_stars")]
		public long? MinGiftsStars { get; init; }
		[JsonPropertyName("max_gifts_stars")]
		public long? MaxGiftsStars { get; init; }
		[JsonPropertyName("min_gifts_convert_stars")]
		public long? MinGiftsConvertStars { get; init; }
		[JsonPropertyName("max_gifts_convert_stars")]
		public long? MaxGiftsConvertStars { get; init; }
		[JsonPropertyName("dc_id[]")]
		public List<long?>? DcId { get; init; }
		[JsonPropertyName("not_dc_id[]")]
		public List<long?>? NotDcId { get; init; }
		[JsonPropertyName("email")]
		public Email? Email { get; init; }
		[JsonPropertyName("min_bots")]
		public long? MinBots { get; init; }
		[JsonPropertyName("max_bots")]
		public long? MaxBots { get; init; }
		[JsonPropertyName("min_bot_active_users")]
		public long? MinBotActiveUsers { get; init; }
		[JsonPropertyName("max_bot_active_users")]
		public long? MaxBotActiveUsers { get; init; }
	}

	public sealed record CategoryTelegramResponse(
		[property: JsonPropertyName("items")] List<CategoryTelegramResponseItems> Items,
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

	public sealed record CategoryTelegramResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryTelegramResponseItemsTelegramGroupCounters(
	[property: JsonPropertyName("chats")] long Chats,
	[property: JsonPropertyName("channels")] long Channels,
	[property: JsonPropertyName("conversations")] long Conversations,
	[property: JsonPropertyName("admin")] long Admin
);

	public sealed record CategoryTelegramResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] JsonElement RestorePercents
);

	public sealed record CategoryTelegramResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] JsonElement EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("telegram_item_id")] long TelegramItemId,
	[property: JsonPropertyName("telegram_country")] string TelegramCountry,
	[property: JsonPropertyName("telegram_last_seen")] long TelegramLastSeen,
	[property: JsonPropertyName("telegram_premium")] long TelegramPremium,
	[property: JsonPropertyName("telegram_stars_count")] long TelegramStarsCount,
	[property: JsonPropertyName("telegram_birthday")] long TelegramBirthday,
	[property: JsonPropertyName("telegram_password")] long TelegramPassword,
	[property: JsonPropertyName("telegram_premium_expires")] long TelegramPremiumExpires,
	[property: JsonPropertyName("telegram_spam_block")] JsonElement TelegramSpamBlock,
	[property: JsonPropertyName("telegram_channels_count")] long TelegramChannelsCount,
	[property: JsonPropertyName("telegram_chats_count")] long TelegramChatsCount,
	[property: JsonPropertyName("telegram_admin_count")] long TelegramAdminCount,
	[property: JsonPropertyName("telegram_admin_subs_count")] long TelegramAdminSubsCount,
	[property: JsonPropertyName("telegram_conversations_count")] long TelegramConversationsCount,
	[property: JsonPropertyName("telegram_id_count")] long TelegramIdCount,
	[property: JsonPropertyName("telegram_contacts_count")] long TelegramContactsCount,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryTelegramResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("telegram_group_counters")] CategoryTelegramResponseItemsTelegramGroupCounters TelegramGroupCounters,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<JsonElement> AccountLinks,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryTelegramResponseItemsSeller Seller
);

	public sealed record CategorySupercellParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("daybreak")]
		public long? Daybreak { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("eg")]
		public CategoryEg? Eg { get; init; }
		[JsonPropertyName("tel")]
		public Tel? Tel { get; init; }
		[JsonPropertyName("brawl_level_min")]
		public long? BrawlLevelMin { get; init; }
		[JsonPropertyName("brawl_level_max")]
		public long? BrawlLevelMax { get; init; }
		[JsonPropertyName("brawl_cup_min")]
		public long? BrawlCupMin { get; init; }
		[JsonPropertyName("brawl_cup_max")]
		public long? BrawlCupMax { get; init; }
		[JsonPropertyName("brawl_wins_min")]
		public long? BrawlWinsMin { get; init; }
		[JsonPropertyName("brawl_wins_max")]
		public long? BrawlWinsMax { get; init; }
		[JsonPropertyName("brawl_pass")]
		public BrawlPass? BrawlPass { get; init; }
		[JsonPropertyName("brawler[]")]
		public JsonElement? Brawler { get; init; }
		[JsonPropertyName("brawlers_min")]
		public long? BrawlersMin { get; init; }
		[JsonPropertyName("brawlers_max")]
		public long? BrawlersMax { get; init; }
		[JsonPropertyName("legendary_brawlers_min")]
		public long? LegendaryBrawlersMin { get; init; }
		[JsonPropertyName("legendary_brawlers_max")]
		public long? LegendaryBrawlersMax { get; init; }
		[JsonPropertyName("royale_level_min")]
		public long? RoyaleLevelMin { get; init; }
		[JsonPropertyName("royale_level_max")]
		public long? RoyaleLevelMax { get; init; }
		[JsonPropertyName("royale_cup_min")]
		public long? RoyaleCupMin { get; init; }
		[JsonPropertyName("royale_cup_max")]
		public long? RoyaleCupMax { get; init; }
		[JsonPropertyName("royale_wins_min")]
		public long? RoyaleWinsMin { get; init; }
		[JsonPropertyName("royale_wins_max")]
		public long? RoyaleWinsMax { get; init; }
		[JsonPropertyName("king_level_min")]
		public long? KingLevelMin { get; init; }
		[JsonPropertyName("king_level_max")]
		public long? KingLevelMax { get; init; }
		[JsonPropertyName("royale_pass")]
		public RoyalePass? RoyalePass { get; init; }
		[JsonPropertyName("clash_level_min")]
		public long? ClashLevelMin { get; init; }
		[JsonPropertyName("clash_level_max")]
		public long? ClashLevelMax { get; init; }
		[JsonPropertyName("clash_cup_min")]
		public long? ClashCupMin { get; init; }
		[JsonPropertyName("clash_cup_max")]
		public long? ClashCupMax { get; init; }
		[JsonPropertyName("clash_wins_min")]
		public long? ClashWinsMin { get; init; }
		[JsonPropertyName("clash_wins_max")]
		public long? ClashWinsMax { get; init; }
		[JsonPropertyName("clash_pass")]
		public ClashPass? ClashPass { get; init; }
		[JsonPropertyName("total_heroes_level_min")]
		public long? TotalHeroesLevelMin { get; init; }
		[JsonPropertyName("total_heroes_level_max")]
		public long? TotalHeroesLevelMax { get; init; }
		[JsonPropertyName("total_troops_level_min")]
		public long? TotalTroopsLevelMin { get; init; }
		[JsonPropertyName("total_troops_level_max")]
		public long? TotalTroopsLevelMax { get; init; }
		[JsonPropertyName("total_spells_level_min")]
		public long? TotalSpellsLevelMin { get; init; }
		[JsonPropertyName("total_spells_level_max")]
		public long? TotalSpellsLevelMax { get; init; }
		[JsonPropertyName("total_builder_heroes_level_min")]
		public long? TotalBuilderHeroesLevelMin { get; init; }
		[JsonPropertyName("total_builder_heroes_level_max")]
		public long? TotalBuilderHeroesLevelMax { get; init; }
		[JsonPropertyName("total_builder_troops_level_min")]
		public long? TotalBuilderTroopsLevelMin { get; init; }
		[JsonPropertyName("total_builder_troops_level_max")]
		public long? TotalBuilderTroopsLevelMax { get; init; }
		[JsonPropertyName("town_hall_level_min")]
		public long? TownHallLevelMin { get; init; }
		[JsonPropertyName("town_hall_level_max")]
		public long? TownHallLevelMax { get; init; }
		[JsonPropertyName("builder_hall_level_min")]
		public long? BuilderHallLevelMin { get; init; }
		[JsonPropertyName("builder_hall_level_max")]
		public long? BuilderHallLevelMax { get; init; }
		[JsonPropertyName("builder_hall_cup_min")]
		public long? BuilderHallCupMin { get; init; }
		[JsonPropertyName("builder_hall_cup_max")]
		public long? BuilderHallCupMax { get; init; }
		[JsonPropertyName("creation_year_min")]
		public long? CreationYearMin { get; init; }
		[JsonPropertyName("creation_year_max")]
		public long? CreationYearMax { get; init; }
	}

	public sealed record CategorySupercellResponse(
		[property: JsonPropertyName("items")] List<CategorySupercellResponseItems> Items,
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

	public sealed record CategorySupercellResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategorySupercellResponseItemsAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
);

	public sealed record CategorySupercellResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] JsonElement RestorePercents
);

	public sealed record CategorySupercellResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("supercell_item_id")] long SupercellItemId,
	[property: JsonPropertyName("supercell_id")] string SupercellId,
	[property: JsonPropertyName("supercell_arena")] string SupercellArena,
	[property: JsonPropertyName("supercell_brawler_count")] long SupercellBrawlerCount,
	[property: JsonPropertyName("supercell_last_activity")] long SupercellLastActivity,
	[property: JsonPropertyName("supercell_legendary_brawler_count")] long SupercellLegendaryBrawlerCount,
	[property: JsonPropertyName("supercell_town_hall_level")] long SupercellTownHallLevel,
	[property: JsonPropertyName("supercell_builder_hall_level")] long SupercellBuilderHallLevel,
	[property: JsonPropertyName("supercell_builder_hall_cup_count")] long SupercellBuilderHallCupCount,
	[property: JsonPropertyName("supercell_phone")] long SupercellPhone,
	[property: JsonPropertyName("supercell_laser_level")] long SupercellLaserLevel,
	[property: JsonPropertyName("supercell_scroll_level")] long SupercellScrollLevel,
	[property: JsonPropertyName("supercell_magic_level")] long SupercellMagicLevel,
	[property: JsonPropertyName("supercell_laser_trophies")] long SupercellLaserTrophies,
	[property: JsonPropertyName("supercell_scroll_trophies")] long SupercellScrollTrophies,
	[property: JsonPropertyName("supercell_magic_trophies")] long SupercellMagicTrophies,
	[property: JsonPropertyName("supercell_laser_victories")] long SupercellLaserVictories,
	[property: JsonPropertyName("supercell_scroll_victories")] long SupercellScrollVictories,
	[property: JsonPropertyName("supercell_magic_victories")] long SupercellMagicVictories,
	[property: JsonPropertyName("supercell_laser_battle_pass")] long SupercellLaserBattlePass,
	[property: JsonPropertyName("supercell_scroll_battle_pass")] long SupercellScrollBattlePass,
	[property: JsonPropertyName("supercell_magic_battle_pass")] long SupercellMagicBattlePass,
	[property: JsonPropertyName("supercell_systems")] string SupercellSystems,
	[property: JsonPropertyName("supercell_king_level")] long SupercellKingLevel,
	[property: JsonPropertyName("supercell_total_heroes_level")] long SupercellTotalHeroesLevel,
	[property: JsonPropertyName("supercell_total_troops_level")] long SupercellTotalTroopsLevel,
	[property: JsonPropertyName("supercell_total_spells_level")] long SupercellTotalSpellsLevel,
	[property: JsonPropertyName("supercell_total_builder_heroes_level")] long SupercellTotalBuilderHeroesLevel,
	[property: JsonPropertyName("supercell_total_builder_troops_level")] long SupercellTotalBuilderTroopsLevel,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategorySupercellResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("isSmallExf")] bool IsSmallExf,
	[property: JsonPropertyName("supercellBrawlers")] List<JsonElement> SupercellBrawlers,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<CategorySupercellResponseItemsAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategorySupercellResponseItemsSeller Seller
);

	public sealed record CategoryEaParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
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
		public long? Gmin { get; init; }
		[JsonPropertyName("gmax")]
		public long? Gmax { get; init; }
		[JsonPropertyName("al_rank_min")]
		public long? AlRankMin { get; init; }
		[JsonPropertyName("al_rank_max")]
		public long? AlRankMax { get; init; }
		[JsonPropertyName("al_level_min")]
		public long? AlLevelMin { get; init; }
		[JsonPropertyName("al_level_max")]
		public long? AlLevelMax { get; init; }
		[JsonPropertyName("has_ban")]
		public HasBan? HasBan { get; init; }
		[JsonPropertyName("xbox_connected")]
		public XboxConnected? XboxConnected { get; init; }
		[JsonPropertyName("steam_connected")]
		public SteamConnected? SteamConnected { get; init; }
		[JsonPropertyName("psn_connected")]
		public PsnConnected? PsnConnected { get; init; }
		[JsonPropertyName("subscription")]
		public CategorySubscription? Subscription { get; init; }
		[JsonPropertyName("subscription_length")]
		public long? SubscriptionLength { get; init; }
		[JsonPropertyName("subscription_period")]
		public SubscriptionPeriod? SubscriptionPeriod { get; init; }
		[JsonPropertyName("hours_played")]
		public JsonElement? HoursPlayed { get; init; }
		[JsonPropertyName("hours_played_max")]
		public JsonElement? HoursPlayedMax { get; init; }
		[JsonPropertyName("transactions")]
		public Transactions? Transactions { get; init; }
	}

	public sealed record CategoryEaResponse(
		[property: JsonPropertyName("items")] List<CategoryEaResponseItems> Items,
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

	public sealed record CategoryEaResponseItemsEaGamesApexLegends(
	[property: JsonPropertyName("game_id")] string GameId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("total_played")] long TotalPlayed,
	[property: JsonPropertyName("img")] string Img
);

	public sealed record CategoryEaResponseItemsEaGames(
	[property: JsonPropertyName("apex-legends")] CategoryEaResponseItemsEaGamesApexLegends ApexLegends
);

	public sealed record CategoryEaResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryEaResponseItemsAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
);

	public sealed record CategoryEaResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long RestorePercents
);

	public sealed record CategoryEaResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("ea_item_id")] long EaItemId,
	[property: JsonPropertyName("ea_id")] long EaId,
	[property: JsonPropertyName("ea_country")] string EaCountry,
	[property: JsonPropertyName("ea_games")] CategoryEaResponseItemsEaGames EaGames,
	[property: JsonPropertyName("ea_game_count")] long EaGameCount,
	[property: JsonPropertyName("ea_last_activity")] long EaLastActivity,
	[property: JsonPropertyName("ea_al_level")] long EaAlLevel,
	[property: JsonPropertyName("ea_al_rank_score")] long EaAlRankScore,
	[property: JsonPropertyName("ea_subscription")] string EaSubscription,
	[property: JsonPropertyName("ea_subscription_end_date")] long EaSubscriptionEndDate,
	[property: JsonPropertyName("ea_username")] string EaUsername,
	[property: JsonPropertyName("ea_xbox_connected")] long EaXboxConnected,
	[property: JsonPropertyName("ea_steam_connected")] long EaSteamConnected,
	[property: JsonPropertyName("ea_psn_connected")] long EaPsnConnected,
	[property: JsonPropertyName("ea_bans")] List<JsonElement> EaBans,
	[property: JsonPropertyName("ea_has_ban")] long EaHasBan,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryEaResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<CategoryEaResponseItemsAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryEaResponseItemsSeller Seller
);

	public sealed record CategoryWotParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("tel")]
		public Tel? Tel { get; init; }
		[JsonPropertyName("daybreak")]
		public long? Daybreak { get; init; }
		[JsonPropertyName("battles_min")]
		public long? BattlesMin { get; init; }
		[JsonPropertyName("battles_max")]
		public long? BattlesMax { get; init; }
		[JsonPropertyName("gold_min")]
		public long? GoldMin { get; init; }
		[JsonPropertyName("gold_max")]
		public long? GoldMax { get; init; }
		[JsonPropertyName("silver_min")]
		public long? SilverMin { get; init; }
		[JsonPropertyName("silver_max")]
		public long? SilverMax { get; init; }
		[JsonPropertyName("top_min")]
		public long? TopMin { get; init; }
		[JsonPropertyName("top_max")]
		public long? TopMax { get; init; }
		[JsonPropertyName("prem_min")]
		public long? PremMin { get; init; }
		[JsonPropertyName("prem_max")]
		public long? PremMax { get; init; }
		[JsonPropertyName("top_prem_min")]
		public long? TopPremMin { get; init; }
		[JsonPropertyName("top_prem_max")]
		public long? TopPremMax { get; init; }
		[JsonPropertyName("win_pmin")]
		public long? WinPmin { get; init; }
		[JsonPropertyName("win_pmax")]
		public long? WinPmax { get; init; }
		[JsonPropertyName("tank[]")]
		public List<long?>? Tank { get; init; }
		[JsonPropertyName("region[]")]
		public JsonElement? Region { get; init; }
		[JsonPropertyName("not_region[]")]
		public JsonElement? NotRegion { get; init; }
		[JsonPropertyName("premium")]
		public Premium? Premium { get; init; }
		[JsonPropertyName("premium_expiration")]
		public long? PremiumExpiration { get; init; }
		[JsonPropertyName("premium_expiration_period")]
		public PremiumExpirationPeriod? PremiumExpirationPeriod { get; init; }
		[JsonPropertyName("clan")]
		public Clan? Clan { get; init; }
		[JsonPropertyName("clan_role[]")]
		public JsonElement? ClanRole { get; init; }
		[JsonPropertyName("not_clan_role[]")]
		public JsonElement? NotClanRole { get; init; }
		[JsonPropertyName("clan_gold_min")]
		public long? ClanGoldMin { get; init; }
		[JsonPropertyName("clan_gold_max")]
		public long? ClanGoldMax { get; init; }
		[JsonPropertyName("clan_credits_min")]
		public long? ClanCreditsMin { get; init; }
		[JsonPropertyName("clan_credits_max")]
		public long? ClanCreditsMax { get; init; }
		[JsonPropertyName("clan_crystal_min")]
		public long? ClanCrystalMin { get; init; }
		[JsonPropertyName("clan_crystal_max")]
		public long? ClanCrystalMax { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
	}

	public sealed record CategoryWotResponse(
		[property: JsonPropertyName("items")] List<CategoryWotResponseItems> Items,
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

	public sealed record CategoryWotResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryWotResponseItemsWotTopPremiumTanks00000(
	[property: JsonPropertyName("tank_id")] long? TankId,
	[property: JsonPropertyName("name")] string? Name,
	[property: JsonPropertyName("is_premium")] long? IsPremium,
	[property: JsonPropertyName("image_url")] string? ImageUrl,
	[property: JsonPropertyName("short_name")] string? ShortName,
	[property: JsonPropertyName("tier")] long? Tier
);

	public sealed record CategoryWotResponseItemsWotTopPremiumTanks(
	[property: JsonPropertyName("00000")] CategoryWotResponseItemsWotTopPremiumTanks00000 _00000
);

	public sealed record CategoryWotResponseItemsWotTanks00000(
	[property: JsonPropertyName("tank_id")] long? TankId,
	[property: JsonPropertyName("name")] string? Name,
	[property: JsonPropertyName("is_premium")] long? IsPremium,
	[property: JsonPropertyName("image_url")] string? ImageUrl,
	[property: JsonPropertyName("short_name")] string? ShortName,
	[property: JsonPropertyName("tier")] long? Tier
);

	public sealed record CategoryWotResponseItemsWotTanks(
	[property: JsonPropertyName("00000")] CategoryWotResponseItemsWotTanks00000 _00000
);

	public sealed record CategoryWotResponseItemsWotPremiumTanks30465(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("tier")] long Tier
);

	public sealed record CategoryWotResponseItemsWotPremiumTanks60945(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("tier")] long Tier
);

	public sealed record CategoryWotResponseItemsWotPremiumTanks51233(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("tier")] long Tier
);

	public sealed record CategoryWotResponseItemsWotPremiumTanks57377(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("tier")] long Tier
);

	public sealed record CategoryWotResponseItemsWotPremiumTanks62497(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("tier")] long Tier
);

	public sealed record CategoryWotResponseItemsWotPremiumTanks55569(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("tier")] long Tier
);

	public sealed record CategoryWotResponseItemsWotPremiumTanks7937025(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("tier")] long Tier
);

	public sealed record CategoryWotResponseItemsWotPremiumTanks50977(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("tier")] long Tier
);

	public sealed record CategoryWotResponseItemsWotPremiumTanks51585(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("tier")] long Tier
);

	public sealed record CategoryWotResponseItemsWotPremiumTanks46097(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("tier")] long Tier
);

	public sealed record CategoryWotResponseItemsWotPremiumTanks47873(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("tier")] long Tier
);

	public sealed record CategoryWotResponseItemsWotPremiumTanks43841(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("tier")] long Tier
);

	public sealed record CategoryWotResponseItemsWotPremiumTanks(
	[property: JsonPropertyName("30465")] CategoryWotResponseItemsWotPremiumTanks30465 _30465,
	[property: JsonPropertyName("60945")] CategoryWotResponseItemsWotPremiumTanks60945 _60945,
	[property: JsonPropertyName("51233")] CategoryWotResponseItemsWotPremiumTanks51233 _51233,
	[property: JsonPropertyName("57377")] CategoryWotResponseItemsWotPremiumTanks57377 _57377,
	[property: JsonPropertyName("62497")] CategoryWotResponseItemsWotPremiumTanks62497 _62497,
	[property: JsonPropertyName("55569")] CategoryWotResponseItemsWotPremiumTanks55569 _55569,
	[property: JsonPropertyName("7937025")] CategoryWotResponseItemsWotPremiumTanks7937025 _7937025,
	[property: JsonPropertyName("50977")] CategoryWotResponseItemsWotPremiumTanks50977 _50977,
	[property: JsonPropertyName("51585")] CategoryWotResponseItemsWotPremiumTanks51585 _51585,
	[property: JsonPropertyName("46097")] CategoryWotResponseItemsWotPremiumTanks46097 _46097,
	[property: JsonPropertyName("47873")] CategoryWotResponseItemsWotPremiumTanks47873 _47873,
	[property: JsonPropertyName("43841")] CategoryWotResponseItemsWotPremiumTanks43841 _43841
);

	public sealed record CategoryWotResponseItemsWotTopTanks00000(
	[property: JsonPropertyName("tank_id")] long? TankId,
	[property: JsonPropertyName("name")] string? Name,
	[property: JsonPropertyName("is_premium")] long? IsPremium,
	[property: JsonPropertyName("image_url")] string? ImageUrl,
	[property: JsonPropertyName("short_name")] string? ShortName,
	[property: JsonPropertyName("tier")] long? Tier
);

	public sealed record CategoryWotResponseItemsWotTopTanks(
	[property: JsonPropertyName("00000")] CategoryWotResponseItemsWotTopTanks00000 _00000
);

	public sealed record CategoryWotResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long RestorePercents
);

	public sealed record CategoryWotResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] JsonElement EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("wot_item_id")] long WotItemId,
	[property: JsonPropertyName("wot_last_activity")] long WotLastActivity,
	[property: JsonPropertyName("wot_register_date")] long WotRegisterDate,
	[property: JsonPropertyName("wot_mobile")] long WotMobile,
	[property: JsonPropertyName("wot_premium")] long WotPremium,
	[property: JsonPropertyName("wot_premium_expires")] long WotPremiumExpires,
	[property: JsonPropertyName("wot_gold")] long WotGold,
	[property: JsonPropertyName("wot_credits")] long WotCredits,
	[property: JsonPropertyName("wot_battle_count")] long WotBattleCount,
	[property: JsonPropertyName("wot_win_count")] long WotWinCount,
	[property: JsonPropertyName("wot_loss_count")] long WotLossCount,
	[property: JsonPropertyName("wot_win_count_percents")] long WotWinCountPercents,
	[property: JsonPropertyName("wot_top_tanks")] long WotTopTanks,
	[property: JsonPropertyName("wot_premium_tanks")] long WotPremiumTanks,
	[property: JsonPropertyName("wot_top_premium_tanks")] long WotTopPremiumTanks,
	[property: JsonPropertyName("wot_region")] string WotRegion,
	[property: JsonPropertyName("wot_blitz")] long WotBlitz,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryWotResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("wotRegionPhrase")] string WotRegionPhrase,
	[property: JsonPropertyName("isSmallExf")] bool IsSmallExf,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("wotTopPremiumTanks")] CategoryWotResponseItemsWotTopPremiumTanks WotTopPremiumTanks2,
	[property: JsonPropertyName("wotTanks")] CategoryWotResponseItemsWotTanks WotTanks,
	[property: JsonPropertyName("wotPremiumTanks")] CategoryWotResponseItemsWotPremiumTanks WotPremiumTanks2,
	[property: JsonPropertyName("wotTopTanks")] CategoryWotResponseItemsWotTopTanks WotTopTanks2,
	[property: JsonPropertyName("wotPremiumTankCount")] long WotPremiumTankCount,
	[property: JsonPropertyName("wotTankCount")] long WotTankCount,
	[property: JsonPropertyName("wotLauncherTitle")] string WotLauncherTitle,
	[property: JsonPropertyName("wot_has_clan")] bool WotHasClan,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<JsonElement> AccountLinks,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryWotResponseItemsSeller Seller
);

	public sealed record CategoryWotBlitzParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("tel")]
		public Tel? Tel { get; init; }
		[JsonPropertyName("daybreak")]
		public long? Daybreak { get; init; }
		[JsonPropertyName("battles_min")]
		public long? BattlesMin { get; init; }
		[JsonPropertyName("battles_max")]
		public long? BattlesMax { get; init; }
		[JsonPropertyName("gold_min")]
		public long? GoldMin { get; init; }
		[JsonPropertyName("gold_max")]
		public long? GoldMax { get; init; }
		[JsonPropertyName("silver_min")]
		public long? SilverMin { get; init; }
		[JsonPropertyName("silver_max")]
		public long? SilverMax { get; init; }
		[JsonPropertyName("top_min")]
		public long? TopMin { get; init; }
		[JsonPropertyName("top_max")]
		public long? TopMax { get; init; }
		[JsonPropertyName("prem_min")]
		public long? PremMin { get; init; }
		[JsonPropertyName("prem_max")]
		public long? PremMax { get; init; }
		[JsonPropertyName("top_prem_min")]
		public long? TopPremMin { get; init; }
		[JsonPropertyName("top_prem_max")]
		public long? TopPremMax { get; init; }
		[JsonPropertyName("win_pmin")]
		public long? WinPmin { get; init; }
		[JsonPropertyName("win_pmax")]
		public long? WinPmax { get; init; }
		[JsonPropertyName("tank[]")]
		public List<long?>? Tank { get; init; }
		[JsonPropertyName("region[]")]
		public JsonElement? Region { get; init; }
		[JsonPropertyName("not_region[]")]
		public JsonElement? NotRegion { get; init; }
		[JsonPropertyName("premium")]
		public Premium? Premium { get; init; }
		[JsonPropertyName("premium_expiration")]
		public long? PremiumExpiration { get; init; }
		[JsonPropertyName("premium_expiration_period")]
		public PremiumExpirationPeriod? PremiumExpirationPeriod { get; init; }
		[JsonPropertyName("clan")]
		public Clan? Clan { get; init; }
		[JsonPropertyName("clan_role[]")]
		public JsonElement? ClanRole { get; init; }
		[JsonPropertyName("not_clan_role[]")]
		public JsonElement? NotClanRole { get; init; }
		[JsonPropertyName("clan_gold_min")]
		public long? ClanGoldMin { get; init; }
		[JsonPropertyName("clan_gold_max")]
		public long? ClanGoldMax { get; init; }
		[JsonPropertyName("clan_credits_min")]
		public long? ClanCreditsMin { get; init; }
		[JsonPropertyName("clan_credits_max")]
		public long? ClanCreditsMax { get; init; }
		[JsonPropertyName("clan_crystal_min")]
		public long? ClanCrystalMin { get; init; }
		[JsonPropertyName("clan_crystal_max")]
		public long? ClanCrystalMax { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
	}

	public sealed record CategoryWotBlitzResponse(
		[property: JsonPropertyName("items")] List<CategoryWotBlitzResponseItems> Items,
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

	public sealed record CategoryWotBlitzResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryWotBlitzResponseItemsWotTopPremiumTanks15697(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopPremiumTanks5681(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopPremiumTanks23313(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopPremiumTanks(
	[property: JsonPropertyName("15697")] CategoryWotBlitzResponseItemsWotTopPremiumTanks15697 _15697,
	[property: JsonPropertyName("5681")] CategoryWotBlitzResponseItemsWotTopPremiumTanks5681 _5681,
	[property: JsonPropertyName("23313")] CategoryWotBlitzResponseItemsWotTopPremiumTanks23313 _23313
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks12305(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks6753(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks18001(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks6449(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks15697(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks4481(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks13185(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks14337(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks3681(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks6145(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks5425(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks3649(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks7169(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks7249(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks7297(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks19537(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks5681(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks6209(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks58641(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks16897(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks10369(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks22817(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks9489(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks385(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks19217(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks9297(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks13825(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks5505(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks13089(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks12049(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks13569(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks4145(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks24321(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks23313(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks20257(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks14609(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks10289(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks14881(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks3937(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks10785(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks6929(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks16401(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks641(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks20001(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks12545(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks7953(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks25361(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks20481(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks62737(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks5137(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks18753(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks19025(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks13345(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks2945(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks16193(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks18209(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks19985(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks19489(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks20305(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks20737(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks21329(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks53025(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks18241(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks10881(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks21265(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks20513(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks12673(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks16705(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks6785(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks58881(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks18513(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks2849(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks9073(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks18769(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks15953(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks6257(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks6001(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks55297(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks23841(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks64529(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks21025(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks23057(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks7281(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks23825(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks8753(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks59137(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks10241(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks7793(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks5745(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks11553(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks625(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks20817(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks23297(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks2625(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks19713(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks24849(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks56097(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks57105(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks54785(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks2609(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks57361(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks1409(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks55889(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks5393(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks5489(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks53761(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks65377(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks54545(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks51473(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks10273(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks3121(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks4881(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks51729(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks4369(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks6993(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTanks(
	[property: JsonPropertyName("12305")] CategoryWotBlitzResponseItemsWotTanks12305 _12305,
	[property: JsonPropertyName("6753")] CategoryWotBlitzResponseItemsWotTanks6753 _6753,
	[property: JsonPropertyName("18001")] CategoryWotBlitzResponseItemsWotTanks18001 _18001,
	[property: JsonPropertyName("6449")] CategoryWotBlitzResponseItemsWotTanks6449 _6449,
	[property: JsonPropertyName("15697")] CategoryWotBlitzResponseItemsWotTanks15697 _15697,
	[property: JsonPropertyName("4481")] CategoryWotBlitzResponseItemsWotTanks4481 _4481,
	[property: JsonPropertyName("13185")] CategoryWotBlitzResponseItemsWotTanks13185 _13185,
	[property: JsonPropertyName("14337")] CategoryWotBlitzResponseItemsWotTanks14337 _14337,
	[property: JsonPropertyName("3681")] CategoryWotBlitzResponseItemsWotTanks3681 _3681,
	[property: JsonPropertyName("6145")] CategoryWotBlitzResponseItemsWotTanks6145 _6145,
	[property: JsonPropertyName("5425")] CategoryWotBlitzResponseItemsWotTanks5425 _5425,
	[property: JsonPropertyName("3649")] CategoryWotBlitzResponseItemsWotTanks3649 _3649,
	[property: JsonPropertyName("7169")] CategoryWotBlitzResponseItemsWotTanks7169 _7169,
	[property: JsonPropertyName("7249")] CategoryWotBlitzResponseItemsWotTanks7249 _7249,
	[property: JsonPropertyName("7297")] CategoryWotBlitzResponseItemsWotTanks7297 _7297,
	[property: JsonPropertyName("19537")] CategoryWotBlitzResponseItemsWotTanks19537 _19537,
	[property: JsonPropertyName("5681")] CategoryWotBlitzResponseItemsWotTanks5681 _5681,
	[property: JsonPropertyName("6209")] CategoryWotBlitzResponseItemsWotTanks6209 _6209,
	[property: JsonPropertyName("58641")] CategoryWotBlitzResponseItemsWotTanks58641 _58641,
	[property: JsonPropertyName("16897")] CategoryWotBlitzResponseItemsWotTanks16897 _16897,
	[property: JsonPropertyName("10369")] CategoryWotBlitzResponseItemsWotTanks10369 _10369,
	[property: JsonPropertyName("22817")] CategoryWotBlitzResponseItemsWotTanks22817 _22817,
	[property: JsonPropertyName("9489")] CategoryWotBlitzResponseItemsWotTanks9489 _9489,
	[property: JsonPropertyName("385")] CategoryWotBlitzResponseItemsWotTanks385 _385,
	[property: JsonPropertyName("19217")] CategoryWotBlitzResponseItemsWotTanks19217 _19217,
	[property: JsonPropertyName("9297")] CategoryWotBlitzResponseItemsWotTanks9297 _9297,
	[property: JsonPropertyName("13825")] CategoryWotBlitzResponseItemsWotTanks13825 _13825,
	[property: JsonPropertyName("5505")] CategoryWotBlitzResponseItemsWotTanks5505 _5505,
	[property: JsonPropertyName("13089")] CategoryWotBlitzResponseItemsWotTanks13089 _13089,
	[property: JsonPropertyName("12049")] CategoryWotBlitzResponseItemsWotTanks12049 _12049,
	[property: JsonPropertyName("13569")] CategoryWotBlitzResponseItemsWotTanks13569 _13569,
	[property: JsonPropertyName("4145")] CategoryWotBlitzResponseItemsWotTanks4145 _4145,
	[property: JsonPropertyName("24321")] CategoryWotBlitzResponseItemsWotTanks24321 _24321,
	[property: JsonPropertyName("23313")] CategoryWotBlitzResponseItemsWotTanks23313 _23313,
	[property: JsonPropertyName("20257")] CategoryWotBlitzResponseItemsWotTanks20257 _20257,
	[property: JsonPropertyName("14609")] CategoryWotBlitzResponseItemsWotTanks14609 _14609,
	[property: JsonPropertyName("10289")] CategoryWotBlitzResponseItemsWotTanks10289 _10289,
	[property: JsonPropertyName("14881")] CategoryWotBlitzResponseItemsWotTanks14881 _14881,
	[property: JsonPropertyName("3937")] CategoryWotBlitzResponseItemsWotTanks3937 _3937,
	[property: JsonPropertyName("10785")] CategoryWotBlitzResponseItemsWotTanks10785 _10785,
	[property: JsonPropertyName("6929")] CategoryWotBlitzResponseItemsWotTanks6929 _6929,
	[property: JsonPropertyName("16401")] CategoryWotBlitzResponseItemsWotTanks16401 _16401,
	[property: JsonPropertyName("641")] CategoryWotBlitzResponseItemsWotTanks641 _641,
	[property: JsonPropertyName("20001")] CategoryWotBlitzResponseItemsWotTanks20001 _20001,
	[property: JsonPropertyName("12545")] CategoryWotBlitzResponseItemsWotTanks12545 _12545,
	[property: JsonPropertyName("7953")] CategoryWotBlitzResponseItemsWotTanks7953 _7953,
	[property: JsonPropertyName("25361")] CategoryWotBlitzResponseItemsWotTanks25361 _25361,
	[property: JsonPropertyName("20481")] CategoryWotBlitzResponseItemsWotTanks20481 _20481,
	[property: JsonPropertyName("62737")] CategoryWotBlitzResponseItemsWotTanks62737 _62737,
	[property: JsonPropertyName("5137")] CategoryWotBlitzResponseItemsWotTanks5137 _5137,
	[property: JsonPropertyName("18753")] CategoryWotBlitzResponseItemsWotTanks18753 _18753,
	[property: JsonPropertyName("19025")] CategoryWotBlitzResponseItemsWotTanks19025 _19025,
	[property: JsonPropertyName("13345")] CategoryWotBlitzResponseItemsWotTanks13345 _13345,
	[property: JsonPropertyName("2945")] CategoryWotBlitzResponseItemsWotTanks2945 _2945,
	[property: JsonPropertyName("16193")] CategoryWotBlitzResponseItemsWotTanks16193 _16193,
	[property: JsonPropertyName("18209")] CategoryWotBlitzResponseItemsWotTanks18209 _18209,
	[property: JsonPropertyName("19985")] CategoryWotBlitzResponseItemsWotTanks19985 _19985,
	[property: JsonPropertyName("19489")] CategoryWotBlitzResponseItemsWotTanks19489 _19489,
	[property: JsonPropertyName("20305")] CategoryWotBlitzResponseItemsWotTanks20305 _20305,
	[property: JsonPropertyName("20737")] CategoryWotBlitzResponseItemsWotTanks20737 _20737,
	[property: JsonPropertyName("21329")] CategoryWotBlitzResponseItemsWotTanks21329 _21329,
	[property: JsonPropertyName("53025")] CategoryWotBlitzResponseItemsWotTanks53025 _53025,
	[property: JsonPropertyName("18241")] CategoryWotBlitzResponseItemsWotTanks18241 _18241,
	[property: JsonPropertyName("10881")] CategoryWotBlitzResponseItemsWotTanks10881 _10881,
	[property: JsonPropertyName("21265")] CategoryWotBlitzResponseItemsWotTanks21265 _21265,
	[property: JsonPropertyName("20513")] CategoryWotBlitzResponseItemsWotTanks20513 _20513,
	[property: JsonPropertyName("12673")] CategoryWotBlitzResponseItemsWotTanks12673 _12673,
	[property: JsonPropertyName("16705")] CategoryWotBlitzResponseItemsWotTanks16705 _16705,
	[property: JsonPropertyName("6785")] CategoryWotBlitzResponseItemsWotTanks6785 _6785,
	[property: JsonPropertyName("58881")] CategoryWotBlitzResponseItemsWotTanks58881 _58881,
	[property: JsonPropertyName("18513")] CategoryWotBlitzResponseItemsWotTanks18513 _18513,
	[property: JsonPropertyName("2849")] CategoryWotBlitzResponseItemsWotTanks2849 _2849,
	[property: JsonPropertyName("9073")] CategoryWotBlitzResponseItemsWotTanks9073 _9073,
	[property: JsonPropertyName("18769")] CategoryWotBlitzResponseItemsWotTanks18769 _18769,
	[property: JsonPropertyName("15953")] CategoryWotBlitzResponseItemsWotTanks15953 _15953,
	[property: JsonPropertyName("6257")] CategoryWotBlitzResponseItemsWotTanks6257 _6257,
	[property: JsonPropertyName("6001")] CategoryWotBlitzResponseItemsWotTanks6001 _6001,
	[property: JsonPropertyName("55297")] CategoryWotBlitzResponseItemsWotTanks55297 _55297,
	[property: JsonPropertyName("23841")] CategoryWotBlitzResponseItemsWotTanks23841 _23841,
	[property: JsonPropertyName("64529")] CategoryWotBlitzResponseItemsWotTanks64529 _64529,
	[property: JsonPropertyName("21025")] CategoryWotBlitzResponseItemsWotTanks21025 _21025,
	[property: JsonPropertyName("23057")] CategoryWotBlitzResponseItemsWotTanks23057 _23057,
	[property: JsonPropertyName("7281")] CategoryWotBlitzResponseItemsWotTanks7281 _7281,
	[property: JsonPropertyName("23825")] CategoryWotBlitzResponseItemsWotTanks23825 _23825,
	[property: JsonPropertyName("8753")] CategoryWotBlitzResponseItemsWotTanks8753 _8753,
	[property: JsonPropertyName("59137")] CategoryWotBlitzResponseItemsWotTanks59137 _59137,
	[property: JsonPropertyName("10241")] CategoryWotBlitzResponseItemsWotTanks10241 _10241,
	[property: JsonPropertyName("7793")] CategoryWotBlitzResponseItemsWotTanks7793 _7793,
	[property: JsonPropertyName("5745")] CategoryWotBlitzResponseItemsWotTanks5745 _5745,
	[property: JsonPropertyName("11553")] CategoryWotBlitzResponseItemsWotTanks11553 _11553,
	[property: JsonPropertyName("625")] CategoryWotBlitzResponseItemsWotTanks625 _625,
	[property: JsonPropertyName("20817")] CategoryWotBlitzResponseItemsWotTanks20817 _20817,
	[property: JsonPropertyName("23297")] CategoryWotBlitzResponseItemsWotTanks23297 _23297,
	[property: JsonPropertyName("2625")] CategoryWotBlitzResponseItemsWotTanks2625 _2625,
	[property: JsonPropertyName("19713")] CategoryWotBlitzResponseItemsWotTanks19713 _19713,
	[property: JsonPropertyName("24849")] CategoryWotBlitzResponseItemsWotTanks24849 _24849,
	[property: JsonPropertyName("56097")] CategoryWotBlitzResponseItemsWotTanks56097 _56097,
	[property: JsonPropertyName("57105")] CategoryWotBlitzResponseItemsWotTanks57105 _57105,
	[property: JsonPropertyName("54785")] CategoryWotBlitzResponseItemsWotTanks54785 _54785,
	[property: JsonPropertyName("2609")] CategoryWotBlitzResponseItemsWotTanks2609 _2609,
	[property: JsonPropertyName("57361")] CategoryWotBlitzResponseItemsWotTanks57361 _57361,
	[property: JsonPropertyName("1409")] CategoryWotBlitzResponseItemsWotTanks1409 _1409,
	[property: JsonPropertyName("55889")] CategoryWotBlitzResponseItemsWotTanks55889 _55889,
	[property: JsonPropertyName("5393")] CategoryWotBlitzResponseItemsWotTanks5393 _5393,
	[property: JsonPropertyName("5489")] CategoryWotBlitzResponseItemsWotTanks5489 _5489,
	[property: JsonPropertyName("53761")] CategoryWotBlitzResponseItemsWotTanks53761 _53761,
	[property: JsonPropertyName("65377")] CategoryWotBlitzResponseItemsWotTanks65377 _65377,
	[property: JsonPropertyName("54545")] CategoryWotBlitzResponseItemsWotTanks54545 _54545,
	[property: JsonPropertyName("51473")] CategoryWotBlitzResponseItemsWotTanks51473 _51473,
	[property: JsonPropertyName("10273")] CategoryWotBlitzResponseItemsWotTanks10273 _10273,
	[property: JsonPropertyName("3121")] CategoryWotBlitzResponseItemsWotTanks3121 _3121,
	[property: JsonPropertyName("4881")] CategoryWotBlitzResponseItemsWotTanks4881 _4881,
	[property: JsonPropertyName("51729")] CategoryWotBlitzResponseItemsWotTanks51729 _51729,
	[property: JsonPropertyName("4369")] CategoryWotBlitzResponseItemsWotTanks4369 _4369,
	[property: JsonPropertyName("6993")] CategoryWotBlitzResponseItemsWotTanks6993 _6993
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks5681(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks23313(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks15697(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks25361(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks12545(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks62737(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks18769(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks53025(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks20737(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks20481(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks18753(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks58881(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks19025(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks13345(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks2945(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks16193(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks19985(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks19489(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks20305(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks18241(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks21329(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks18513(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks16705(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks9073(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks12673(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks6785(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks21265(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks2849(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks20513(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks23057(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks64529(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks7793(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks23841(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks21025(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks6001(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks55297(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks6257(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks8753(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks23825(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks15953(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks59137(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks7281(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks20817(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks5745(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks625(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks19713(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks57105(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks23297(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks57361(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks54785(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks2609(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks55889(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks56097(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks51473(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks65377(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks5489(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks53761(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks54545(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks51729(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks4881(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotPremiumTanks(
	[property: JsonPropertyName("5681")] CategoryWotBlitzResponseItemsWotPremiumTanks5681 _5681,
	[property: JsonPropertyName("23313")] CategoryWotBlitzResponseItemsWotPremiumTanks23313 _23313,
	[property: JsonPropertyName("15697")] CategoryWotBlitzResponseItemsWotPremiumTanks15697 _15697,
	[property: JsonPropertyName("25361")] CategoryWotBlitzResponseItemsWotPremiumTanks25361 _25361,
	[property: JsonPropertyName("12545")] CategoryWotBlitzResponseItemsWotPremiumTanks12545 _12545,
	[property: JsonPropertyName("62737")] CategoryWotBlitzResponseItemsWotPremiumTanks62737 _62737,
	[property: JsonPropertyName("18769")] CategoryWotBlitzResponseItemsWotPremiumTanks18769 _18769,
	[property: JsonPropertyName("53025")] CategoryWotBlitzResponseItemsWotPremiumTanks53025 _53025,
	[property: JsonPropertyName("20737")] CategoryWotBlitzResponseItemsWotPremiumTanks20737 _20737,
	[property: JsonPropertyName("20481")] CategoryWotBlitzResponseItemsWotPremiumTanks20481 _20481,
	[property: JsonPropertyName("18753")] CategoryWotBlitzResponseItemsWotPremiumTanks18753 _18753,
	[property: JsonPropertyName("58881")] CategoryWotBlitzResponseItemsWotPremiumTanks58881 _58881,
	[property: JsonPropertyName("19025")] CategoryWotBlitzResponseItemsWotPremiumTanks19025 _19025,
	[property: JsonPropertyName("13345")] CategoryWotBlitzResponseItemsWotPremiumTanks13345 _13345,
	[property: JsonPropertyName("2945")] CategoryWotBlitzResponseItemsWotPremiumTanks2945 _2945,
	[property: JsonPropertyName("16193")] CategoryWotBlitzResponseItemsWotPremiumTanks16193 _16193,
	[property: JsonPropertyName("19985")] CategoryWotBlitzResponseItemsWotPremiumTanks19985 _19985,
	[property: JsonPropertyName("19489")] CategoryWotBlitzResponseItemsWotPremiumTanks19489 _19489,
	[property: JsonPropertyName("20305")] CategoryWotBlitzResponseItemsWotPremiumTanks20305 _20305,
	[property: JsonPropertyName("18241")] CategoryWotBlitzResponseItemsWotPremiumTanks18241 _18241,
	[property: JsonPropertyName("21329")] CategoryWotBlitzResponseItemsWotPremiumTanks21329 _21329,
	[property: JsonPropertyName("18513")] CategoryWotBlitzResponseItemsWotPremiumTanks18513 _18513,
	[property: JsonPropertyName("16705")] CategoryWotBlitzResponseItemsWotPremiumTanks16705 _16705,
	[property: JsonPropertyName("9073")] CategoryWotBlitzResponseItemsWotPremiumTanks9073 _9073,
	[property: JsonPropertyName("12673")] CategoryWotBlitzResponseItemsWotPremiumTanks12673 _12673,
	[property: JsonPropertyName("6785")] CategoryWotBlitzResponseItemsWotPremiumTanks6785 _6785,
	[property: JsonPropertyName("21265")] CategoryWotBlitzResponseItemsWotPremiumTanks21265 _21265,
	[property: JsonPropertyName("2849")] CategoryWotBlitzResponseItemsWotPremiumTanks2849 _2849,
	[property: JsonPropertyName("20513")] CategoryWotBlitzResponseItemsWotPremiumTanks20513 _20513,
	[property: JsonPropertyName("23057")] CategoryWotBlitzResponseItemsWotPremiumTanks23057 _23057,
	[property: JsonPropertyName("64529")] CategoryWotBlitzResponseItemsWotPremiumTanks64529 _64529,
	[property: JsonPropertyName("7793")] CategoryWotBlitzResponseItemsWotPremiumTanks7793 _7793,
	[property: JsonPropertyName("23841")] CategoryWotBlitzResponseItemsWotPremiumTanks23841 _23841,
	[property: JsonPropertyName("21025")] CategoryWotBlitzResponseItemsWotPremiumTanks21025 _21025,
	[property: JsonPropertyName("6001")] CategoryWotBlitzResponseItemsWotPremiumTanks6001 _6001,
	[property: JsonPropertyName("55297")] CategoryWotBlitzResponseItemsWotPremiumTanks55297 _55297,
	[property: JsonPropertyName("6257")] CategoryWotBlitzResponseItemsWotPremiumTanks6257 _6257,
	[property: JsonPropertyName("8753")] CategoryWotBlitzResponseItemsWotPremiumTanks8753 _8753,
	[property: JsonPropertyName("23825")] CategoryWotBlitzResponseItemsWotPremiumTanks23825 _23825,
	[property: JsonPropertyName("15953")] CategoryWotBlitzResponseItemsWotPremiumTanks15953 _15953,
	[property: JsonPropertyName("59137")] CategoryWotBlitzResponseItemsWotPremiumTanks59137 _59137,
	[property: JsonPropertyName("7281")] CategoryWotBlitzResponseItemsWotPremiumTanks7281 _7281,
	[property: JsonPropertyName("20817")] CategoryWotBlitzResponseItemsWotPremiumTanks20817 _20817,
	[property: JsonPropertyName("5745")] CategoryWotBlitzResponseItemsWotPremiumTanks5745 _5745,
	[property: JsonPropertyName("625")] CategoryWotBlitzResponseItemsWotPremiumTanks625 _625,
	[property: JsonPropertyName("19713")] CategoryWotBlitzResponseItemsWotPremiumTanks19713 _19713,
	[property: JsonPropertyName("57105")] CategoryWotBlitzResponseItemsWotPremiumTanks57105 _57105,
	[property: JsonPropertyName("23297")] CategoryWotBlitzResponseItemsWotPremiumTanks23297 _23297,
	[property: JsonPropertyName("57361")] CategoryWotBlitzResponseItemsWotPremiumTanks57361 _57361,
	[property: JsonPropertyName("54785")] CategoryWotBlitzResponseItemsWotPremiumTanks54785 _54785,
	[property: JsonPropertyName("2609")] CategoryWotBlitzResponseItemsWotPremiumTanks2609 _2609,
	[property: JsonPropertyName("55889")] CategoryWotBlitzResponseItemsWotPremiumTanks55889 _55889,
	[property: JsonPropertyName("56097")] CategoryWotBlitzResponseItemsWotPremiumTanks56097 _56097,
	[property: JsonPropertyName("51473")] CategoryWotBlitzResponseItemsWotPremiumTanks51473 _51473,
	[property: JsonPropertyName("65377")] CategoryWotBlitzResponseItemsWotPremiumTanks65377 _65377,
	[property: JsonPropertyName("5489")] CategoryWotBlitzResponseItemsWotPremiumTanks5489 _5489,
	[property: JsonPropertyName("53761")] CategoryWotBlitzResponseItemsWotPremiumTanks53761 _53761,
	[property: JsonPropertyName("54545")] CategoryWotBlitzResponseItemsWotPremiumTanks54545 _54545,
	[property: JsonPropertyName("51729")] CategoryWotBlitzResponseItemsWotPremiumTanks51729 _51729,
	[property: JsonPropertyName("4881")] CategoryWotBlitzResponseItemsWotPremiumTanks4881 _4881
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks5505(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks13089(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks13569(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks4145(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks10289(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks3937(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks3649(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks18001(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks6449(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks15697(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks12305(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks4481(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks6145(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks7249(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks5681(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks58641(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks16897(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks14337(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks9489(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks385(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks10785(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks14609(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks23313(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks6929(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks6209(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks19537(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks7297(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks7169(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks5425(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks6753(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks3681(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks13185(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks10369(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks22817(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks14881(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks20257(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks24321(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks12049(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks13825(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks9297(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks19217(
	[property: JsonPropertyName("tank_id")] long TankId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("is_premium")] long IsPremium,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("tier")] long Tier,
	[property: JsonPropertyName("short_name")] string ShortName,
	[property: JsonPropertyName("is_collectible")] long IsCollectible
);

	public sealed record CategoryWotBlitzResponseItemsWotTopTanks(
	[property: JsonPropertyName("5505")] CategoryWotBlitzResponseItemsWotTopTanks5505 _5505,
	[property: JsonPropertyName("13089")] CategoryWotBlitzResponseItemsWotTopTanks13089 _13089,
	[property: JsonPropertyName("13569")] CategoryWotBlitzResponseItemsWotTopTanks13569 _13569,
	[property: JsonPropertyName("4145")] CategoryWotBlitzResponseItemsWotTopTanks4145 _4145,
	[property: JsonPropertyName("10289")] CategoryWotBlitzResponseItemsWotTopTanks10289 _10289,
	[property: JsonPropertyName("3937")] CategoryWotBlitzResponseItemsWotTopTanks3937 _3937,
	[property: JsonPropertyName("3649")] CategoryWotBlitzResponseItemsWotTopTanks3649 _3649,
	[property: JsonPropertyName("18001")] CategoryWotBlitzResponseItemsWotTopTanks18001 _18001,
	[property: JsonPropertyName("6449")] CategoryWotBlitzResponseItemsWotTopTanks6449 _6449,
	[property: JsonPropertyName("15697")] CategoryWotBlitzResponseItemsWotTopTanks15697 _15697,
	[property: JsonPropertyName("12305")] CategoryWotBlitzResponseItemsWotTopTanks12305 _12305,
	[property: JsonPropertyName("4481")] CategoryWotBlitzResponseItemsWotTopTanks4481 _4481,
	[property: JsonPropertyName("6145")] CategoryWotBlitzResponseItemsWotTopTanks6145 _6145,
	[property: JsonPropertyName("7249")] CategoryWotBlitzResponseItemsWotTopTanks7249 _7249,
	[property: JsonPropertyName("5681")] CategoryWotBlitzResponseItemsWotTopTanks5681 _5681,
	[property: JsonPropertyName("58641")] CategoryWotBlitzResponseItemsWotTopTanks58641 _58641,
	[property: JsonPropertyName("16897")] CategoryWotBlitzResponseItemsWotTopTanks16897 _16897,
	[property: JsonPropertyName("14337")] CategoryWotBlitzResponseItemsWotTopTanks14337 _14337,
	[property: JsonPropertyName("9489")] CategoryWotBlitzResponseItemsWotTopTanks9489 _9489,
	[property: JsonPropertyName("385")] CategoryWotBlitzResponseItemsWotTopTanks385 _385,
	[property: JsonPropertyName("10785")] CategoryWotBlitzResponseItemsWotTopTanks10785 _10785,
	[property: JsonPropertyName("14609")] CategoryWotBlitzResponseItemsWotTopTanks14609 _14609,
	[property: JsonPropertyName("23313")] CategoryWotBlitzResponseItemsWotTopTanks23313 _23313,
	[property: JsonPropertyName("6929")] CategoryWotBlitzResponseItemsWotTopTanks6929 _6929,
	[property: JsonPropertyName("6209")] CategoryWotBlitzResponseItemsWotTopTanks6209 _6209,
	[property: JsonPropertyName("19537")] CategoryWotBlitzResponseItemsWotTopTanks19537 _19537,
	[property: JsonPropertyName("7297")] CategoryWotBlitzResponseItemsWotTopTanks7297 _7297,
	[property: JsonPropertyName("7169")] CategoryWotBlitzResponseItemsWotTopTanks7169 _7169,
	[property: JsonPropertyName("5425")] CategoryWotBlitzResponseItemsWotTopTanks5425 _5425,
	[property: JsonPropertyName("6753")] CategoryWotBlitzResponseItemsWotTopTanks6753 _6753,
	[property: JsonPropertyName("3681")] CategoryWotBlitzResponseItemsWotTopTanks3681 _3681,
	[property: JsonPropertyName("13185")] CategoryWotBlitzResponseItemsWotTopTanks13185 _13185,
	[property: JsonPropertyName("10369")] CategoryWotBlitzResponseItemsWotTopTanks10369 _10369,
	[property: JsonPropertyName("22817")] CategoryWotBlitzResponseItemsWotTopTanks22817 _22817,
	[property: JsonPropertyName("14881")] CategoryWotBlitzResponseItemsWotTopTanks14881 _14881,
	[property: JsonPropertyName("20257")] CategoryWotBlitzResponseItemsWotTopTanks20257 _20257,
	[property: JsonPropertyName("24321")] CategoryWotBlitzResponseItemsWotTopTanks24321 _24321,
	[property: JsonPropertyName("12049")] CategoryWotBlitzResponseItemsWotTopTanks12049 _12049,
	[property: JsonPropertyName("13825")] CategoryWotBlitzResponseItemsWotTopTanks13825 _13825,
	[property: JsonPropertyName("9297")] CategoryWotBlitzResponseItemsWotTopTanks9297 _9297,
	[property: JsonPropertyName("19217")] CategoryWotBlitzResponseItemsWotTopTanks19217 _19217
);

	public sealed record CategoryWotBlitzResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long RestorePercents
);

	public sealed record CategoryWotBlitzResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] JsonElement EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("wot_item_id")] long WotItemId,
	[property: JsonPropertyName("wot_last_activity")] long WotLastActivity,
	[property: JsonPropertyName("wot_register_date")] long WotRegisterDate,
	[property: JsonPropertyName("wot_mobile")] long WotMobile,
	[property: JsonPropertyName("wot_premium")] long WotPremium,
	[property: JsonPropertyName("wot_premium_expires")] long WotPremiumExpires,
	[property: JsonPropertyName("wot_gold")] long WotGold,
	[property: JsonPropertyName("wot_credits")] long WotCredits,
	[property: JsonPropertyName("wot_battle_count")] long WotBattleCount,
	[property: JsonPropertyName("wot_win_count")] long WotWinCount,
	[property: JsonPropertyName("wot_loss_count")] long WotLossCount,
	[property: JsonPropertyName("wot_win_count_percents")] long WotWinCountPercents,
	[property: JsonPropertyName("wot_top_tanks")] long WotTopTanks,
	[property: JsonPropertyName("wot_premium_tanks")] long WotPremiumTanks,
	[property: JsonPropertyName("wot_top_premium_tanks")] long WotTopPremiumTanks,
	[property: JsonPropertyName("wot_region")] string WotRegion,
	[property: JsonPropertyName("wot_blitz")] long WotBlitz,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryWotBlitzResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("wotRegionPhrase")] string WotRegionPhrase,
	[property: JsonPropertyName("isSmallExf")] bool IsSmallExf,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("wotTopPremiumTanks")] CategoryWotBlitzResponseItemsWotTopPremiumTanks WotTopPremiumTanks2,
	[property: JsonPropertyName("wotTanks")] CategoryWotBlitzResponseItemsWotTanks WotTanks,
	[property: JsonPropertyName("wotPremiumTanks")] CategoryWotBlitzResponseItemsWotPremiumTanks WotPremiumTanks2,
	[property: JsonPropertyName("wotTopTanks")] CategoryWotBlitzResponseItemsWotTopTanks WotTopTanks2,
	[property: JsonPropertyName("wotPremiumTankCount")] long WotPremiumTankCount,
	[property: JsonPropertyName("wotTankCount")] long WotTankCount,
	[property: JsonPropertyName("wotLauncherTitle")] string WotLauncherTitle,
	[property: JsonPropertyName("wot_has_clan")] bool WotHasClan,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<JsonElement> AccountLinks,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryWotBlitzResponseItemsSeller Seller
);

	public sealed record CategoryGiftsParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("subscription")]
		public CategorySubscription? Subscription { get; init; }
		[JsonPropertyName("subscription_length")]
		public long? SubscriptionLength { get; init; }
		[JsonPropertyName("subscription_period")]
		public SubscriptionPeriod? SubscriptionPeriod { get; init; }
	}

	public sealed record CategoryGiftsResponse(
		[property: JsonPropertyName("items")] List<CategoryGiftsResponseItems> Items,
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

	public sealed record CategoryGiftsResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryGiftsResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] JsonElement RestorePercents
);

	public sealed record CategoryGiftsResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] JsonElement EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("gifts_item_id")] long GiftsItemId,
	[property: JsonPropertyName("gifts_service")] string GiftsService,
	[property: JsonPropertyName("gifts_duration")] long GiftsDuration,
	[property: JsonPropertyName("gifts_type")] string GiftsType,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryGiftsResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("giftsSubscriptionName")] string GiftsSubscriptionName,
	[property: JsonPropertyName("giftsServiceName")] string GiftsServiceName,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryGiftsResponseItemsSeller Seller
);

	public sealed record CategoryEpicGamesParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("eg")]
		public CategoryEg? Eg { get; init; }
		[JsonPropertyName("game[]")]
		public List<string>? Game { get; init; }
		[JsonPropertyName("change_email")]
		public ChangeEmail? ChangeEmail { get; init; }
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
		public long? Gmin { get; init; }
		[JsonPropertyName("gmax")]
		public long? Gmax { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("daybreak")]
		public long? Daybreak { get; init; }
		[JsonPropertyName("hours_played")]
		public JsonElement? HoursPlayed { get; init; }
		[JsonPropertyName("hours_played_max")]
		public JsonElement? HoursPlayedMax { get; init; }
	}

	public sealed record CategoryEpicGamesResponse(
		[property: JsonPropertyName("items")] List<CategoryEpicGamesResponseItems> Items,
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

	public sealed record CategoryEpicGamesResponseItemsEgGames0(
	[property: JsonPropertyName("internal_game_id")] long InternalGameId,
	[property: JsonPropertyName("app_id")] string AppId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("abbr")] string Abbr,
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("img")] string Img,
	[property: JsonPropertyName("url")] string Url,
	[property: JsonPropertyName("ru")] JsonElement Ru,
	[property: JsonPropertyName("hits_count")] long HitsCount,
	[property: JsonPropertyName("link")] string Link
);

	public sealed record CategoryEpicGamesResponseItemsEgGames(
	[property: JsonPropertyName("0")] CategoryEpicGamesResponseItemsEgGames0 _0
);

	public sealed record CategoryEpicGamesResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryEpicGamesResponseItemsEgTransactions(
	[property: JsonPropertyName("date")] long Date,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("presentmentTotal")] string PresentmentTotal,
	[property: JsonPropertyName("orderType")] string OrderType
);

	public sealed record CategoryEpicGamesResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long RestorePercents
);

	public sealed record CategoryEpicGamesResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("eg_item_id")] long EgItemId,
	[property: JsonPropertyName("eg_country")] string EgCountry,
	[property: JsonPropertyName("eg_code_redemption_history")] List<JsonElement> EgCodeRedemptionHistory,
	[property: JsonPropertyName("eg_coupons")] List<JsonElement> EgCoupons,
	[property: JsonPropertyName("eg_games")] CategoryEpicGamesResponseItemsEgGames EgGames,
	[property: JsonPropertyName("eg_change_email")] long EgChangeEmail,
	[property: JsonPropertyName("eg_can_update_display_name")] long EgCanUpdateDisplayName,
	[property: JsonPropertyName("eg_last_activity")] long EgLastActivity,
	[property: JsonPropertyName("eg_payment_methods")] List<JsonElement> EgPaymentMethods,
	[property: JsonPropertyName("eg_rl_purchases")] long EgRlPurchases,
	[property: JsonPropertyName("eg_username")] string EgUsername,
	[property: JsonPropertyName("eg_rewards_balance")] long EgRewardsBalance,
	[property: JsonPropertyName("eg_rewards_expiration_date")] long EgRewardsExpirationDate,
	[property: JsonPropertyName("eg_next_change_email_date")] long EgNextChangeEmailDate,
	[property: JsonPropertyName("eg_game_count")] long EgGameCount,
	[property: JsonPropertyName("eg_balance")] long EgBalance,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryEpicGamesResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("egBalance")] string EgBalance2,
	[property: JsonPropertyName("egGameCount")] long EgGameCount2,
	[property: JsonPropertyName("egTransactions")] List<CategoryEpicGamesResponseItemsEgTransactions> EgTransactions,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<JsonElement> AccountLinks,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryEpicGamesResponseItemsSeller Seller
);

	public sealed record CategoryEscapeFromTarkovParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("region")]
		public Region? Region { get; init; }
		[JsonPropertyName("version[]")]
		public JsonElement? Version { get; init; }
		[JsonPropertyName("reg")]
		public long? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public RegPeriod? RegPeriod { get; init; }
		[JsonPropertyName("level_min")]
		public long? LevelMin { get; init; }
		[JsonPropertyName("level_max")]
		public long? LevelMax { get; init; }
		[JsonPropertyName("pve")]
		public Pve? Pve { get; init; }
		[JsonPropertyName("side")]
		public Side? Side { get; init; }
	}

	public sealed record CategoryEscapeFromTarkovResponse(
		[property: JsonPropertyName("items")] List<CategoryEscapeFromTarkovResponseItems> Items,
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

	public sealed record CategoryEscapeFromTarkovResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryEscapeFromTarkovResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long RestorePercents
);

	public sealed record CategoryEscapeFromTarkovResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("tarkov_item_id")] long TarkovItemId,
	[property: JsonPropertyName("tarkov_game_version")] string TarkovGameVersion,
	[property: JsonPropertyName("tarkov_register_date")] long TarkovRegisterDate,
	[property: JsonPropertyName("tarkov_level")] long TarkovLevel,
	[property: JsonPropertyName("tarkov_exp")] long TarkovExp,
	[property: JsonPropertyName("tarkov_last_activity")] long TarkovLastActivity,
	[property: JsonPropertyName("tarkov_side")] string TarkovSide,
	[property: JsonPropertyName("tarkov_rubles")] long TarkovRubles,
	[property: JsonPropertyName("tarkov_secured_container")] string TarkovSecuredContainer,
	[property: JsonPropertyName("tarkov_euros")] long TarkovEuros,
	[property: JsonPropertyName("tarkov_dollars")] long TarkovDollars,
	[property: JsonPropertyName("tarkov_kd")] long TarkovKd,
	[property: JsonPropertyName("tarkov_deaths")] long TarkovDeaths,
	[property: JsonPropertyName("tarkov_kills")] long TarkovKills,
	[property: JsonPropertyName("tarkov_sessions")] long TarkovSessions,
	[property: JsonPropertyName("tarkov_region")] string TarkovRegion,
	[property: JsonPropertyName("tarkov_total_in_game")] long TarkovTotalInGame,
	[property: JsonPropertyName("tarkov_mail_forwarding")] long TarkovMailForwarding,
	[property: JsonPropertyName("tarkov_username")] string TarkovUsername,
	[property: JsonPropertyName("tarkov_purchase_date")] long TarkovPurchaseDate,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryEscapeFromTarkovResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("tarkovRegionPhrase")] string TarkovRegionPhrase,
	[property: JsonPropertyName("tarkovGameVersionPhrase")] string TarkovGameVersionPhrase,
	[property: JsonPropertyName("tarkovSecuredContainer")] string TarkovSecuredContainer2,
	[property: JsonPropertyName("tarkovKd")] long TarkovKd2,
	[property: JsonPropertyName("accountDomain")] string AccountDomain,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryEscapeFromTarkovResponseItemsSeller Seller
);

	public sealed record CategorySocialClubParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("daybreak")]
		public long? Daybreak { get; init; }
		[JsonPropertyName("level_min")]
		public long? LevelMin { get; init; }
		[JsonPropertyName("level_max")]
		public long? LevelMax { get; init; }
		[JsonPropertyName("cash_min")]
		public long? CashMin { get; init; }
		[JsonPropertyName("cash_max")]
		public long? CashMax { get; init; }
		[JsonPropertyName("bank_cash_min")]
		public long? BankCashMin { get; init; }
		[JsonPropertyName("bank_cash_max")]
		public long? BankCashMax { get; init; }
		[JsonPropertyName("game[]")]
		public List<string>? Game { get; init; }
	}

	public sealed record CategorySocialClubResponse(
		[property: JsonPropertyName("items")] List<CategorySocialClubResponseItems> Items,
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

	public sealed record CategorySocialClubResponseItemsSocialclubGames(
	[property: JsonPropertyName("id")] long Id,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("defaultPlatform")] string DefaultPlatform,
	[property: JsonPropertyName("platform")] string Platform,
	[property: JsonPropertyName("lastSeen")] string LastSeen,
	[property: JsonPropertyName("internal_game_id")] long InternalGameId,
	[property: JsonPropertyName("app_id")] string AppId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("abbr")] string Abbr,
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("img")] string Img,
	[property: JsonPropertyName("url")] string Url,
	[property: JsonPropertyName("ru")] JsonElement Ru
);

	public sealed record CategorySocialClubResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategorySocialClubResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] JsonElement RestorePercents
);

	public sealed record CategorySocialClubResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("socialclub_item_id")] long SocialclubItemId,
	[property: JsonPropertyName("socialclub_level")] long SocialclubLevel,
	[property: JsonPropertyName("socialclub_cash")] long SocialclubCash,
	[property: JsonPropertyName("socialclub_bank_cash")] long SocialclubBankCash,
	[property: JsonPropertyName("socialclub_games")] List<CategorySocialClubResponseItemsSocialclubGames> SocialclubGames,
	[property: JsonPropertyName("socialclub_last_activity")] long SocialclubLastActivity,
	[property: JsonPropertyName("socialclub_has_gtav")] long SocialclubHasGtav,
	[property: JsonPropertyName("socialclub_has_rdr2")] long SocialclubHasRdr2,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategorySocialClubResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("isSmallExf")] bool IsSmallExf,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<JsonElement> AccountLinks,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategorySocialClubResponseItemsSeller Seller
);

	public sealed record CategoryUplayParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
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
		public long? Daybreak { get; init; }
		[JsonPropertyName("gmin")]
		public long? Gmin { get; init; }
		[JsonPropertyName("gmax")]
		public long? Gmax { get; init; }
		[JsonPropertyName("subscription")]
		public CategorySubscription? Subscription { get; init; }
		[JsonPropertyName("subscription_length")]
		public long? SubscriptionLength { get; init; }
		[JsonPropertyName("subscription_period")]
		public SubscriptionPeriod? SubscriptionPeriod { get; init; }
		[JsonPropertyName("r6_level_min")]
		public long? R6LevelMin { get; init; }
		[JsonPropertyName("r6_level_max")]
		public long? R6LevelMax { get; init; }
		[JsonPropertyName("r6_rank_min")]
		public long? R6RankMin { get; init; }
		[JsonPropertyName("r6_rank_max")]
		public long? R6RankMax { get; init; }
		[JsonPropertyName("r6_operators_min")]
		public long? R6OperatorsMin { get; init; }
		[JsonPropertyName("r6_operators_max")]
		public long? R6OperatorsMax { get; init; }
		[JsonPropertyName("r6_ban")]
		public R6Ban? R6Ban { get; init; }
		[JsonPropertyName("r6_smin")]
		public long? R6Smin { get; init; }
		[JsonPropertyName("r6_smax")]
		public long? R6Smax { get; init; }
		[JsonPropertyName("r6_skin[]")]
		public List<string>? R6Skin { get; init; }
		[JsonPropertyName("r6_operator[]")]
		public List<string>? R6Operator { get; init; }
		[JsonPropertyName("xbox_connected")]
		public XboxConnected? XboxConnected { get; init; }
		[JsonPropertyName("psn_connected")]
		public PsnConnected? PsnConnected { get; init; }
		[JsonPropertyName("steam_connected")]
		public SteamConnected? SteamConnected { get; init; }
		[JsonPropertyName("balance_min")]
		public double? BalanceMin { get; init; }
		[JsonPropertyName("balance_max")]
		public double? BalanceMax { get; init; }
		[JsonPropertyName("transactions")]
		public Transactions? Transactions { get; init; }
		[JsonPropertyName("reg")]
		public long? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public RegPeriod? RegPeriod { get; init; }
	}

	public sealed record CategoryUplayResponse(
		[property: JsonPropertyName("items")] List<CategoryUplayResponseItems> Items,
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

	public sealed record CategoryUplayResponseItemsUplayGamesFfffffffFfffFfffFfffFfffffffffff(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("img")] string Img,
	[property: JsonPropertyName("pvpTimePlayed")] long PvpTimePlayed,
	[property: JsonPropertyName("pveTimePlayed")] long PveTimePlayed,
	[property: JsonPropertyName("abbr")] string Abbr,
	[property: JsonPropertyName("gameId")] string GameId
);

	public sealed record CategoryUplayResponseItemsUplayGames(
	[property: JsonPropertyName("ffffffff-ffff-ffff-ffff-ffffffffffff")] CategoryUplayResponseItemsUplayGamesFfffffffFfffFfffFfffFfffffffffff FfffffffFfffFfffFfffFfffffffffff
);

	public sealed record CategoryUplayResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryUplayResponseItemsR6Operators(
	[property: JsonPropertyName("img")] string Img,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("url")] string Url
);

	public sealed record CategoryUplayResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long RestorePercents
);

	public sealed record CategoryUplayResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("uplay_item_id")] long UplayItemId,
	[property: JsonPropertyName("uplay_last_activity")] long UplayLastActivity,
	[property: JsonPropertyName("uplay_country")] string UplayCountry,
	[property: JsonPropertyName("uplay_created_date")] long UplayCreatedDate,
	[property: JsonPropertyName("uplay_games")] CategoryUplayResponseItemsUplayGames UplayGames,
	[property: JsonPropertyName("uplay_game_count")] long UplayGameCount,
	[property: JsonPropertyName("uplay_r6_level")] long UplayR6Level,
	[property: JsonPropertyName("uplay_r6_ban")] long UplayR6Ban,
	[property: JsonPropertyName("uplay_r6_operators")] string UplayR6Operators,
	[property: JsonPropertyName("uplay_r6_operators_count")] long UplayR6OperatorsCount,
	[property: JsonPropertyName("uplay_r6_skins")] string UplayR6Skins,
	[property: JsonPropertyName("uplay_r6_skins_count")] long UplayR6SkinsCount,
	[property: JsonPropertyName("uplay_subscription")] string UplaySubscription,
	[property: JsonPropertyName("uplay_subscription_end_date")] long UplaySubscriptionEndDate,
	[property: JsonPropertyName("uplay_xbox_connected")] long UplayXboxConnected,
	[property: JsonPropertyName("uplay_psn_connected")] long UplayPsnConnected,
	[property: JsonPropertyName("uplay_steam_connected")] long UplaySteamConnected,
	[property: JsonPropertyName("uplay_r6_rank")] long UplayR6Rank,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryUplayResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("uplayLinkedAccounts")] string UplayLinkedAccounts,
	[property: JsonPropertyName("uplayR6Rank")] string UplayR6Rank2,
	[property: JsonPropertyName("uplay_r6_steam_warning")] bool UplayR6SteamWarning,
	[property: JsonPropertyName("uplay_r6_external_warning")] bool UplayR6ExternalWarning,
	[property: JsonPropertyName("uplay_r6")] bool UplayR6,
	[property: JsonPropertyName("uplay_r6_ban_active")] bool UplayR6BanActive,
	[property: JsonPropertyName("isSmallExf")] bool IsSmallExf,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("r6Skins")] List<JsonElement> R6Skins,
	[property: JsonPropertyName("r6Operators")] List<CategoryUplayResponseItemsR6Operators> R6Operators,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryUplayResponseItemsSeller Seller
);

	public sealed record CategoryDiscordParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("tel")]
		public Tel? Tel { get; init; }
		[JsonPropertyName("nitro")]
		public Nitro? Nitro { get; init; }
		[JsonPropertyName("nitro_type[]")]
		public JsonElement? NitroType { get; init; }
		[JsonPropertyName("nitro_length")]
		public long? NitroLength { get; init; }
		[JsonPropertyName("nitro_period")]
		public NitroPeriod? NitroPeriod { get; init; }
		[JsonPropertyName("boosts_min")]
		public long? BoostsMin { get; init; }
		[JsonPropertyName("boosts_max")]
		public long? BoostsMax { get; init; }
		[JsonPropertyName("billing")]
		public Billing? Billing { get; init; }
		[JsonPropertyName("gifts")]
		public Gifts? Gifts { get; init; }
		[JsonPropertyName("transactions")]
		public Transactions? Transactions { get; init; }
		[JsonPropertyName("badge[]")]
		public JsonElement? Badge { get; init; }
		[JsonPropertyName("condition[]")]
		public JsonElement? Condition { get; init; }
		[JsonPropertyName("chat_min")]
		public long? ChatMin { get; init; }
		[JsonPropertyName("chat_max")]
		public long? ChatMax { get; init; }
		[JsonPropertyName("min_admin_members")]
		public long? MinAdminMembers { get; init; }
		[JsonPropertyName("max_admin_members")]
		public long? MaxAdminMembers { get; init; }
		[JsonPropertyName("min_admin")]
		public long? MinAdmin { get; init; }
		[JsonPropertyName("max_admin")]
		public long? MaxAdmin { get; init; }
		[JsonPropertyName("reg")]
		public long? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public RegPeriod? RegPeriod { get; init; }
		[JsonPropertyName("language[]")]
		public List<string>? Language { get; init; }
		[JsonPropertyName("not_language[]")]
		public List<string>? NotLanguage { get; init; }
		[JsonPropertyName("clans")]
		public Clans? Clans { get; init; }
		[JsonPropertyName("min_admin_clans")]
		public long? MinAdminClans { get; init; }
		[JsonPropertyName("max_admin_clans")]
		public long? MaxAdminClans { get; init; }
		[JsonPropertyName("min_owner_clans")]
		public long? MinOwnerClans { get; init; }
		[JsonPropertyName("max_owner_clans")]
		public long? MaxOwnerClans { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("min_servers")]
		public long? MinServers { get; init; }
		[JsonPropertyName("max_servers")]
		public long? MaxServers { get; init; }
		[JsonPropertyName("2fa")]
		public E2fa? _2fa { get; init; }
		[JsonPropertyName("min_full_credits")]
		public long? MinFullCredits { get; init; }
		[JsonPropertyName("max_full_credits")]
		public long? MaxFullCredits { get; init; }
		[JsonPropertyName("min_basic_credits")]
		public long? MinBasicCredits { get; init; }
		[JsonPropertyName("max_basic_credits")]
		public long? MaxBasicCredits { get; init; }
		[JsonPropertyName("min_orbs")]
		public long? MinOrbs { get; init; }
		[JsonPropertyName("max_orbs")]
		public long? MaxOrbs { get; init; }
	}

	public sealed record CategoryDiscordResponse(
		[property: JsonPropertyName("items")] List<CategoryDiscordResponseItems> Items,
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

	public sealed record CategoryDiscordResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryDiscordResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] JsonElement RestorePercents
);

	public sealed record CategoryDiscordResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("discord_item_id")] long DiscordItemId,
	[property: JsonPropertyName("discord_chat_count")] long DiscordChatCount,
	[property: JsonPropertyName("discord_verified")] long DiscordVerified,
	[property: JsonPropertyName("discord_condition")] string DiscordCondition,
	[property: JsonPropertyName("discord_gifts")] long DiscordGifts,
	[property: JsonPropertyName("discord_billing")] long DiscordBilling,
	[property: JsonPropertyName("discord_register_date")] long DiscordRegisterDate,
	[property: JsonPropertyName("discord_locale")] string DiscordLocale,
	[property: JsonPropertyName("discord_nitro_end_date")] long DiscordNitroEndDate,
	[property: JsonPropertyName("discord_available_boosts")] long DiscordAvailableBoosts,
	[property: JsonPropertyName("discord_nitro_type")] long DiscordNitroType,
	[property: JsonPropertyName("discord_admin_members_count")] long DiscordAdminMembersCount,
	[property: JsonPropertyName("discord_admin_servers_count")] long DiscordAdminServersCount,
	[property: JsonPropertyName("discord_admin_servers")] string DiscordAdminServers,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryDiscordResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("discordAccountConditionLabel")] string DiscordAccountConditionLabel,
	[property: JsonPropertyName("discordLocaleTitle")] string DiscordLocaleTitle,
	[property: JsonPropertyName("discordNitroType")] string DiscordNitroType2,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryDiscordResponseItemsSeller Seller
);

	public sealed record CategoryTikTokParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("tel")]
		public Tel? Tel { get; init; }
		[JsonPropertyName("reg")]
		public long? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public RegPeriod? RegPeriod { get; init; }
		[JsonPropertyName("followers_min")]
		public long? FollowersMin { get; init; }
		[JsonPropertyName("followers_max")]
		public long? FollowersMax { get; init; }
		[JsonPropertyName("post_min")]
		public long? PostMin { get; init; }
		[JsonPropertyName("post_max")]
		public long? PostMax { get; init; }
		[JsonPropertyName("like_min")]
		public long? LikeMin { get; init; }
		[JsonPropertyName("like_max")]
		public long? LikeMax { get; init; }
		[JsonPropertyName("coins_min")]
		public long? CoinsMin { get; init; }
		[JsonPropertyName("coins_max")]
		public long? CoinsMax { get; init; }
		[JsonPropertyName("cookie_login")]
		public CookieLogin? CookieLogin { get; init; }
		[JsonPropertyName("verified")]
		public Verified? Verified { get; init; }
		[JsonPropertyName("email")]
		public Email? Email { get; init; }
	}

	public sealed record CategoryTikTokResponse(
		[property: JsonPropertyName("items")] List<CategoryTikTokResponseItems> Items,
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

	public sealed record CategoryTikTokResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryTikTokResponseItemsAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
);

	public sealed record CategoryTikTokResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long RestorePercents
);

	public sealed record CategoryTikTokResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] JsonElement EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("tt_item_id")] long TtItemId,
	[property: JsonPropertyName("tt_id")] long TtId,
	[property: JsonPropertyName("tt_permalink")] string TtPermalink,
	[property: JsonPropertyName("tt_uniqueId")] string TtUniqueId,
	[property: JsonPropertyName("tt_verified")] long TtVerified,
	[property: JsonPropertyName("tt_createTime")] long TtCreateTime,
	[property: JsonPropertyName("tt_privateAccount")] long TtPrivateAccount,
	[property: JsonPropertyName("tt_followers")] long TtFollowers,
	[property: JsonPropertyName("tt_following")] long TtFollowing,
	[property: JsonPropertyName("tt_likes")] long TtLikes,
	[property: JsonPropertyName("tt_videos")] long TtVideos,
	[property: JsonPropertyName("tt_screen_name")] string TtScreenName,
	[property: JsonPropertyName("tt_hasEmail")] long TtHasEmail,
	[property: JsonPropertyName("tt_hasMobile")] long TtHasMobile,
	[property: JsonPropertyName("tt_top_country")] string TtTopCountry,
	[property: JsonPropertyName("tt_countries")] string TtCountries,
	[property: JsonPropertyName("tt_coins")] long TtCoins,
	[property: JsonPropertyName("tt_hasLivePermission")] long TtHasLivePermission,
	[property: JsonPropertyName("tt_cookie_login")] long TtCookieLogin,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryTikTokResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<CategoryTikTokResponseItemsAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryTikTokResponseItemsSeller Seller
);

	public sealed record CategoryInstagramParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("tel")]
		public Tel? Tel { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("cookies")]
		public Cookies? Cookies { get; init; }
		[JsonPropertyName("login_without_cookies")]
		public LoginWithoutCookies? LoginWithoutCookies { get; init; }
		[JsonPropertyName("followers_min")]
		public long? FollowersMin { get; init; }
		[JsonPropertyName("followers_max")]
		public long? FollowersMax { get; init; }
		[JsonPropertyName("post_min")]
		public long? PostMin { get; init; }
		[JsonPropertyName("post_max")]
		public long? PostMax { get; init; }
		[JsonPropertyName("reg")]
		public long? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public RegPeriod? RegPeriod { get; init; }
	}

	public sealed record CategoryInstagramResponse(
		[property: JsonPropertyName("items")] List<CategoryInstagramResponseItems> Items,
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

	public sealed record CategoryInstagramResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryInstagramResponseItemsAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
);

	public sealed record CategoryInstagramResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] JsonElement RestorePercents
);

	public sealed record CategoryInstagramResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("instagram_item_id")] long InstagramItemId,
	[property: JsonPropertyName("instagram_id")] string InstagramId,
	[property: JsonPropertyName("instagram_follower_count")] long InstagramFollowerCount,
	[property: JsonPropertyName("instagram_follow_count")] long InstagramFollowCount,
	[property: JsonPropertyName("instagram_post_count")] long InstagramPostCount,
	[property: JsonPropertyName("instagram_country")] string InstagramCountry,
	[property: JsonPropertyName("instagram_username")] string InstagramUsername,
	[property: JsonPropertyName("instagram_mobile")] long InstagramMobile,
	[property: JsonPropertyName("instagram_register_date")] long InstagramRegisterDate,
	[property: JsonPropertyName("instagram_has_cookies")] long InstagramHasCookies,
	[property: JsonPropertyName("instagram_login_without_cookies")] long InstagramLoginWithoutCookies,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryInstagramResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<CategoryInstagramResponseItemsAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryInstagramResponseItemsSeller Seller
);

	public sealed record CategoryBattleNetParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("eg")]
		public CategoryEg? Eg { get; init; }
		[JsonPropertyName("game[]")]
		public List<long?>? Game { get; init; }
		[JsonPropertyName("daybreak")]
		public long? Daybreak { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("tel")]
		public Tel? Tel { get; init; }
		[JsonPropertyName("edit_btag")]
		public EditBtag? EditBtag { get; init; }
		[JsonPropertyName("changeable_fn")]
		public ChangeableFn? ChangeableFn { get; init; }
		[JsonPropertyName("real_id")]
		public RealId? RealId { get; init; }
		[JsonPropertyName("parent_control")]
		public ParentControl? ParentControl { get; init; }
		[JsonPropertyName("no_bans")]
		public NoBans? NoBans { get; init; }
		[JsonPropertyName("balance_min")]
		public long? BalanceMin { get; init; }
		[JsonPropertyName("balance_max")]
		public long? BalanceMax { get; init; }
	}

	public sealed record CategoryBattleNetResponse(
		[property: JsonPropertyName("items")] List<CategoryBattleNetResponseItems> Items,
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

	public sealed record CategoryBattleNetResponseItemsGuarantee(
	[property: JsonPropertyName("duration")] long Duration,
	[property: JsonPropertyName("class")] string Class,
	[property: JsonPropertyName("durationPhrase")] string DurationPhrase,
	[property: JsonPropertyName("endDate")] JsonElement EndDate,
	[property: JsonPropertyName("active")] JsonElement Active,
	[property: JsonPropertyName("cancelled")] JsonElement Cancelled,
	[property: JsonPropertyName("remainingTime")] JsonElement RemainingTime
);

	public sealed record CategoryBattleNetResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryBattleNetResponseItemsBattlenetGames17459(
	[property: JsonPropertyName("internal_game_id")] long InternalGameId,
	[property: JsonPropertyName("app_id")] string AppId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("abbr")] string Abbr,
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("img")] string Img,
	[property: JsonPropertyName("url")] string Url,
	[property: JsonPropertyName("ru")] JsonElement Ru
);

	public sealed record CategoryBattleNetResponseItemsBattlenetGames(
	[property: JsonPropertyName("17459")] CategoryBattleNetResponseItemsBattlenetGames17459 _17459
);

	public sealed record CategoryBattleNetResponseItemsBattlenetTransactions(
	[property: JsonPropertyName("date")] long Date,
	[property: JsonPropertyName("productTitle")] string ProductTitle,
	[property: JsonPropertyName("formattedTotal")] string FormattedTotal,
	[property: JsonPropertyName("total")] string Total
);

	public sealed record CategoryBattleNetResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long RestorePercents
);

	public sealed record CategoryBattleNetResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("battlenet_item_id")] long BattlenetItemId,
	[property: JsonPropertyName("battlenet_balance")] string BattlenetBalance,
	[property: JsonPropertyName("battlenet_country")] string BattlenetCountry,
	[property: JsonPropertyName("battlenet_last_activity")] long BattlenetLastActivity,
	[property: JsonPropertyName("battlenet_mobile")] long BattlenetMobile,
	[property: JsonPropertyName("battlenet_bans")] string BattlenetBans,
	[property: JsonPropertyName("battlenet_can_change_tag")] long BattlenetCanChangeTag,
	[property: JsonPropertyName("battlenet_real_id_enabled")] long BattlenetRealIdEnabled,
	[property: JsonPropertyName("battlenet_change_full_name")] long BattlenetChangeFullName,
	[property: JsonPropertyName("battlenet_parent_control")] long BattlenetParentControl,
	[property: JsonPropertyName("battlenet_converted_balance")] long BattlenetConvertedBalance,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] CategoryBattleNetResponseItemsGuarantee Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryBattleNetResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("isSmallExf")] bool IsSmallExf,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("battlenetBans")] string BattlenetBans2,
	[property: JsonPropertyName("battlenetGames")] CategoryBattleNetResponseItemsBattlenetGames BattlenetGames,
	[property: JsonPropertyName("hasOverwatch")] bool HasOverwatch,
	[property: JsonPropertyName("battlenetTransactions")] List<CategoryBattleNetResponseItemsBattlenetTransactions> BattlenetTransactions,
	[property: JsonPropertyName("displayConvertedBalance")] bool DisplayConvertedBalance,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<JsonElement> AccountLinks,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryBattleNetResponseItemsSeller Seller
);

	public sealed record CategoryChatGPTParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email_type[]")]
		public JsonElement? EmailType { get; init; }
		[JsonPropertyName("item_domain")]
		public string? ItemDomain { get; init; }
		[JsonPropertyName("subscription[]")]
		public JsonElement? Subscription { get; init; }
		[JsonPropertyName("subscription_length")]
		public long? SubscriptionLength { get; init; }
		[JsonPropertyName("subscription_period")]
		public SubscriptionPeriod? SubscriptionPeriod { get; init; }
		[JsonPropertyName("autorenewal")]
		public Autorenewal? Autorenewal { get; init; }
		[JsonPropertyName("tel")]
		public Tel? Tel { get; init; }
		[JsonPropertyName("transactions")]
		public Transactions? Transactions { get; init; }
		[JsonPropertyName("reg")]
		public long? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public RegPeriod? RegPeriod { get; init; }
		[JsonPropertyName("openai_tier[]")]
		public JsonElement? OpenaiTier { get; init; }
		[JsonPropertyName("openai_balance_min")]
		public long? OpenaiBalanceMin { get; init; }
		[JsonPropertyName("openai_balance_max")]
		public long? OpenaiBalanceMax { get; init; }
	}

	public sealed record CategoryChatGPTResponse(
		[property: JsonPropertyName("items")] List<CategoryChatGPTResponseItems> Items,
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

	public sealed record CategoryChatGPTResponseItemsCopyFormatData(
	[property: JsonPropertyName("title_link")] string TitleLink
);

	public sealed record CategoryChatGPTResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryChatGPTResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] JsonElement RestorePercents
);

	public sealed record CategoryChatGPTResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("chatgpt_item_id")] long ChatgptItemId,
	[property: JsonPropertyName("chatgpt_country")] string ChatgptCountry,
	[property: JsonPropertyName("chatgpt_register_date")] long ChatgptRegisterDate,
	[property: JsonPropertyName("chatgpt_phone")] long ChatgptPhone,
	[property: JsonPropertyName("chatgpt_subscription")] string ChatgptSubscription,
	[property: JsonPropertyName("chatgpt_subscription_ends")] long ChatgptSubscriptionEnds,
	[property: JsonPropertyName("chatgpt_subscription_auto_renew")] long ChatgptSubscriptionAutoRenew,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] double PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewItemViews")] bool CanViewItemViews,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("copyFormatData")] CategoryChatGPTResponseItemsCopyFormatData CopyFormatData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryChatGPTResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("isPersonalAccount")] bool IsPersonalAccount,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("priceWithSellerFeeLabel")] string PriceWithSellerFeeLabel,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("gptSubType")] string GptSubType,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("canChangeEmailPassword")] bool CanChangeEmailPassword,
	[property: JsonPropertyName("uniqueKeyExists")] bool UniqueKeyExists,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryChatGPTResponseItemsSeller Seller
);

	public sealed record CategoryVpnParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("service[]")]
		public JsonElement? Service { get; init; }
		[JsonPropertyName("subscription_length")]
		public long? SubscriptionLength { get; init; }
		[JsonPropertyName("subscription_period")]
		public SubscriptionPeriod? SubscriptionPeriod { get; init; }
		[JsonPropertyName("autorenewal")]
		public Autorenewal? Autorenewal { get; init; }
	}

	public sealed record CategoryVpnResponse(
		[property: JsonPropertyName("items")] List<CategoryVpnResponseItems> Items,
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

	public sealed record CategoryVpnResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryVpnResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long RestorePercents
);

	public sealed record CategoryVpnResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] JsonElement EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("vpn_item_id")] long VpnItemId,
	[property: JsonPropertyName("vpn_service")] string VpnService,
	[property: JsonPropertyName("vpn_expire_date")] long VpnExpireDate,
	[property: JsonPropertyName("vpn_renewable")] long VpnRenewable,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryVpnResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("vpnProductTitle")] string VpnProductTitle,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryVpnResponseItemsSeller Seller
);

	public sealed record CategoryRobloxParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("email")]
		public Email? Email { get; init; }
		[JsonPropertyName("robux_min")]
		public long? RobuxMin { get; init; }
		[JsonPropertyName("robux_max")]
		public long? RobuxMax { get; init; }
		[JsonPropertyName("friends_min")]
		public long? FriendsMin { get; init; }
		[JsonPropertyName("friends_max")]
		public long? FriendsMax { get; init; }
		[JsonPropertyName("followers_min")]
		public long? FollowersMin { get; init; }
		[JsonPropertyName("followers_max")]
		public long? FollowersMax { get; init; }
		[JsonPropertyName("country")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("reg")]
		public long? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public RegPeriod? RegPeriod { get; init; }
		[JsonPropertyName("subscription")]
		public CategorySubscription? Subscription { get; init; }
		[JsonPropertyName("subscription_length")]
		public long? SubscriptionLength { get; init; }
		[JsonPropertyName("subscription_period")]
		public SubscriptionPeriod? SubscriptionPeriod { get; init; }
		[JsonPropertyName("autorenewal")]
		public Autorenewal? Autorenewal { get; init; }
		[JsonPropertyName("xbox_connected")]
		public XboxConnected? XboxConnected { get; init; }
		[JsonPropertyName("psn_connected")]
		public PsnConnected? PsnConnected { get; init; }
		[JsonPropertyName("verified")]
		public Verified? Verified { get; init; }
		[JsonPropertyName("age_verified")]
		public AgeVerified? AgeVerified { get; init; }
		[JsonPropertyName("incoming_robux_total_min")]
		public long? IncomingRobuxTotalMin { get; init; }
		[JsonPropertyName("incoming_robux_total_max")]
		public long? IncomingRobuxTotalMax { get; init; }
		[JsonPropertyName("limited_price_min")]
		public long? LimitedPriceMin { get; init; }
		[JsonPropertyName("limited_price_max")]
		public long? LimitedPriceMax { get; init; }
		[JsonPropertyName("gamepass_min")]
		public long? GamepassMin { get; init; }
		[JsonPropertyName("gamepass_max")]
		public long? GamepassMax { get; init; }
		[JsonPropertyName("game_donations")]
		public GameDonations? GameDonations { get; init; }
		[JsonPropertyName("inv_min")]
		public long? InvMin { get; init; }
		[JsonPropertyName("inv_max")]
		public long? InvMax { get; init; }
		[JsonPropertyName("ugc_limited_price_min")]
		public long? UgcLimitedPriceMin { get; init; }
		[JsonPropertyName("ugc_limited_price_max")]
		public long? UgcLimitedPriceMax { get; init; }
		[JsonPropertyName("credit_balance_min")]
		public long? CreditBalanceMin { get; init; }
		[JsonPropertyName("credit_balance_max")]
		public long? CreditBalanceMax { get; init; }
		[JsonPropertyName("offsale_min")]
		public long? OffsaleMin { get; init; }
		[JsonPropertyName("offsale_max")]
		public long? OffsaleMax { get; init; }
		[JsonPropertyName("voice")]
		public Voice? Voice { get; init; }
		[JsonPropertyName("age_group[]")]
		public List<string>? AgeGroup { get; init; }
		[JsonPropertyName("not_age_group[]")]
		public List<string>? NotAgeGroup { get; init; }
	}

	public sealed record CategoryRobloxResponse(
		[property: JsonPropertyName("items")] List<CategoryRobloxResponseItems> Items,
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

	public sealed record CategoryRobloxResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryRobloxResponseItemsRobloxGameDonations(
	[property: JsonPropertyName("id")] long Id,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("amount")] long Amount
);

	public sealed record CategoryRobloxResponseItemsRobloxGameDonationsDetails(
	[property: JsonPropertyName("product")] string Product,
	[property: JsonPropertyName("amount")] long Amount,
	[property: JsonPropertyName("type")] string Type
);

	public sealed record CategoryRobloxResponseItemsAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
);

	public sealed record CategoryRobloxResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long RestorePercents
);

	public sealed record CategoryRobloxResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("roblox_item_id")] long RobloxItemId,
	[property: JsonPropertyName("roblox_id")] long RobloxId,
	[property: JsonPropertyName("roblox_email_verified")] long RobloxEmailVerified,
	[property: JsonPropertyName("roblox_robux")] long RobloxRobux,
	[property: JsonPropertyName("roblox_username")] string RobloxUsername,
	[property: JsonPropertyName("roblox_country")] string RobloxCountry,
	[property: JsonPropertyName("roblox_register_date")] long RobloxRegisterDate,
	[property: JsonPropertyName("roblox_friends")] long RobloxFriends,
	[property: JsonPropertyName("roblox_followers")] long RobloxFollowers,
	[property: JsonPropertyName("roblox_subscription")] string RobloxSubscription,
	[property: JsonPropertyName("roblox_subscription_end_date")] long RobloxSubscriptionEndDate,
	[property: JsonPropertyName("roblox_xbox_connected")] long RobloxXboxConnected,
	[property: JsonPropertyName("roblox_incoming_robux_total")] long RobloxIncomingRobuxTotal,
	[property: JsonPropertyName("roblox_limited_price")] long RobloxLimitedPrice,
	[property: JsonPropertyName("roblox_verified")] long RobloxVerified,
	[property: JsonPropertyName("roblox_age_verified")] long RobloxAgeVerified,
	[property: JsonPropertyName("roblox_psn_connected")] long RobloxPsnConnected,
	[property: JsonPropertyName("roblox_subscription_auto_renew")] long RobloxSubscriptionAutoRenew,
	[property: JsonPropertyName("roblox_game_pass_total_robux")] long RobloxGamePassTotalRobux,
	[property: JsonPropertyName("roblox_game_donations")] string RobloxGameDonations,
	[property: JsonPropertyName("roblox_inventory_price")] long RobloxInventoryPrice,
	[property: JsonPropertyName("roblox_ugc_limited_price")] long RobloxUgcLimitedPrice,
	[property: JsonPropertyName("roblox_credit_balance")] long RobloxCreditBalance,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryRobloxResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("robloxLinkedAccounts")] string RobloxLinkedAccounts,
	[property: JsonPropertyName("creditBalance")] string CreditBalance,
	[property: JsonPropertyName("robloxGameDonations")] List<CategoryRobloxResponseItemsRobloxGameDonations> RobloxGameDonations2,
	[property: JsonPropertyName("robloxGameDonationsDetails")] List<CategoryRobloxResponseItemsRobloxGameDonationsDetails> RobloxGameDonationsDetails,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<CategoryRobloxResponseItemsAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryRobloxResponseItemsSeller Seller
);

	public sealed record CategoryWarfaceParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("rank_min")]
		public long? RankMin { get; init; }
		[JsonPropertyName("rank_max")]
		public long? RankMax { get; init; }
		[JsonPropertyName("bonus_rank_min")]
		public long? BonusRankMin { get; init; }
		[JsonPropertyName("bonus_rank_max")]
		public long? BonusRankMax { get; init; }
		[JsonPropertyName("tel")]
		public Tel? Tel { get; init; }
		[JsonPropertyName("daybreak")]
		public long? Daybreak { get; init; }
		[JsonPropertyName("kredits_min")]
		public long? KreditsMin { get; init; }
		[JsonPropertyName("kredits_max")]
		public long? KreditsMax { get; init; }
		[JsonPropertyName("total_kredits_min")]
		public long? TotalKreditsMin { get; init; }
		[JsonPropertyName("total_kredits_max")]
		public long? TotalKreditsMax { get; init; }
	}

	public sealed record CategoryWarfaceResponse(
		[property: JsonPropertyName("items")] List<CategoryWarfaceResponseItems> Items,
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

	public sealed record CategoryWarfaceResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryWarfaceResponseItemsWfServers(
	[property: JsonPropertyName("id")] long Id,
	[property: JsonPropertyName("rank")] long Rank,
	[property: JsonPropertyName("title")] string Title
);

	public sealed record CategoryWarfaceResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long RestorePercents
);

	public sealed record CategoryWarfaceResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] JsonElement EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("wf_item_id")] long WfItemId,
	[property: JsonPropertyName("wf_players")] bool WfPlayers,
	[property: JsonPropertyName("wf_server_1")] long WfServer_1,
	[property: JsonPropertyName("wf_server_2")] long WfServer_2,
	[property: JsonPropertyName("wf_server_3")] long WfServer_3,
	[property: JsonPropertyName("wf_mobile")] long WfMobile,
	[property: JsonPropertyName("wf_bonus_rank")] long WfBonusRank,
	[property: JsonPropertyName("wf_mail_mobile")] long WfMailMobile,
	[property: JsonPropertyName("wf_last_game_date")] long WfLastGameDate,
	[property: JsonPropertyName("wf_loan")] bool WfLoan,
	[property: JsonPropertyName("wf_active_loan")] long WfActiveLoan,
	[property: JsonPropertyName("wf_rank")] long WfRank,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryWarfaceResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("isSmallExf")] bool IsSmallExf,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("wf_servers")] List<CategoryWarfaceResponseItemsWfServers> WfServers,
	[property: JsonPropertyName("domain")] string Domain,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryWarfaceResponseItemsSeller Seller
);

	public sealed record CategoryMinecraftParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("subscription")]
		public CategorySubscription? Subscription { get; init; }
		[JsonPropertyName("subscription_length")]
		public long? SubscriptionLength { get; init; }
		[JsonPropertyName("subscription_period")]
		public SubscriptionPeriod? SubscriptionPeriod { get; init; }
		[JsonPropertyName("autorenewal")]
		public Autorenewal? Autorenewal { get; init; }
		[JsonPropertyName("java")]
		public Java? Java { get; init; }
		[JsonPropertyName("bedrock")]
		public Bedrock? Bedrock { get; init; }
		[JsonPropertyName("dungeons")]
		public Dungeons? Dungeons { get; init; }
		[JsonPropertyName("legends")]
		public Legends? Legends { get; init; }
		[JsonPropertyName("change_nickname")]
		public ChangeNickname? ChangeNickname { get; init; }
		[JsonPropertyName("capes[]")]
		public List<string>? Capes { get; init; }
		[JsonPropertyName("capes_min")]
		public long? CapesMin { get; init; }
		[JsonPropertyName("capes_max")]
		public long? CapesMax { get; init; }
		[JsonPropertyName("country[]")]
		public List<string>? Country { get; init; }
		[JsonPropertyName("not_country[]")]
		public List<string>? NotCountry { get; init; }
		[JsonPropertyName("hypixel_ban")]
		public HypixelBan? HypixelBan { get; init; }
		[JsonPropertyName("hypixel_skyblock_api_enabled")]
		public HypixelSkyblockApiEnabled? HypixelSkyblockApiEnabled { get; init; }
		[JsonPropertyName("rank_hypixel[]")]
		public JsonElement? RankHypixel { get; init; }
		[JsonPropertyName("level_hypixel_min")]
		public long? LevelHypixelMin { get; init; }
		[JsonPropertyName("level_hypixel_max")]
		public long? LevelHypixelMax { get; init; }
		[JsonPropertyName("achievement_hypixel_min")]
		public long? AchievementHypixelMin { get; init; }
		[JsonPropertyName("achievement_hypixel_max")]
		public long? AchievementHypixelMax { get; init; }
		[JsonPropertyName("level_hypixel_skyblock_min")]
		public long? LevelHypixelSkyblockMin { get; init; }
		[JsonPropertyName("level_hypixel_skyblock_max")]
		public long? LevelHypixelSkyblockMax { get; init; }
		[JsonPropertyName("net_worth_hypixel_skyblock_min")]
		public long? NetWorthHypixelSkyblockMin { get; init; }
		[JsonPropertyName("net_worth_hypixel_skyblock_max")]
		public long? NetWorthHypixelSkyblockMax { get; init; }
		[JsonPropertyName("reg")]
		public long? Reg { get; init; }
		[JsonPropertyName("reg_period")]
		public RegPeriod? RegPeriod { get; init; }
		[JsonPropertyName("last_login_hypixel")]
		public long? LastLoginHypixel { get; init; }
		[JsonPropertyName("last_login_hypixel_period")]
		public LastLoginHypixelPeriod? LastLoginHypixelPeriod { get; init; }
		[JsonPropertyName("can_change_details")]
		public CanChangeDetails? CanChangeDetails { get; init; }
		[JsonPropertyName("nickname_length_min")]
		public long? NicknameLengthMin { get; init; }
		[JsonPropertyName("nickname_length_max")]
		public long? NicknameLengthMax { get; init; }
		[JsonPropertyName("hypixel_ban_parsed")]
		public HypixelBanParsed? HypixelBanParsed { get; init; }
		[JsonPropertyName("minecoins_min")]
		public long? MinecoinsMin { get; init; }
		[JsonPropertyName("minecoins_max")]
		public long? MinecoinsMax { get; init; }
	}

	public sealed record CategoryMinecraftResponse(
		[property: JsonPropertyName("items")] List<CategoryMinecraftResponseItems> Items,
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

	public sealed record CategoryMinecraftResponseItemsBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record CategoryMinecraftResponseItemsAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
);

	public sealed record CategoryMinecraftResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] JsonElement RestorePercents
);

	public sealed record CategoryMinecraftResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("minecraft_item_id")] long MinecraftItemId,
	[property: JsonPropertyName("minecraft_id")] string MinecraftId,
	[property: JsonPropertyName("minecraft_nickname")] string MinecraftNickname,
	[property: JsonPropertyName("minecraft_country")] string MinecraftCountry,
	[property: JsonPropertyName("minecraft_skin")] string MinecraftSkin,
	[property: JsonPropertyName("minecraft_java")] long MinecraftJava,
	[property: JsonPropertyName("minecraft_bedrock")] long MinecraftBedrock,
	[property: JsonPropertyName("minecraft_can_change_nickname")] long MinecraftCanChangeNickname,
	[property: JsonPropertyName("minecraft_created_at")] long MinecraftCreatedAt,
	[property: JsonPropertyName("minecraft_hypixel_rank")] string MinecraftHypixelRank,
	[property: JsonPropertyName("minecraft_hypixel_level")] long MinecraftHypixelLevel,
	[property: JsonPropertyName("minecraft_hypixel_achievement")] long MinecraftHypixelAchievement,
	[property: JsonPropertyName("minecraft_hypixel_last_login")] long MinecraftHypixelLastLogin,
	[property: JsonPropertyName("minecraft_hypixel_ban")] long MinecraftHypixelBan,
	[property: JsonPropertyName("minecraft_hypixel_ban_reason")] string MinecraftHypixelBanReason,
	[property: JsonPropertyName("minecraft_hypixel_skyblock_level")] long MinecraftHypixelSkyblockLevel,
	[property: JsonPropertyName("minecraft_hypixel_skyblock_net_worth")] long MinecraftHypixelSkyblockNetWorth,
	[property: JsonPropertyName("minecraft_dungeons")] long MinecraftDungeons,
	[property: JsonPropertyName("minecraft_legends")] long MinecraftLegends,
	[property: JsonPropertyName("minecraft_capes_count")] long MinecraftCapesCount,
	[property: JsonPropertyName("minecraft_capes")] List<JsonElement> MinecraftCapes,
	[property: JsonPropertyName("minecraft_subscription_name")] string MinecraftSubscriptionName,
	[property: JsonPropertyName("minecraft_subscription_ends")] long MinecraftSubscriptionEnds,
	[property: JsonPropertyName("minecraft_subscription_auto_renew")] long MinecraftSubscriptionAutoRenew,
	[property: JsonPropertyName("minecraft_email_reset_date")] long MinecraftEmailResetDate,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] CategoryMinecraftResponseItemsBumpSettings BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("minecraftHasPaidLicense")] bool MinecraftHasPaidLicense,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<CategoryMinecraftResponseItemsAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryMinecraftResponseItemsSeller Seller
);

	public sealed record CategoryHytaleParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		[JsonPropertyName("email_provider[]")]
		public JsonElement? EmailProvider { get; init; }
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
		[JsonPropertyName("edition[]")]
		public JsonElement? Edition { get; init; }
		[JsonPropertyName("profiles_min")]
		public long? ProfilesMin { get; init; }
		[JsonPropertyName("profiles_max")]
		public long? ProfilesMax { get; init; }
	}

	public sealed record CategoryHytaleResponse(
		[property: JsonPropertyName("items")] List<CategoryHytaleResponseItems> Items,
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

	public sealed record CategoryHytaleResponseItemsCategory(
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("category_title")] string CategoryTitle,
	[property: JsonPropertyName("category_name")] string CategoryName,
	[property: JsonPropertyName("category_url")] string CategoryUrl
);

	public sealed record CategoryHytaleResponseItemsCopyFormatData(
	[property: JsonPropertyName("title_link")] string TitleLink
);

	public sealed record CategoryHytaleResponseItemsSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] JsonElement RestorePercents
);

	public sealed record CategoryHytaleResponseItems(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("auto_bump_period")] long AutoBumpPeriod,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("discount")] bool Discount,
	[property: JsonPropertyName("hytale_item_id")] long HytaleItemId,
	[property: JsonPropertyName("hytale_profiles")] long HytaleProfiles,
	[property: JsonPropertyName("hytale_edition")] string HytaleEdition,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("max_discount_percent")] long MaxDiscountPercent,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("priceWithSellerFee")] double PriceWithSellerFee,
	[property: JsonPropertyName("category")] CategoryHytaleResponseItemsCategory Category,
	[property: JsonPropertyName("guarantee")] JsonElement Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canViewTempEmail")] bool CanViewTempEmail,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewItemViews")] bool CanViewItemViews,
	[property: JsonPropertyName("canManagePublicTag")] bool CanManagePublicTag,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("copyFormatData")] CategoryHytaleResponseItemsCopyFormatData CopyFormatData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canNotBumpItemReason")] string CanNotBumpItemReason,
	[property: JsonPropertyName("buyer")] JsonElement Buyer,
	[property: JsonPropertyName("isPersonalAccount")] bool IsPersonalAccount,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("priceWithSellerFeeLabel")] string PriceWithSellerFeeLabel,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItem")] bool CanResellItem,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("imagePreviewLinks")] List<JsonElement> ImagePreviewLinks,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("canChangeEmailPassword")] bool CanChangeEmailPassword,
	[property: JsonPropertyName("uniqueKeyExists")] bool UniqueKeyExists,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("public_tag")] JsonElement PublicTag,
	[property: JsonPropertyName("note_text")] JsonElement NoteText,
	[property: JsonPropertyName("hasPendingAutoBuy")] bool HasPendingAutoBuy,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] CategoryHytaleResponseItemsSeller Seller
);

	public sealed record CategoryListParams
	{
		[JsonPropertyName("top_queries")]
		public bool? TopQueries { get; init; }
	}

	public sealed record CategoryListResponse(
		[property: JsonPropertyName("category")] CategoryListResponseCategory Category,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CategoryListResponseCategoryLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums
);

	public sealed record CategoryListResponseCategory(
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("category_title")] string CategoryTitle,
	[property: JsonPropertyName("category_description")] string CategoryDescription,
	[property: JsonPropertyName("links")] CategoryListResponseCategoryLinks Links
);

	public sealed record CategoryParamsResponse(
		[property: JsonPropertyName("category")] CategoryParamsResponseCategory? Category,
		[property: JsonPropertyName("params")] List<CategoryParamsResponseParams>? Params,
		[property: JsonPropertyName("base_params")] CategoryParamsResponseBaseParams? BaseParams,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record CategoryParamsResponseCategory(
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("sub_category_id")] long SubCategoryId,
	[property: JsonPropertyName("category_order")] long CategoryOrder,
	[property: JsonPropertyName("category_title")] string CategoryTitle,
	[property: JsonPropertyName("category_name")] string CategoryName,
	[property: JsonPropertyName("category_url")] string CategoryUrl,
	[property: JsonPropertyName("category_description_html")] string CategoryDescriptionHtml,
	[property: JsonPropertyName("category_login_url")] string CategoryLoginUrl,
	[property: JsonPropertyName("add_item_available")] long AddItemAvailable,
	[property: JsonPropertyName("mass_upload_item_available")] long MassUploadItemAvailable,
	[property: JsonPropertyName("has_guarantee")] long HasGuarantee,
	[property: JsonPropertyName("has_account_link")] long HasAccountLink,
	[property: JsonPropertyName("require_temp_email")] long RequireTempEmail,
	[property: JsonPropertyName("recovery_link")] string RecoveryLink,
	[property: JsonPropertyName("check_button_enabled")] long CheckButtonEnabled,
	[property: JsonPropertyName("checker_enabled")] long CheckerEnabled,
	[property: JsonPropertyName("support_personal_proxy")] long SupportPersonalProxy,
	[property: JsonPropertyName("support_email_login_data")] long SupportEmailLoginData,
	[property: JsonPropertyName("require_email_login_data")] long RequireEmailLoginData,
	[property: JsonPropertyName("display_in_list")] long DisplayInList,
	[property: JsonPropertyName("category_description_html_en")] string CategoryDescriptionHtmlEn,
	[property: JsonPropertyName("category_h1_html_en")] string CategoryH1HtmlEn,
	[property: JsonPropertyName("account_price_min")] long AccountPriceMin,
	[property: JsonPropertyName("require_video_recording")] long RequireVideoRecording,
	[property: JsonPropertyName("top_queries")] string TopQueries,
	[property: JsonPropertyName("require_eld_for_native_accs")] long RequireEldForNativeAccs,
	[property: JsonPropertyName("can_be_resold")] long CanBeResold,
	[property: JsonPropertyName("support_temp_email")] long SupportTempEmail,
	[property: JsonPropertyName("cookies")] string Cookies,
	[property: JsonPropertyName("login_type")] string LoginType,
	[property: JsonPropertyName("guest_hidden")] long GuestHidden,
	[property: JsonPropertyName("available_temp_email")] long AvailableTempEmail,
	[property: JsonPropertyName("resale_duration_limit_days")] long ResaleDurationLimitDays,
	[property: JsonPropertyName("buy_without_validation")] long BuyWithoutValidation,
	[property: JsonPropertyName("max_invalid_upload_tries")] long MaxInvalidUploadTries
);

	public sealed record CategoryParamsResponseParams(
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("input")] string Input,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("values")] List<string> Values
);

	public sealed record CategoryParamsResponseBaseParams0(
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("input")] string Input,
	[property: JsonPropertyName("description")] string Description
);

	public sealed record CategoryParamsResponseBaseParams(
	[property: JsonPropertyName("0")] CategoryParamsResponseBaseParams0 _0
);

	public sealed record CategoryGamesResponse(
		[property: JsonPropertyName("games")] List<CategoryGamesResponseGames>? Games,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record CategoryGamesResponseGames(
	[property: JsonPropertyName("app_id")] string AppId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("abbr")] string Abbr,
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("img")] string Img,
	[property: JsonPropertyName("url")] string Url,
	[property: JsonPropertyName("ru")] string Ru
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
		public required long? UserId { get; init; }
		[JsonPropertyName("category_id")]
		public required CategoryId CategoryId { get; init; }
		[JsonPropertyName("discount_percent")]
		public required double? DiscountPercent { get; init; }
		[JsonPropertyName("min_price")]
		public required double? MinPrice { get; init; }
		[JsonPropertyName("max_price")]
		public double? MaxPrice { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
	}

	public sealed record CustomDiscountsCreateResponse(
		[property: JsonPropertyName("discount")] DiscountModel Discount,
		[property: JsonPropertyName("total")] long Total,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record CustomDiscountsEditBody
	{
		[JsonPropertyName("discount_id")]
		public required long? DiscountId { get; init; }
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
		public required long? DiscountId { get; init; }
	}

	public sealed record CustomDiscountsDeleteResponse(
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
		public required long? Port { get; init; }
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

// ─── ListApi Types ────────────────────────────────────────

public static class ListApiTypes
{
	public sealed record ListUserParams
	{
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("category_id")]
		public CategoryId? CategoryId { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("show")]
		public Show? Show { get; init; }
		[JsonPropertyName("delete_reason")]
		public string? DeleteReason { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("login")]
		public string? Login { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
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
		public long? UserId { get; init; }
		[JsonPropertyName("category_id")]
		public CategoryId? CategoryId { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("show")]
		public Show? Show { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("login")]
		public string? Login { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
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
		public Lolzteam.Api.Runtime.StringOrLong? UserId { get; init; }
	}

	public sealed record ListStatesResponse(
		[property: JsonPropertyName("userItemStates")] ListStatesResponseUserItemStates UserItemStates,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ListStatesResponseUserItemStatesStickied(
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("stickyLimit")] long StickyLimit
);

	public sealed record ListStatesResponseUserItemStatesDiscountRequest(
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("title")] string Title
);

	public sealed record ListStatesResponseUserItemStatesInBuyersFavorites(
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("title")] string Title
);

	public sealed record ListStatesResponseUserItemStatesActive(
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("title")] string Title
);

	public sealed record ListStatesResponseUserItemStatesPaid(
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("title")] string Title
);

	public sealed record ListStatesResponseUserItemStatesClosed(
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("title")] string Title
);

	public sealed record ListStatesResponseUserItemStatesDeleted(
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("title")] string Title
);

	public sealed record ListStatesResponseUserItemStatesAwaiting(
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("title")] string Title
);

	public sealed record ListStatesResponseUserItemStatesPreActive(
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("title")] string Title
);

	public sealed record ListStatesResponseUserItemStatesPreUpload(
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("title")] string Title
);

	public sealed record ListStatesResponseUserItemStatesPendingDeletion(
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("title")] string Title
);

	public sealed record ListStatesResponseUserItemStatesClosedInactive(
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("title")] string Title
);

	public sealed record ListStatesResponseUserItemStatesAutoBump(
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("title")] string Title
);

	public sealed record ListStatesResponseUserItemStates(
	[property: JsonPropertyName("stickied")] ListStatesResponseUserItemStatesStickied Stickied,
	[property: JsonPropertyName("discount_request")] ListStatesResponseUserItemStatesDiscountRequest DiscountRequest,
	[property: JsonPropertyName("in_buyers_favorites")] ListStatesResponseUserItemStatesInBuyersFavorites InBuyersFavorites,
	[property: JsonPropertyName("active")] ListStatesResponseUserItemStatesActive Active,
	[property: JsonPropertyName("paid")] ListStatesResponseUserItemStatesPaid Paid,
	[property: JsonPropertyName("closed")] ListStatesResponseUserItemStatesClosed Closed,
	[property: JsonPropertyName("deleted")] ListStatesResponseUserItemStatesDeleted Deleted,
	[property: JsonPropertyName("awaiting")] ListStatesResponseUserItemStatesAwaiting Awaiting,
	[property: JsonPropertyName("pre_active")] ListStatesResponseUserItemStatesPreActive PreActive,
	[property: JsonPropertyName("pre_upload")] ListStatesResponseUserItemStatesPreUpload PreUpload,
	[property: JsonPropertyName("pending_deletion")] ListStatesResponseUserItemStatesPendingDeletion PendingDeletion,
	[property: JsonPropertyName("closed_inactive")] ListStatesResponseUserItemStatesClosedInactive ClosedInactive,
	[property: JsonPropertyName("auto_bump")] ListStatesResponseUserItemStatesAutoBump AutoBump
);

	public sealed record ListDownloadParams
	{
		[JsonPropertyName("format")]
		public Format? Format { get; init; }
		[JsonPropertyName("custom_format")]
		public string? CustomFormat { get; init; }
		[JsonPropertyName("category_id")]
		public CategoryId? CategoryId { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("show")]
		public Show? Show { get; init; }
		[JsonPropertyName("delete_reason")]
		public string? DeleteReason { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
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

	public sealed record ListDownloadResponse(string Data);

	public sealed record ListFavoritesParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("show")]
		public Show? Show { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
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
		public long? Page { get; init; }
		[JsonPropertyName("show")]
		public Show? Show { get; init; }
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("origin[]")]
		public JsonElement? Origin { get; init; }
		[JsonPropertyName("not_origin[]")]
		public JsonElement? NotOrigin { get; init; }
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
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
		public required long? ItemId { get; init; }
		[JsonPropertyName("post_body")]
		public required string PostBody { get; init; }
	}

	public sealed record ManagingCreateClaimResponse(
		[property: JsonPropertyName("thread")] ManagingCreateClaimResponseThread Thread,
		[property: JsonPropertyName("system_info")] ManagingCreateClaimResponseSystemInfo SystemInfo
	);

	public sealed record ManagingCreateClaimResponseThreadFirstPostLikeUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("display_style_group_id")] long? DisplayStyleGroupId,
	[property: JsonPropertyName("is_banned")] long? IsBanned,
	[property: JsonPropertyName("uniq_username_css")] string? UniqUsernameCss
);

	public sealed record ManagingCreateClaimResponseThreadFirstPostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("attachments")] string Attachments,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
);

	public sealed record ManagingCreateClaimResponseThreadFirstPostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment
);

	public sealed record ManagingCreateClaimResponseThreadFirstPost(
	[property: JsonPropertyName("post_id")] long PostId,
	[property: JsonPropertyName("thread_id")] long ThreadId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("post_create_date")] long PostCreateDate,
	[property: JsonPropertyName("post_body")] string PostBody,
	[property: JsonPropertyName("post_body_html")] string PostBodyHtml,
	[property: JsonPropertyName("post_body_plain_text")] string PostBodyPlainText,
	[property: JsonPropertyName("signature")] string Signature,
	[property: JsonPropertyName("signature_html")] string SignatureHtml,
	[property: JsonPropertyName("signature_plain_text")] string SignaturePlainText,
	[property: JsonPropertyName("post_like_count")] long PostLikeCount,
	[property: JsonPropertyName("post_attachment_count")] long PostAttachmentCount,
	[property: JsonPropertyName("like_users")] List<ManagingCreateClaimResponseThreadFirstPostLikeUsers> LikeUsers,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("links")] ManagingCreateClaimResponseThreadFirstPostLinks Links,
	[property: JsonPropertyName("permissions")] ManagingCreateClaimResponseThreadFirstPostPermissions Permissions
);

	public sealed record ManagingCreateClaimResponseThreadLinks(
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

	public sealed record ManagingCreateClaimResponseThreadPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("edit")] bool Edit
);

	public sealed record ManagingCreateClaimResponseThreadForumForumPrefixesGroupPrefixes(
	[property: JsonPropertyName("prefix_id")] long PrefixId,
	[property: JsonPropertyName("prefix_title")] string PrefixTitle
);

	public sealed record ManagingCreateClaimResponseThreadForumForumPrefixes(
	[property: JsonPropertyName("group_title")] string GroupTitle,
	[property: JsonPropertyName("group_prefixes")] List<ManagingCreateClaimResponseThreadForumForumPrefixesGroupPrefixes> GroupPrefixes
);

	public sealed record ManagingCreateClaimResponseThreadForumLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
);

	public sealed record ManagingCreateClaimResponseThreadForumPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
);

	public sealed record ManagingCreateClaimResponseThreadForum(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<ManagingCreateClaimResponseThreadForumForumPrefixes> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] ManagingCreateClaimResponseThreadForumLinks Links,
	[property: JsonPropertyName("permissions")] ManagingCreateClaimResponseThreadForumPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
);

	public sealed record ManagingCreateClaimResponseThread(
	[property: JsonPropertyName("thread_id")] long ThreadId,
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("thread_title")] string ThreadTitle,
	[property: JsonPropertyName("thread_view_count")] long ThreadViewCount,
	[property: JsonPropertyName("creator_user_id")] long CreatorUserId,
	[property: JsonPropertyName("creator_username")] string CreatorUsername,
	[property: JsonPropertyName("thread_create_date")] long ThreadCreateDate,
	[property: JsonPropertyName("thread_update_date")] long ThreadUpdateDate,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("thread_post_count")] long ThreadPostCount,
	[property: JsonPropertyName("thread_is_published")] bool ThreadIsPublished,
	[property: JsonPropertyName("thread_is_deleted")] bool ThreadIsDeleted,
	[property: JsonPropertyName("thread_is_sticky")] bool ThreadIsSticky,
	[property: JsonPropertyName("thread_is_followed")] bool ThreadIsFollowed,
	[property: JsonPropertyName("first_post")] ManagingCreateClaimResponseThreadFirstPost FirstPost,
	[property: JsonPropertyName("thread_prefixes")] List<JsonElement> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] List<JsonElement> ThreadTags,
	[property: JsonPropertyName("links")] ManagingCreateClaimResponseThreadLinks Links,
	[property: JsonPropertyName("permissions")] ManagingCreateClaimResponseThreadPermissions Permissions,
	[property: JsonPropertyName("forum")] ManagingCreateClaimResponseThreadForum Forum
);

	public sealed record ManagingCreateClaimResponseSystemInfo(
	[property: JsonPropertyName("visitor_id")] long VisitorId,
	[property: JsonPropertyName("time")] long Time
);

	public sealed record ManagingBulkGetBody
	{
		[JsonPropertyName("item_id")]
		public List<long?>? ItemId { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
	}

	public sealed record ManagingBulkGetResponse(
		[property: JsonPropertyName("items")] List<ManagingBulkGetResponseItems> Items,
		[property: JsonPropertyName("left_item_id")] List<long> LeftItemId,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingBulkGetResponseItems(
	[property: JsonPropertyName("0")] ItemModel? _0
);

	public sealed record ManagingSteamInventoryValueParams
	{
		[JsonPropertyName("app_id")]
		public AppId? AppId { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("ignore_cache")]
		public bool? IgnoreCache { get; init; }
	}

	public sealed record ManagingSteamInventoryValueResponse(
		[property: JsonPropertyName("query")] string? Query,
		[property: JsonPropertyName("data")] ManagingSteamInventoryValueResponseData? Data,
		[property: JsonPropertyName("appId")] long? AppId,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ManagingSteamInventoryValueResponseDataItems0Stickers(
	[property: JsonPropertyName("stickerCount")] long StickerCount,
	[property: JsonPropertyName("count")] long Count,
	[property: JsonPropertyName("images")] List<string> Images,
	[property: JsonPropertyName("title")] string Title
);

	public sealed record ManagingSteamInventoryValueResponseDataItems0(
	[property: JsonPropertyName("classid")] string Classid,
	[property: JsonPropertyName("tradable")] long Tradable,
	[property: JsonPropertyName("marketable")] long Marketable,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("price")] double Price,
	[property: JsonPropertyName("count")] long Count,
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("market_hash_name")] string MarketHashName,
	[property: JsonPropertyName("fraudwarnings")] JsonElement Fraudwarnings,
	[property: JsonPropertyName("stickers")] ManagingSteamInventoryValueResponseDataItems0Stickers Stickers
);

	public sealed record ManagingSteamInventoryValueResponseDataItems(
	[property: JsonPropertyName("0")] ManagingSteamInventoryValueResponseDataItems0? _0
);

	public sealed record ManagingSteamInventoryValueResponseData(
	[property: JsonPropertyName("items")] ManagingSteamInventoryValueResponseDataItems Items,
	[property: JsonPropertyName("steam_id")] string SteamId,
	[property: JsonPropertyName("appId")] long AppId,
	[property: JsonPropertyName("appTitle")] string AppTitle,
	[property: JsonPropertyName("totalValue")] double TotalValue,
	[property: JsonPropertyName("itemCount")] long ItemCount,
	[property: JsonPropertyName("marketableItemCount")] long MarketableItemCount,
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("currencyIcon")] string CurrencyIcon,
	[property: JsonPropertyName("language")] string Language,
	[property: JsonPropertyName("time")] long Time
);

	public sealed record ManagingSteamValueParams
	{
		[JsonPropertyName("link")]
		public string? Link { get; init; }
		[JsonPropertyName("app_id")]
		public AppId? AppId { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("ignore_cache")]
		public bool? IgnoreCache { get; init; }
	}

	public sealed record ManagingSteamValueResponse(
		[property: JsonPropertyName("query")] string? Query,
		[property: JsonPropertyName("data")] ManagingSteamValueResponseData? Data,
		[property: JsonPropertyName("appId")] long? AppId,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	);

	public sealed record ManagingSteamValueResponseDataItems0Stickers(
	[property: JsonPropertyName("stickerCount")] long StickerCount,
	[property: JsonPropertyName("count")] long Count,
	[property: JsonPropertyName("images")] List<string> Images,
	[property: JsonPropertyName("title")] string Title
);

	public sealed record ManagingSteamValueResponseDataItems0(
	[property: JsonPropertyName("classid")] string Classid,
	[property: JsonPropertyName("tradable")] long Tradable,
	[property: JsonPropertyName("marketable")] long Marketable,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("price")] double Price,
	[property: JsonPropertyName("count")] long Count,
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("market_hash_name")] string MarketHashName,
	[property: JsonPropertyName("fraudwarnings")] JsonElement Fraudwarnings,
	[property: JsonPropertyName("stickers")] ManagingSteamValueResponseDataItems0Stickers Stickers
);

	public sealed record ManagingSteamValueResponseDataItems(
	[property: JsonPropertyName("0")] ManagingSteamValueResponseDataItems0? _0
);

	public sealed record ManagingSteamValueResponseData(
	[property: JsonPropertyName("items")] ManagingSteamValueResponseDataItems Items,
	[property: JsonPropertyName("steam_id")] string SteamId,
	[property: JsonPropertyName("appId")] long AppId,
	[property: JsonPropertyName("appTitle")] string AppTitle,
	[property: JsonPropertyName("totalValue")] double TotalValue,
	[property: JsonPropertyName("itemCount")] long ItemCount,
	[property: JsonPropertyName("marketableItemCount")] long MarketableItemCount,
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("currencyIcon")] string CurrencyIcon,
	[property: JsonPropertyName("language")] string Language,
	[property: JsonPropertyName("time")] long Time
);

	public sealed record ManagingSteamPreviewParams
	{
		[JsonPropertyName("type")]
		public ManagingType? Type { get; init; }
	}

	public sealed record ManagingSteamPreviewResponse(string Data);

	public sealed record ManagingEditBody
	{
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("title_en")]
		public string? TitleEn { get; init; }
		[JsonPropertyName("price")]
		public long? Price { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("item_origin")]
		public ManagingItemOrigin? ItemOrigin { get; init; }
		[JsonPropertyName("email_login_data")]
		public string? EmailLoginData { get; init; }
		[JsonPropertyName("email_type")]
		public EmailType? EmailType { get; init; }
		[JsonPropertyName("allow_ask_discount")]
		public bool? AllowAskDiscount { get; init; }
		[JsonPropertyName("proxy_id")]
		public long? ProxyId { get; init; }
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
		public AppId? AppId { get; init; }
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
		public required long? Hour { get; init; }
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
		public ManagingType? Type { get; init; }
	}

	public sealed record ManagingImageResponse(
		[property: JsonPropertyName("base64")] string Base64,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingEmailCodeResponse(
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("codeData")] ManagingEmailCodeResponseCodeData CodeData
	);

	public sealed record ManagingEmailCodeResponseCodeData(
	[property: JsonPropertyName("code")] string Code,
	[property: JsonPropertyName("date")] long Date,
	[property: JsonPropertyName("textPlain")] string TextPlain
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
		public long? Limit { get; init; }
	}

	public sealed record ManagingGetLetters2Response(
		[property: JsonPropertyName("email")] string Email,
		[property: JsonPropertyName("letters")] List<ManagingGetLetters2ResponseLetters> Letters,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingGetLetters2ResponseLetters(
	[property: JsonPropertyName("textHtml")] string TextHtml,
	[property: JsonPropertyName("textPlain")] string TextPlain,
	[property: JsonPropertyName("from")] string From,
	[property: JsonPropertyName("date")] long Date
);

	public sealed record ManagingSteamGetMafileResponse(
		[property: JsonPropertyName("maFile")] ManagingSteamGetMafileResponseMaFile MaFile,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingSteamGetMafileResponseMaFileSession(
	[property: JsonPropertyName("SessionID")] string SessionID,
	[property: JsonPropertyName("AccessToken")] string AccessToken,
	[property: JsonPropertyName("RefreshToken")] string RefreshToken,
	[property: JsonPropertyName("SteamID")] string SteamID,
	[property: JsonPropertyName("SteamLoginSecure")] string SteamLoginSecure
);

	public sealed record ManagingSteamGetMafileResponseMaFile(
	[property: JsonPropertyName("shared_secret")] string SharedSecret,
	[property: JsonPropertyName("serial_number")] long SerialNumber,
	[property: JsonPropertyName("revocation_code")] string RevocationCode,
	[property: JsonPropertyName("uri")] string Uri,
	[property: JsonPropertyName("account_name")] string AccountName,
	[property: JsonPropertyName("token_gid")] string TokenGid,
	[property: JsonPropertyName("identity_secret")] string IdentitySecret,
	[property: JsonPropertyName("secret_1")] string Secret_1,
	[property: JsonPropertyName("device_id")] string DeviceId,
	[property: JsonPropertyName("fully_enrolled")] bool FullyEnrolled,
	[property: JsonPropertyName("Session")] ManagingSteamGetMafileResponseMaFileSession Session
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
		[property: JsonPropertyName("codeData")] ManagingSteamMafileCodeResponseCodeData CodeData
	);

	public sealed record ManagingSteamMafileCodeResponseCodeData(
	[property: JsonPropertyName("code")] string Code,
	[property: JsonPropertyName("date")] long Date,
	[property: JsonPropertyName("textPlain")] string TextPlain
);

	public sealed record ManagingSteamSDABody
	{
		[JsonPropertyName("id")]
		public long? Id { get; init; }
		[JsonPropertyName("nonce")]
		public long? Nonce { get; init; }
	}

	public sealed record ManagingSteamSDAResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingTelegramCodeResponse(
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("codes")] ManagingTelegramCodeResponseCodes Codes
	);

	public sealed record ManagingTelegramCodeResponseCodes(
	[property: JsonPropertyName("code")] string? Code,
	[property: JsonPropertyName("date")] long? Date
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
		public Cancel? Cancel { get; init; }
	}

	public sealed record ManagingChangePasswordResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("new_password")] string NewPassword
	);

	public sealed record ManagingTempEmailPasswordResponse(
		[property: JsonPropertyName("item")] ManagingTempEmailPasswordResponseItem Item
	);

	public sealed record ManagingTempEmailPasswordResponseItem(
	[property: JsonPropertyName("account")] string Account
);

	public sealed record ManagingTagBody
	{
		[JsonPropertyName("tag_id")]
		public required long? TagId { get; init; }
	}

	public sealed record ManagingTagResponse(
		[property: JsonPropertyName("itemId")] long ItemId,
		[property: JsonPropertyName("tag")] ManagingTagResponseTag Tag,
		[property: JsonPropertyName("addedTagId")] long AddedTagId,
		[property: JsonPropertyName("deleteTags")] List<long> DeleteTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingTagResponseTag(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
);

	public sealed record ManagingUntagBody
	{
		[JsonPropertyName("tag_id")]
		public required long? TagId { get; init; }
	}

	public sealed record ManagingUntagResponse(
		[property: JsonPropertyName("itemId")] long ItemId,
		[property: JsonPropertyName("tag")] ManagingUntagResponseTag Tag,
		[property: JsonPropertyName("addedTagId")] long AddedTagId,
		[property: JsonPropertyName("deleteTags")] List<long> DeleteTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingUntagResponseTag(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
);

	public sealed record ManagingPublicTagBody
	{
		[JsonPropertyName("tag_id")]
		public required long? TagId { get; init; }
	}

	public sealed record ManagingPublicTagResponse(
		[property: JsonPropertyName("itemId")] long ItemId,
		[property: JsonPropertyName("tag")] ManagingPublicTagResponseTag Tag,
		[property: JsonPropertyName("addedTagId")] long AddedTagId,
		[property: JsonPropertyName("deleteTags")] List<long> DeleteTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingPublicTagResponseTag(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
);

	public sealed record ManagingPublicUntagBody
	{
		[JsonPropertyName("tag_id")]
		public required long? TagId { get; init; }
	}

	public sealed record ManagingPublicUntagResponse(
		[property: JsonPropertyName("itemId")] long ItemId,
		[property: JsonPropertyName("tag")] ManagingPublicUntagResponseTag Tag,
		[property: JsonPropertyName("addedTagId")] long AddedTagId,
		[property: JsonPropertyName("deleteTags")] List<long> DeleteTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ManagingPublicUntagResponseTag(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
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

// ─── PaymentsApi Types ────────────────────────────────────────

public static class PaymentsApiTypes
{
	public sealed record PaymentsInvoiceGetParams
	{
		[JsonPropertyName("invoice_id")]
		public long? InvoiceId { get; init; }
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
		public required Currency Currency { get; init; }
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
		public required long? MerchantId { get; init; }
		[JsonPropertyName("required_telegram_id")]
		public long? RequiredTelegramId { get; init; }
		[JsonPropertyName("required_telegram_username")]
		public string? RequiredTelegramUsername { get; init; }
		/// <summary>Default: 3600</summary>
		[JsonPropertyName("lifetime")]
		public double? Lifetime { get; init; } = 3600;
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
		public long? Page { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("status")]
		public Status? Status { get; init; }
		[JsonPropertyName("amount")]
		public double? Amount { get; init; }
		[JsonPropertyName("merchant_id")]
		public long? MerchantId { get; init; }
	}

	public sealed record PaymentsInvoiceListResponse(
		[property: JsonPropertyName("invoices")] List<InvoiceModel> Invoices,
		[property: JsonPropertyName("count")] long Count,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsCurrencyResponse(
		[property: JsonPropertyName("currencyList")] PaymentsCurrencyResponseCurrencyList CurrencyList,
		[property: JsonPropertyName("lastUpdate")] long LastUpdate,
		[property: JsonPropertyName("visitorCurrency")] string VisitorCurrency,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsCurrencyResponseCurrencyListBTC(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListETH(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListBNB(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListBCH(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListXMR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListSOL(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListLTC(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListDASH(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListTON(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListUSDT(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListMATIC(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListTRX(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListDOGE(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListKWD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListGBP(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListCHF(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListEUR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListUSD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListSGD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListCAD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListAUD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListNZD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListBGN(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListGEL(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListILS(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListQAR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListPEN(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListAED(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListSAR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListPLN(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListMYR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListRON(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListBRL(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListDKK(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListCNY(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListHKD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListSEK(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListNOK(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListZAR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListMXN(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListCZK(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListTWD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListTHB(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListTRY(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListUAH(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListUYU(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListPHP(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListINR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListRUB(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] long Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListRSD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListJPY(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListHUF(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListKZT(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListCRC(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListCLP(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListARS(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListKRW(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListCOP(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListIDR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyListVND(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
);

	public sealed record PaymentsCurrencyResponseCurrencyList(
	[property: JsonPropertyName("BTC")] PaymentsCurrencyResponseCurrencyListBTC BTC,
	[property: JsonPropertyName("ETH")] PaymentsCurrencyResponseCurrencyListETH ETH,
	[property: JsonPropertyName("BNB")] PaymentsCurrencyResponseCurrencyListBNB BNB,
	[property: JsonPropertyName("BCH")] PaymentsCurrencyResponseCurrencyListBCH BCH,
	[property: JsonPropertyName("XMR")] PaymentsCurrencyResponseCurrencyListXMR XMR,
	[property: JsonPropertyName("SOL")] PaymentsCurrencyResponseCurrencyListSOL SOL,
	[property: JsonPropertyName("LTC")] PaymentsCurrencyResponseCurrencyListLTC LTC,
	[property: JsonPropertyName("DASH")] PaymentsCurrencyResponseCurrencyListDASH DASH,
	[property: JsonPropertyName("TON")] PaymentsCurrencyResponseCurrencyListTON TON,
	[property: JsonPropertyName("USDT")] PaymentsCurrencyResponseCurrencyListUSDT USDT,
	[property: JsonPropertyName("MATIC")] PaymentsCurrencyResponseCurrencyListMATIC MATIC,
	[property: JsonPropertyName("TRX")] PaymentsCurrencyResponseCurrencyListTRX TRX,
	[property: JsonPropertyName("DOGE")] PaymentsCurrencyResponseCurrencyListDOGE DOGE,
	[property: JsonPropertyName("KWD")] PaymentsCurrencyResponseCurrencyListKWD KWD,
	[property: JsonPropertyName("GBP")] PaymentsCurrencyResponseCurrencyListGBP GBP,
	[property: JsonPropertyName("CHF")] PaymentsCurrencyResponseCurrencyListCHF CHF,
	[property: JsonPropertyName("EUR")] PaymentsCurrencyResponseCurrencyListEUR EUR,
	[property: JsonPropertyName("USD")] PaymentsCurrencyResponseCurrencyListUSD USD,
	[property: JsonPropertyName("SGD")] PaymentsCurrencyResponseCurrencyListSGD SGD,
	[property: JsonPropertyName("CAD")] PaymentsCurrencyResponseCurrencyListCAD CAD,
	[property: JsonPropertyName("AUD")] PaymentsCurrencyResponseCurrencyListAUD AUD,
	[property: JsonPropertyName("NZD")] PaymentsCurrencyResponseCurrencyListNZD NZD,
	[property: JsonPropertyName("BGN")] PaymentsCurrencyResponseCurrencyListBGN BGN,
	[property: JsonPropertyName("GEL")] PaymentsCurrencyResponseCurrencyListGEL GEL,
	[property: JsonPropertyName("ILS")] PaymentsCurrencyResponseCurrencyListILS ILS,
	[property: JsonPropertyName("QAR")] PaymentsCurrencyResponseCurrencyListQAR QAR,
	[property: JsonPropertyName("PEN")] PaymentsCurrencyResponseCurrencyListPEN PEN,
	[property: JsonPropertyName("AED")] PaymentsCurrencyResponseCurrencyListAED AED,
	[property: JsonPropertyName("SAR")] PaymentsCurrencyResponseCurrencyListSAR SAR,
	[property: JsonPropertyName("PLN")] PaymentsCurrencyResponseCurrencyListPLN PLN,
	[property: JsonPropertyName("MYR")] PaymentsCurrencyResponseCurrencyListMYR MYR,
	[property: JsonPropertyName("RON")] PaymentsCurrencyResponseCurrencyListRON RON,
	[property: JsonPropertyName("BRL")] PaymentsCurrencyResponseCurrencyListBRL BRL,
	[property: JsonPropertyName("DKK")] PaymentsCurrencyResponseCurrencyListDKK DKK,
	[property: JsonPropertyName("CNY")] PaymentsCurrencyResponseCurrencyListCNY CNY,
	[property: JsonPropertyName("HKD")] PaymentsCurrencyResponseCurrencyListHKD HKD,
	[property: JsonPropertyName("SEK")] PaymentsCurrencyResponseCurrencyListSEK SEK,
	[property: JsonPropertyName("NOK")] PaymentsCurrencyResponseCurrencyListNOK NOK,
	[property: JsonPropertyName("ZAR")] PaymentsCurrencyResponseCurrencyListZAR ZAR,
	[property: JsonPropertyName("MXN")] PaymentsCurrencyResponseCurrencyListMXN MXN,
	[property: JsonPropertyName("CZK")] PaymentsCurrencyResponseCurrencyListCZK CZK,
	[property: JsonPropertyName("TWD")] PaymentsCurrencyResponseCurrencyListTWD TWD,
	[property: JsonPropertyName("THB")] PaymentsCurrencyResponseCurrencyListTHB THB,
	[property: JsonPropertyName("TRY")] PaymentsCurrencyResponseCurrencyListTRY TRY,
	[property: JsonPropertyName("UAH")] PaymentsCurrencyResponseCurrencyListUAH UAH,
	[property: JsonPropertyName("UYU")] PaymentsCurrencyResponseCurrencyListUYU UYU,
	[property: JsonPropertyName("PHP")] PaymentsCurrencyResponseCurrencyListPHP PHP,
	[property: JsonPropertyName("INR")] PaymentsCurrencyResponseCurrencyListINR INR,
	[property: JsonPropertyName("RUB")] PaymentsCurrencyResponseCurrencyListRUB RUB,
	[property: JsonPropertyName("RSD")] PaymentsCurrencyResponseCurrencyListRSD RSD,
	[property: JsonPropertyName("JPY")] PaymentsCurrencyResponseCurrencyListJPY JPY,
	[property: JsonPropertyName("HUF")] PaymentsCurrencyResponseCurrencyListHUF HUF,
	[property: JsonPropertyName("KZT")] PaymentsCurrencyResponseCurrencyListKZT KZT,
	[property: JsonPropertyName("CRC")] PaymentsCurrencyResponseCurrencyListCRC CRC,
	[property: JsonPropertyName("CLP")] PaymentsCurrencyResponseCurrencyListCLP CLP,
	[property: JsonPropertyName("ARS")] PaymentsCurrencyResponseCurrencyListARS ARS,
	[property: JsonPropertyName("KRW")] PaymentsCurrencyResponseCurrencyListKRW KRW,
	[property: JsonPropertyName("COP")] PaymentsCurrencyResponseCurrencyListCOP COP,
	[property: JsonPropertyName("IDR")] PaymentsCurrencyResponseCurrencyListIDR IDR,
	[property: JsonPropertyName("VND")] PaymentsCurrencyResponseCurrencyListVND VND
);

	public sealed record PaymentsBalanceListResponse(
		[property: JsonPropertyName("from")] PaymentsBalanceListResponseFrom From,
		[property: JsonPropertyName("to")] PaymentsBalanceListResponseTo To,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsBalanceListResponseFromBalance(
	[property: JsonPropertyName("balance")] string Balance,
	[property: JsonPropertyName("convertedBalance")] long ConvertedBalance,
	[property: JsonPropertyName("fullTitle")] string FullTitle,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("type")] string Type
);

	public sealed record PaymentsBalanceListResponseFrom(
	[property: JsonPropertyName("balance")] PaymentsBalanceListResponseFromBalance Balance,
	[property: JsonPropertyName("12345")] BalanceModel _12345
);

	public sealed record PaymentsBalanceListResponseTo(
	[property: JsonPropertyName("balance")] UserModel Balance
);

	public sealed record PaymentsBalanceExchangeBody
	{
		[JsonPropertyName("from_balance")]
		public required string FromBalance { get; init; }
		[JsonPropertyName("to_balance")]
		public required string ToBalance { get; init; }
		[JsonPropertyName("amount")]
		public required long? Amount { get; init; }
	}

	public sealed record PaymentsBalanceExchangeResponse(
		[property: JsonPropertyName("from")] PaymentsBalanceExchangeResponseFrom From,
		[property: JsonPropertyName("to")] PaymentsBalanceExchangeResponseTo To,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsBalanceExchangeResponseFromBalance(
	[property: JsonPropertyName("balance")] string Balance,
	[property: JsonPropertyName("convertedBalance")] long ConvertedBalance,
	[property: JsonPropertyName("fullTitle")] string FullTitle,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("type")] string Type
);

	public sealed record PaymentsBalanceExchangeResponseFrom(
	[property: JsonPropertyName("balance")] PaymentsBalanceExchangeResponseFromBalance Balance,
	[property: JsonPropertyName("12345")] BalanceModel _12345
);

	public sealed record PaymentsBalanceExchangeResponseTo(
	[property: JsonPropertyName("balance")] UserModel Balance
);

	public sealed record PaymentsTransferBody
	{
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("username")]
		public string? Username { get; init; }
		[JsonPropertyName("amount")]
		public required long? Amount { get; init; }
		[JsonPropertyName("currency")]
		public required Currency Currency { get; init; }
		[JsonPropertyName("comment")]
		public string? Comment { get; init; }
		[JsonPropertyName("telegram_deal")]
		public bool? TelegramDeal { get; init; }
		[JsonPropertyName("telegram_username")]
		public string? TelegramUsername { get; init; }
		[JsonPropertyName("transfer_hold")]
		public bool? TransferHold { get; init; }
		[JsonPropertyName("hold_length_value")]
		public long? HoldLengthValue { get; init; }
		[JsonPropertyName("hold_length_option")]
		public HoldLengthOption? HoldLengthOption { get; init; }
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
		[property: JsonPropertyName("calculator")] PaymentsFeeResponseCalculator Calculator,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsFeeResponseCalculator(
	[property: JsonPropertyName("inputAmount")] long InputAmount,
	[property: JsonPropertyName("commissionAmount")] long CommissionAmount,
	[property: JsonPropertyName("totalOutputAmount")] long TotalOutputAmount
);

	public sealed record PaymentsCancelBody
	{
		[JsonPropertyName("payment_id")]
		public required long? PaymentId { get; init; }
	}

	public sealed record PaymentsCancelResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsHistoryParams
	{
		[JsonPropertyName("type")]
		public PaymentsType? Type { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("operation_id_lt")]
		public long? OperationIdLt { get; init; }
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
		[property: JsonPropertyName("payments")] PaymentsHistoryResponsePayments Payments,
		[property: JsonPropertyName("perPage")] string PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("pageNavLink")] string PageNavLink,
		[property: JsonPropertyName("pageNavParams")] PaymentsHistoryResponsePageNavParams PageNavParams,
		[property: JsonPropertyName("periodLabel")] string PeriodLabel,
		[property: JsonPropertyName("periodLabelPhrase")] string PeriodLabelPhrase,
		[property: JsonPropertyName("filterDatesDefault")] bool FilterDatesDefault,
		[property: JsonPropertyName("input")] PaymentsHistoryResponseInput Input,
		[property: JsonPropertyName("paymentStats")] JsonElement PaymentStats,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("lastOperationId")] long LastOperationId,
		[property: JsonPropertyName("nextPageHref")] string NextPageHref,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsHistoryResponsePayments1234567890Data(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("comment")] string Comment,
	[property: JsonPropertyName("fee")] long Fee,
	[property: JsonPropertyName("invoice_id")] long InvoiceId,
	[property: JsonPropertyName("is_test")] bool IsTest,
	[property: JsonPropertyName("payment_id")] string PaymentId,
	[property: JsonPropertyName("commentPlain")] string CommentPlain,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss,
	[property: JsonPropertyName("uniq_banner")] string UniqBanner,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("user_group_id")] long UserGroupId,
	[property: JsonPropertyName("username_html")] string UsernameHtml,
	[property: JsonPropertyName("avatar")] string Avatar
);

	public sealed record PaymentsHistoryResponsePayments1234567890Label(
	[property: JsonPropertyName("title")] string Title
);

	public sealed record PaymentsHistoryResponsePayments1234567890Merchant(
	[property: JsonPropertyName("merchant_id")] long MerchantId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("created_date")] long CreatedDate,
	[property: JsonPropertyName("secret_key")] string SecretKey,
	[property: JsonPropertyName("avatar_data")] string AvatarData,
	[property: JsonPropertyName("url")] string Url
);

	public sealed record PaymentsHistoryResponsePayments1234567890User(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("user_balance")] string UserBalance,
	[property: JsonPropertyName("user_hold")] string UserHold,
	[property: JsonPropertyName("user_balance_with_hold")] double UserBalanceWithHold
);

	public sealed record PaymentsHistoryResponsePayments1234567890(
	[property: JsonPropertyName("operation_id")] long OperationId,
	[property: JsonPropertyName("operation_date")] long OperationDate,
	[property: JsonPropertyName("operation_type")] string OperationType,
	[property: JsonPropertyName("outgoing_sum")] string OutgoingSum,
	[property: JsonPropertyName("incoming_sum")] string IncomingSum,
	[property: JsonPropertyName("item_id")] long ItemId,
	[property: JsonPropertyName("wallet")] string Wallet,
	[property: JsonPropertyName("is_finished")] long IsFinished,
	[property: JsonPropertyName("is_hold")] long IsHold,
	[property: JsonPropertyName("payment_system")] string PaymentSystem,
	[property: JsonPropertyName("data")] PaymentsHistoryResponsePayments1234567890Data Data,
	[property: JsonPropertyName("hold_end_date")] long HoldEndDate,
	[property: JsonPropertyName("operation_end_date")] long OperationEndDate,
	[property: JsonPropertyName("api")] long Api,
	[property: JsonPropertyName("sum")] string Sum,
	[property: JsonPropertyName("payment_status")] string PaymentStatus,
	[property: JsonPropertyName("supportLink")] JsonElement SupportLink,
	[property: JsonPropertyName("paymentSystemIcons")] List<JsonElement> PaymentSystemIcons,
	[property: JsonPropertyName("canCancelPaidMailPayment")] bool CanCancelPaidMailPayment,
	[property: JsonPropertyName("canCancelBalanceTransfer")] bool CanCancelBalanceTransfer,
	[property: JsonPropertyName("canCancelBalancePayout")] bool CanCancelBalancePayout,
	[property: JsonPropertyName("canCancelBalanceHold")] bool CanCancelBalanceHold,
	[property: JsonPropertyName("canFinishBalanceTransfer")] bool CanFinishBalanceTransfer,
	[property: JsonPropertyName("canFinishBalancePayout")] bool CanFinishBalancePayout,
	[property: JsonPropertyName("canFinishBalanceHold")] bool CanFinishBalanceHold,
	[property: JsonPropertyName("label")] PaymentsHistoryResponsePayments1234567890Label Label,
	[property: JsonPropertyName("merchant")] PaymentsHistoryResponsePayments1234567890Merchant Merchant,
	[property: JsonPropertyName("user")] PaymentsHistoryResponsePayments1234567890User User
);

	public sealed record PaymentsHistoryResponsePayments(
	[property: JsonPropertyName("1234567890")] PaymentsHistoryResponsePayments1234567890 _1234567890
);

	public sealed record PaymentsHistoryResponsePageNavParams(
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("startDate")] string StartDate,
	[property: JsonPropertyName("endDate")] string EndDate
);

	public sealed record PaymentsHistoryResponseInput(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("startDate")] string StartDate,
	[property: JsonPropertyName("endDate")] string EndDate,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("period_label")] string PeriodLabel,
	[property: JsonPropertyName("receiver")] string Receiver,
	[property: JsonPropertyName("sender")] string Sender,
	[property: JsonPropertyName("comment")] string Comment,
	[property: JsonPropertyName("pmin")] string Pmin,
	[property: JsonPropertyName("pmax")] string Pmax,
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("wallet")] string Wallet,
	[property: JsonPropertyName("is_hold")] bool IsHold,
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("operation_id_lt")] long OperationIdLt
);

	public sealed record PaymentsPayoutServicesResponse(
		[property: JsonPropertyName("systems")] List<PaymentsPayoutServicesResponseSystems> Systems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PaymentsPayoutServicesResponseSystemsProvidersBEP20(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
);

	public sealed record PaymentsPayoutServicesResponseSystemsProvidersTRC20(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
);

	public sealed record PaymentsPayoutServicesResponseSystemsProvidersERC20(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
);

	public sealed record PaymentsPayoutServicesResponseSystemsProvidersTRX(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
);

	public sealed record PaymentsPayoutServicesResponseSystemsProvidersBTC(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
);

	public sealed record PaymentsPayoutServicesResponseSystemsProvidersTON(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
);

	public sealed record PaymentsPayoutServicesResponseSystemsProvidersETH(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
);

	public sealed record PaymentsPayoutServicesResponseSystemsProvidersLTC(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
);

	public sealed record PaymentsPayoutServicesResponseSystemsProvidersBNB(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
);

	public sealed record PaymentsPayoutServicesResponseSystemsProvidersDASH(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
);

	public sealed record PaymentsPayoutServicesResponseSystemsProvidersDOGE(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
);

	public sealed record PaymentsPayoutServicesResponseSystemsProvidersXMR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
);

	public sealed record PaymentsPayoutServicesResponseSystemsProvidersSOL(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
);

	public sealed record PaymentsPayoutServicesResponseSystemsProvidersBCH(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
);

	public sealed record PaymentsPayoutServicesResponseSystemsProviders(
	[property: JsonPropertyName("BEP20")] PaymentsPayoutServicesResponseSystemsProvidersBEP20 BEP20,
	[property: JsonPropertyName("TRC20")] PaymentsPayoutServicesResponseSystemsProvidersTRC20 TRC20,
	[property: JsonPropertyName("ERC20")] PaymentsPayoutServicesResponseSystemsProvidersERC20 ERC20,
	[property: JsonPropertyName("TRX")] PaymentsPayoutServicesResponseSystemsProvidersTRX TRX,
	[property: JsonPropertyName("BTC")] PaymentsPayoutServicesResponseSystemsProvidersBTC BTC,
	[property: JsonPropertyName("TON")] PaymentsPayoutServicesResponseSystemsProvidersTON TON,
	[property: JsonPropertyName("ETH")] PaymentsPayoutServicesResponseSystemsProvidersETH ETH,
	[property: JsonPropertyName("LTC")] PaymentsPayoutServicesResponseSystemsProvidersLTC LTC,
	[property: JsonPropertyName("BNB")] PaymentsPayoutServicesResponseSystemsProvidersBNB BNB,
	[property: JsonPropertyName("DASH")] PaymentsPayoutServicesResponseSystemsProvidersDASH DASH,
	[property: JsonPropertyName("DOGE")] PaymentsPayoutServicesResponseSystemsProvidersDOGE DOGE,
	[property: JsonPropertyName("XMR")] PaymentsPayoutServicesResponseSystemsProvidersXMR XMR,
	[property: JsonPropertyName("SOL")] PaymentsPayoutServicesResponseSystemsProvidersSOL SOL,
	[property: JsonPropertyName("BCH")] PaymentsPayoutServicesResponseSystemsProvidersBCH BCH
);

	public sealed record PaymentsPayoutServicesResponseSystems(
	[property: JsonPropertyName("system")] string System,
	[property: JsonPropertyName("commission")] string Commission,
	[property: JsonPropertyName("min")] long Min,
	[property: JsonPropertyName("max")] long Max,
	[property: JsonPropertyName("instant_payout")] bool InstantPayout,
	[property: JsonPropertyName("problematic_payout")] bool ProblematicPayout,
	[property: JsonPropertyName("is_unavailable")] bool IsUnavailable,
	[property: JsonPropertyName("p2p")] bool P2p,
	[property: JsonPropertyName("has_wallet")] bool HasWallet,
	[property: JsonPropertyName("providers")] PaymentsPayoutServicesResponseSystemsProviders Providers
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
		public required Currency Currency { get; init; }
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

// ─── ProfileApi Types ────────────────────────────────────────

public static class ProfileApiTypes
{
	public sealed record ProfileClaimsParams
	{
		[JsonPropertyName("type")]
		public ProfileType? Type { get; init; }
		[JsonPropertyName("claim_state")]
		public ClaimState? ClaimState { get; init; }
	}

	public sealed record ProfileClaimsResponse(
		[property: JsonPropertyName("claims")] List<ProfileClaimsResponseClaims> Claims,
		[property: JsonPropertyName("stats")] ProfileClaimsResponseStats Stats,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProfileClaimsResponseClaimsAuthorLinks(
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

	public sealed record ProfileClaimsResponseClaimsAuthorPermissions(
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("ignore")] bool Ignore
);

	public sealed record ProfileClaimsResponseClaimsAuthorFields(
	[property: JsonPropertyName("id")] string Id,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("position")] string Position,
	[property: JsonPropertyName("is_required")] bool IsRequired
);

	public sealed record ProfileClaimsResponseClaimsAuthor(
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
	[property: JsonPropertyName("links")] ProfileClaimsResponseClaimsAuthorLinks Links,
	[property: JsonPropertyName("permissions")] ProfileClaimsResponseClaimsAuthorPermissions Permissions,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("user_is_visitor")] bool UserIsVisitor,
	[property: JsonPropertyName("user_group_id")] long UserGroupId,
	[property: JsonPropertyName("ban_reason")] string BanReason,
	[property: JsonPropertyName("fields")] List<ProfileClaimsResponseClaimsAuthorFields> Fields
);

	public sealed record ProfileClaimsResponseClaims(
	[property: JsonPropertyName("thread_id")] long ThreadId,
	[property: JsonPropertyName("claim_date")] long ClaimDate,
	[property: JsonPropertyName("claim_state")] string ClaimState,
	[property: JsonPropertyName("message_body")] string MessageBody,
	[property: JsonPropertyName("amount_formatted")] string AmountFormatted,
	[property: JsonPropertyName("author")] ProfileClaimsResponseClaimsAuthor Author
);

	public sealed record ProfileClaimsResponseStatsMarket(
	[property: JsonPropertyName("total")] long Total,
	[property: JsonPropertyName("solved")] long Solved,
	[property: JsonPropertyName("settled")] long Settled,
	[property: JsonPropertyName("rejected")] long Rejected
);

	public sealed record ProfileClaimsResponseStatsNoMarket(
	[property: JsonPropertyName("total")] long Total,
	[property: JsonPropertyName("solved")] long Solved,
	[property: JsonPropertyName("settled")] long Settled,
	[property: JsonPropertyName("rejected")] long Rejected
);

	public sealed record ProfileClaimsResponseStats(
	[property: JsonPropertyName("market")] ProfileClaimsResponseStatsMarket Market,
	[property: JsonPropertyName("noMarket")] ProfileClaimsResponseStatsNoMarket NoMarket
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

// ─── ProxyApi Types ────────────────────────────────────────

public static class ProxyApiTypes
{
	public sealed record ProxyGetResponse(
		[property: JsonPropertyName("proxies")] List<ProxyGetResponseProxies> Proxies,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record ProxyGetResponseProxiesProxy(
	[property: JsonPropertyName("proxy_id")] long ProxyId,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("proxy_ip")] string ProxyIp,
	[property: JsonPropertyName("proxy_port")] long ProxyPort,
	[property: JsonPropertyName("proxy_user")] string ProxyUser,
	[property: JsonPropertyName("proxy_pass")] string ProxyPass,
	[property: JsonPropertyName("proxyString")] string ProxyString
);

	public sealed record ProxyGetResponseProxies(
	[property: JsonPropertyName("proxy")] ProxyGetResponseProxiesProxy Proxy
);

	public sealed record ProxyAddBody
	{
		[JsonPropertyName("proxy_ip")]
		public string? ProxyIp { get; init; }
		[JsonPropertyName("proxy_port")]
		public long? ProxyPort { get; init; }
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
		public long? ProxyId { get; init; }
		[JsonPropertyName("delete_all")]
		public bool? DeleteAll { get; init; }
	}

	public sealed record ProxyDeleteResponse(
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
		public required CategoryId CategoryId { get; init; }
		[JsonPropertyName("currency")]
		public required Currency Currency { get; init; }
		[JsonPropertyName("item_origin")]
		public required PublishingItemOrigin ItemOrigin { get; init; }
		[JsonPropertyName("extended_guarantee")]
		public ExtendedGuarantee? ExtendedGuarantee { get; init; }
		[JsonPropertyName("allow_ask_discount")]
		public bool? AllowAskDiscount { get; init; }
		[JsonPropertyName("proxy_id")]
		public long? ProxyId { get; init; }
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
		public EmailType? EmailType { get; init; }
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
		public required CategoryId CategoryId { get; init; }
		[JsonPropertyName("currency")]
		public required Currency Currency { get; init; }
		[JsonPropertyName("item_origin")]
		public required PublishingItemOrigin ItemOrigin { get; init; }
		[JsonPropertyName("extended_guarantee")]
		public ExtendedGuarantee? ExtendedGuarantee { get; init; }
		[JsonPropertyName("description")]
		public string? Description { get; init; }
		[JsonPropertyName("information")]
		public string? Information { get; init; }
		[JsonPropertyName("forceTempEmail")]
		public bool? ForceTempEmail { get; init; }
		[JsonPropertyName("resell_item_id")]
		public long? ResellItemId { get; init; }
		[JsonPropertyName("has_email_login_data")]
		public bool? HasEmailLoginData { get; init; }
		[JsonPropertyName("email_login_data")]
		public string? EmailLoginData { get; init; }
		[JsonPropertyName("email_type")]
		public EmailType? EmailType { get; init; }
		[JsonPropertyName("allow_ask_discount")]
		public bool? AllowAskDiscount { get; init; }
		[JsonPropertyName("proxy_id")]
		public long? ProxyId { get; init; }
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
		public long? ResellItemId { get; init; }
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
		public EmailType? EmailType { get; init; }
		[JsonPropertyName("extra")]
		public JsonElement? Extra { get; init; }
	}

	public sealed record PublishingCheckResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("item")] PublishingCheckResponseItem Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PublishingCheckResponseItemGuarantee(
	[property: JsonPropertyName("duration")] long Duration,
	[property: JsonPropertyName("class")] string Class,
	[property: JsonPropertyName("durationPhrase")] string DurationPhrase,
	[property: JsonPropertyName("endDate")] long EndDate,
	[property: JsonPropertyName("active")] bool Active,
	[property: JsonPropertyName("cancelled")] bool Cancelled,
	[property: JsonPropertyName("remainingTime")] long RemainingTime,
	[property: JsonPropertyName("remainingTimePhrase")] string RemainingTimePhrase
);

	public sealed record PublishingCheckResponseItemLoginData(
	[property: JsonPropertyName("raw")] string Raw,
	[property: JsonPropertyName("encodedRaw")] string EncodedRaw,
	[property: JsonPropertyName("login")] string Login,
	[property: JsonPropertyName("password")] string Password,
	[property: JsonPropertyName("encodedPassword")] string EncodedPassword,
	[property: JsonPropertyName("oldPassword")] string OldPassword,
	[property: JsonPropertyName("encodedOldPassword")] JsonElement EncodedOldPassword
);

	public sealed record PublishingCheckResponseItemEmailLoginData(
	[property: JsonPropertyName("raw")] string Raw,
	[property: JsonPropertyName("encodedRaw")] string EncodedRaw,
	[property: JsonPropertyName("login")] string Login,
	[property: JsonPropertyName("password")] string Password,
	[property: JsonPropertyName("encodedPassword")] string EncodedPassword,
	[property: JsonPropertyName("oldPassword")] string OldPassword,
	[property: JsonPropertyName("encodedOldPassword")] string EncodedOldPassword
);

	public sealed record PublishingCheckResponseItemBuyer(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("operation_date")] long OperationDate,
	[property: JsonPropertyName("visitorIsBuyer")] bool VisitorIsBuyer,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss,
	[property: JsonPropertyName("user_group_id")] long UserGroupId
);

	public sealed record PublishingCheckResponseItemAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
);

	public sealed record PublishingCheckResponseItemTags1(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
);

	public sealed record PublishingCheckResponseItemTags(
	[property: JsonPropertyName("1")] PublishingCheckResponseItemTags1 _1
);

	public sealed record PublishingCheckResponseItemExtraPrices(
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("price")] string Price
);

	public sealed record PublishingCheckResponseItemBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record PublishingCheckResponseItemSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("joined_date")] long JoinedDate,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("restore_percents")] long RestorePercents,
	[property: JsonPropertyName("isOnline")] bool IsOnline
);

	public sealed record PublishingCheckResponseItem(
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
	[property: JsonPropertyName("user_allow_ask_discount")] long UserAllowAskDiscount,
	[property: JsonPropertyName("max_discount_percent")] long MaxDiscountPercent,
	[property: JsonPropertyName("market_custom_title")] string MarketCustomTitle,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("buyer_avatar_date")] long BuyerAvatarDate,
	[property: JsonPropertyName("buyer_user_group_id")] long BuyerUserGroupId,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] PublishingCheckResponseItemGuarantee Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("loginData")] PublishingCheckResponseItemLoginData LoginData,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("emailLoginData")] PublishingCheckResponseItemEmailLoginData EmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("getEmailCodeDisplayLogin")] string GetEmailCodeDisplayLogin,
	[property: JsonPropertyName("buyer")] PublishingCheckResponseItemBuyer Buyer,
	[property: JsonPropertyName("isPersonalAccount")] bool IsPersonalAccount,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("displayConvertedBalance")] bool DisplayConvertedBalance,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<PublishingCheckResponseItemAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("visitorIsAuthor")] bool VisitorIsAuthor,
	[property: JsonPropertyName("canAskDiscount")] bool CanAskDiscount,
	[property: JsonPropertyName("tags")] PublishingCheckResponseItemTags Tags,
	[property: JsonPropertyName("customFields")] List<JsonElement> CustomFields,
	[property: JsonPropertyName("externalAuth")] List<JsonElement> ExternalAuth,
	[property: JsonPropertyName("isTrusted")] bool IsTrusted,
	[property: JsonPropertyName("isBirthdayToday")] bool IsBirthdayToday,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("deposit")] long Deposit,
	[property: JsonPropertyName("extraPrices")] List<PublishingCheckResponseItemExtraPrices> ExtraPrices,
	[property: JsonPropertyName("canViewAccountLoginAndTempEmail")] bool CanViewAccountLoginAndTempEmail,
	[property: JsonPropertyName("bumpSettings")] PublishingCheckResponseItemBumpSettings BumpSettings,
	[property: JsonPropertyName("canCheckGuarantee")] bool CanCheckGuarantee,
	[property: JsonPropertyName("needToRequireVideoToViewLoginData")] bool NeedToRequireVideoToViewLoginData,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] PublishingCheckResponseItemSeller Seller
);

	public sealed record PublishingExternalBody
	{
		[JsonPropertyName("type")]
		public required PublishingType Type { get; init; }
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

// ─── PurchasingApi Types ────────────────────────────────────────

public static class PurchasingApiTypes
{
	public sealed record PurchasingFastBuyBody
	{
		[JsonPropertyName("price")]
		public double? Price { get; init; }
		[JsonPropertyName("balance_id")]
		public long? BalanceId { get; init; }
	}

	public sealed record PurchasingFastBuyResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("item")] PurchasingFastBuyResponseItem Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PurchasingFastBuyResponseItemGuarantee(
	[property: JsonPropertyName("duration")] long Duration,
	[property: JsonPropertyName("class")] string Class,
	[property: JsonPropertyName("durationPhrase")] string DurationPhrase,
	[property: JsonPropertyName("endDate")] long EndDate,
	[property: JsonPropertyName("active")] bool Active,
	[property: JsonPropertyName("cancelled")] bool Cancelled,
	[property: JsonPropertyName("remainingTime")] long RemainingTime,
	[property: JsonPropertyName("remainingTimePhrase")] string RemainingTimePhrase
);

	public sealed record PurchasingFastBuyResponseItemLoginData(
	[property: JsonPropertyName("raw")] string Raw,
	[property: JsonPropertyName("encodedRaw")] string EncodedRaw,
	[property: JsonPropertyName("login")] string Login,
	[property: JsonPropertyName("password")] string Password,
	[property: JsonPropertyName("encodedPassword")] string EncodedPassword,
	[property: JsonPropertyName("oldPassword")] string OldPassword,
	[property: JsonPropertyName("encodedOldPassword")] JsonElement EncodedOldPassword
);

	public sealed record PurchasingFastBuyResponseItemEmailLoginData(
	[property: JsonPropertyName("raw")] string Raw,
	[property: JsonPropertyName("encodedRaw")] string EncodedRaw,
	[property: JsonPropertyName("login")] string Login,
	[property: JsonPropertyName("password")] string Password,
	[property: JsonPropertyName("encodedPassword")] string EncodedPassword,
	[property: JsonPropertyName("oldPassword")] string OldPassword,
	[property: JsonPropertyName("encodedOldPassword")] string EncodedOldPassword
);

	public sealed record PurchasingFastBuyResponseItemBuyer(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("operation_date")] long OperationDate,
	[property: JsonPropertyName("visitorIsBuyer")] bool VisitorIsBuyer,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss,
	[property: JsonPropertyName("user_group_id")] long UserGroupId
);

	public sealed record PurchasingFastBuyResponseItemAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
);

	public sealed record PurchasingFastBuyResponseItemTags1(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
);

	public sealed record PurchasingFastBuyResponseItemTags(
	[property: JsonPropertyName("1")] PurchasingFastBuyResponseItemTags1 _1
);

	public sealed record PurchasingFastBuyResponseItemExtraPrices(
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("price")] string Price
);

	public sealed record PurchasingFastBuyResponseItemBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record PurchasingFastBuyResponseItemSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("joined_date")] long JoinedDate,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("restore_percents")] long RestorePercents,
	[property: JsonPropertyName("isOnline")] bool IsOnline
);

	public sealed record PurchasingFastBuyResponseItem(
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
	[property: JsonPropertyName("user_allow_ask_discount")] long UserAllowAskDiscount,
	[property: JsonPropertyName("max_discount_percent")] long MaxDiscountPercent,
	[property: JsonPropertyName("market_custom_title")] string MarketCustomTitle,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("buyer_avatar_date")] long BuyerAvatarDate,
	[property: JsonPropertyName("buyer_user_group_id")] long BuyerUserGroupId,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] PurchasingFastBuyResponseItemGuarantee Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("loginData")] PurchasingFastBuyResponseItemLoginData LoginData,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("emailLoginData")] PurchasingFastBuyResponseItemEmailLoginData EmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("getEmailCodeDisplayLogin")] string GetEmailCodeDisplayLogin,
	[property: JsonPropertyName("buyer")] PurchasingFastBuyResponseItemBuyer Buyer,
	[property: JsonPropertyName("isPersonalAccount")] bool IsPersonalAccount,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("displayConvertedBalance")] bool DisplayConvertedBalance,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<PurchasingFastBuyResponseItemAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("visitorIsAuthor")] bool VisitorIsAuthor,
	[property: JsonPropertyName("canAskDiscount")] bool CanAskDiscount,
	[property: JsonPropertyName("tags")] PurchasingFastBuyResponseItemTags Tags,
	[property: JsonPropertyName("customFields")] List<JsonElement> CustomFields,
	[property: JsonPropertyName("externalAuth")] List<JsonElement> ExternalAuth,
	[property: JsonPropertyName("isTrusted")] bool IsTrusted,
	[property: JsonPropertyName("isBirthdayToday")] bool IsBirthdayToday,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("deposit")] long Deposit,
	[property: JsonPropertyName("extraPrices")] List<PurchasingFastBuyResponseItemExtraPrices> ExtraPrices,
	[property: JsonPropertyName("canViewAccountLoginAndTempEmail")] bool CanViewAccountLoginAndTempEmail,
	[property: JsonPropertyName("bumpSettings")] PurchasingFastBuyResponseItemBumpSettings BumpSettings,
	[property: JsonPropertyName("canCheckGuarantee")] bool CanCheckGuarantee,
	[property: JsonPropertyName("needToRequireVideoToViewLoginData")] bool NeedToRequireVideoToViewLoginData,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] PurchasingFastBuyResponseItemSeller Seller
);

	public sealed record PurchasingCheckResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("item")] PurchasingCheckResponseItem Item,
		[property: JsonPropertyName("requireVideoRecording")] bool RequireVideoRecording,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PurchasingCheckResponseItemGuarantee(
	[property: JsonPropertyName("duration")] long Duration,
	[property: JsonPropertyName("class")] string Class,
	[property: JsonPropertyName("durationPhrase")] string DurationPhrase,
	[property: JsonPropertyName("endDate")] JsonElement EndDate,
	[property: JsonPropertyName("active")] JsonElement Active,
	[property: JsonPropertyName("cancelled")] JsonElement Cancelled,
	[property: JsonPropertyName("remainingTime")] JsonElement RemainingTime
);

	public sealed record PurchasingCheckResponseItemAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
);

	public sealed record PurchasingCheckResponseItemExtraPrices(
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("price")] string Price
);

	public sealed record PurchasingCheckResponseItemBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
);

	public sealed record PurchasingCheckResponseItemSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("joined_date")] long JoinedDate,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("restore_percents")] JsonElement RestorePercents,
	[property: JsonPropertyName("isOnline")] bool IsOnline
);

	public sealed record PurchasingCheckResponseItem(
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
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("user_allow_ask_discount")] long UserAllowAskDiscount,
	[property: JsonPropertyName("max_discount_percent")] long MaxDiscountPercent,
	[property: JsonPropertyName("market_custom_title")] string MarketCustomTitle,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("category_title")] string CategoryTitle,
	[property: JsonPropertyName("category_url")] string CategoryUrl,
	[property: JsonPropertyName("require_temp_email")] long RequireTempEmail,
	[property: JsonPropertyName("available_temp_email")] long AvailableTempEmail,
	[property: JsonPropertyName("check_button_enabled")] long CheckButtonEnabled,
	[property: JsonPropertyName("checker_enabled")] long CheckerEnabled,
	[property: JsonPropertyName("buy_without_validation")] long BuyWithoutValidation,
	[property: JsonPropertyName("has_guarantee")] long HasGuarantee,
	[property: JsonPropertyName("require_video_recording")] long RequireVideoRecording,
	[property: JsonPropertyName("can_be_resold")] long CanBeResold,
	[property: JsonPropertyName("login_type")] string LoginType,
	[property: JsonPropertyName("require_email_login_data")] long RequireEmailLoginData,
	[property: JsonPropertyName("category_prefix_id")] long CategoryPrefixId,
	[property: JsonPropertyName("ask_user_id")] JsonElement AskUserId,
	[property: JsonPropertyName("ask_item_id")] JsonElement AskItemId,
	[property: JsonPropertyName("ask_date")] JsonElement AskDate,
	[property: JsonPropertyName("discount_price")] JsonElement DiscountPrice,
	[property: JsonPropertyName("discount_accepted")] JsonElement DiscountAccepted,
	[property: JsonPropertyName("user_alerted")] JsonElement UserAlerted,
	[property: JsonPropertyName("message")] JsonElement Message,
	[property: JsonPropertyName("min_price")] long MinPrice,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] PurchasingCheckResponseItemGuarantee Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("isPersonalAccount")] bool IsPersonalAccount,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("isSmallExf")] bool IsSmallExf,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<PurchasingCheckResponseItemAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("visitorIsAuthor")] bool VisitorIsAuthor,
	[property: JsonPropertyName("canAskDiscount")] bool CanAskDiscount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("customFields")] List<JsonElement> CustomFields,
	[property: JsonPropertyName("externalAuth")] List<JsonElement> ExternalAuth,
	[property: JsonPropertyName("isTrusted")] bool IsTrusted,
	[property: JsonPropertyName("isBirthdayToday")] bool IsBirthdayToday,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("deposit")] long Deposit,
	[property: JsonPropertyName("extraPrices")] List<PurchasingCheckResponseItemExtraPrices> ExtraPrices,
	[property: JsonPropertyName("canViewAccountLoginAndTempEmail")] bool CanViewAccountLoginAndTempEmail,
	[property: JsonPropertyName("bumpSettings")] PurchasingCheckResponseItemBumpSettings BumpSettings,
	[property: JsonPropertyName("canCheckGuarantee")] bool CanCheckGuarantee,
	[property: JsonPropertyName("needToRequireVideoToViewLoginData")] bool NeedToRequireVideoToViewLoginData,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] PurchasingCheckResponseItemSeller Seller
);

	public sealed record PurchasingConfirmBody
	{
		[JsonPropertyName("price")]
		public long? Price { get; init; }
		[JsonPropertyName("balance_id")]
		public long? BalanceId { get; init; }
	}

	public sealed record PurchasingConfirmResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("item")] PurchasingConfirmResponseItem Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	);

	public sealed record PurchasingConfirmResponseItemLoginData(
	[property: JsonPropertyName("raw")] string Raw,
	[property: JsonPropertyName("encodedRaw")] string EncodedRaw,
	[property: JsonPropertyName("login")] string Login,
	[property: JsonPropertyName("password")] string Password,
	[property: JsonPropertyName("encodedPassword")] string EncodedPassword,
	[property: JsonPropertyName("oldPassword")] string OldPassword,
	[property: JsonPropertyName("encodedOldPassword")] string EncodedOldPassword,
	[property: JsonPropertyName("adviceToChangePassword")] bool AdviceToChangePassword
);

	public sealed record PurchasingConfirmResponseItem(
	[property: JsonPropertyName("loginData")] PurchasingConfirmResponseItemLoginData LoginData
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

