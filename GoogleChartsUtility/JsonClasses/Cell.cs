using Newtonsoft.Json;

namespace GoogleChartsUtility.Json
{
    public class Cell
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [JsonProperty(PropertyName = "v")]
        public object value { get; set; }

        [JsonProperty(PropertyName = "f")]
        public string format { get; set; }
    }
}
