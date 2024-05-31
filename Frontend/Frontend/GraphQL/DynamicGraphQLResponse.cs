using System.Text.Json;
using System.Text.Json.Serialization;

namespace Frontend.GraphQL
{
    public class DynamicGraphQLResponse
    {
        [JsonPropertyName("data")]
        public JsonElement Data { get; set; }
    }
}
