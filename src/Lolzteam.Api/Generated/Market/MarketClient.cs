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

    /// <summary>Get Auto Payments</summary>
    /// <remarks>
    /// Get auto payments list.
    /// 
    /// Required scopes:
    /// + payment
    /// </remarks>
    public async Task<AutoPaymentsApiTypes.AutoPaymentsListResponse> ListAsync(CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/auto-payments",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<AutoPaymentsApiTypes.AutoPaymentsListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Create Auto Payment</summary>
    /// <remarks>
    /// Creates auto payment.
    /// 
    /// Required scopes:
    /// + payment
    /// </remarks>
    public async Task<AutoPaymentsApiTypes.AutoPaymentsCreateResponse> CreateAsync(AutoPaymentsApiTypes.AutoPaymentsCreateBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/auto-payment",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<AutoPaymentsApiTypes.AutoPaymentsCreateResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Delete Auto Payment</summary>
    /// <remarks>
    /// Deletes an auto payment.
    /// 
    /// Required scopes:
    /// + payment
    /// </remarks>
    public async Task<AutoPaymentsApiTypes.AutoPaymentsDeleteResponse> DeleteAsync(AutoPaymentsApiTypes.AutoPaymentsDeleteBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = "/auto-payment",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<AutoPaymentsApiTypes.AutoPaymentsDeleteResponse>(__result, JsonDefaults.Options)!;
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
    /// Execute multiple API requests at once (separated by comma). Maximum batch jobs is 10.
    /// Following methods are unavailable in Batch:
    /// - GET /{item_id}/image
    /// - /item/fast-sell
    /// </remarks>
    public async Task<BatchApiTypes.BatchBatchResponse> BatchAsync(List<JsonElement> body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/batch",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<BatchApiTypes.BatchBatchResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class CartApi
{
    private readonly LolzteamHttpClient _http;

    public CartApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Cart Items</summary>
    /// <remarks>
    /// Returns the list of items currently in your cart.
    /// </remarks>
    public async Task<CartApiTypes.CartGetResponse> GetAsync(CartApiTypes.CartGetParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/cart",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CartApiTypes.CartGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Add Item to Cart</summary>
    /// <remarks>
    /// Adds item to your cart.
    /// </remarks>
    public async Task<CartApiTypes.CartAddResponse> AddAsync(CartApiTypes.CartAddBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/cart",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CartApiTypes.CartAddResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Delete Item From Cart</summary>
    /// <remarks>
    /// Deletes an item from the cart.
    /// </remarks>
    public async Task<CartApiTypes.CartDeleteResponse> DeleteAsync(CartApiTypes.CartDeleteBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = "/cart",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CartApiTypes.CartDeleteResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class CategoryApi
{
    private readonly LolzteamHttpClient _http;

    public CategoryApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Last Accounts</summary>
    /// <remarks>
    /// Displays a list of latest accounts.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryAllResponse> AllAsync(CategoryApiTypes.CategoryAllParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryAllResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Steam</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategorySteamResponse> SteamAsync(CategoryApiTypes.CategorySteamParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/steam",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategorySteamResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Fortnite</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryFortniteResponse> FortniteAsync(CategoryApiTypes.CategoryFortniteParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/fortnite",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryFortniteResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>miHoYo</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryMihoyoResponse> MihoyoAsync(CategoryApiTypes.CategoryMihoyoParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/mihoyo",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryMihoyoResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Riot</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryRiotResponse> RiotAsync(CategoryApiTypes.CategoryRiotParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/riot",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryRiotResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Telegram</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryTelegramResponse> TelegramAsync(CategoryApiTypes.CategoryTelegramParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/telegram",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryTelegramResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Supercell</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategorySupercellResponse> SupercellAsync(CategoryApiTypes.CategorySupercellParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/supercell",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategorySupercellResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>EA (Origin)</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryEaResponse> EaAsync(CategoryApiTypes.CategoryEaParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/ea",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryEaResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>World of Tanks</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryWotResponse> WotAsync(CategoryApiTypes.CategoryWotParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/world-of-tanks",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryWotResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>WoT Blitz</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryWotBlitzResponse> WotBlitzAsync(CategoryApiTypes.CategoryWotBlitzParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/wot-blitz",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryWotBlitzResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Gifts</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryGiftsResponse> GiftsAsync(CategoryApiTypes.CategoryGiftsParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/gifts",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryGiftsResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Epic Games</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryEpicGamesResponse> EpicGamesAsync(CategoryApiTypes.CategoryEpicGamesParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/epicgames",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryEpicGamesResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Escape from Tarkov</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryEscapeFromTarkovResponse> EscapeFromTarkovAsync(CategoryApiTypes.CategoryEscapeFromTarkovParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/escape-from-tarkov",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryEscapeFromTarkovResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Social Club</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategorySocialClubResponse> SocialClubAsync(CategoryApiTypes.CategorySocialClubParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/socialclub",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategorySocialClubResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Uplay</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryUplayResponse> UplayAsync(CategoryApiTypes.CategoryUplayParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/uplay",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryUplayResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Discord</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryDiscordResponse> DiscordAsync(CategoryApiTypes.CategoryDiscordParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/discord",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryDiscordResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>TikTok</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryTikTokResponse> TikTokAsync(CategoryApiTypes.CategoryTikTokParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/tiktok",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryTikTokResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Instagram</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryInstagramResponse> InstagramAsync(CategoryApiTypes.CategoryInstagramParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/instagram",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryInstagramResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>BattleNet</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryBattleNetResponse> BattleNetAsync(CategoryApiTypes.CategoryBattleNetParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/battlenet",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryBattleNetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>ChatGPT</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryChatGPTResponse> ChatGPTAsync(CategoryApiTypes.CategoryChatGPTParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/chatgpt",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryChatGPTResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>VPN</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryVpnResponse> VpnAsync(CategoryApiTypes.CategoryVpnParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/vpn",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryVpnResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Roblox</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryRobloxResponse> RobloxAsync(CategoryApiTypes.CategoryRobloxParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/roblox",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryRobloxResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Warface</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryWarfaceResponse> WarfaceAsync(CategoryApiTypes.CategoryWarfaceParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/warface",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryWarfaceResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Minecraft</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryMinecraftResponse> MinecraftAsync(CategoryApiTypes.CategoryMinecraftParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/minecraft",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryMinecraftResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Hytale</summary>
    /// <remarks>
    /// Displays a list of accounts in a specific category according to your parameters.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryHytaleResponse> HytaleAsync(CategoryApiTypes.CategoryHytaleParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/hytale",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryHytaleResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Categories</summary>
    /// <remarks>
    /// Display category list.
    /// </remarks>
    public async Task<CategoryApiTypes.CategoryListResponse> ListAsync(CategoryApiTypes.CategoryListParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/category",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Category Search Params</summary>
    /// <remarks>
    /// Displays search parameters for a category.
    /// </remarks>
    /// <param name="CategoryName">Category name.</param>
    public async Task<CategoryApiTypes.CategoryParamsResponse> ParamsAsync(string CategoryName, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/{CategoryName}/params",
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryParamsResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Category Games</summary>
    /// <remarks>
    /// Displays a list of games in the category.
    /// </remarks>
    /// <param name="CategoryName">Category name.</param>
    public async Task<CategoryApiTypes.CategoryGamesResponse> GamesAsync(string CategoryName, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/{CategoryName}/games",
            IsSearch = true,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CategoryApiTypes.CategoryGamesResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class CustomDiscountsApi
{
    private readonly LolzteamHttpClient _http;

    public CustomDiscountsApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Custom Discounts</summary>
    /// <remarks>
    /// Get a list of custom discounts.
    /// </remarks>
    public async Task<CustomDiscountsApiTypes.CustomDiscountsGetResponse> GetAsync(CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/custom-discounts",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CustomDiscountsApiTypes.CustomDiscountsGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Create Custom Discount</summary>
    /// <remarks>
    /// Creates a new custom discount.
    /// </remarks>
    public async Task<CustomDiscountsApiTypes.CustomDiscountsCreateResponse> CreateAsync(CustomDiscountsApiTypes.CustomDiscountsCreateBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/custom-discounts",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CustomDiscountsApiTypes.CustomDiscountsCreateResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Edit Custom Discount</summary>
    /// <remarks>
    /// Edit an existing custom discount.
    /// </remarks>
    public async Task<CustomDiscountsApiTypes.CustomDiscountsEditResponse> EditAsync(CustomDiscountsApiTypes.CustomDiscountsEditBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "PUT",
            Path = "/custom-discounts",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CustomDiscountsApiTypes.CustomDiscountsEditResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Delete Custom Discount</summary>
    /// <remarks>
    /// Delete an existing custom discount.
    /// </remarks>
    public async Task<CustomDiscountsApiTypes.CustomDiscountsDeleteResponse> DeleteAsync(CustomDiscountsApiTypes.CustomDiscountsDeleteBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = "/custom-discounts",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<CustomDiscountsApiTypes.CustomDiscountsDeleteResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class ImapApi
{
    private readonly LolzteamHttpClient _http;

    public ImapApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Create IMAP Configuration</summary>
    /// <remarks>
    /// Create an IMAP configuration for a domain.
    /// </remarks>
    public async Task<ImapApiTypes.ImapCreateResponse> CreateAsync(ImapApiTypes.ImapCreateBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/imap",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ImapApiTypes.ImapCreateResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Delete IMAP Configuration</summary>
    /// <remarks>
    /// Delete an IMAP configuration for a domain.
    /// </remarks>
    public async Task<ImapApiTypes.ImapDeleteResponse> DeleteAsync(ImapApiTypes.ImapDeleteBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = "/imap",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ImapApiTypes.ImapDeleteResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class ListApi
{
    private readonly LolzteamHttpClient _http;

    public ListApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get All User Accounts</summary>
    /// <remarks>
    /// Displays a list of user accounts.
    /// </remarks>
    public async Task<ListApiTypes.ListUserResponse> UserAsync(ListApiTypes.ListUserParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/user/items",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ListApiTypes.ListUserResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get All Purchased Accounts</summary>
    /// <remarks>
    /// Displays a list of purchased accounts.
    /// </remarks>
    public async Task<ListApiTypes.ListOrdersResponse> OrdersAsync(ListApiTypes.ListOrdersParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/user/orders",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ListApiTypes.ListOrdersResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get User Items States</summary>
    /// <remarks>
    /// Returns the states of user items.
    /// </remarks>
    public async Task<ListApiTypes.ListStatesResponse> StatesAsync(ListApiTypes.ListStatesParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/user/item-states",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ListApiTypes.ListStatesResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Download Accounts Data</summary>
    /// <remarks>
    /// Download accounts data in the specified format.
    /// </remarks>
    /// <param name="Type">The type of account list to download.</param>
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

    /// <summary>Get All Favourites Accounts</summary>
    /// <remarks>
    /// Displays a list of favourites accounts.
    /// </remarks>
    public async Task<ListApiTypes.ListFavoritesResponse> FavoritesAsync(ListApiTypes.ListFavoritesParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/fave",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ListApiTypes.ListFavoritesResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get All Viewed Accounts</summary>
    /// <remarks>
    /// Displays a list of viewed accounts.
    /// </remarks>
    public async Task<ListApiTypes.ListViewedResponse> ViewedAsync(ListApiTypes.ListViewedParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/viewed",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ListApiTypes.ListViewedResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class ManagingApi
{
    private readonly LolzteamHttpClient _http;

    public ManagingApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Account</summary>
    /// <remarks>
    /// Displays account information.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingGetResponse> GetAsync(long ItemId, ManagingApiTypes.ManagingGetParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/{ItemId}",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Delete Account</summary>
    /// <remarks>
    /// Deletes your account from public search. Deletion type is soft. You can restore account after deletion if you want.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingDeleteResponse> DeleteAsync(long ItemId, ManagingApiTypes.ManagingDeleteBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/{ItemId}",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingDeleteResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Create Claim</summary>
    /// <remarks>
    /// Create a claim.
    /// </remarks>
    public async Task<ManagingApiTypes.ManagingCreateClaimResponse> CreateClaimAsync(ManagingApiTypes.ManagingCreateClaimBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/claims",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingCreateClaimResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Bulk Get Accounts</summary>
    /// <remarks>
    /// Bulk get up to 250 accounts.
    /// </remarks>
    public async Task<ManagingApiTypes.ManagingBulkGetResponse> BulkGetAsync(ManagingApiTypes.ManagingBulkGetBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/bulk/items",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingBulkGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Account Steam Inventory Value</summary>
    /// <remarks>
    /// Gets Account steam inventory value.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingSteamInventoryValueResponse> SteamInventoryValueAsync(long ItemId, ManagingApiTypes.ManagingSteamInventoryValueParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/{ItemId}/inventory-value",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingSteamInventoryValueResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Steam Inventory Value</summary>
    /// <remarks>
    /// Gets steam inventory value.
    /// &gt; 📘 This method is rate limited. You can send 20 requests per minute (3s delay between requests)
    /// </remarks>
    public async Task<ManagingApiTypes.ManagingSteamValueResponse> SteamValueAsync(ManagingApiTypes.ManagingSteamValueParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/steam-value",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingSteamValueResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Steam HTML</summary>
    /// <remarks>
    /// Returns Steam account profile/games preview.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
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

    /// <summary>Edit Account</summary>
    /// <remarks>
    /// Edits any details of account.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingEditResponse> EditAsync(long ItemId, ManagingApiTypes.ManagingEditBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "PUT",
            Path = $"/{ItemId}/edit",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingEditResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get AI Price</summary>
    /// <remarks>
    /// Get AI-suggested price for the account.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingAIPriceResponse> AIPriceAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/{ItemId}/ai-price",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingAIPriceResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Auto Buy Price</summary>
    /// <remarks>
    /// Get auto buy price for the account.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingAutoBuyPriceResponse> AutoBuyPriceAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/{ItemId}/auto-buy-price",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingAutoBuyPriceResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Edit Note</summary>
    /// <remarks>
    /// Edits a note for the account.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingNoteResponse> NoteAsync(long ItemId, ManagingApiTypes.ManagingNoteBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/note-save",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingNoteResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Update Inventory Value</summary>
    /// <remarks>
    /// Update inventory value.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingSteamUpdateValueResponse> SteamUpdateValueAsync(long ItemId, ManagingApiTypes.ManagingSteamUpdateValueBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/update-inventory",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingSteamUpdateValueResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Bump Account</summary>
    /// <remarks>
    /// Bumps account in the search.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingBumpResponse> BumpAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/bump",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingBumpResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Auto Bump</summary>
    /// <remarks>
    /// Enables/edits automatic bumping for the specified account.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingAutoBumpResponse> AutoBumpAsync(long ItemId, ManagingApiTypes.ManagingAutoBumpBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/auto-bump",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingAutoBumpResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Disable Auto Bump</summary>
    /// <remarks>
    /// Disables automatic bumping for the specified account.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingAutoBumpDisableResponse> AutoBumpDisableAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/{ItemId}/auto-bump",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingAutoBumpDisableResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Open Account</summary>
    /// <remarks>
    /// Opens account.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingOpenResponse> OpenAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/open",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingOpenResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Close Account</summary>
    /// <remarks>
    /// Closes account.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingCloseResponse> CloseAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/close",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingCloseResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Account Image</summary>
    /// <remarks>
    /// Get account image.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingImageResponse> ImageAsync(long ItemId, ManagingApiTypes.ManagingImageParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/{ItemId}/image",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingImageResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Email Confirmation Code</summary>
    /// <remarks>
    /// Gets confirmation code or link.
    /// 
    /// &gt; ❗️ If you receive a &quot;retry_request&quot; error, you should repeat the same request (up to a maximum of 100 times)
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingEmailCodeResponse> EmailCodeAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/{ItemId}/email-code",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingEmailCodeResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Email Letters</summary>
    /// <remarks>
    /// Returns account letters.
    /// 
    /// &gt; ❗️ If you receive a &quot;retry_request&quot; error, you should repeat the same request (up to a maximum of 100 times)
    /// </remarks>
    public async Task<ManagingApiTypes.ManagingGetLetters2Response> GetLetters2Async(ManagingApiTypes.ManagingGetLetters2Params? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/letters2",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingGetLetters2Response>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Mafile</summary>
    /// <remarks>
    /// Returns steam mafile.
    /// &gt; ❗️ This action is cancelling active account guarantee
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingSteamGetMafileResponse> SteamGetMafileAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/{ItemId}/mafile",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingSteamGetMafileResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Add Mafile</summary>
    /// <remarks>
    /// Add a new Steam mafile to the account.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingSteamAddMafileResponse> SteamAddMafileAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/mafile",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingSteamAddMafileResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Remove Mafile</summary>
    /// <remarks>
    /// Remove steam mafile.
    /// &gt; ❗️ This will unlink the authenticator from the account and remove mafile from the item
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingSteamRemoveMafileResponse> SteamRemoveMafileAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/{ItemId}/mafile",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingSteamRemoveMafileResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Mafile Confirmation Code</summary>
    /// <remarks>
    /// Gets confirmation code from MaFile (Only for Steam accounts).
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingSteamMafileCodeResponse> SteamMafileCodeAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/{ItemId}/guard-code",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingSteamMafileCodeResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Confirm SDA</summary>
    /// <remarks>
    /// Confirm steam action. 
    /// 
    ///  Don't set id and nonce parameters to get list of available confirmation requests. 
    /// 
    /// &gt; ❗️ This action is cancelling active account guarantee
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingSteamSDAResponse> SteamSDAAsync(long ItemId, ManagingApiTypes.ManagingSteamSDABody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/confirm-sda",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingSteamSDAResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Telegram Confirmation Code</summary>
    /// <remarks>
    /// Gets confirmation code from Telegram.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingTelegramCodeResponse> TelegramCodeAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/{ItemId}/telegram-login-code",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingTelegramCodeResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Telegram Reset Auth</summary>
    /// <remarks>
    /// Resets Telegram authorizations.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingTelegramResetAuthResponse> TelegramResetAuthAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/telegram-reset-authorizations",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingTelegramResetAuthResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Cancel Guarantee</summary>
    /// <remarks>
    /// Cancel guarantee of account. It can be useful for account reselling.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingRefuseGuaranteeResponse> RefuseGuaranteeAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/refuse-guarantee",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingRefuseGuaranteeResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Decline Video Recording Request</summary>
    /// <remarks>
    /// Waiver of the requirement to record a video and any claims regarding this account.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingDeclineVideoRecordingResponse> DeclineVideoRecordingAsync(long ItemId, ManagingApiTypes.ManagingDeclineVideoRecordingBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/decline-video-recording",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingDeclineVideoRecordingResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Check Guarantee</summary>
    /// <remarks>
    /// Checks the guarantee and cancels it if there are reasons to cancel it.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingCheckGuaranteeResponse> CheckGuaranteeAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/check-guarantee",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingCheckGuaranteeResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Change Password</summary>
    /// <remarks>
    /// Changes password of account.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingChangePasswordResponse> ChangePasswordAsync(long ItemId, ManagingApiTypes.ManagingChangePasswordBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/change-password",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingChangePasswordResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Temp Email Password</summary>
    /// <remarks>
    /// Gets password from temp email of account. After calling of this method, the guarantee will be cancelled and you cannot automatically resell account.
    /// &gt; ❗️ This action is cancelling active account guarantee
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingTempEmailPasswordResponse> TempEmailPasswordAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = $"/{ItemId}/temp-email-password",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingTempEmailPasswordResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Add a Tag</summary>
    /// <remarks>
    /// Adds a tag to the specified account.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingTagResponse> TagAsync(long ItemId, ManagingApiTypes.ManagingTagBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/tag",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingTagResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Remove a Tag</summary>
    /// <remarks>
    /// Removes a tag from from the specified account.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingUntagResponse> UntagAsync(long ItemId, ManagingApiTypes.ManagingUntagBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/{ItemId}/tag",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingUntagResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Add a Public Tag</summary>
    /// <remarks>
    /// Adds a public tag to the specified account.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingPublicTagResponse> PublicTagAsync(long ItemId, ManagingApiTypes.ManagingPublicTagBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/public-tag",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingPublicTagResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Remove a Public Tag</summary>
    /// <remarks>
    /// Removes a public tag from the specified account.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingPublicUntagResponse> PublicUntagAsync(long ItemId, ManagingApiTypes.ManagingPublicUntagBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/{ItemId}/public-tag",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingPublicUntagResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Favorite</summary>
    /// <remarks>
    /// Adds account to favorites.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingFavoriteResponse> FavoriteAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/star",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingFavoriteResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Unfavorite</summary>
    /// <remarks>
    /// Delete account from favorites.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingUnfavoriteResponse> UnfavoriteAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/{ItemId}/star",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingUnfavoriteResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Stick Account</summary>
    /// <remarks>
    /// Stick account in the top of search.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingStickResponse> StickAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/stick",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingStickResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Unstick Account</summary>
    /// <remarks>
    /// Unstick account from the top of search.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingUnstickResponse> UnstickAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/{ItemId}/stick",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingUnstickResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Change Account Owner</summary>
    /// <remarks>
    /// Transfer account to another user.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<ManagingApiTypes.ManagingTransferResponse> TransferAsync(long ItemId, ManagingApiTypes.ManagingTransferBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/change-owner",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ManagingApiTypes.ManagingTransferResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class PaymentsApi
{
    private readonly LolzteamHttpClient _http;

    public PaymentsApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Invoice</summary>
    /// <remarks>
    /// Get invoice.
    /// 
    /// Required scopes:
    /// + invoice
    /// </remarks>
    public async Task<PaymentsApiTypes.PaymentsInvoiceGetResponse> InvoiceGetAsync(PaymentsApiTypes.PaymentsInvoiceGetParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/invoice",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsInvoiceGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Create Invoice</summary>
    /// <remarks>
    /// Create invoice.
    /// 
    /// Required scopes:
    /// + invoice
    /// </remarks>
    public async Task<PaymentsApiTypes.PaymentsInvoiceCreateResponse> InvoiceCreateAsync(PaymentsApiTypes.PaymentsInvoiceCreateBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/invoice",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsInvoiceCreateResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Invoice List</summary>
    /// <remarks>
    /// Get invoice list.
    /// 
    /// Required scopes:
    /// + invoice
    /// </remarks>
    public async Task<PaymentsApiTypes.PaymentsInvoiceListResponse> InvoiceListAsync(PaymentsApiTypes.PaymentsInvoiceListParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/invoice/list",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsInvoiceListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Currency</summary>
    /// <remarks>
    /// Get currency list.
    /// </remarks>
    public async Task<PaymentsApiTypes.PaymentsCurrencyResponse> CurrencyAsync(CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/currency",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsCurrencyResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get List Of Balances</summary>
    /// <remarks>
    /// Returns list of balances.
    /// </remarks>
    public async Task<PaymentsApiTypes.PaymentsBalanceListResponse> BalanceListAsync(CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/balance/exchange",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsBalanceListResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Exchange Balance</summary>
    /// <remarks>
    /// Transfer funds from one balance to another.
    /// </remarks>
    public async Task<PaymentsApiTypes.PaymentsBalanceExchangeResponse> BalanceExchangeAsync(PaymentsApiTypes.PaymentsBalanceExchangeBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/balance/exchange",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsBalanceExchangeResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Transfer Money</summary>
    /// <remarks>
    /// Transfer money to any user.
    /// 
    /// Required scopes:
    /// + payment
    /// </remarks>
    public async Task<PaymentsApiTypes.PaymentsTransferResponse> TransferAsync(PaymentsApiTypes.PaymentsTransferBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/balance/transfer",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsTransferResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Check Transfer Fee</summary>
    /// <remarks>
    /// Get transfer limits and get fee amount for transfer.
    /// 
    /// Required scopes:
    /// + payment
    /// </remarks>
    public async Task<PaymentsApiTypes.PaymentsFeeResponse> FeeAsync(PaymentsApiTypes.PaymentsFeeParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/balance/transfer/fee",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsFeeResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Cancel Transfer</summary>
    /// <remarks>
    /// Cancels a transfer with a hold that was sent to your account.
    /// 
    /// Required scopes:
    /// + payment
    /// </remarks>
    public async Task<PaymentsApiTypes.PaymentsCancelResponse> CancelAsync(PaymentsApiTypes.PaymentsCancelBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/balance/transfer/cancel",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsCancelResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Payments History</summary>
    /// <remarks>
    /// Displays list of your payments.
    /// 
    /// Required scopes:
    /// + payment
    /// </remarks>
    public async Task<PaymentsApiTypes.PaymentsHistoryResponse> HistoryAsync(PaymentsApiTypes.PaymentsHistoryParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/user/payments",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsHistoryResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Payout Services</summary>
    /// <remarks>
    /// Get a list of available payout services.
    /// </remarks>
    public async Task<PaymentsApiTypes.PaymentsPayoutServicesResponse> PayoutServicesAsync(CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/balance/payout/services",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsPayoutServicesResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Create Payout</summary>
    /// <remarks>
    /// Creates a payout request.
    /// </remarks>
    public async Task<PaymentsApiTypes.PaymentsPayoutResponse> PayoutAsync(PaymentsApiTypes.PaymentsPayoutBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/balance/payout",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PaymentsApiTypes.PaymentsPayoutResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class ProfileApi
{
    private readonly LolzteamHttpClient _http;

    public ProfileApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Claims</summary>
    /// <remarks>
    /// Returns a list of claims filed against you.
    /// </remarks>
    public async Task<ProfileApiTypes.ProfileClaimsResponse> ClaimsAsync(ProfileApiTypes.ProfileClaimsParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/claims",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfileApiTypes.ProfileClaimsResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Get Profile</summary>
    /// <remarks>
    /// Displays info about your profile.
    /// </remarks>
    public async Task<ProfileApiTypes.ProfileGetResponse> GetAsync(ProfileApiTypes.ProfileGetParams? @params = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/me",
            Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfileApiTypes.ProfileGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Edit Market Settings</summary>
    /// <remarks>
    /// Change settings about your profile on the market.
    /// </remarks>
    public async Task<ProfileApiTypes.ProfileEditResponse> EditAsync(ProfileApiTypes.ProfileEditBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "PUT",
            Path = "/me",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProfileApiTypes.ProfileEditResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class ProxyApi
{
    private readonly LolzteamHttpClient _http;

    public ProxyApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Get Proxy</summary>
    /// <remarks>
    /// Gets your proxy list.
    /// </remarks>
    public async Task<ProxyApiTypes.ProxyGetResponse> GetAsync(CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/proxy",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProxyApiTypes.ProxyGetResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Add Proxy</summary>
    /// <remarks>
    /// Add single proxy or proxy list.
    /// 
    /// 
    /// To add single proxy use this parameters:
    /// 
    /// 
    /// + proxy_ip (required) - proxy ip or host
    /// + proxy_port (required) - proxy port
    /// + proxy_user (optional) - proxy username
    /// + proxy_pass (optional) - proxy password
    /// 
    /// To add proxy list use this parameters:
    /// 
    /// 
    /// + proxy_row (required) - proxy list in String format ip:port:user:pass. Each proxy must be start with new line (use \n separator)
    /// </remarks>
    public async Task<ProxyApiTypes.ProxyAddResponse> AddAsync(ProxyApiTypes.ProxyAddBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/proxy",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProxyApiTypes.ProxyAddResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Delete Proxy</summary>
    /// <remarks>
    /// Delete single or all proxies.
    /// </remarks>
    public async Task<ProxyApiTypes.ProxyDeleteResponse> DeleteAsync(ProxyApiTypes.ProxyDeleteBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = "/proxy",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<ProxyApiTypes.ProxyDeleteResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class PublishingApi
{
    private readonly LolzteamHttpClient _http;

    public PublishingApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Fast Account Upload</summary>
    /// <remarks>
    /// Adds and checks the account for validity.
    /// 
    /// &gt; ❗️ If you receive a &quot;retry_request&quot; error, you should repeat the same request (up to a maximum of 100 times).
    /// </remarks>
    public async Task<PublishingApiTypes.PublishingFastSellResponse> FastSellAsync(PublishingApiTypes.PublishingFastSellBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/item/fast-sell",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PublishingApiTypes.PublishingFastSellResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Add Account</summary>
    /// <remarks>
    /// Adds account on the market.
    /// 
    /// Required email login data categories:
    /// + 9 - Fortnite
    /// + 12 - Epic games
    /// + 18 - Escape from Tarkov
    /// </remarks>
    public async Task<PublishingApiTypes.PublishingAddResponse> AddAsync(PublishingApiTypes.PublishingAddBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/item/add",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PublishingApiTypes.PublishingAddResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Check Account Details</summary>
    /// <remarks>
    /// Check and put up to sale not published account OR update account information existing account.
    /// 
    /// &gt; ❗️ If you receive a &quot;retry_request&quot; error, you should repeat the same request (up to a maximum of 100 times).
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<PublishingApiTypes.PublishingCheckResponse> CheckAsync(long ItemId, PublishingApiTypes.PublishingCheckBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/goods/check",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PublishingApiTypes.PublishingCheckResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Add an External Account</summary>
    /// <remarks>
    /// Check and add an external account to your item.
    /// 
    /// &gt; ❗️ Please note that if you're linking a Social Club account to Steam, it will update the last activity on your account (This is a limitation of Steam). If Social Club Games does not have a linked account, do not enter any data.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<PublishingApiTypes.PublishingExternalResponse> ExternalAsync(long ItemId, PublishingApiTypes.PublishingExternalBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/external-account",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PublishingApiTypes.PublishingExternalResponse>(__result, JsonDefaults.Options)!;
    }
}

public sealed class PurchasingApi
{
    private readonly LolzteamHttpClient _http;

    public PurchasingApi(LolzteamHttpClient http)
    {
        _http = http;
    }

    /// <summary>Fast Buy Account</summary>
    /// <remarks>
    /// Check and buy account.
    /// 
    /// &gt; ❗️ If you receive a &quot;retry_request&quot; error, you should repeat the same request (up to a maximum of 100 times).
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<PurchasingApiTypes.PurchasingFastBuyResponse> FastBuyAsync(long ItemId, PurchasingApiTypes.PurchasingFastBuyBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/fast-buy",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PurchasingApiTypes.PurchasingFastBuyResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Check Account</summary>
    /// <remarks>
    /// Checking account for validity.
    /// 
    /// &gt; ❗️ If you receive a &quot;retry_request&quot; error, you should repeat the same request (up to a maximum of 100 times).
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<PurchasingApiTypes.PurchasingCheckResponse> CheckAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/check-account",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PurchasingApiTypes.PurchasingCheckResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Confirm Buy</summary>
    /// <remarks>
    /// Confirm buy.
    /// 
    /// &gt; ❗️ This method doesn't check account for validity. If you want to confirm validity before buying, you should use [FastBuy](https://lzt-market.readme.io/reference/purchasingfastbuy) method
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<PurchasingApiTypes.PurchasingConfirmResponse> ConfirmAsync(long ItemId, PurchasingApiTypes.PurchasingConfirmBody? body = null, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/confirm-buy",
            Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PurchasingApiTypes.PurchasingConfirmResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Discount Request</summary>
    /// <remarks>
    /// Request a discount for the specified item.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<PurchasingApiTypes.PurchasingDiscountRequestResponse> DiscountRequestAsync(long ItemId, PurchasingApiTypes.PurchasingDiscountRequestBody body, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = $"/{ItemId}/discount",
            Body = JsonSerializer.SerializeToElement(body),
            BodyEncoding = BodyEncoding.Json,
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PurchasingApiTypes.PurchasingDiscountRequestResponse>(__result, JsonDefaults.Options)!;
    }

    /// <summary>Cancel Discount Request</summary>
    /// <remarks>
    /// Cancel a requested discount for the specified item.
    /// </remarks>
    /// <param name="ItemId">Item id.</param>
    public async Task<PurchasingApiTypes.PurchasingDiscountCancelResponse> DiscountCancelAsync(long ItemId, CancellationToken cancellationToken = default)
    {
        var __result = await _http.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = $"/{ItemId}/discount",
        }, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize<PurchasingApiTypes.PurchasingDiscountCancelResponse>(__result, JsonDefaults.Options)!;
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

    public static MarketClient Create(string token)
    {
        return new MarketClient(new ClientConfig { Token = token });
    }

    public void Dispose()
    {
        _http.Dispose();
    }
}
