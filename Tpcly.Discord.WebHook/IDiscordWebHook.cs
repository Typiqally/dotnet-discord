using Tpcly.Discord.WebHook.Resources;

namespace Tpcly.Discord.WebHook;

public interface IDiscordWebHook
{
    public HttpResponseMessage Execute(DiscordWebHookMessage message,  CancellationToken cancellationToken = default);

    public Task<HttpResponseMessage> ExecuteAsync(DiscordWebHookMessage message, CancellationToken cancellationToken = default);
}