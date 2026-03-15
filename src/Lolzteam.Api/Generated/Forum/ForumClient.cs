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

	public async Task<OAuthApiTypes.OAuthTokenResponse> TokenAsync(OAuthApiTypes.OAuthTokenBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/oauth/token",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Multipart,
		}, cancellationToken).ConfigureAwait(false);
		return new OAuthApiTypes.OAuthTokenResponse(__result);
	}
}

public sealed class AssetsApi
{
	private readonly LolzteamHttpClient _http;

	public AssetsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<AssetsApiTypes.AssetsCssResponse> CssAsync(AssetsApiTypes.AssetsCssParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/css",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new AssetsApiTypes.AssetsCssResponse(__result);
	}
}

public sealed class CategoriesApi
{
	private readonly LolzteamHttpClient _http;

	public CategoriesApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<CategoriesApiTypes.CategoriesListResponse> ListAsync(CategoriesApiTypes.CategoriesListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/categories",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new CategoriesApiTypes.CategoriesListResponse(__result);
	}

	public async Task<CategoriesApiTypes.CategoriesGetResponse> GetAsync(int CategoryId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/categories/{CategoryId}",
		}, cancellationToken).ConfigureAwait(false);
		return new CategoriesApiTypes.CategoriesGetResponse(__result);
	}
}

public sealed class ForumsApi
{
	private readonly LolzteamHttpClient _http;

	public ForumsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ForumsApiTypes.ForumsListResponse> ListAsync(ForumsApiTypes.ForumsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/forums",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ForumsApiTypes.ForumsListResponse(__result);
	}

	public async Task<ForumsApiTypes.ForumsGroupedResponse> GroupedAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/forums/grouped",
		}, cancellationToken).ConfigureAwait(false);
		return new ForumsApiTypes.ForumsGroupedResponse(__result);
	}

	public async Task<ForumsApiTypes.ForumsGetResponse> GetAsync(int ForumId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/forums/{ForumId}",
		}, cancellationToken).ConfigureAwait(false);
		return new ForumsApiTypes.ForumsGetResponse(__result);
	}

	public async Task<ForumsApiTypes.ForumsFollowersResponse> FollowersAsync(int ForumId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/forums/{ForumId}/followers",
		}, cancellationToken).ConfigureAwait(false);
		return new ForumsApiTypes.ForumsFollowersResponse(__result);
	}

	public async Task<ForumsApiTypes.ForumsFollowResponse> FollowAsync(int ForumId, ForumsApiTypes.ForumsFollowBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/forums/{ForumId}/followers",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ForumsApiTypes.ForumsFollowResponse(__result);
	}

	public async Task<ForumsApiTypes.ForumsUnfollowResponse> UnfollowAsync(int ForumId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/forums/{ForumId}/followers",
		}, cancellationToken).ConfigureAwait(false);
		return new ForumsApiTypes.ForumsUnfollowResponse(__result);
	}

	public async Task<ForumsApiTypes.ForumsFollowedResponse> FollowedAsync(ForumsApiTypes.ForumsFollowedParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/forums/followed",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ForumsApiTypes.ForumsFollowedResponse(__result);
	}

	public async Task<ForumsApiTypes.ForumsGetFeedOptionsResponse> GetFeedOptionsAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/forums/feed/options",
		}, cancellationToken).ConfigureAwait(false);
		return new ForumsApiTypes.ForumsGetFeedOptionsResponse(__result);
	}

	public async Task<ForumsApiTypes.ForumsEditFeedOptionsResponse> EditFeedOptionsAsync(ForumsApiTypes.ForumsEditFeedOptionsBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = "/forums/feed/options",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ForumsApiTypes.ForumsEditFeedOptionsResponse(__result);
	}
}

public sealed class LinksApi
{
	private readonly LolzteamHttpClient _http;

	public LinksApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<LinksApiTypes.LinksListResponse> ListAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/link-forums",
		}, cancellationToken).ConfigureAwait(false);
		return new LinksApiTypes.LinksListResponse(__result);
	}

	public async Task<LinksApiTypes.LinksGetResponse> GetAsync(int LinkId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/link-forums/{LinkId}",
		}, cancellationToken).ConfigureAwait(false);
		return new LinksApiTypes.LinksGetResponse(__result);
	}
}

public sealed class PagesApi
{
	private readonly LolzteamHttpClient _http;

	public PagesApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<PagesApiTypes.PagesListResponse> ListAsync(PagesApiTypes.PagesListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/pages",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new PagesApiTypes.PagesListResponse(__result);
	}

	public async Task<PagesApiTypes.PagesGetResponse> GetAsync(int PageId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/pages/{PageId}",
		}, cancellationToken).ConfigureAwait(false);
		return new PagesApiTypes.PagesGetResponse(__result);
	}
}

public sealed class NavigationApi
{
	private readonly LolzteamHttpClient _http;

	public NavigationApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<NavigationApiTypes.NavigationListResponse> ListAsync(NavigationApiTypes.NavigationListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/navigation",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new NavigationApiTypes.NavigationListResponse(__result);
	}
}

public sealed class ThreadsApi
{
	private readonly LolzteamHttpClient _http;

	public ThreadsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ThreadsApiTypes.ThreadsListResponse> ListAsync(ThreadsApiTypes.ThreadsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/threads",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsListResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsCreateResponse> CreateAsync(ThreadsApiTypes.ThreadsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/threads",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsCreateResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsCreateContestResponse> CreateContestAsync(ThreadsApiTypes.ThreadsCreateContestBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/contests",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsCreateContestResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsClaimResponse> ClaimAsync(ThreadsApiTypes.ThreadsClaimBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/claims",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsClaimResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsGetResponse> GetAsync(int ThreadId, ThreadsApiTypes.ThreadsGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/threads/{ThreadId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsGetResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsEditResponse> EditAsync(int ThreadId, ThreadsApiTypes.ThreadsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = $"/threads/{ThreadId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsEditResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsDeleteResponse> DeleteAsync(int ThreadId, ThreadsApiTypes.ThreadsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/threads/{ThreadId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsDeleteResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsMoveResponse> MoveAsync(int ThreadId, ThreadsApiTypes.ThreadsMoveBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/move",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsMoveResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsBumpResponse> BumpAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/bump",
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsBumpResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsHideResponse> HideAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/hide",
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsHideResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsStarResponse> StarAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/star",
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsStarResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsUnstarResponse> UnstarAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/threads/{ThreadId}/star",
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsUnstarResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsFollowersResponse> FollowersAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/threads/{ThreadId}/followers",
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsFollowersResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsFollowResponse> FollowAsync(int ThreadId, ThreadsApiTypes.ThreadsFollowBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/followers",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsFollowResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsUnfollowResponse> UnfollowAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/threads/{ThreadId}/followers",
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsUnfollowResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsFollowedResponse> FollowedAsync(ThreadsApiTypes.ThreadsFollowedParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/threads/followed",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsFollowedResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsNavigationResponse> NavigationAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/threads/{ThreadId}/navigation",
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsNavigationResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsPollGetResponse> PollGetAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/threads/{ThreadId}/poll",
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsPollGetResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsPollVoteResponse> PollVoteAsync(int ThreadId, ThreadsApiTypes.ThreadsPollVoteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/poll/votes",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsPollVoteResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsUnreadResponse> UnreadAsync(ThreadsApiTypes.ThreadsUnreadParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/threads/new",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsUnreadResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsRecentResponse> RecentAsync(ThreadsApiTypes.ThreadsRecentParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/threads/recent",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsRecentResponse(__result);
	}

	public async Task<ThreadsApiTypes.ThreadsFinishResponse> FinishAsync(int ThreadId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/contests/{ThreadId}/finish",
		}, cancellationToken).ConfigureAwait(false);
		return new ThreadsApiTypes.ThreadsFinishResponse(__result);
	}
}

public sealed class PostsApi
{
	private readonly LolzteamHttpClient _http;

	public PostsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<PostsApiTypes.PostsListResponse> ListAsync(PostsApiTypes.PostsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/posts",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new PostsApiTypes.PostsListResponse(__result);
	}

	public async Task<PostsApiTypes.PostsCreateResponse> CreateAsync(PostsApiTypes.PostsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/posts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PostsApiTypes.PostsCreateResponse(__result);
	}

	public async Task<PostsApiTypes.PostsGetResponse> GetAsync(int PostId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/posts/{PostId}",
		}, cancellationToken).ConfigureAwait(false);
		return new PostsApiTypes.PostsGetResponse(__result);
	}

	public async Task<PostsApiTypes.PostsEditResponse> EditAsync(int PostId, PostsApiTypes.PostsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = $"/posts/{PostId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PostsApiTypes.PostsEditResponse(__result);
	}

	public async Task<PostsApiTypes.PostsDeleteResponse> DeleteAsync(int PostId, PostsApiTypes.PostsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/posts/{PostId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PostsApiTypes.PostsDeleteResponse(__result);
	}

	public async Task<PostsApiTypes.PostsLikesResponse> LikesAsync(int PostId, PostsApiTypes.PostsLikesParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/posts/{PostId}/likes",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new PostsApiTypes.PostsLikesResponse(__result);
	}

	public async Task<PostsApiTypes.PostsLikeResponse> LikeAsync(int PostId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/posts/{PostId}/likes",
		}, cancellationToken).ConfigureAwait(false);
		return new PostsApiTypes.PostsLikeResponse(__result);
	}

	public async Task<PostsApiTypes.PostsUnlikeResponse> UnlikeAsync(int PostId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/posts/{PostId}/likes",
		}, cancellationToken).ConfigureAwait(false);
		return new PostsApiTypes.PostsUnlikeResponse(__result);
	}

	public async Task<PostsApiTypes.PostsReportReasonsResponse> ReportReasonsAsync(int PostId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/posts/{PostId}/report",
		}, cancellationToken).ConfigureAwait(false);
		return new PostsApiTypes.PostsReportReasonsResponse(__result);
	}

	public async Task<PostsApiTypes.PostsReportResponse> ReportAsync(int PostId, PostsApiTypes.PostsReportBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/posts/{PostId}/report",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PostsApiTypes.PostsReportResponse(__result);
	}

	public async Task<PostsApiTypes.PostsCommentsGetResponse> CommentsGetAsync(PostsApiTypes.PostsCommentsGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/posts/comments",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new PostsApiTypes.PostsCommentsGetResponse(__result);
	}

	public async Task<PostsApiTypes.PostsCommentsCreateResponse> CommentsCreateAsync(PostsApiTypes.PostsCommentsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/posts/comments",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PostsApiTypes.PostsCommentsCreateResponse(__result);
	}

	public async Task<PostsApiTypes.PostsCommentsEditResponse> CommentsEditAsync(PostsApiTypes.PostsCommentsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = "/posts/comments",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PostsApiTypes.PostsCommentsEditResponse(__result);
	}

	public async Task<PostsApiTypes.PostsCommentsDeleteResponse> CommentsDeleteAsync(PostsApiTypes.PostsCommentsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/posts/comments",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PostsApiTypes.PostsCommentsDeleteResponse(__result);
	}

	public async Task<PostsApiTypes.PostsCommentsReportResponse> CommentsReportAsync(PostsApiTypes.PostsCommentsReportBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/posts/comments/report",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new PostsApiTypes.PostsCommentsReportResponse(__result);
	}
}

public sealed class UsersApi
{
	private readonly LolzteamHttpClient _http;

	public UsersApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<UsersApiTypes.UsersListResponse> ListAsync(UsersApiTypes.UsersListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/users",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersListResponse(__result);
	}

	public async Task<UsersApiTypes.UsersFieldsResponse> FieldsAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/users/fields",
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersFieldsResponse(__result);
	}

	public async Task<UsersApiTypes.UsersFindResponse> FindAsync(UsersApiTypes.UsersFindParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/users/find",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersFindResponse(__result);
	}

	public async Task<UsersApiTypes.UsersGetResponse> GetAsync(JsonElement UserId, UsersApiTypes.UsersGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersGetResponse(__result);
	}

	public async Task<UsersApiTypes.UsersEditResponse> EditAsync(JsonElement UserId, UsersApiTypes.UsersEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = $"/users/{UserId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersEditResponse(__result);
	}

	public async Task<UsersApiTypes.UsersClaimsResponse> ClaimsAsync(JsonElement UserId, UsersApiTypes.UsersClaimsParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/claims",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersClaimsResponse(__result);
	}

	public async Task<UsersApiTypes.UsersAvatarUploadResponse> AvatarUploadAsync(JsonElement UserId, UsersApiTypes.UsersAvatarUploadBody? body = null, CancellationToken cancellationToken = default)
	{
		if (body is not null)
		{
			var jsonObj = new System.Text.Json.Nodes.JsonObject();
			if (body.X is not null) jsonObj["x"] = System.Text.Json.Nodes.JsonValue.Create(body.X);
			if (body.Y is not null) jsonObj["y"] = System.Text.Json.Nodes.JsonValue.Create(body.Y);
			if (body.Crop is not null) jsonObj["crop"] = System.Text.Json.Nodes.JsonValue.Create(body.Crop);
			var byteFields = new Dictionary<string, byte[]>();
			byteFields["avatar"] = body.Avatar;
			var __result = await _http.RequestAsync(new RequestOptions
			{
				Method = "POST",
				Path = $"/users/{UserId}/avatar",
				Body = JsonSerializer.SerializeToElement(jsonObj),
				BodyEncoding = BodyEncoding.Multipart,
				ByteArrayFields = byteFields,
			}, cancellationToken).ConfigureAwait(false);
			return new UsersApiTypes.UsersAvatarUploadResponse(__result);
		}
		else
		{
			var __result = await _http.RequestAsync(new RequestOptions
			{
				Method = "POST",
				Path = $"/users/{UserId}/avatar",
				BodyEncoding = BodyEncoding.Multipart,
			}, cancellationToken).ConfigureAwait(false);
			return new UsersApiTypes.UsersAvatarUploadResponse(__result);
		}
	}

	public async Task<UsersApiTypes.UsersAvatarDeleteResponse> AvatarDeleteAsync(JsonElement UserId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/users/{UserId}/avatar",
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersAvatarDeleteResponse(__result);
	}

	public async Task<UsersApiTypes.UsersAvatarCropResponse> AvatarCropAsync(JsonElement UserId, UsersApiTypes.UsersAvatarCropBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/avatar/crop",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersAvatarCropResponse(__result);
	}

	public async Task<UsersApiTypes.UsersBackgroundUploadResponse> BackgroundUploadAsync(JsonElement UserId, UsersApiTypes.UsersBackgroundUploadBody? body = null, CancellationToken cancellationToken = default)
	{
		if (body is not null)
		{
			var jsonObj = new System.Text.Json.Nodes.JsonObject();
			if (body.X is not null) jsonObj["x"] = System.Text.Json.Nodes.JsonValue.Create(body.X);
			if (body.Y is not null) jsonObj["y"] = System.Text.Json.Nodes.JsonValue.Create(body.Y);
			if (body.Crop is not null) jsonObj["crop"] = System.Text.Json.Nodes.JsonValue.Create(body.Crop);
			var byteFields = new Dictionary<string, byte[]>();
			byteFields["background"] = body.Background;
			var __result = await _http.RequestAsync(new RequestOptions
			{
				Method = "POST",
				Path = $"/users/{UserId}/background",
				Body = JsonSerializer.SerializeToElement(jsonObj),
				BodyEncoding = BodyEncoding.Multipart,
				ByteArrayFields = byteFields,
			}, cancellationToken).ConfigureAwait(false);
			return new UsersApiTypes.UsersBackgroundUploadResponse(__result);
		}
		else
		{
			var __result = await _http.RequestAsync(new RequestOptions
			{
				Method = "POST",
				Path = $"/users/{UserId}/background",
				BodyEncoding = BodyEncoding.Multipart,
			}, cancellationToken).ConfigureAwait(false);
			return new UsersApiTypes.UsersBackgroundUploadResponse(__result);
		}
	}

	public async Task<UsersApiTypes.UsersBackgroundDeleteResponse> BackgroundDeleteAsync(JsonElement UserId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/users/{UserId}/background",
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersBackgroundDeleteResponse(__result);
	}

	public async Task<UsersApiTypes.UsersBackgroundCropResponse> BackgroundCropAsync(JsonElement UserId, UsersApiTypes.UsersBackgroundCropBody body, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/background/crop",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersBackgroundCropResponse(__result);
	}

	public async Task<UsersApiTypes.UsersFollowersResponse> FollowersAsync(JsonElement UserId, UsersApiTypes.UsersFollowersParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/followers",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersFollowersResponse(__result);
	}

	public async Task<UsersApiTypes.UsersFollowResponse> FollowAsync(JsonElement UserId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/followers",
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersFollowResponse(__result);
	}

	public async Task<UsersApiTypes.UsersUnfollowResponse> UnfollowAsync(JsonElement UserId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/users/{UserId}/followers",
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersUnfollowResponse(__result);
	}

	public async Task<UsersApiTypes.UsersFollowingsResponse> FollowingsAsync(JsonElement UserId, UsersApiTypes.UsersFollowingsParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/followings",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersFollowingsResponse(__result);
	}

	public async Task<UsersApiTypes.UsersLikesResponse> LikesAsync(JsonElement UserId, UsersApiTypes.UsersLikesParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/likes",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersLikesResponse(__result);
	}

	public async Task<UsersApiTypes.UsersIgnoredResponse> IgnoredAsync(UsersApiTypes.UsersIgnoredParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/users/ignored",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersIgnoredResponse(__result);
	}

	public async Task<UsersApiTypes.UsersIgnoreResponse> IgnoreAsync(JsonElement UserId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/ignore",
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersIgnoreResponse(__result);
	}

	public async Task<UsersApiTypes.UsersIgnoreEditResponse> IgnoreEditAsync(JsonElement UserId, UsersApiTypes.UsersIgnoreEditParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = $"/users/{UserId}/ignore",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersIgnoreEditResponse(__result);
	}

	public async Task<UsersApiTypes.UsersUnignoreResponse> UnignoreAsync(JsonElement UserId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/users/{UserId}/ignore",
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersUnignoreResponse(__result);
	}

	public async Task<UsersApiTypes.UsersContentsResponse> ContentsAsync(JsonElement UserId, UsersApiTypes.UsersContentsParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/timeline",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersContentsResponse(__result);
	}

	public async Task<UsersApiTypes.UsersTrophiesResponse> TrophiesAsync(JsonElement UserId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/trophies",
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersTrophiesResponse(__result);
	}

	public async Task<UsersApiTypes.UsersSecretAnswerTypesResponse> SecretAnswerTypesAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/users/secret-answer/types",
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersSecretAnswerTypesResponse(__result);
	}

	public async Task<UsersApiTypes.UsersSaResetResponse> SaResetAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/account/secret-answer/reset",
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersSaResetResponse(__result);
	}

	public async Task<UsersApiTypes.UsersSaCancelResetResponse> SaCancelResetAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/account/secret-answer/reset",
		}, cancellationToken).ConfigureAwait(false);
		return new UsersApiTypes.UsersSaCancelResetResponse(__result);
	}
}

public sealed class ProfilePostsApi
{
	private readonly LolzteamHttpClient _http;

	public ProfilePostsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsListResponse> ListAsync(JsonElement UserId, ProfilePostsApiTypes.ProfilePostsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/profile-posts",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsListResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsGetResponse> GetAsync(int ProfilePostId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/profile-posts/{ProfilePostId}",
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsGetResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsEditResponse> EditAsync(int ProfilePostId, ProfilePostsApiTypes.ProfilePostsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = $"/profile-posts/{ProfilePostId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsEditResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsDeleteResponse> DeleteAsync(int ProfilePostId, ProfilePostsApiTypes.ProfilePostsDeleteParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/profile-posts/{ProfilePostId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsDeleteResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsReportReasonsResponse> ReportReasonsAsync(int ProfilePostId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/profile-posts/{ProfilePostId}/report",
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsReportReasonsResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsReportResponse> ReportAsync(int ProfilePostId, ProfilePostsApiTypes.ProfilePostsReportBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/profile-posts/{ProfilePostId}/report",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsReportResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsCreateResponse> CreateAsync(ProfilePostsApiTypes.ProfilePostsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/profile-posts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsCreateResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsStickResponse> StickAsync(int ProfilePostId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/profile-posts/{ProfilePostId}/stick",
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsStickResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsUnstickResponse> UnstickAsync(int ProfilePostId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/profile-posts/{ProfilePostId}/stick",
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsUnstickResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsLikesResponse> LikesAsync(int ProfilePostId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/profile-posts/{ProfilePostId}/likes",
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsLikesResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsLikeResponse> LikeAsync(int ProfilePostId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/profile-posts/{ProfilePostId}/likes",
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsLikeResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsUnlikeResponse> UnlikeAsync(int ProfilePostId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/profile-posts/{ProfilePostId}/likes",
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsUnlikeResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsListResponse> CommentsListAsync(ProfilePostsApiTypes.ProfilePostsCommentsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/profile-posts/comments",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsCommentsListResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsCreateResponse> CommentsCreateAsync(ProfilePostsApiTypes.ProfilePostsCommentsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/profile-posts/comments",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsCommentsCreateResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsEditResponse> CommentsEditAsync(ProfilePostsApiTypes.ProfilePostsCommentsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = "/profile-posts/comments",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsCommentsEditResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsDeleteResponse> CommentsDeleteAsync(ProfilePostsApiTypes.ProfilePostsCommentsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/profile-posts/comments",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsCommentsDeleteResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsGetResponse> CommentsGetAsync(int ProfilePostId, int CommentId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/profile-posts/{ProfilePostId}/comments/{CommentId}",
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsCommentsGetResponse(__result);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsReportResponse> CommentsReportAsync(int CommentId, ProfilePostsApiTypes.ProfilePostsCommentsReportBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/profile-posts/comments/{CommentId}/report",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ProfilePostsApiTypes.ProfilePostsCommentsReportResponse(__result);
	}
}

public sealed class ConversationsApi
{
	private readonly LolzteamHttpClient _http;

	public ConversationsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ConversationsApiTypes.ConversationsListResponse> ListAsync(ConversationsApiTypes.ConversationsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/conversations",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsListResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsCreateResponse> CreateAsync(ConversationsApiTypes.ConversationsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/conversations",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsCreateResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsUpdateResponse> UpdateAsync(ConversationsApiTypes.ConversationsUpdateBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = "/conversations",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsUpdateResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsDeleteResponse> DeleteAsync(ConversationsApiTypes.ConversationsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/conversations",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsDeleteResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsStartResponse> StartAsync(ConversationsApiTypes.ConversationsStartBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/conversations/start",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsStartResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsSaveResponse> SaveAsync(ConversationsApiTypes.ConversationsSaveBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/conversations/save",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsSaveResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsGetResponse> GetAsync(int ConversationId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/conversations/{ConversationId}",
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsGetResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsMessagesListResponse> MessagesListAsync(int ConversationId, ConversationsApiTypes.ConversationsMessagesListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/conversations/{ConversationId}/messages",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsMessagesListResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsMessagesCreateResponse> MessagesCreateAsync(int ConversationId, ConversationsApiTypes.ConversationsMessagesCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/messages",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsMessagesCreateResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsSearchResponse> SearchAsync(ConversationsApiTypes.ConversationsSearchBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/conversations/search",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsSearchResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsMessagesGetResponse> MessagesGetAsync(int MessageId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/conversations/messages/{MessageId}",
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsMessagesGetResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsMessagesEditResponse> MessagesEditAsync(int ConversationId, int MessageId, ConversationsApiTypes.ConversationsMessagesEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = $"/conversations/{ConversationId}/messages/{MessageId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsMessagesEditResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsMessagesDeleteResponse> MessagesDeleteAsync(int ConversationId, int MessageId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/conversations/{ConversationId}/messages/{MessageId}",
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsMessagesDeleteResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsInviteResponse> InviteAsync(int ConversationId, ConversationsApiTypes.ConversationsInviteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/invite",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsInviteResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsKickResponse> KickAsync(int ConversationId, ConversationsApiTypes.ConversationsKickBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/kick",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsKickResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsReadResponse> ReadAsync(int ConversationId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/read",
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsReadResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsReadAllResponse> ReadAllAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/conversations/read-all",
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsReadAllResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsMessagesStickResponse> MessagesStickAsync(int ConversationId, int MessageId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/messages/{MessageId}/stick",
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsMessagesStickResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsMessagesUnstickResponse> MessagesUnstickAsync(int ConversationId, int MessageId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/conversations/{ConversationId}/messages/{MessageId}/stick",
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsMessagesUnstickResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsStarResponse> StarAsync(int ConversationId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/star",
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsStarResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsUnstarResponse> UnstarAsync(int ConversationId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/conversations/{ConversationId}/star",
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsUnstarResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsAlertsEnableResponse> AlertsEnableAsync(int ConversationId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/alerts",
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsAlertsEnableResponse(__result);
	}

	public async Task<ConversationsApiTypes.ConversationsAlertsDisableResponse> AlertsDisableAsync(int ConversationId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = $"/conversations/{ConversationId}/alerts",
		}, cancellationToken).ConfigureAwait(false);
		return new ConversationsApiTypes.ConversationsAlertsDisableResponse(__result);
	}
}

public sealed class NotificationsApi
{
	private readonly LolzteamHttpClient _http;

	public NotificationsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<NotificationsApiTypes.NotificationsListResponse> ListAsync(NotificationsApiTypes.NotificationsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/notifications",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new NotificationsApiTypes.NotificationsListResponse(__result);
	}

	public async Task<NotificationsApiTypes.NotificationsGetResponse> GetAsync(int NotificationId, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/notifications/{NotificationId}/content",
		}, cancellationToken).ConfigureAwait(false);
		return new NotificationsApiTypes.NotificationsGetResponse(__result);
	}

	public async Task<NotificationsApiTypes.NotificationsReadResponse> ReadAsync(NotificationsApiTypes.NotificationsReadBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/notifications/read",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new NotificationsApiTypes.NotificationsReadResponse(__result);
	}
}

public sealed class TagsApi
{
	private readonly LolzteamHttpClient _http;

	public TagsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<TagsApiTypes.TagsPopularResponse> PopularAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/tags",
		}, cancellationToken).ConfigureAwait(false);
		return new TagsApiTypes.TagsPopularResponse(__result);
	}

	public async Task<TagsApiTypes.TagsListResponse> ListAsync(TagsApiTypes.TagsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/tags/list",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new TagsApiTypes.TagsListResponse(__result);
	}

	public async Task<TagsApiTypes.TagsGetResponse> GetAsync(int TagId, TagsApiTypes.TagsGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/tags/{TagId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new TagsApiTypes.TagsGetResponse(__result);
	}

	public async Task<TagsApiTypes.TagsFindResponse> FindAsync(TagsApiTypes.TagsFindParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/tags/find",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new TagsApiTypes.TagsFindResponse(__result);
	}
}

public sealed class SearchApi
{
	private readonly LolzteamHttpClient _http;

	public SearchApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<SearchApiTypes.SearchAllResponse> AllAsync(SearchApiTypes.SearchAllBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/search",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new SearchApiTypes.SearchAllResponse(__result);
	}

	public async Task<SearchApiTypes.SearchThreadsResponse> ThreadsAsync(SearchApiTypes.SearchThreadsBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/search/threads",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new SearchApiTypes.SearchThreadsResponse(__result);
	}

	public async Task<SearchApiTypes.SearchPostsResponse> PostsAsync(SearchApiTypes.SearchPostsBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/search/posts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new SearchApiTypes.SearchPostsResponse(__result);
	}

	public async Task<SearchApiTypes.SearchUsersResponse> UsersAsync(SearchApiTypes.SearchUsersBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/search/users",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new SearchApiTypes.SearchUsersResponse(__result);
	}

	public async Task<SearchApiTypes.SearchProfilePostsResponse> ProfilePostsAsync(SearchApiTypes.SearchProfilePostsBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/search/profile-posts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new SearchApiTypes.SearchProfilePostsResponse(__result);
	}

	public async Task<SearchApiTypes.SearchTaggedResponse> TaggedAsync(SearchApiTypes.SearchTaggedBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/search/tagged",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new SearchApiTypes.SearchTaggedResponse(__result);
	}

	public async Task<SearchApiTypes.SearchResultsResponse> ResultsAsync(JsonElement SearchId, SearchApiTypes.SearchResultsParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/search/{SearchId}/results",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new SearchApiTypes.SearchResultsResponse(__result);
	}
}

public sealed class BatchApi
{
	private readonly LolzteamHttpClient _http;

	public BatchApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<BatchApiTypes.BatchExecuteResponse> ExecuteAsync(List<JsonElement>? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/batch",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new BatchApiTypes.BatchExecuteResponse(__result);
	}
}

public sealed class ChatboxApi
{
	private readonly LolzteamHttpClient _http;

	public ChatboxApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ChatboxApiTypes.ChatboxIndexResponse> IndexAsync(ChatboxApiTypes.ChatboxIndexParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ChatboxApiTypes.ChatboxIndexResponse(__result);
	}

	public async Task<ChatboxApiTypes.ChatboxGetMessagesResponse> GetMessagesAsync(ChatboxApiTypes.ChatboxGetMessagesParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/messages",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ChatboxApiTypes.ChatboxGetMessagesResponse(__result);
	}

	public async Task<ChatboxApiTypes.ChatboxPostMessageResponse> PostMessageAsync(ChatboxApiTypes.ChatboxPostMessageBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/chatbox/messages",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ChatboxApiTypes.ChatboxPostMessageResponse(__result);
	}

	public async Task<ChatboxApiTypes.ChatboxEditMessageResponse> EditMessageAsync(ChatboxApiTypes.ChatboxEditMessageBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "PUT",
			Path = "/chatbox/messages",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ChatboxApiTypes.ChatboxEditMessageResponse(__result);
	}

	public async Task<ChatboxApiTypes.ChatboxDeleteMessageResponse> DeleteMessageAsync(ChatboxApiTypes.ChatboxDeleteMessageBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/chatbox/messages",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ChatboxApiTypes.ChatboxDeleteMessageResponse(__result);
	}

	public async Task<ChatboxApiTypes.ChatboxOnlineResponse> OnlineAsync(ChatboxApiTypes.ChatboxOnlineParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/messages/online",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ChatboxApiTypes.ChatboxOnlineResponse(__result);
	}

	public async Task<ChatboxApiTypes.ChatboxReportReasonsResponse> ReportReasonsAsync(ChatboxApiTypes.ChatboxReportReasonsParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/messages/report",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ChatboxApiTypes.ChatboxReportReasonsResponse(__result);
	}

	public async Task<ChatboxApiTypes.ChatboxReportResponse> ReportAsync(ChatboxApiTypes.ChatboxReportBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/chatbox/messages/report",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ChatboxApiTypes.ChatboxReportResponse(__result);
	}

	public async Task<ChatboxApiTypes.ChatboxGetLeaderboardResponse> GetLeaderboardAsync(ChatboxApiTypes.ChatboxGetLeaderboardParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/messages/leaderboard",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ChatboxApiTypes.ChatboxGetLeaderboardResponse(__result);
	}

	public async Task<ChatboxApiTypes.ChatboxGetIgnoreResponse> GetIgnoreAsync(CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/ignore",
		}, cancellationToken).ConfigureAwait(false);
		return new ChatboxApiTypes.ChatboxGetIgnoreResponse(__result);
	}

	public async Task<ChatboxApiTypes.ChatboxPostIgnoreResponse> PostIgnoreAsync(ChatboxApiTypes.ChatboxPostIgnoreBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/chatbox/ignore",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ChatboxApiTypes.ChatboxPostIgnoreResponse(__result);
	}

	public async Task<ChatboxApiTypes.ChatboxDeleteIgnoreResponse> DeleteIgnoreAsync(ChatboxApiTypes.ChatboxDeleteIgnoreBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "DELETE",
			Path = "/chatbox/ignore",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new ChatboxApiTypes.ChatboxDeleteIgnoreResponse(__result);
	}
}

public sealed class FormsApi
{
	private readonly LolzteamHttpClient _http;

	public FormsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<FormsApiTypes.FormsListResponse> ListAsync(FormsApiTypes.FormsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "GET",
			Path = "/forms",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new FormsApiTypes.FormsListResponse(__result);
	}

	public async Task<FormsApiTypes.FormsCreateResponse> CreateAsync(FormsApiTypes.FormsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestAsync(new RequestOptions
		{
			Method = "POST",
			Path = "/forms/save",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		}, cancellationToken).ConfigureAwait(false);
		return new FormsApiTypes.FormsCreateResponse(__result);
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
