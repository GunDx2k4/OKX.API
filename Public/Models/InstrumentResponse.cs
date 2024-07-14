using Newtonsoft.Json;
using OKX.API.Base.Converters;
using OKX.API.Base.Enums;
using OKX.API.Public.Converters;
using OKX.API.Public.Enums;
using OKX.API.Extensions;

namespace OKX.API.Public.Models
{
    public class InstrumentResponse
    {
        [JsonProperty("instType"), JsonConverter(typeof(InstrumentTypeConverter))]
        public InstrumentType InstrumentType { get; set; }

        [JsonProperty("instId")]
        public string InstrumentId { get; set; }

        [JsonProperty("uly")]
        public string Underlying { get; set; }

        [JsonProperty("instFamily")]
        public string InstrumentFamily { get; set; }

        [JsonProperty("baseCcy")]
        public string BaseCurrency { get; set; }

        [JsonProperty("quoteCcy")]
        public string QuoteCurrency { get; set; }

        [JsonProperty("settleCcy")]
        public string SettlementCurrency { get; set; }

        [JsonProperty("ctVal")]
        public decimal? ContractValue { get; set; }

        [JsonProperty("ctMult")]
        public decimal? ContractMultiplier { get; set; }

        [JsonProperty("ctValCcy")]
        public string ContractValueCurrency { get; set; }

        [JsonProperty("optType"), JsonConverter(typeof(OptionTypeConverter))]
        public OptionType? OptionType { get; set; }

        [JsonProperty("stk")]
        public decimal? StrikePrice { get; set; }

        [JsonProperty("listTime")]
        public long? ListingTimestamp { get; set; }

        [JsonIgnore]
        public DateTime? ListingTime { get { return ListingTimestamp?.ConvertFromMilliseconds(); } }

        [JsonProperty("expTime")]
        public long? ExpiryTimestamp { get; set; }

        [JsonIgnore]
        public DateTime? ExpiryTime { get { return ExpiryTimestamp?.ConvertFromMilliseconds(); } }

        [JsonProperty("lever")]
        public decimal? MaximumLeverage { get; set; }

        [JsonProperty("tickSz")]
        public decimal TickSize { get; set; }

        [JsonProperty("lotSz")]
        public decimal LotSize { get; set; }

        [JsonProperty("minSz")]
        public decimal MinimumOrderSize { get; set; }

        [JsonProperty("ctType"), JsonConverter(typeof(ContractTypeConverter))]
        public ContractType? ContractType { get; set; }

        [JsonProperty("alias"), JsonConverter(typeof(InstrumentAliasConverter))]
        public InstrumentAlias? Alias { get; set; }

        [JsonProperty("state"), JsonConverter(typeof(InstrumentStateConverter))]
        public InstrumentState State { get; set; }

        [JsonProperty("maxLmtSz")]
        public decimal? MaximumLimitOrderSize { get; set; }

        [JsonProperty("maxMktSz")]
        public decimal? MaximumMarketOrderSize { get; set; }

        [JsonProperty("maxLmtAmt")]
        public decimal? MaximumLimitOrderAmount { get; set; }

        [JsonProperty("maxMktAmt")]
        public decimal? MaximumMarketOrderAmount { get; set; }

        [JsonProperty("maxTwapSz")]
        public decimal? MaximumTwapOrderSize { get; set; }

        [JsonProperty("maxIcebergSz")]
        public decimal? MaximumIcebergOrderSize { get; set; }

        [JsonProperty("maxTriggerSz")]
        public decimal? MaximumTriggerOrderSize { get; set; }

        [JsonProperty("maxStopSz")]
        public decimal? MaximumStopMarketSize { get; set; }

    }
}
