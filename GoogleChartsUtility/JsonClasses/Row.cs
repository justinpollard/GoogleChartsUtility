using System.Collections.Generic;
using Newtonsoft.Json;

namespace GoogleChartsUtility.Json
{
    public class Row
    {
        [JsonProperty(PropertyName = "c")]
        public List<Cell> cells { get; set; }
    }
}
