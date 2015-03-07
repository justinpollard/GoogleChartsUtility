using System.Collections.Generic;
using Newtonsoft.Json;

namespace GoogleChartsUtility.Json
{
    public class DataTable
    {
        public DataTable()
        {
            columns = new List<Column>();
            rows = new List<Row>();
        }

        [JsonProperty(PropertyName = "cols")]
        public List<Column> columns { get; set; }

        public List<Row> rows { get; set; }
    }
}
