using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace EmpList.Models
{
    public  class Malt
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("amount")]
        public BoilVolume Amount { get; set; }
    }
}
