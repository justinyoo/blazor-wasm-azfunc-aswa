using System.Text.Json.Serialization;

using Newtonsoft.Json;

namespace AppModels
{
    public class Author
    {
        [JsonProperty("ID")]
        [JsonPropertyName("ID")]
        public virtual int AuthorId { get; set; }

        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public virtual string FirstName { get; set; }

        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public virtual string Surname { get; set; }

        public virtual string Name { get; set; }
    }
}