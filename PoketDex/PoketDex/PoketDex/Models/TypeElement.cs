namespace PoketDex.Models
{
    using Newtonsoft.Json;

    public class TypeElement
    {
        [JsonProperty("slot")]
        public long Slot { get; set; }

        [JsonProperty("type")]
        public Species Type { get; set; }
    }
}
