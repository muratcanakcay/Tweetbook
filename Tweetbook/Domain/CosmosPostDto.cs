using Cosmonaut.Attributes;
using Newtonsoft.Json;

namespace Tweetbook.Domain
{   
    [CosmosCollection("posts")]
    public class CosmosPostDto
    {
        [CosmosPartitionKey]
        [JsonProperty]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}