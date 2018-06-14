using Newtonsoft.Json;

namespace PopularGames.Core.Models
{
    public class Game
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("cover")]
        public Cover Cover { get; set; }
    }
}
