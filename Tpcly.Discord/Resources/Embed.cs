using System.Text.Json.Serialization;

namespace Tpcly.Discord.Resources;

// From https://discord.com/developers/docs/resources/message#embed-object
public record Embed
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /**
     * Type of embed, (always "rich" for webhook embeds)
     */
    [JsonPropertyName("type")]
    public EmbedType Type { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("url")]
    public Uri? Url { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; set; }

    [JsonPropertyName("color")]
    public int? Color { get; set; }
    
    // todo: footer
    
    [JsonPropertyName("image")]
    public EmbedMedia? Image { get; set; }
    
    [JsonPropertyName("thumbnail")]
    public EmbedMedia? Thumbnail { get; set; }
    
    [JsonPropertyName("video")]
    public EmbedMedia? Video { get; set; }
    
    // todo: provider
    
    // todo: author
    
    [JsonPropertyName("fields")]
    public IEnumerable<EmbedField>? Fields { get; set; }
}