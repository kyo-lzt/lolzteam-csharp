using System.Diagnostics;
using Lolzteam.Api.Runtime;
using Xunit;

namespace Lolzteam.Api.Tests;

public class RateLimiterTests
{
    [Fact]
    public async Task AllowsRequestsWithinLimit()
    {
        using var limiter = new RateLimiter(100);
        var sw = Stopwatch.StartNew();

        for (var i = 0; i < 5; i++)
        {
            await limiter.AcquireAsync();
        }

        sw.Stop();
        Assert.True(sw.ElapsedMilliseconds < 500, $"Expected < 500ms but took {sw.ElapsedMilliseconds}ms");
    }

    [Fact]
    public async Task RateLimitsAfterBurst()
    {
        using var limiter = new RateLimiter(3);

        // Exhaust all tokens
        for (var i = 0; i < 3; i++)
        {
            await limiter.AcquireAsync();
        }

        // 4th request should block waiting for token refill
        var sw = Stopwatch.StartNew();
        await limiter.AcquireAsync();
        sw.Stop();

        Assert.True(sw.ElapsedMilliseconds >= 500, $"Expected >= 500ms but took {sw.ElapsedMilliseconds}ms");
    }
}
