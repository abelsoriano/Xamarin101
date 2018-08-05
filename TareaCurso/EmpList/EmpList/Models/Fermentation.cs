using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace EmpList.Models
{
    public  class Fermentation
    {
        [JsonProperty("temp")]
        public BoilVolume Temp { get; set; }
    }
}
