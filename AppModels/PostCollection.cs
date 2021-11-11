using System.Collections.Generic;
using System.Text.Json.Serialization;

using Newtonsoft.Json;

namespace AppModels
{
    public class PostCollection
    {
        public virtual int Found { get; set; }

        public virtual List<Post> Posts { get; set; }

        [JsonProperty("meta")]
        [JsonPropertyName("meta")]
        public virtual Metadata Metadata { get; set; }
    }
}