using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpList.Models
{
    public  class Ingredients
    {
        [JsonProperty("malt")]
        public List<Malt> Malt { get; set; }

        [JsonProperty("hops")]
        public List<Hop> Hops { get; set; }

        [JsonProperty("yeast")]
        public string Yeast { get; set; }
    }
}
