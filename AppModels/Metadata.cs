using System.Collections.Generic;
using System.Text.Json.Serialization;

using Newtonsoft.Json;

namespace AppModels
{
    public class Metadata
    {
        public virtual Dictionary<string, string> Links { get; set; }

        [JsonProperty("next_page")]
        [JsonPropertyName("next_page")]
        public virtual string NextPage { get; set; }

        [JsonProperty("wpcom")]
        [JsonPropertyName("wpcom")]
        public virtual bool IsWordpressCom { get; set; }
    }
}