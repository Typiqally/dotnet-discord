using System.Text.Json.Serialization;

namespace Tpcly.Discord.Resources;

public record EmbedField(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("value")] string Value,
    [property: JsonPropertyName("inline")] bool? Inline = null
);