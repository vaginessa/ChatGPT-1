using System.Text.Json.Serialization;

namespace AI.Model.Json.Chat;

[JsonSerializable(typeof(ChatRequestBody))]
[JsonSerializable(typeof(ChatResponseSuccess))]
[JsonSerializable(typeof(ChatChoice))]
[JsonSerializable(typeof(ChatMessage))]
[JsonSerializable(typeof(ChatUsage))]
[JsonSerializable(typeof(ChatResponseError))]
[JsonSerializable(typeof(ChatError))]
public partial class ChatJsonContext : JsonSerializerContext
{
}
