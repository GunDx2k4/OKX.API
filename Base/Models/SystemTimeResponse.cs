using Newtonsoft.Json;
using OKX.API.Extensions;

namespace OKX.API.Base.Models
{
    public class SystemTimeResponse
    {
        [JsonProperty("ts")]
        public long Timestamp { get; set; }

        [JsonIgnore]
        public DateTime Time { get { return Timestamp.ConvertFromMilliseconds(); } }
    }
}
