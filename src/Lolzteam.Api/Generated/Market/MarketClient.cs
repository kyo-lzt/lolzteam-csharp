// Auto-generated. Do not edit manually.

using System.Text.Json;
using Lolzteam.Api.Runtime;

namespace Lolzteam.Api.Generated.Market;

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
		return JsonSerializer.Deserialize<AutoPaymentsApiTypes.AutoPaymentsListResponse>(__result)!;
	}

	public async Task<AutoPaymentsApiTypes.AutoPaymentsCreateResponse> CreateAsync(AutoPaymentsApiTypes.AutoPaymentsCreateBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/auto-payment",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<AutoPaymentsApiTypes.AutoPaymentsCreateResponse>(__result)!;
	}

	public async Task<AutoPaymentsApiTypes.AutoPaymentsDeleteResponse> DeleteAsync(AutoPaymentsApiTypes.AutoPaymentsDeleteBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/auto-payment",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<AutoPaymentsApiTypes.AutoPaymentsDeleteResponse>(__result)!;
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
		return JsonSerializer.Deserialize<BatchApiTypes.BatchBatchResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CartApiTypes.CartGetResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CartApiTypes.CartAddResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CartApiTypes.CartDeleteResponse>(__result)!;
	}
}

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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryAllResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategorySteamResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryFortniteResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryMihoyoResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryRiotResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryTelegramResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategorySupercellResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryEaResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryWotResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryWotBlitzResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryGiftsResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryEpicGamesResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryEscapeFromTarkovResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategorySocialClubResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryUplayResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryDiscordResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryTikTokResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryInstagramResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryBattleNetResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryChatGPTResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryVpnResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryRobloxResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryWarfaceResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryMinecraftResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryHytaleResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryListResponse>(__result)!;
	}

	public async Task<CategoryApiTypes.CategoryParamsResponse> ParamsAsync(string CategoryName, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{CategoryName}/params",
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryParamsResponse>(__result)!;
	}

	public async Task<CategoryApiTypes.CategoryGamesResponse> GamesAsync(string CategoryName, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{CategoryName}/games",
			IsSearch = true,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<CategoryApiTypes.CategoryGamesResponse>(__result)!;
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
		return JsonSerializer.Deserialize<CustomDiscountsApiTypes.CustomDiscountsGetResponse>(__result)!;
	}

	public async Task<CustomDiscountsApiTypes.CustomDiscountsCreateResponse> CreateAsync(CustomDiscountsApiTypes.CustomDiscountsCreateBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/custom-discounts",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<CustomDiscountsApiTypes.CustomDiscountsCreateResponse>(__result)!;
	}

	public async Task<CustomDiscountsApiTypes.CustomDiscountsEditResponse> EditAsync(CustomDiscountsApiTypes.CustomDiscountsEditBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = "/custom-discounts",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<CustomDiscountsApiTypes.CustomDiscountsEditResponse>(__result)!;
	}

	public async Task<CustomDiscountsApiTypes.CustomDiscountsDeleteResponse> DeleteAsync(CustomDiscountsApiTypes.CustomDiscountsDeleteBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/custom-discounts",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<CustomDiscountsApiTypes.CustomDiscountsDeleteResponse>(__result)!;
	}
}

public sealed class ImapApi
{
	private readonly LolzteamHttpClient _http;

	public ImapApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ImapApiTypes.ImapCreateResponse> CreateAsync(ImapApiTypes.ImapCreateBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/imap",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ImapApiTypes.ImapCreateResponse>(__result)!;
	}

	public async Task<ImapApiTypes.ImapDeleteResponse> DeleteAsync(ImapApiTypes.ImapDeleteBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/imap",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ImapApiTypes.ImapDeleteResponse>(__result)!;
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
		return JsonSerializer.Deserialize<ListApiTypes.ListUserResponse>(__result)!;
	}

	public async Task<ListApiTypes.ListOrdersResponse> OrdersAsync(ListApiTypes.ListOrdersParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/user/orders",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ListApiTypes.ListOrdersResponse>(__result)!;
	}

	public async Task<ListApiTypes.ListStatesResponse> StatesAsync(ListApiTypes.ListStatesParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/user/item-states",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ListApiTypes.ListStatesResponse>(__result)!;
	}

	public async Task<ListApiTypes.ListDownloadResponse> DownloadAsync(string Type, ListApiTypes.ListDownloadParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestRawAsync(new RequestOptions
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
		return JsonSerializer.Deserialize<ListApiTypes.ListFavoritesResponse>(__result)!;
	}

	public async Task<ListApiTypes.ListViewedResponse> ViewedAsync(ListApiTypes.ListViewedParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/viewed",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ListApiTypes.ListViewedResponse>(__result)!;
	}
}

public sealed class ManagingApi
{
	private readonly LolzteamHttpClient _http;

	public ManagingApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ManagingApiTypes.ManagingGetResponse> GetAsync(long ItemId, ManagingApiTypes.ManagingGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingGetResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingDeleteResponse> DeleteAsync(long ItemId, ManagingApiTypes.ManagingDeleteBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingDeleteResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingCreateClaimResponse> CreateClaimAsync(ManagingApiTypes.ManagingCreateClaimBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/claims",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingCreateClaimResponse>(__result)!;
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
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingBulkGetResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingSteamInventoryValueResponse> SteamInventoryValueAsync(long ItemId, ManagingApiTypes.ManagingSteamInventoryValueParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/inventory-value",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingSteamInventoryValueResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingSteamValueResponse> SteamValueAsync(ManagingApiTypes.ManagingSteamValueParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/steam-value",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingSteamValueResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingSteamPreviewResponse> SteamPreviewAsync(long ItemId, ManagingApiTypes.ManagingSteamPreviewParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestRawAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/steam-preview",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingSteamPreviewResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingEditResponse> EditAsync(long ItemId, ManagingApiTypes.ManagingEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = $"/{ItemId}/edit",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingEditResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingAIPriceResponse> AIPriceAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/ai-price",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingAIPriceResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingAutoBuyPriceResponse> AutoBuyPriceAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/auto-buy-price",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingAutoBuyPriceResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingNoteResponse> NoteAsync(long ItemId, ManagingApiTypes.ManagingNoteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/note-save",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingNoteResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingSteamUpdateValueResponse> SteamUpdateValueAsync(long ItemId, ManagingApiTypes.ManagingSteamUpdateValueBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/update-inventory",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingSteamUpdateValueResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingBumpResponse> BumpAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/bump",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingBumpResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingAutoBumpResponse> AutoBumpAsync(long ItemId, ManagingApiTypes.ManagingAutoBumpBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/auto-bump",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingAutoBumpResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingAutoBumpDisableResponse> AutoBumpDisableAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/auto-bump",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingAutoBumpDisableResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingOpenResponse> OpenAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/open",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingOpenResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingCloseResponse> CloseAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/close",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingCloseResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingImageResponse> ImageAsync(long ItemId, ManagingApiTypes.ManagingImageParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/image",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingImageResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingEmailCodeResponse> EmailCodeAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/email-code",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingEmailCodeResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingGetLetters2Response> GetLetters2Async(ManagingApiTypes.ManagingGetLetters2Params? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/letters2",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingGetLetters2Response>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingSteamGetMafileResponse> SteamGetMafileAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/mafile",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingSteamGetMafileResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingSteamAddMafileResponse> SteamAddMafileAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/mafile",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingSteamAddMafileResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingSteamRemoveMafileResponse> SteamRemoveMafileAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/mafile",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingSteamRemoveMafileResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingSteamMafileCodeResponse> SteamMafileCodeAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/guard-code",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingSteamMafileCodeResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingSteamSDAResponse> SteamSDAAsync(long ItemId, ManagingApiTypes.ManagingSteamSDABody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/confirm-sda",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingSteamSDAResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingTelegramCodeResponse> TelegramCodeAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/telegram-login-code",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingTelegramCodeResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingTelegramResetAuthResponse> TelegramResetAuthAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/telegram-reset-authorizations",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingTelegramResetAuthResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingRefuseGuaranteeResponse> RefuseGuaranteeAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/refuse-guarantee",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingRefuseGuaranteeResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingDeclineVideoRecordingResponse> DeclineVideoRecordingAsync(long ItemId, ManagingApiTypes.ManagingDeclineVideoRecordingBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/decline-video-recording",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingDeclineVideoRecordingResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingCheckGuaranteeResponse> CheckGuaranteeAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/check-guarantee",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingCheckGuaranteeResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingChangePasswordResponse> ChangePasswordAsync(long ItemId, ManagingApiTypes.ManagingChangePasswordBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/change-password",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingChangePasswordResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingTempEmailPasswordResponse> TempEmailPasswordAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/temp-email-password",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingTempEmailPasswordResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingTagResponse> TagAsync(long ItemId, ManagingApiTypes.ManagingTagBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/tag",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingTagResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingUntagResponse> UntagAsync(long ItemId, ManagingApiTypes.ManagingUntagBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/tag",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingUntagResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingPublicTagResponse> PublicTagAsync(long ItemId, ManagingApiTypes.ManagingPublicTagBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/public-tag",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingPublicTagResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingPublicUntagResponse> PublicUntagAsync(long ItemId, ManagingApiTypes.ManagingPublicUntagBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/public-tag",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingPublicUntagResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingFavoriteResponse> FavoriteAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/star",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingFavoriteResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingUnfavoriteResponse> UnfavoriteAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/star",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingUnfavoriteResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingStickResponse> StickAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/stick",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingStickResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingUnstickResponse> UnstickAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/stick",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingUnstickResponse>(__result)!;
	}

	public async Task<ManagingApiTypes.ManagingTransferResponse> TransferAsync(long ItemId, ManagingApiTypes.ManagingTransferBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/change-owner",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ManagingApiTypes.ManagingTransferResponse>(__result)!;
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
		return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsInvoiceGetResponse>(__result)!;
	}

	public async Task<PaymentsApiTypes.PaymentsInvoiceCreateResponse> InvoiceCreateAsync(PaymentsApiTypes.PaymentsInvoiceCreateBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/invoice",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsInvoiceCreateResponse>(__result)!;
	}

	public async Task<PaymentsApiTypes.PaymentsInvoiceListResponse> InvoiceListAsync(PaymentsApiTypes.PaymentsInvoiceListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/invoice/list",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsInvoiceListResponse>(__result)!;
	}

	public async Task<PaymentsApiTypes.PaymentsCurrencyResponse> CurrencyAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/currency",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsCurrencyResponse>(__result)!;
	}

	public async Task<PaymentsApiTypes.PaymentsBalanceListResponse> BalanceListAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/balance/exchange",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsBalanceListResponse>(__result)!;
	}

	public async Task<PaymentsApiTypes.PaymentsBalanceExchangeResponse> BalanceExchangeAsync(PaymentsApiTypes.PaymentsBalanceExchangeBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/balance/exchange",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsBalanceExchangeResponse>(__result)!;
	}

	public async Task<PaymentsApiTypes.PaymentsTransferResponse> TransferAsync(PaymentsApiTypes.PaymentsTransferBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/balance/transfer",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsTransferResponse>(__result)!;
	}

	public async Task<PaymentsApiTypes.PaymentsFeeResponse> FeeAsync(PaymentsApiTypes.PaymentsFeeParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/balance/transfer/fee",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsFeeResponse>(__result)!;
	}

	public async Task<PaymentsApiTypes.PaymentsCancelResponse> CancelAsync(PaymentsApiTypes.PaymentsCancelBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/balance/transfer/cancel",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsCancelResponse>(__result)!;
	}

	public async Task<PaymentsApiTypes.PaymentsHistoryResponse> HistoryAsync(PaymentsApiTypes.PaymentsHistoryParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/user/payments",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsHistoryResponse>(__result)!;
	}

	public async Task<PaymentsApiTypes.PaymentsPayoutServicesResponse> PayoutServicesAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/balance/payout/services",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsPayoutServicesResponse>(__result)!;
	}

	public async Task<PaymentsApiTypes.PaymentsPayoutResponse> PayoutAsync(PaymentsApiTypes.PaymentsPayoutBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/balance/payout",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsPayoutResponse>(__result)!;
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
		return JsonSerializer.Deserialize<ProfileApiTypes.ProfileClaimsResponse>(__result)!;
	}

	public async Task<ProfileApiTypes.ProfileGetResponse> GetAsync(ProfileApiTypes.ProfileGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/me",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<ProfileApiTypes.ProfileGetResponse>(__result)!;
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
		return JsonSerializer.Deserialize<ProfileApiTypes.ProfileEditResponse>(__result)!;
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
		return JsonSerializer.Deserialize<ProxyApiTypes.ProxyGetResponse>(__result)!;
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
		return JsonSerializer.Deserialize<ProxyApiTypes.ProxyAddResponse>(__result)!;
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
		return JsonSerializer.Deserialize<ProxyApiTypes.ProxyDeleteResponse>(__result)!;
	}
}

public sealed class PublishingApi
{
	private readonly LolzteamHttpClient _http;

	public PublishingApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<PublishingApiTypes.PublishingFastSellResponse> FastSellAsync(PublishingApiTypes.PublishingFastSellBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/item/fast-sell",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PublishingApiTypes.PublishingFastSellResponse>(__result)!;
	}

	public async Task<PublishingApiTypes.PublishingAddResponse> AddAsync(PublishingApiTypes.PublishingAddBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/item/add",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PublishingApiTypes.PublishingAddResponse>(__result)!;
	}

	public async Task<PublishingApiTypes.PublishingCheckResponse> CheckAsync(long ItemId, PublishingApiTypes.PublishingCheckBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/goods/check",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PublishingApiTypes.PublishingCheckResponse>(__result)!;
	}

	public async Task<PublishingApiTypes.PublishingExternalResponse> ExternalAsync(long ItemId, PublishingApiTypes.PublishingExternalBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/external-account",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PublishingApiTypes.PublishingExternalResponse>(__result)!;
	}
}

public sealed class PurchasingApi
{
	private readonly LolzteamHttpClient _http;

	public PurchasingApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<PurchasingApiTypes.PurchasingFastBuyResponse> FastBuyAsync(long ItemId, PurchasingApiTypes.PurchasingFastBuyBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/fast-buy",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PurchasingApiTypes.PurchasingFastBuyResponse>(__result)!;
	}

	public async Task<PurchasingApiTypes.PurchasingCheckResponse> CheckAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/check-account",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PurchasingApiTypes.PurchasingCheckResponse>(__result)!;
	}

	public async Task<PurchasingApiTypes.PurchasingConfirmResponse> ConfirmAsync(long ItemId, PurchasingApiTypes.PurchasingConfirmBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/confirm-buy",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PurchasingApiTypes.PurchasingConfirmResponse>(__result)!;
	}

	public async Task<PurchasingApiTypes.PurchasingDiscountRequestResponse> DiscountRequestAsync(long ItemId, PurchasingApiTypes.PurchasingDiscountRequestBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/discount",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PurchasingApiTypes.PurchasingDiscountRequestResponse>(__result)!;
	}

	public async Task<PurchasingApiTypes.PurchasingDiscountCancelResponse> DiscountCancelAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/discount",
		}, cancellationToken).ConfigureAwait(false);
		return JsonSerializer.Deserialize<PurchasingApiTypes.PurchasingDiscountCancelResponse>(__result)!;
	}
}

public sealed class MarketClient : IDisposable
{
	public AutoPaymentsApi AutoPayments { get; }
	public BatchApi Batch { get; }
	public CartApi Cart { get; }
	public CategoryApi Category { get; }
	public CustomDiscountsApi CustomDiscounts { get; }
	public ImapApi Imap { get; }
	public ListApi List { get; }
	public ManagingApi Managing { get; }
	public PaymentsApi Payments { get; }
	public ProfileApi Profile { get; }
	public ProxyApi Proxy { get; }
	public PublishingApi Publishing { get; }
	public PurchasingApi Purchasing { get; }

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

		AutoPayments = new AutoPaymentsApi(_http);
		Batch = new BatchApi(_http);
		Cart = new CartApi(_http);
		Category = new CategoryApi(_http);
		CustomDiscounts = new CustomDiscountsApi(_http);
		Imap = new ImapApi(_http);
		List = new ListApi(_http);
		Managing = new ManagingApi(_http);
		Payments = new PaymentsApi(_http);
		Profile = new ProfileApi(_http);
		Proxy = new ProxyApi(_http);
		Publishing = new PublishingApi(_http);
		Purchasing = new PurchasingApi(_http);
	}

	public void Dispose()
	{
		_http.Dispose();
	}
}
