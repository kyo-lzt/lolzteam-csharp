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

	public async Task<CategoryApiTypes.CategoryAllResponse> AllAsync(CategoryApiTypes.CategoryAllParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryAllResponse(__result);
	}

	public async Task<CategoryApiTypes.CategorySteamResponse> SteamAsync(CategoryApiTypes.CategorySteamParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/steam",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategorySteamResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryFortniteResponse> FortniteAsync(CategoryApiTypes.CategoryFortniteParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/fortnite",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryFortniteResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryMihoyoResponse> MihoyoAsync(CategoryApiTypes.CategoryMihoyoParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/mihoyo",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryMihoyoResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryRiotResponse> RiotAsync(CategoryApiTypes.CategoryRiotParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/riot",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryRiotResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryTelegramResponse> TelegramAsync(CategoryApiTypes.CategoryTelegramParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/telegram",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryTelegramResponse(__result);
	}

	public async Task<CategoryApiTypes.CategorySupercellResponse> SupercellAsync(CategoryApiTypes.CategorySupercellParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/supercell",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategorySupercellResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryEaResponse> EaAsync(CategoryApiTypes.CategoryEaParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/ea",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryEaResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryWotResponse> WotAsync(CategoryApiTypes.CategoryWotParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/world-of-tanks",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryWotResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryWotBlitzResponse> WotBlitzAsync(CategoryApiTypes.CategoryWotBlitzParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/wot-blitz",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryWotBlitzResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryGiftsResponse> GiftsAsync(CategoryApiTypes.CategoryGiftsParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/gifts",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryGiftsResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryEpicGamesResponse> EpicGamesAsync(CategoryApiTypes.CategoryEpicGamesParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/epicgames",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryEpicGamesResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryEscapeFromTarkovResponse> EscapeFromTarkovAsync(CategoryApiTypes.CategoryEscapeFromTarkovParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/escape-from-tarkov",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryEscapeFromTarkovResponse(__result);
	}

	public async Task<CategoryApiTypes.CategorySocialClubResponse> SocialClubAsync(CategoryApiTypes.CategorySocialClubParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/socialclub",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategorySocialClubResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryUplayResponse> UplayAsync(CategoryApiTypes.CategoryUplayParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/uplay",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryUplayResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryDiscordResponse> DiscordAsync(CategoryApiTypes.CategoryDiscordParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/discord",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryDiscordResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryTikTokResponse> TikTokAsync(CategoryApiTypes.CategoryTikTokParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/tiktok",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryTikTokResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryInstagramResponse> InstagramAsync(CategoryApiTypes.CategoryInstagramParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/instagram",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryInstagramResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryBattleNetResponse> BattleNetAsync(CategoryApiTypes.CategoryBattleNetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/battlenet",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryBattleNetResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryChatGPTResponse> ChatGPTAsync(CategoryApiTypes.CategoryChatGPTParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/chatgpt",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryChatGPTResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryVpnResponse> VpnAsync(CategoryApiTypes.CategoryVpnParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/vpn",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryVpnResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryRobloxResponse> RobloxAsync(CategoryApiTypes.CategoryRobloxParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/roblox",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryRobloxResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryWarfaceResponse> WarfaceAsync(CategoryApiTypes.CategoryWarfaceParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/warface",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryWarfaceResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryMinecraftResponse> MinecraftAsync(CategoryApiTypes.CategoryMinecraftParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/minecraft",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryMinecraftResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryHytaleResponse> HytaleAsync(CategoryApiTypes.CategoryHytaleParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/hytale",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryHytaleResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryListResponse> ListAsync(CategoryApiTypes.CategoryListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/category",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryListResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryParamsResponse> ParamsAsync(string CategoryName, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{CategoryName}/params",
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryParamsResponse(__result);
	}

	public async Task<CategoryApiTypes.CategoryGamesResponse> GamesAsync(string CategoryName, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{CategoryName}/games",
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoryApiTypes.CategoryGamesResponse(__result);
	}
}

public sealed class ListApi
{
	private readonly LolzteamHttpClient _http;

	public ListApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ListApiTypes.ListUserResponse> UserAsync(ListApiTypes.ListUserParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/user/items",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ListApiTypes.ListUserResponse(__result);
	}

	public async Task<ListApiTypes.ListOrdersResponse> OrdersAsync(ListApiTypes.ListOrdersParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/user/orders",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ListApiTypes.ListOrdersResponse(__result);
	}

	public async Task<ListApiTypes.ListStatesResponse> StatesAsync(ListApiTypes.ListStatesParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/user/item-states",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ListApiTypes.ListStatesResponse(__result);
	}

	public async Task<ListApiTypes.ListDownloadResponse> DownloadAsync(string Type, ListApiTypes.ListDownloadParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/user/{Type}/download",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ListApiTypes.ListDownloadResponse(__result);
	}

	public async Task<ListApiTypes.ListFavoritesResponse> FavoritesAsync(ListApiTypes.ListFavoritesParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/fave",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ListApiTypes.ListFavoritesResponse(__result);
	}

	public async Task<ListApiTypes.ListViewedResponse> ViewedAsync(ListApiTypes.ListViewedParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/viewed",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ListApiTypes.ListViewedResponse(__result);
	}
}

public sealed class ManagingApi
{
	private readonly LolzteamHttpClient _http;

	public ManagingApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ManagingApiTypes.ManagingGetResponse> GetAsync(int ItemId, ManagingApiTypes.ManagingGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingGetResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingDeleteResponse> DeleteAsync(int ItemId, ManagingApiTypes.ManagingDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingDeleteResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingCreateClaimResponse> CreateClaimAsync(ManagingApiTypes.ManagingCreateClaimBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/claims",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingCreateClaimResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingBulkGetResponse> BulkGetAsync(ManagingApiTypes.ManagingBulkGetBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/bulk/items",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingBulkGetResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingSteamInventoryValueResponse> SteamInventoryValueAsync(int ItemId, ManagingApiTypes.ManagingSteamInventoryValueParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/inventory-value",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingSteamInventoryValueResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingSteamValueResponse> SteamValueAsync(ManagingApiTypes.ManagingSteamValueParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/steam-value",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingSteamValueResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingSteamPreviewResponse> SteamPreviewAsync(int ItemId, ManagingApiTypes.ManagingSteamPreviewParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/steam-preview",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingSteamPreviewResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingEditResponse> EditAsync(int ItemId, ManagingApiTypes.ManagingEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = $"/{ItemId}/edit",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingEditResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingAIPriceResponse> AIPriceAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/ai-price",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingAIPriceResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingAutoBuyPriceResponse> AutoBuyPriceAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/auto-buy-price",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingAutoBuyPriceResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingNoteResponse> NoteAsync(int ItemId, ManagingApiTypes.ManagingNoteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/note-save",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingNoteResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingSteamUpdateValueResponse> SteamUpdateValueAsync(int ItemId, ManagingApiTypes.ManagingSteamUpdateValueBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/update-inventory",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingSteamUpdateValueResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingBumpResponse> BumpAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/bump",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingBumpResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingAutoBumpResponse> AutoBumpAsync(int ItemId, ManagingApiTypes.ManagingAutoBumpBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/auto-bump",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingAutoBumpResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingAutoBumpDisableResponse> AutoBumpDisableAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/auto-bump",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingAutoBumpDisableResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingOpenResponse> OpenAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/open",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingOpenResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingCloseResponse> CloseAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/close",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingCloseResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingImageResponse> ImageAsync(int ItemId, ManagingApiTypes.ManagingImageParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/image",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingImageResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingEmailCodeResponse> EmailCodeAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/email-code",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingEmailCodeResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingGetLetters2Response> GetLetters2Async(ManagingApiTypes.ManagingGetLetters2Params? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/letters2",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingGetLetters2Response(__result);
	}

	public async Task<ManagingApiTypes.ManagingSteamGetMafileResponse> SteamGetMafileAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/mafile",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingSteamGetMafileResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingSteamAddMafileResponse> SteamAddMafileAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/mafile",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingSteamAddMafileResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingSteamRemoveMafileResponse> SteamRemoveMafileAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/mafile",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingSteamRemoveMafileResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingSteamMafileCodeResponse> SteamMafileCodeAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/guard-code",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingSteamMafileCodeResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingSteamSDAResponse> SteamSDAAsync(int ItemId, ManagingApiTypes.ManagingSteamSDABody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/confirm-sda",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingSteamSDAResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingTelegramCodeResponse> TelegramCodeAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/telegram-login-code",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingTelegramCodeResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingTelegramResetAuthResponse> TelegramResetAuthAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/telegram-reset-authorizations",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingTelegramResetAuthResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingRefuseGuaranteeResponse> RefuseGuaranteeAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/refuse-guarantee",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingRefuseGuaranteeResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingDeclineVideoRecordingResponse> DeclineVideoRecordingAsync(int ItemId, ManagingApiTypes.ManagingDeclineVideoRecordingBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/decline-video-recording",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingDeclineVideoRecordingResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingCheckGuaranteeResponse> CheckGuaranteeAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/check-guarantee",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingCheckGuaranteeResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingChangePasswordResponse> ChangePasswordAsync(int ItemId, ManagingApiTypes.ManagingChangePasswordBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/change-password",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingChangePasswordResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingTempEmailPasswordResponse> TempEmailPasswordAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/temp-email-password",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingTempEmailPasswordResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingTagResponse> TagAsync(int ItemId, ManagingApiTypes.ManagingTagBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/tag",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingTagResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingUntagResponse> UntagAsync(int ItemId, ManagingApiTypes.ManagingUntagBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/tag",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingUntagResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingPublicTagResponse> PublicTagAsync(int ItemId, ManagingApiTypes.ManagingPublicTagBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/public-tag",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingPublicTagResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingPublicUntagResponse> PublicUntagAsync(int ItemId, ManagingApiTypes.ManagingPublicUntagBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/public-tag",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingPublicUntagResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingFavoriteResponse> FavoriteAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/star",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingFavoriteResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingUnfavoriteResponse> UnfavoriteAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/star",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingUnfavoriteResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingStickResponse> StickAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/stick",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingStickResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingUnstickResponse> UnstickAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/stick",
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingUnstickResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingTransferResponse> TransferAsync(int ItemId, ManagingApiTypes.ManagingTransferBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/change-owner",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingTransferResponse(__result);
	}
}

public sealed class ProfileApi
{
	private readonly LolzteamHttpClient _http;

	public ProfileApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ProfileApiTypes.ProfileClaimsResponse> ClaimsAsync(ProfileApiTypes.ProfileClaimsParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/claims",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ProfileApiTypes.ProfileClaimsResponse(__result);
	}

	public async Task<ProfileApiTypes.ProfileGetResponse> GetAsync(ProfileApiTypes.ProfileGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/me",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ProfileApiTypes.ProfileGetResponse(__result);
	}

	public async Task<ProfileApiTypes.ProfileEditResponse> EditAsync(ProfileApiTypes.ProfileEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = "/me",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ProfileApiTypes.ProfileEditResponse(__result);
	}
}

public sealed class CartApi
{
	private readonly LolzteamHttpClient _http;

	public CartApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<CartApiTypes.CartGetResponse> GetAsync(CartApiTypes.CartGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/cart",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new CartApiTypes.CartGetResponse(__result);
	}

	public async Task<CartApiTypes.CartAddResponse> AddAsync(CartApiTypes.CartAddBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/cart",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new CartApiTypes.CartAddResponse(__result);
	}

	public async Task<CartApiTypes.CartDeleteResponse> DeleteAsync(CartApiTypes.CartDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/cart",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new CartApiTypes.CartDeleteResponse(__result);
	}
}

public sealed class PurchasingApi
{
	private readonly LolzteamHttpClient _http;

	public PurchasingApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<PurchasingApiTypes.PurchasingFastBuyResponse> FastBuyAsync(int ItemId, PurchasingApiTypes.PurchasingFastBuyBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/fast-buy",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PurchasingApiTypes.PurchasingFastBuyResponse(__result);
	}

	public async Task<PurchasingApiTypes.PurchasingCheckResponse> CheckAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/check-account",
		}, cancellationToken).ConfigureAwait(false);
		return new PurchasingApiTypes.PurchasingCheckResponse(__result);
	}

	public async Task<PurchasingApiTypes.PurchasingConfirmResponse> ConfirmAsync(int ItemId, PurchasingApiTypes.PurchasingConfirmBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/confirm-buy",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PurchasingApiTypes.PurchasingConfirmResponse(__result);
	}

	public async Task<PurchasingApiTypes.PurchasingDiscountRequestResponse> DiscountRequestAsync(int ItemId, PurchasingApiTypes.PurchasingDiscountRequestBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/discount",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PurchasingApiTypes.PurchasingDiscountRequestResponse(__result);
	}

	public async Task<PurchasingApiTypes.PurchasingDiscountCancelResponse> DiscountCancelAsync(int ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/discount",
		}, cancellationToken).ConfigureAwait(false);
		return new PurchasingApiTypes.PurchasingDiscountCancelResponse(__result);
	}
}

public sealed class CustomDiscountsApi
{
	private readonly LolzteamHttpClient _http;

	public CustomDiscountsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<CustomDiscountsApiTypes.CustomDiscountsGetResponse> GetAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/custom-discounts",
		}, cancellationToken).ConfigureAwait(false);
		return new CustomDiscountsApiTypes.CustomDiscountsGetResponse(__result);
	}

	public async Task<CustomDiscountsApiTypes.CustomDiscountsCreateResponse> CreateAsync(CustomDiscountsApiTypes.CustomDiscountsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/custom-discounts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new CustomDiscountsApiTypes.CustomDiscountsCreateResponse(__result);
	}

	public async Task<CustomDiscountsApiTypes.CustomDiscountsEditResponse> EditAsync(CustomDiscountsApiTypes.CustomDiscountsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = "/custom-discounts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new CustomDiscountsApiTypes.CustomDiscountsEditResponse(__result);
	}

	public async Task<CustomDiscountsApiTypes.CustomDiscountsDeleteResponse> DeleteAsync(CustomDiscountsApiTypes.CustomDiscountsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/custom-discounts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new CustomDiscountsApiTypes.CustomDiscountsDeleteResponse(__result);
	}
}

public sealed class PublishingApi
{
	private readonly LolzteamHttpClient _http;

	public PublishingApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<PublishingApiTypes.PublishingFastSellResponse> FastSellAsync(PublishingApiTypes.PublishingFastSellBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/item/fast-sell",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PublishingApiTypes.PublishingFastSellResponse(__result);
	}

	public async Task<PublishingApiTypes.PublishingAddResponse> AddAsync(PublishingApiTypes.PublishingAddBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/item/add",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PublishingApiTypes.PublishingAddResponse(__result);
	}

	public async Task<PublishingApiTypes.PublishingCheckResponse> CheckAsync(int ItemId, PublishingApiTypes.PublishingCheckBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/goods/check",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PublishingApiTypes.PublishingCheckResponse(__result);
	}

	public async Task<PublishingApiTypes.PublishingExternalResponse> ExternalAsync(int ItemId, PublishingApiTypes.PublishingExternalBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/external-account",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PublishingApiTypes.PublishingExternalResponse(__result);
	}
}

public sealed class PaymentsApi
{
	private readonly LolzteamHttpClient _http;

	public PaymentsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<PaymentsApiTypes.PaymentsInvoiceGetResponse> InvoiceGetAsync(PaymentsApiTypes.PaymentsInvoiceGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/invoice",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new PaymentsApiTypes.PaymentsInvoiceGetResponse(__result);
	}

	public async Task<PaymentsApiTypes.PaymentsInvoiceCreateResponse> InvoiceCreateAsync(PaymentsApiTypes.PaymentsInvoiceCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/invoice",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PaymentsApiTypes.PaymentsInvoiceCreateResponse(__result);
	}

	public async Task<PaymentsApiTypes.PaymentsInvoiceListResponse> InvoiceListAsync(PaymentsApiTypes.PaymentsInvoiceListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/invoice/list",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new PaymentsApiTypes.PaymentsInvoiceListResponse(__result);
	}

	public async Task<PaymentsApiTypes.PaymentsCurrencyResponse> CurrencyAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/currency",
		}, cancellationToken).ConfigureAwait(false);
		return new PaymentsApiTypes.PaymentsCurrencyResponse(__result);
	}

	public async Task<PaymentsApiTypes.PaymentsBalanceListResponse> BalanceListAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/balance/exchange",
		}, cancellationToken).ConfigureAwait(false);
		return new PaymentsApiTypes.PaymentsBalanceListResponse(__result);
	}

	public async Task<PaymentsApiTypes.PaymentsBalanceExchangeResponse> BalanceExchangeAsync(PaymentsApiTypes.PaymentsBalanceExchangeBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/balance/exchange",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PaymentsApiTypes.PaymentsBalanceExchangeResponse(__result);
	}

	public async Task<PaymentsApiTypes.PaymentsTransferResponse> TransferAsync(PaymentsApiTypes.PaymentsTransferBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/balance/transfer",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PaymentsApiTypes.PaymentsTransferResponse(__result);
	}

	public async Task<PaymentsApiTypes.PaymentsFeeResponse> FeeAsync(PaymentsApiTypes.PaymentsFeeParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/balance/transfer/fee",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new PaymentsApiTypes.PaymentsFeeResponse(__result);
	}

	public async Task<PaymentsApiTypes.PaymentsCancelResponse> CancelAsync(PaymentsApiTypes.PaymentsCancelBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/balance/transfer/cancel",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PaymentsApiTypes.PaymentsCancelResponse(__result);
	}

	public async Task<PaymentsApiTypes.PaymentsHistoryResponse> HistoryAsync(PaymentsApiTypes.PaymentsHistoryParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/user/payments",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new PaymentsApiTypes.PaymentsHistoryResponse(__result);
	}

	public async Task<PaymentsApiTypes.PaymentsPayoutServicesResponse> PayoutServicesAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/balance/payout/services",
		}, cancellationToken).ConfigureAwait(false);
		return new PaymentsApiTypes.PaymentsPayoutServicesResponse(__result);
	}

	public async Task<PaymentsApiTypes.PaymentsPayoutResponse> PayoutAsync(PaymentsApiTypes.PaymentsPayoutBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/balance/payout",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PaymentsApiTypes.PaymentsPayoutResponse(__result);
	}
}

public sealed class AutoPaymentsApi
{
	private readonly LolzteamHttpClient _http;

	public AutoPaymentsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<AutoPaymentsApiTypes.AutoPaymentsListResponse> ListAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/auto-payments",
		}, cancellationToken).ConfigureAwait(false);
		return new AutoPaymentsApiTypes.AutoPaymentsListResponse(__result);
	}

	public async Task<AutoPaymentsApiTypes.AutoPaymentsCreateResponse> CreateAsync(AutoPaymentsApiTypes.AutoPaymentsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/auto-payment",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new AutoPaymentsApiTypes.AutoPaymentsCreateResponse(__result);
	}

	public async Task<AutoPaymentsApiTypes.AutoPaymentsDeleteResponse> DeleteAsync(AutoPaymentsApiTypes.AutoPaymentsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/auto-payment",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new AutoPaymentsApiTypes.AutoPaymentsDeleteResponse(__result);
	}
}

public sealed class ProxyApi
{
	private readonly LolzteamHttpClient _http;

	public ProxyApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ProxyApiTypes.ProxyGetResponse> GetAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/proxy",
		}, cancellationToken).ConfigureAwait(false);
		return new ProxyApiTypes.ProxyGetResponse(__result);
	}

	public async Task<ProxyApiTypes.ProxyAddResponse> AddAsync(ProxyApiTypes.ProxyAddBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/proxy",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ProxyApiTypes.ProxyAddResponse(__result);
	}

	public async Task<ProxyApiTypes.ProxyDeleteResponse> DeleteAsync(ProxyApiTypes.ProxyDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/proxy",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ProxyApiTypes.ProxyDeleteResponse(__result);
	}
}

public sealed class ImapApi
{
	private readonly LolzteamHttpClient _http;

	public ImapApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ImapApiTypes.ImapCreateResponse> CreateAsync(ImapApiTypes.ImapCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/imap",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ImapApiTypes.ImapCreateResponse(__result);
	}

	public async Task<ImapApiTypes.ImapDeleteResponse> DeleteAsync(ImapApiTypes.ImapDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/imap",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ImapApiTypes.ImapDeleteResponse(__result);
	}
}

public sealed class BatchApi
{
	private readonly LolzteamHttpClient _http;

	public BatchApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<BatchApiTypes.BatchBatchResponse> BatchAsync(List<JsonElement> body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/batch",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new BatchApiTypes.BatchBatchResponse(__result);
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
