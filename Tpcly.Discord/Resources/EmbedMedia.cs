using System.Text.Json.Serialization;

namespace Tpcly.Discord.Resources;

public record EmbedMedia([property: JsonPropertyName("url")] Uri Url)
{
    [property: JsonPropertyName("proxy_url")]
    public Uri? ProxyUrl { get; set; }
    
    [property: JsonPropertyName("height")]
    public int? Height { get; set; }
    
    [property: JsonPropertyName("width")]
    public int? Width { get; set; }
}