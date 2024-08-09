using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tpcly.Extensions.Json;

namespace Tpcly.Discord.Resources;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum EmbedType
{
    [EnumMember(Value = "rich")] Rich,
    [EnumMember(Value = "image")] Image,
    [EnumMember(Value = "video")] Video,
    [EnumMember(Value = "gifv")] Gifv,
    [EnumMember(Value = "article")] Article,
    [EnumMember(Value = "link")] Link
}