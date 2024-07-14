using Newtonsoft.Json;
using OKX.API.Extensions;

namespace OKX.API.Account.Models
{
    public class DetailBalanceResponse
    {
        [JsonProperty("ccy")]
        public string Currency { get; set; }

        [JsonProperty("eq")]
        public decimal Equity { get; set; }

        [JsonProperty("cashBal")]
        public decimal CashBalance { get; set; }

        [JsonProperty("uTime")]
        public long UpdateTimestamp { get; set; }

        [JsonIgnore]
        public DateTime UpdateTime { get { return UpdateTimestamp.ConvertFromMilliseconds(); } }

        [JsonProperty("isoEq")]
        public decimal? IsolatedMarginEquity { get; set; }

        [JsonProperty("availEq")]
        public decimal? AvailableEquity { get; set; }

        [JsonProperty("disEq")]
        public decimal DiscountEquity { get; set; }

        [JsonProperty("fixedBal")]
        public decimal? FixedBalance { get; set; }

        [JsonProperty("availBal")]
        public decimal AvailableBalance { get; set; }

        [JsonProperty("frozenBal")]
        public decimal FrozenBalance { get; set; }

        [JsonProperty("ordFrozen")]
        public decimal OrderFrozen { get; set; }

        [JsonProperty("liab")]
        public decimal? Liabilities { get; set; }

        [JsonProperty("upl")]
        public decimal? UnrealizedProfitAndLoss { get; set; }

        [JsonProperty("uplLiab")]
        public decimal? UnrealizedProfitAndLossLiabilities { get; set; }

        [JsonProperty("crossLiab")]
        public decimal? CrossLiabilities { get; set; }

        [JsonProperty("isoLiab")]
        public decimal? IsolatedLiabilities { get; set; }

        [JsonProperty("mgnRatio")]
        public decimal? MarginRatio { get; set; }

        [JsonProperty("interest")]
        public decimal? Interest { get; set; }

        [JsonProperty("twap")]
        public decimal? Twap { get; set; }

        [JsonProperty("maxLoan")]
        public decimal? MaximumLoan { get; set; }

        [JsonProperty("eqUsd")]
        public decimal UsdEquity { get; set; }

        [JsonProperty("borrowFroz")]
        public decimal? BorrowFrozen { get; set; }

        [JsonProperty("notionalLever")]
        public decimal? Leverage { get; set; }

        [JsonProperty("stgyEq")]
        public decimal StrategyEquity { get; set; }

        [JsonProperty("isoUpl")]
        public decimal? IsolatedUnrealizedProfitAndLoss { get; set; }

        [JsonProperty("spotInUseAmt")]
        public decimal? SpotInUseAmount { get; set; }

        [JsonProperty("spotIsoBal")]
        public decimal? SpotIsolatedBalance { get; set; }
    }
}
