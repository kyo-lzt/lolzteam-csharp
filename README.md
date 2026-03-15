# lolzteam-csharp

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![CI](https://github.com/kyo-lzt/lolzteam-csharp/actions/workflows/ci.yml/badge.svg)](https://github.com/kyo-lzt/lolzteam-csharp/actions)

C# API wrapper for the [Lolzteam](https://lolz.live) Forum and Market APIs. **266 endpoints** (151 Forum + 115 Market), auto-generated from OpenAPI specifications. Fully async with `Task`-based API and `CancellationToken` support.

## Features

- **Complete API coverage** -- 266 endpoints across Forum and Market clients
- **Auto-generated** -- clients and types generated from OpenAPI 3.1.0 specs, always in sync
- **Async-only** -- every method returns `Task<JsonElement>` with `CancellationToken` support
- **Proxy support** -- HTTP, HTTPS, and SOCKS5 via `WebProxy`
- **Retry logic** -- exponential backoff with jitter, respects `Retry-After` headers
- **Rate limiting** -- thread-safe token bucket with `SemaphoreSlim`
- **Typed exceptions** -- exception hierarchy with pattern matching
- **Zero dependencies** -- only `System.Text.Json` (built-in)

## Quick Start

Requires **.NET 8+**.

```sh
git clone https://github.com/kyo-lzt/lolzteam-csharp.git
cd lolzteam-csharp
dotnet build
```

## Usage

```csharp
using Lolzteam.Api.Runtime;
using Lolzteam.Api.Generated.Forum;
using Lolzteam.Api.Generated.Market;

var config = new ClientConfig { Token = "your_token" };
using var forum = new ForumClient(config);
using var market = new MarketClient(config);

var threads = await forum.Threads.ListAsync();
var items = await market.Category.AllAsync();
```

Forum API groups: `OAuth`, `Assets`, `Categories`, `Forums`, `Links`, `Pages`, `Navigation`, `Threads`, `Posts`, `Users`, `ProfilePosts`, `Conversations`, `Notifications`, `Tags`, `Search`, `Batch`, `Chatbox`, `Forms`.

Market API groups: `Category`, `List`, `Managing`, `Profile`, `Cart`, `Purchasing`, `CustomDiscounts`, `Publishing`, `Payments`, `AutoPayments`, `Proxy`, `Imap`, `Batch`.

## Configuration

```csharp
var config = new ClientConfig
{
    Token = "your_token",
    BaseUrl = "https://prod-api.lolz.live",
    Proxy = new ProxyConfig("http://user:pass@127.0.0.1:8080"),
    Retry = new RetryConfig
    {
        MaxRetries = 5,                             // default: 3
        BaseDelay = TimeSpan.FromSeconds(1),        // default: 1s
        MaxDelay = TimeSpan.FromSeconds(30),        // default: 30s
    },
    RateLimit = new RateLimitConfig(200),
};
```

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `Token` | `string` | *required* | API access token |
| `BaseUrl` | `string?` | per-client | Override base URL |
| `Proxy` | `ProxyConfig?` | `null` | Proxy URL (http/https/socks5) |
| `Retry` | `RetryConfig` | 3 retries, 1s base, 30s max | Retry behavior |
| `RateLimit` | `RateLimitConfig?` | Forum: 300/min, Market: 120/min | Requests per minute |

## Retry Logic

Failed requests are retried automatically for transient errors. The delay uses exponential backoff with jitter. `Retry-After` header on 429 responses is respected.

| Status | Retried | Behavior |
|--------|---------|----------|
| 429 | Yes | Uses `Retry-After` header if present |
| 502, 503, 504 | Yes | Exponential backoff with jitter |
| Network errors | Yes | Timeout and connection errors |
| 401, 403 | No | Thrown immediately |
| 404 | No | Thrown immediately |

Delay formula: `min(baseDelay * 2^attempt + random(0, baseDelay), maxDelay)`

```csharp
// Disable retry
var client = new ForumClient(new ClientConfig { Token = "...", Retry = null });

// OnRetry callback
var client = new ForumClient(new ClientConfig
{
    Token = "...",
    Retry = new RetryConfig { OnRetry = info => Console.WriteLine($"Retry #{info.Attempt}") },
});
```

## Proxy

Configured via `ProxyConfig`. Supported schemes: `http`, `https`, `socks5`.

```csharp
var config = new ClientConfig
{
    Token = "your_token",
    Proxy = new ProxyConfig("socks5://127.0.0.1:1080"),
};
```

## Error Handling

All exceptions extend `LolzteamException`:

```csharp
try
{
    var result = await forum.Threads.ListAsync();
}
catch (RateLimitException e)
{
    Console.WriteLine($"Rate limited, retry after: {e.RetryAfter}");
}
catch (AuthException e)
{
    Console.WriteLine($"Auth failed: {e.StatusCode}");
}
catch (NotFoundException)
{
    Console.WriteLine("Not found");
}
catch (ServerException e)
{
    Console.WriteLine($"Server error: {e.StatusCode}");
}
catch (HttpException e)
{
    Console.WriteLine($"HTTP {e.StatusCode}: {e.ResponseBody}");
}
catch (NetworkException e)
{
    Console.WriteLine($"Network error: {e.InnerException}");
}
```

Error hierarchy:

```
LolzteamException
├── HttpException
│   ├── RateLimitException    (429)
│   ├── AuthException         (401, 403)
│   ├── NotFoundException     (404)
│   └── ServerException       (500, 501, 502, 503)
├── NetworkException
└── ConfigException
```

## Rate Limits

The built-in rate limiter uses a token bucket algorithm. Thread-safe with `SemaphoreSlim`. When the bucket is empty, `AcquireAsync()` awaits until tokens refill -- no requests are dropped.

| Client | Default limit |
|--------|---------------|
| Forum  | 300 req/min   |
| Market | 120 req/min   |
| Market (search) | 20 req/min |

```csharp
var client = new MarketClient(new ClientConfig
{
    Token = "...",
    SearchRateLimit = new RateLimitConfig { RequestsPerMinute = 30 },
});
```

## Code Generation

Clients and types are auto-generated from OpenAPI 3.1.0 specs in `schemas/`:

```sh
dotnet run --project codegen/Lolzteam.Codegen
```

| Input | Output |
|-------|--------|
| `schemas/forum.json` | `Generated/Forum/ForumClient.cs`, `Types.cs` |
| `schemas/market.json` | `Generated/Market/MarketClient.cs`, `Types.cs` |

Generator source is in `codegen/Lolzteam.Codegen/`.

## Project Structure

```
schemas/                        OpenAPI 3.1.0 specifications
codegen/Lolzteam.Codegen/      Code generator (console app)
src/Lolzteam.Api/
  Runtime/                      HTTP client, config, retry, rate limiter, exceptions
  Generated/
    Forum/                      ForumClient + types (auto-generated)
    Market/                     MarketClient + types (auto-generated)
tests/Lolzteam.Api.Tests/      xUnit tests
Lolzteam.sln
```

## Commands

```sh
dotnet build                                          # Build all projects
dotnet run --project codegen/Lolzteam.Codegen         # Generate clients from OpenAPI specs
dotnet test                                           # Run tests
dotnet pack --configuration Release                   # Create NuGet package
```

## License

[MIT](LICENSE)
