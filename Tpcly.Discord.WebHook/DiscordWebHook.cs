using System.Net.Http.Json;
using Tpcly.Discord.WebHook.Resources;

namespace Tpcly.Discord.WebHook;

public class DiscordWebHook(HttpClient client, string id, string token) : IDiscordWebHook
{
    public HttpResponseMessage Execute(DiscordWebHookMessage message, CancellationToken cancellationToken = default)
    {
        // todo: validate web hook message
        return client.Send(CreateRequestMessage(message), cancellationToken);
    }

    public Task<HttpResponseMessage> ExecuteAsync(DiscordWebHookMessage message, CancellationToken cancellationToken = default)
    {
        // todo: validate web hook message
        return client.SendAsync(CreateRequestMessage(message), cancellationToken);
    }

    private HttpRequestMessage CreateRequestMessage(DiscordWebHookMessage message) => new(HttpMethod.Post, $"/webhooks/{id}/{token}")
    {
        Content = JsonContent.Create(message)
    };
}