using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tpcly.Extensions.Json;

namespace Tpcly.Discord.Resources;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum AllowedMentionType
{
    [EnumMember(Value = "roles")] Roles,
    [EnumMember(Value = "users")] Users,
    [EnumMember(Value = "everyone")] Everyone
}