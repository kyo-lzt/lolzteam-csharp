// Auto-generated. Do not edit manually.

using System.Text.Json;
using Lolzteam.Api.Runtime;

namespace Lolzteam.Api.Generated.Market;

public sealed class CategoryApi
{
	private readonly LolzteamHttpClient _http;

	public CategoryApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> AllAsync(CategoryApiTypes.CategoryAllParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SteamAsync(CategoryApiTypes.CategorySteamParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/steam",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FortniteAsync(CategoryApiTypes.CategoryFortniteParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/fortnite",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> MihoyoAsync(CategoryApiTypes.CategoryMihoyoParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/mihoyo",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> RiotAsync(CategoryApiTypes.CategoryRiotParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/riot",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> TelegramAsync(CategoryApiTypes.CategoryTelegramParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/telegram",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SupercellAsync(CategoryApiTypes.CategorySupercellParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/supercell",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> EaAsync(CategoryApiTypes.CategoryEaParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/ea",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> WotAsync(CategoryApiTypes.CategoryWotParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/world-of-tanks",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> WotBlitzAsync(CategoryApiTypes.CategoryWotBlitzParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/wot-blitz",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GiftsAsync(CategoryApiTypes.CategoryGiftsParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/gifts",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> EpicGamesAsync(CategoryApiTypes.CategoryEpicGamesParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/epicgames",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> EscapeFromTarkovAsync(CategoryApiTypes.CategoryEscapeFromTarkovParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/escape-from-tarkov",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SocialClubAsync(CategoryApiTypes.CategorySocialClubParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/socialclub",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> UplayAsync(CategoryApiTypes.CategoryUplayParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/uplay",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DiscordAsync(CategoryApiTypes.CategoryDiscordParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/discord",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> TikTokAsync(CategoryApiTypes.CategoryTikTokParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/tiktok",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> InstagramAsync(CategoryApiTypes.CategoryInstagramParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/instagram",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> BattleNetAsync(CategoryApiTypes.CategoryBattleNetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/battlenet",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ChatGPTAsync(CategoryApiTypes.CategoryChatGPTParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/chatgpt",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> VpnAsync(CategoryApiTypes.CategoryVpnParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/vpn",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> RobloxAsync(CategoryApiTypes.CategoryRobloxParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/roblox",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> WarfaceAsync(CategoryApiTypes.CategoryWarfaceParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/warface",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> MinecraftAsync(CategoryApiTypes.CategoryMinecraftParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/minecraft",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> HytaleAsync(CategoryApiTypes.CategoryHytaleParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/hytale",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ListAsync(CategoryApiTypes.CategoryListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/category",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ParamsAsync(string CategoryName, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{CategoryName}/params",
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GamesAsync(string CategoryName, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{CategoryName}/games",
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ListApi
{
	private readonly LolzteamHttpClient _http;

	public ListApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> UserAsync(ListApiTypes.ListUserParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/user/items",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> OrdersAsync(ListApiTypes.ListOrdersParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/user/orders",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> StatesAsync(ListApiTypes.ListStatesParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/user/item-states",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DownloadAsync(string Type, ListApiTypes.ListDownloadParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/user/{Type}/download",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FavoritesAsync(ListApiTypes.ListFavoritesParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/fave",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ViewedAsync(ListApiTypes.ListViewedParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/viewed",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ManagingApi
{
	private readonly LolzteamHttpClient _http;

	public ManagingApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> GetAsync(int ItemId, ManagingApiTypes.ManagingGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DeleteAsync(int ItemId, ManagingApiTypes.ManagingDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CreateClaimAsync(ManagingApiTypes.ManagingCreateClaimBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/claims",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> BulkGetAsync(ManagingApiTypes.ManagingBulkGetBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/bulk/items",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SteamInventoryValueAsync(int ItemId, ManagingApiTypes.ManagingSteamInventoryValueParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/inventory-value",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SteamValueAsync(ManagingApiTypes.ManagingSteamValueParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/steam-value",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SteamPreviewAsync(int ItemId, ManagingApiTypes.ManagingSteamPreviewParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/steam-preview",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> EditAsync(int ItemId, ManagingApiTypes.ManagingEditBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = $"/{ItemId}/edit",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> AIPriceAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/ai-price",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> AutoBuyPriceAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/auto-buy-price",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> NoteAsync(int ItemId, ManagingApiTypes.ManagingNoteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/note-save",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SteamUpdateValueAsync(int ItemId, ManagingApiTypes.ManagingSteamUpdateValueBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/update-inventory",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> BumpAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/bump",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> AutoBumpAsync(int ItemId, ManagingApiTypes.ManagingAutoBumpBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/auto-bump",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> AutoBumpDisableAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/auto-bump",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> OpenAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/open",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CloseAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/close",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ImageAsync(int ItemId, ManagingApiTypes.ManagingImageParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/image",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> EmailCodeAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/email-code",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetLetters2Async(ManagingApiTypes.ManagingGetLetters2Params? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/letters2",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SteamGetMafileAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/mafile",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SteamAddMafileAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/mafile",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SteamRemoveMafileAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/mafile",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SteamMafileCodeAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/guard-code",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SteamSDAAsync(int ItemId, ManagingApiTypes.ManagingSteamSDABody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/confirm-sda",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> TelegramCodeAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/telegram-login-code",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> TelegramResetAuthAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/telegram-reset-authorizations",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> RefuseGuaranteeAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/refuse-guarantee",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DeclineVideoRecordingAsync(int ItemId, ManagingApiTypes.ManagingDeclineVideoRecordingBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/decline-video-recording",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CheckGuaranteeAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/check-guarantee",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ChangePasswordAsync(int ItemId, ManagingApiTypes.ManagingChangePasswordBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/change-password",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> TempEmailPasswordAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/temp-email-password",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> TagAsync(int ItemId, ManagingApiTypes.ManagingTagBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/tag",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> UntagAsync(int ItemId, ManagingApiTypes.ManagingUntagBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/tag",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> PublicTagAsync(int ItemId, ManagingApiTypes.ManagingPublicTagBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/public-tag",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> PublicUntagAsync(int ItemId, ManagingApiTypes.ManagingPublicUntagBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/public-tag",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FavoriteAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/star",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> UnfavoriteAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/star",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> StickAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/stick",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> UnstickAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/stick",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> TransferAsync(int ItemId, ManagingApiTypes.ManagingTransferBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/change-owner",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ProfileApi
{
	private readonly LolzteamHttpClient _http;

	public ProfileApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> ClaimsAsync(ProfileApiTypes.ProfileClaimsParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/claims",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetAsync(ProfileApiTypes.ProfileGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/me",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> EditAsync(ProfileApiTypes.ProfileEditBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = "/me",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class CartApi
{
	private readonly LolzteamHttpClient _http;

	public CartApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> GetAsync(CartApiTypes.CartGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/cart",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> AddAsync(CartApiTypes.CartAddBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/cart",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DeleteAsync(CartApiTypes.CartDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/cart",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class PurchasingApi
{
	private readonly LolzteamHttpClient _http;

	public PurchasingApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> FastBuyAsync(int ItemId, PurchasingApiTypes.PurchasingFastBuyBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/fast-buy",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CheckAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/check-account",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ConfirmAsync(int ItemId, PurchasingApiTypes.PurchasingConfirmBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/confirm-buy",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DiscountRequestAsync(int ItemId, PurchasingApiTypes.PurchasingDiscountRequestBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/discount",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DiscountCancelAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/discount",
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class CustomDiscountsApi
{
	private readonly LolzteamHttpClient _http;

	public CustomDiscountsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> GetAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/custom-discounts",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CreateAsync(CustomDiscountsApiTypes.CustomDiscountsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/custom-discounts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> EditAsync(CustomDiscountsApiTypes.CustomDiscountsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = "/custom-discounts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DeleteAsync(CustomDiscountsApiTypes.CustomDiscountsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/custom-discounts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class PublishingApi
{
	private readonly LolzteamHttpClient _http;

	public PublishingApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> FastSellAsync(PublishingApiTypes.PublishingFastSellBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/item/fast-sell",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> AddAsync(PublishingApiTypes.PublishingAddBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/item/add",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CheckAsync(int ItemId, PublishingApiTypes.PublishingCheckBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/goods/check",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ExternalAsync(int ItemId, PublishingApiTypes.PublishingExternalBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/external-account",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class PaymentsApi
{
	private readonly LolzteamHttpClient _http;

	public PaymentsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> InvoiceGetAsync(PaymentsApiTypes.PaymentsInvoiceGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/invoice",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> InvoiceCreateAsync(PaymentsApiTypes.PaymentsInvoiceCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/invoice",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> InvoiceListAsync(PaymentsApiTypes.PaymentsInvoiceListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/invoice/list",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CurrencyAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/currency",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> BalanceListAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/balance/exchange",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> BalanceExchangeAsync(PaymentsApiTypes.PaymentsBalanceExchangeBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/balance/exchange",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> TransferAsync(PaymentsApiTypes.PaymentsTransferBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/balance/transfer",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FeeAsync(PaymentsApiTypes.PaymentsFeeParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/balance/transfer/fee",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CancelAsync(PaymentsApiTypes.PaymentsCancelBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/balance/transfer/cancel",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> HistoryAsync(PaymentsApiTypes.PaymentsHistoryParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/user/payments",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> PayoutServicesAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/balance/payout/services",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> PayoutAsync(PaymentsApiTypes.PaymentsPayoutBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/balance/payout",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class AutoPaymentsApi
{
	private readonly LolzteamHttpClient _http;

	public AutoPaymentsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> ListAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/auto-payments",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CreateAsync(AutoPaymentsApiTypes.AutoPaymentsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/auto-payment",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DeleteAsync(AutoPaymentsApiTypes.AutoPaymentsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/auto-payment",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ProxyApi
{
	private readonly LolzteamHttpClient _http;

	public ProxyApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> GetAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/proxy",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> AddAsync(ProxyApiTypes.ProxyAddBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/proxy",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DeleteAsync(ProxyApiTypes.ProxyDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/proxy",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ImapApi
{
	private readonly LolzteamHttpClient _http;

	public ImapApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> CreateAsync(ImapApiTypes.ImapCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/imap",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DeleteAsync(ImapApiTypes.ImapDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/imap",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class BatchApi
{
	private readonly LolzteamHttpClient _http;

	public BatchApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> BatchAsync(List<JsonElement> body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/batch",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class MarketClient : IDisposable
{
	public CategoryApi Category { get; }
	public ListApi List { get; }
	public ManagingApi Managing { get; }
	public ProfileApi Profile { get; }
	public CartApi Cart { get; }
	public PurchasingApi Purchasing { get; }
	public CustomDiscountsApi CustomDiscounts { get; }
	public PublishingApi Publishing { get; }
	public PaymentsApi Payments { get; }
	public AutoPaymentsApi AutoPayments { get; }
	public ProxyApi Proxy { get; }
	public ImapApi Imap { get; }
	public BatchApi Batch { get; }

	private readonly LolzteamHttpClient _http;

	public MarketClient(ClientConfig config)
	{
		var resolvedConfig = config with
		{
			BaseUrl = config.BaseUrl ?? "https://prod-api.lzt.market",
			RateLimit = config.RateLimit ?? new RateLimitConfig(120),
			SearchRateLimit = config.SearchRateLimit ?? new RateLimitConfig(20),
		};
		_http = new LolzteamHttpClient(resolvedConfig);

		Category = new CategoryApi(_http);
		List = new ListApi(_http);
		Managing = new ManagingApi(_http);
		Profile = new ProfileApi(_http);
		Cart = new CartApi(_http);
		Purchasing = new PurchasingApi(_http);
		CustomDiscounts = new CustomDiscountsApi(_http);
		Publishing = new PublishingApi(_http);
		Payments = new PaymentsApi(_http);
		AutoPayments = new AutoPaymentsApi(_http);
		Proxy = new ProxyApi(_http);
		Imap = new ImapApi(_http);
		Batch = new BatchApi(_http);
	}

	public void Dispose()
	{
		_http.Dispose();
	}
}
