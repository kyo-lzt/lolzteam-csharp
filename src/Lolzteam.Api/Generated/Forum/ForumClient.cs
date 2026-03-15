// Auto-generated. Do not edit manually.

using System.Text.Json;
using Lolzteam.Api.Runtime;

namespace Lolzteam.Api.Generated.Forum;

public sealed class OAuthApi
{
	private readonly LolzteamHttpClient _http;

	public OAuthApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> TokenAsync(OAuthApiTypes.OAuthTokenBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/oauth/token",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Multipart,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class AssetsApi
{
	private readonly LolzteamHttpClient _http;

	public AssetsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> CssAsync(AssetsApiTypes.AssetsCssParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/css",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class CategoriesApi
{
	private readonly LolzteamHttpClient _http;

	public CategoriesApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> ListAsync(CategoriesApiTypes.CategoriesListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/categories",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetAsync(int CategoryId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/categories/{CategoryId}",
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ForumsApi
{
	private readonly LolzteamHttpClient _http;

	public ForumsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> ListAsync(ForumsApiTypes.ForumsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/forums",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GroupedAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/forums/grouped",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetAsync(int ForumId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/forums/{ForumId}",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FollowersAsync(int ForumId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/forums/{ForumId}/followers",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FollowAsync(int ForumId, ForumsApiTypes.ForumsFollowBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/forums/{ForumId}/followers",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> UnfollowAsync(int ForumId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/forums/{ForumId}/followers",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FollowedAsync(ForumsApiTypes.ForumsFollowedParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/forums/followed",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetFeedOptionsAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/forums/feed/options",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> EditFeedOptionsAsync(ForumsApiTypes.ForumsEditFeedOptionsBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = "/forums/feed/options",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class LinksApi
{
	private readonly LolzteamHttpClient _http;

	public LinksApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> ListAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/link-forums",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetAsync(int LinkId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/link-forums/{LinkId}",
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class PagesApi
{
	private readonly LolzteamHttpClient _http;

	public PagesApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> ListAsync(PagesApiTypes.PagesListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/pages",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetAsync(int PageId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/pages/{PageId}",
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class NavigationApi
{
	private readonly LolzteamHttpClient _http;

	public NavigationApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> ListAsync(NavigationApiTypes.NavigationListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/navigation",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ThreadsApi
{
	private readonly LolzteamHttpClient _http;

	public ThreadsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> ListAsync(ThreadsApiTypes.ThreadsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/threads",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CreateAsync(ThreadsApiTypes.ThreadsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/threads",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CreateContestAsync(ThreadsApiTypes.ThreadsCreateContestBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/contests",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ClaimAsync(ThreadsApiTypes.ThreadsClaimBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/claims",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetAsync(int ThreadId, ThreadsApiTypes.ThreadsGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/threads/{ThreadId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> EditAsync(int ThreadId, ThreadsApiTypes.ThreadsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = $"/threads/{ThreadId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DeleteAsync(int ThreadId, ThreadsApiTypes.ThreadsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/threads/{ThreadId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> MoveAsync(int ThreadId, ThreadsApiTypes.ThreadsMoveBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/move",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> BumpAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/bump",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> HideAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/hide",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> StarAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/star",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> UnstarAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/threads/{ThreadId}/star",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FollowersAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/threads/{ThreadId}/followers",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FollowAsync(int ThreadId, ThreadsApiTypes.ThreadsFollowBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/followers",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> UnfollowAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/threads/{ThreadId}/followers",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FollowedAsync(ThreadsApiTypes.ThreadsFollowedParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/threads/followed",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> NavigationAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/threads/{ThreadId}/navigation",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> PollGetAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/threads/{ThreadId}/poll",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> PollVoteAsync(int ThreadId, ThreadsApiTypes.ThreadsPollVoteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/poll/votes",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> UnreadAsync(ThreadsApiTypes.ThreadsUnreadParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/threads/new",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> RecentAsync(ThreadsApiTypes.ThreadsRecentParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/threads/recent",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FinishAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/contests/{ThreadId}/finish",
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class PostsApi
{
	private readonly LolzteamHttpClient _http;

	public PostsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> ListAsync(PostsApiTypes.PostsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/posts",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CreateAsync(PostsApiTypes.PostsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/posts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetAsync(int PostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/posts/{PostId}",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> EditAsync(int PostId, PostsApiTypes.PostsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = $"/posts/{PostId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DeleteAsync(int PostId, PostsApiTypes.PostsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/posts/{PostId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> LikesAsync(int PostId, PostsApiTypes.PostsLikesParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/posts/{PostId}/likes",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> LikeAsync(int PostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/posts/{PostId}/likes",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> UnlikeAsync(int PostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/posts/{PostId}/likes",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ReportReasonsAsync(int PostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/posts/{PostId}/report",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ReportAsync(int PostId, PostsApiTypes.PostsReportBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/posts/{PostId}/report",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CommentsGetAsync(PostsApiTypes.PostsCommentsGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/posts/comments",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CommentsCreateAsync(PostsApiTypes.PostsCommentsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/posts/comments",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CommentsEditAsync(PostsApiTypes.PostsCommentsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = "/posts/comments",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CommentsDeleteAsync(PostsApiTypes.PostsCommentsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/posts/comments",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CommentsReportAsync(PostsApiTypes.PostsCommentsReportBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/posts/comments/report",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class UsersApi
{
	private readonly LolzteamHttpClient _http;

	public UsersApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> ListAsync(UsersApiTypes.UsersListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/users",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FieldsAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/users/fields",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FindAsync(UsersApiTypes.UsersFindParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/users/find",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetAsync(JsonElement UserId, UsersApiTypes.UsersGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> EditAsync(JsonElement UserId, UsersApiTypes.UsersEditBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = $"/users/{UserId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ClaimsAsync(JsonElement UserId, UsersApiTypes.UsersClaimsParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/claims",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> AvatarUploadAsync(JsonElement UserId, UsersApiTypes.UsersAvatarUploadBody? body = null, CancellationToken cancellationToken = default)
	{
		if (body is not null)
		{
			var jsonObj = new System.Text.Json.Nodes.JsonObject();
			if (body.X is not null) jsonObj["x"] = System.Text.Json.Nodes.JsonValue.Create(body.X);
			if (body.Y is not null) jsonObj["y"] = System.Text.Json.Nodes.JsonValue.Create(body.Y);
			if (body.Crop is not null) jsonObj["crop"] = System.Text.Json.Nodes.JsonValue.Create(body.Crop);
			var byteFields = new Dictionary<string, byte[]>();
			byteFields["avatar"] = body.Avatar;
			return await _http.RequestAsync(new RequestOptions
			{
				Method = "POST",
				Path = $"/users/{UserId}/avatar",
				Body = JsonSerializer.SerializeToElement(jsonObj),
				BodyEncoding = BodyEncoding.Multipart,
				ByteArrayFields = byteFields,
			}, cancellationToken).ConfigureAwait(false);
		}
		else
		{
			return await _http.RequestAsync(new RequestOptions
			{
				Method = "POST",
				Path = $"/users/{UserId}/avatar",
				BodyEncoding = BodyEncoding.Multipart,
			}, cancellationToken).ConfigureAwait(false);
		}
	}

	public async Task<JsonElement> AvatarDeleteAsync(JsonElement UserId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/users/{UserId}/avatar",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> AvatarCropAsync(JsonElement UserId, UsersApiTypes.UsersAvatarCropBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/avatar/crop",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> BackgroundUploadAsync(JsonElement UserId, UsersApiTypes.UsersBackgroundUploadBody? body = null, CancellationToken cancellationToken = default)
	{
		if (body is not null)
		{
			var jsonObj = new System.Text.Json.Nodes.JsonObject();
			if (body.X is not null) jsonObj["x"] = System.Text.Json.Nodes.JsonValue.Create(body.X);
			if (body.Y is not null) jsonObj["y"] = System.Text.Json.Nodes.JsonValue.Create(body.Y);
			if (body.Crop is not null) jsonObj["crop"] = System.Text.Json.Nodes.JsonValue.Create(body.Crop);
			var byteFields = new Dictionary<string, byte[]>();
			byteFields["background"] = body.Background;
			return await _http.RequestAsync(new RequestOptions
			{
				Method = "POST",
				Path = $"/users/{UserId}/background",
				Body = JsonSerializer.SerializeToElement(jsonObj),
				BodyEncoding = BodyEncoding.Multipart,
				ByteArrayFields = byteFields,
			}, cancellationToken).ConfigureAwait(false);
		}
		else
		{
			return await _http.RequestAsync(new RequestOptions
			{
				Method = "POST",
				Path = $"/users/{UserId}/background",
				BodyEncoding = BodyEncoding.Multipart,
			}, cancellationToken).ConfigureAwait(false);
		}
	}

	public async Task<JsonElement> BackgroundDeleteAsync(JsonElement UserId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/users/{UserId}/background",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> BackgroundCropAsync(JsonElement UserId, UsersApiTypes.UsersBackgroundCropBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/background/crop",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FollowersAsync(JsonElement UserId, UsersApiTypes.UsersFollowersParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/followers",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FollowAsync(JsonElement UserId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/followers",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> UnfollowAsync(JsonElement UserId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/users/{UserId}/followers",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FollowingsAsync(JsonElement UserId, UsersApiTypes.UsersFollowingsParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/followings",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> LikesAsync(JsonElement UserId, UsersApiTypes.UsersLikesParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/likes",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> IgnoredAsync(UsersApiTypes.UsersIgnoredParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/users/ignored",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> IgnoreAsync(JsonElement UserId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/ignore",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> IgnoreEditAsync(JsonElement UserId, UsersApiTypes.UsersIgnoreEditParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = $"/users/{UserId}/ignore",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> UnignoreAsync(JsonElement UserId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/users/{UserId}/ignore",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ContentsAsync(JsonElement UserId, UsersApiTypes.UsersContentsParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/timeline",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> TrophiesAsync(JsonElement UserId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/trophies",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SecretAnswerTypesAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/users/secret-answer/types",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SaResetAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/account/secret-answer/reset",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SaCancelResetAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/account/secret-answer/reset",
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ProfilePostsApi
{
	private readonly LolzteamHttpClient _http;

	public ProfilePostsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> ListAsync(JsonElement UserId, ProfilePostsApiTypes.ProfilePostsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/profile-posts",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetAsync(int ProfilePostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/profile-posts/{ProfilePostId}",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> EditAsync(int ProfilePostId, ProfilePostsApiTypes.ProfilePostsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = $"/profile-posts/{ProfilePostId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DeleteAsync(int ProfilePostId, ProfilePostsApiTypes.ProfilePostsDeleteParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/profile-posts/{ProfilePostId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ReportReasonsAsync(int ProfilePostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/profile-posts/{ProfilePostId}/report",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ReportAsync(int ProfilePostId, ProfilePostsApiTypes.ProfilePostsReportBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/profile-posts/{ProfilePostId}/report",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CreateAsync(ProfilePostsApiTypes.ProfilePostsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/profile-posts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> StickAsync(int ProfilePostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/profile-posts/{ProfilePostId}/stick",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> UnstickAsync(int ProfilePostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/profile-posts/{ProfilePostId}/stick",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> LikesAsync(int ProfilePostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/profile-posts/{ProfilePostId}/likes",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> LikeAsync(int ProfilePostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/profile-posts/{ProfilePostId}/likes",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> UnlikeAsync(int ProfilePostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/profile-posts/{ProfilePostId}/likes",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CommentsListAsync(ProfilePostsApiTypes.ProfilePostsCommentsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/profile-posts/comments",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CommentsCreateAsync(ProfilePostsApiTypes.ProfilePostsCommentsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/profile-posts/comments",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CommentsEditAsync(ProfilePostsApiTypes.ProfilePostsCommentsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = "/profile-posts/comments",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CommentsDeleteAsync(ProfilePostsApiTypes.ProfilePostsCommentsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/profile-posts/comments",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CommentsGetAsync(int ProfilePostId, int CommentId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/profile-posts/{ProfilePostId}/comments/{CommentId}",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CommentsReportAsync(int CommentId, ProfilePostsApiTypes.ProfilePostsCommentsReportBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/profile-posts/comments/{CommentId}/report",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ConversationsApi
{
	private readonly LolzteamHttpClient _http;

	public ConversationsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> ListAsync(ConversationsApiTypes.ConversationsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/conversations",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CreateAsync(ConversationsApiTypes.ConversationsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/conversations",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> UpdateAsync(ConversationsApiTypes.ConversationsUpdateBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = "/conversations",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DeleteAsync(ConversationsApiTypes.ConversationsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/conversations",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> StartAsync(ConversationsApiTypes.ConversationsStartBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/conversations/start",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SaveAsync(ConversationsApiTypes.ConversationsSaveBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/conversations/save",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetAsync(int ConversationId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/conversations/{ConversationId}",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> MessagesListAsync(int ConversationId, ConversationsApiTypes.ConversationsMessagesListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/conversations/{ConversationId}/messages",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> MessagesCreateAsync(int ConversationId, ConversationsApiTypes.ConversationsMessagesCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/messages",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> SearchAsync(ConversationsApiTypes.ConversationsSearchBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/conversations/search",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> MessagesGetAsync(int MessageId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/conversations/messages/{MessageId}",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> MessagesEditAsync(int ConversationId, int MessageId, ConversationsApiTypes.ConversationsMessagesEditBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = $"/conversations/{ConversationId}/messages/{MessageId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> MessagesDeleteAsync(int ConversationId, int MessageId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/conversations/{ConversationId}/messages/{MessageId}",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> InviteAsync(int ConversationId, ConversationsApiTypes.ConversationsInviteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/invite",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> KickAsync(int ConversationId, ConversationsApiTypes.ConversationsKickBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/kick",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ReadAsync(int ConversationId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/read",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ReadAllAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/conversations/read-all",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> MessagesStickAsync(int ConversationId, int MessageId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/messages/{MessageId}/stick",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> MessagesUnstickAsync(int ConversationId, int MessageId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/conversations/{ConversationId}/messages/{MessageId}/stick",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> StarAsync(int ConversationId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/star",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> UnstarAsync(int ConversationId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/conversations/{ConversationId}/star",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> AlertsEnableAsync(int ConversationId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/alerts",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> AlertsDisableAsync(int ConversationId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/conversations/{ConversationId}/alerts",
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class NotificationsApi
{
	private readonly LolzteamHttpClient _http;

	public NotificationsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> ListAsync(NotificationsApiTypes.NotificationsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/notifications",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetAsync(int NotificationId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/notifications/{NotificationId}/content",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ReadAsync(NotificationsApiTypes.NotificationsReadBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/notifications/read",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class TagsApi
{
	private readonly LolzteamHttpClient _http;

	public TagsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> PopularAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/tags",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ListAsync(TagsApiTypes.TagsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/tags/list",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetAsync(int TagId, TagsApiTypes.TagsGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/tags/{TagId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> FindAsync(TagsApiTypes.TagsFindParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/tags/find",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class SearchApi
{
	private readonly LolzteamHttpClient _http;

	public SearchApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> AllAsync(SearchApiTypes.SearchAllBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/search",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ThreadsAsync(SearchApiTypes.SearchThreadsBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/search/threads",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> PostsAsync(SearchApiTypes.SearchPostsBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/search/posts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> UsersAsync(SearchApiTypes.SearchUsersBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/search/users",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ProfilePostsAsync(SearchApiTypes.SearchProfilePostsBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/search/profile-posts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> TaggedAsync(SearchApiTypes.SearchTaggedBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/search/tagged",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ResultsAsync(JsonElement SearchId, SearchApiTypes.SearchResultsParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/search/{SearchId}/results",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
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

	public async Task<JsonElement> ExecuteAsync(List<JsonElement>? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/batch",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ChatboxApi
{
	private readonly LolzteamHttpClient _http;

	public ChatboxApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> IndexAsync(ChatboxApiTypes.ChatboxIndexParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetMessagesAsync(ChatboxApiTypes.ChatboxGetMessagesParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/messages",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> PostMessageAsync(ChatboxApiTypes.ChatboxPostMessageBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/chatbox/messages",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> EditMessageAsync(ChatboxApiTypes.ChatboxEditMessageBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = "/chatbox/messages",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DeleteMessageAsync(ChatboxApiTypes.ChatboxDeleteMessageBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/chatbox/messages",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> OnlineAsync(ChatboxApiTypes.ChatboxOnlineParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/messages/online",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ReportReasonsAsync(ChatboxApiTypes.ChatboxReportReasonsParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/messages/report",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> ReportAsync(ChatboxApiTypes.ChatboxReportBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/chatbox/messages/report",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetLeaderboardAsync(ChatboxApiTypes.ChatboxGetLeaderboardParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/messages/leaderboard",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> GetIgnoreAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/ignore",
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> PostIgnoreAsync(ChatboxApiTypes.ChatboxPostIgnoreBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/chatbox/ignore",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> DeleteIgnoreAsync(ChatboxApiTypes.ChatboxDeleteIgnoreBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/chatbox/ignore",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class FormsApi
{
	private readonly LolzteamHttpClient _http;

	public FormsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<JsonElement> ListAsync(FormsApiTypes.FormsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/forms",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
	}

	public async Task<JsonElement> CreateAsync(FormsApiTypes.FormsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/forms/save",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ForumClient : IDisposable
{
	public OAuthApi OAuth { get; }
	public AssetsApi Assets { get; }
	public CategoriesApi Categories { get; }
	public ForumsApi Forums { get; }
	public LinksApi Links { get; }
	public PagesApi Pages { get; }
	public NavigationApi Navigation { get; }
	public ThreadsApi Threads { get; }
	public PostsApi Posts { get; }
	public UsersApi Users { get; }
	public ProfilePostsApi ProfilePosts { get; }
	public ConversationsApi Conversations { get; }
	public NotificationsApi Notifications { get; }
	public TagsApi Tags { get; }
	public SearchApi Search { get; }
	public BatchApi Batch { get; }
	public ChatboxApi Chatbox { get; }
	public FormsApi Forms { get; }

	private readonly LolzteamHttpClient _http;

	public ForumClient(ClientConfig config)
	{
		var resolvedConfig = config with
		{
			BaseUrl = config.BaseUrl ?? "https://prod-api.lolz.live",
			RateLimit = config.RateLimit ?? new RateLimitConfig(300),
		};
		_http = new LolzteamHttpClient(resolvedConfig);

		OAuth = new OAuthApi(_http);
		Assets = new AssetsApi(_http);
		Categories = new CategoriesApi(_http);
		Forums = new ForumsApi(_http);
		Links = new LinksApi(_http);
		Pages = new PagesApi(_http);
		Navigation = new NavigationApi(_http);
		Threads = new ThreadsApi(_http);
		Posts = new PostsApi(_http);
		Users = new UsersApi(_http);
		ProfilePosts = new ProfilePostsApi(_http);
		Conversations = new ConversationsApi(_http);
		Notifications = new NotificationsApi(_http);
		Tags = new TagsApi(_http);
		Search = new SearchApi(_http);
		Batch = new BatchApi(_http);
		Chatbox = new ChatboxApi(_http);
		Forms = new FormsApi(_http);
	}

	public void Dispose()
	{
		_http.Dispose();
	}
}
