using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace specflow_restsharp.Helpers
{
    class CountryInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("subregion")]
        public string SubRegion { get; set; }
    }
}
