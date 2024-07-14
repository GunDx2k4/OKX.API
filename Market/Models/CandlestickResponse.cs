using Newtonsoft.Json;
using OKX.API.Extensions;
using OKX.API.Market.Converters;

namespace OKX.API.Market.Models
{
    [JsonConverter(typeof(CandlestickConverter))]
    public class CandlestickResponse
    {
        public long Timestamp { get; set; }

        public decimal Open { get; set; }

        public decimal High { get; set; }

        public decimal Low { get; set; }

        public decimal Close { get; set; }

        public decimal TradingVolume { get; set; }

        public decimal BaseVolume { get; set; }

        public decimal QuoteVolume { get; set; }

        public bool Confirm { get; set; }

        [JsonIgnore]
        public DateTime Time { get { return Timestamp.ConvertFromMilliseconds(); } }
    }
}
