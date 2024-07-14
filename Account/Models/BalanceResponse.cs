using Newtonsoft.Json;
using OKX.API.Extensions;

namespace OKX.API.Account.Models
{
    public class BalanceResponse
    {
        [JsonProperty("uTime")]
        public long UpdateTimestamp { get; set; }

        [JsonIgnore]
        public DateTime UpdateTime { get { return UpdateTimestamp.ConvertFromMilliseconds(); } }

        [JsonProperty("totalEq")]
        public decimal TotalEquity { get; set; }

        [JsonProperty("isoEq")]
        public decimal? IsolatedMarginEquity { get; set; }

        [JsonProperty("adjEq")]
        public decimal? AdjustedEquity { get; set; }

        [JsonProperty("ordFroz")]
        public decimal? OrderFrozen { get; set; }

        [JsonProperty("imr")]
        public decimal? InitialMarginRequirement { get; set; }

        [JsonProperty("mmr")]
        public decimal? MaintenanceMarginRequirement { get; set; }

        [JsonProperty("borrowFroz")]
        public decimal? BorrowFrozen { get; set; }

        [JsonProperty("mgnRatio")]
        public decimal? MarginRatio { get; set; }

        [JsonProperty("notionalUsd")]
        public decimal? NotionalUsd { get; set; }

        [JsonProperty("details")]
        public List<DetailBalanceResponse> Details { get; set; }
    }
}
