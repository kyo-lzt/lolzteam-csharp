using Lolzteam.Api.Runtime;
using Xunit;

namespace Lolzteam.Api.Tests;

public class ConfigTests
{
    [Fact]
    public void ConfigProperties()
    {
        var config = new ClientConfig
        {
            Token = "my-token",
            BaseUrl = "https://api.example.com",
        };

        Assert.Equal("my-token", config.Token);
        Assert.Equal("https://api.example.com", config.BaseUrl);
    }

    [Fact]
    public void DefaultRetryConfig()
    {
        var config = new ClientConfig
        {
            Token = "my-token",
            BaseUrl = "https://api.example.com",
        };

        Assert.NotNull(config.Retry);
        Assert.Equal(3, config.Retry.MaxRetries);
    }

    [Fact]
    public void ProxyRejectsInvalidUrl()
    {
        var config = new ClientConfig
        {
            Token = "my-token",
            BaseUrl = "https://api.example.com",
            Proxy = new ProxyConfig("not a valid url"),
        };

        var ex = Assert.Throws<ConfigException>(() => new LolzteamHttpClient(config));
        Assert.Contains("Invalid proxy URL", ex.Message);
    }

    [Fact]
    public void ProxyRejectsUnsupportedScheme()
    {
        var config = new ClientConfig
        {
            Token = "my-token",
            BaseUrl = "https://api.example.com",
            Proxy = new ProxyConfig("ftp://proxy.example.com:8080"),
        };

        var ex = Assert.Throws<ConfigException>(() => new LolzteamHttpClient(config));
        Assert.Contains("Unsupported proxy scheme", ex.Message);
    }

    [Fact]
    public void ProxyAcceptsHttp()
    {
        var config = new ClientConfig
        {
            Token = "my-token",
            BaseUrl = "https://api.example.com",
            Proxy = new ProxyConfig("http://proxy.example.com:8080"),
        };

        using var client = new LolzteamHttpClient(config);
        Assert.NotNull(client);
    }

    [Fact]
    public void ProxyAcceptsSocks5()
    {
        var config = new ClientConfig
        {
            Token = "my-token",
            BaseUrl = "https://api.example.com",
            Proxy = new ProxyConfig("socks5://proxy.example.com:1080"),
        };

        using var client = new LolzteamHttpClient(config);
        Assert.NotNull(client);
    }
}
