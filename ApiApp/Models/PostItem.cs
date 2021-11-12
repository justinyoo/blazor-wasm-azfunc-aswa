using System;

using Newtonsoft.Json;

namespace ApiApp.Models
{
    public class PostItem
    {
        [JsonProperty("ID")]
        public virtual int PostId { get; set; }

        public virtual Author Author { get; set; }

        [JsonProperty("date")]
        public virtual DateTimeOffset DatePublished { get; set; }

        public virtual string Title { get; set; }

        [JsonProperty("URL")]
        public virtual string Url { get; set; }

        public virtual string Excerpt { get; set; }

        public virtual string Content { get; set; }
    }
}