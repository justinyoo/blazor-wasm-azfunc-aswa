using System;
using System.Text.Json.Serialization;

using Newtonsoft.Json;

namespace AppModels
{
    public class Post
    {
        [JsonProperty("ID")]
        [JsonPropertyName("ID")]
        public virtual int PostId { get; set; }

        public virtual Author Author { get; set; }

        [JsonProperty("date")]
        [JsonPropertyName("date")]
        public virtual DateTimeOffset DatePublished { get; set; }

        public virtual string Title { get; set; }

        [JsonProperty("URL")]
        [JsonPropertyName("URL")]
        public virtual string Url { get; set; }

        public virtual string Excerpt { get; set; }

        public virtual string Content { get; set; }
    }
}