namespace PoketDex.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Move
    {
        [JsonProperty("move")]
        public Species MoveMove { get; set; }

        [JsonProperty("version_group_details")]
        public List<VersionGroupDetail> VersionGroupDetails { get; set; }
    }
}
