using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace EmpList.Models
{

    public  class MashTemp
    {
        [JsonProperty("temp")]
        public BoilVolume Temp { get; set; }

        [JsonProperty("duration")]
        public long? Duration { get; set; }
    }
}
