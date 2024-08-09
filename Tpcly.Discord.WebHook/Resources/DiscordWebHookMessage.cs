using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tpcly.Discord.Resources;

namespace Tpcly.Discord.WebHook.Resources;

// From https://discord.com/developers/docs/resources/webhook#execute-webhook-jsonform-params
public record DiscordWebHookMessage
{
   /**
    * The message contents (up to 2000 characters)
    */
    [JsonPropertyName("content")]
    [MaxLength(2000)]
    public string? Content { get; set; }

    /**
     * Override the default username of the webhook
     */
    public string? UserName { get; set; }

    /**
     * Override the default avatar of the webhook
     */
    public Uri? AvatarUrl { get; set; }

    /**
     * True if this is a Text-To-Speech (TTS) message
     */
    public bool? Tts { get; set; }

    /**
     * Embedded rich content
     */
    public IEnumerable<Embed>? Embeds { get; set; }
}