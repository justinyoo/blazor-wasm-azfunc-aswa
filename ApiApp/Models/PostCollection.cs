using System.Collections.Generic;

using Newtonsoft.Json;

namespace ApiApp.Models
{
    public class PostCollection
    {
        public virtual int Found { get; set; }

        public virtual List<PostItem> Posts { get; set; }

        [JsonProperty("meta")]
        public virtual Metadata Metadata { get; set; }
    }
}