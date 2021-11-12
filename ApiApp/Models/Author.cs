using Newtonsoft.Json;

namespace ApiApp.Models
{
    public class Author
    {
        [JsonProperty("ID")]
        public virtual int AuthorId { get; set; }

        [JsonProperty("first_name")]
        public virtual string FirstName { get; set; }

        [JsonProperty("last_name")]
        public virtual string Surname { get; set; }

        public virtual string Name { get; set; }
    }
}