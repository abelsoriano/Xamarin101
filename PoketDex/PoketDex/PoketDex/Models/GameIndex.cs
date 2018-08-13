namespace PoketDex.Models
{
    using Newtonsoft.Json;

    public class GameIndex
    {
        [JsonProperty("game_index")]
        public long GameIndexGameIndex { get; set; }

        [JsonProperty("version")]
        public Species Version { get; set; }
    }
}
