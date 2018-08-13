namespace PoketDex.Models
{
    using Newtonsoft.Json;

    public class Ability
    {
        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("slot")]
        public long Slot { get; set; }

        [JsonProperty("ability")]
        public Species AbilityAbility { get; set; }
    }
}
