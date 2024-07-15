using OKX.API.Base;
using OKX.API.Market.Enums;

namespace OKX.API.Market.Converters
{
    public class BarSizeCandlestickConverter : BaseConverter<BarSizeCandlestick>
    {
        public BarSizeCandlestickConverter(bool useQuotes) : base(useQuotes) { }
        public BarSizeCandlestickConverter() : base(true) { }

        protected override List<KeyValuePair<BarSizeCandlestick, string>> Mapping =>
            new List<KeyValuePair<BarSizeCandlestick, string>>
            {
                new KeyValuePair<BarSizeCandlestick, string>(BarSizeCandlestick.OneMinute, "1m"),
                new KeyValuePair<BarSizeCandlestick, string>(BarSizeCandlestick.ThreeMinutes, "3m"),
                new KeyValuePair<BarSizeCandlestick, string>(BarSizeCandlestick.FiveMinutes, "5m"),
                new KeyValuePair<BarSizeCandlestick, string>(BarSizeCandlestick.FifteenMinutes, "15m"),
                new KeyValuePair<BarSizeCandlestick, string>(BarSizeCandlestick.ThirtyMinutes, "30m"),
                new KeyValuePair<BarSizeCandlestick, string>(BarSizeCandlestick.OneHour, "1H"),
                new KeyValuePair<BarSizeCandlestick, string>(BarSizeCandlestick.TwoHour, "2H"),
                new KeyValuePair<BarSizeCandlestick, string>(BarSizeCandlestick.FourHours, "4H"),
                new KeyValuePair<BarSizeCandlestick, string>(BarSizeCandlestick.SixHours, "6H"),
                new KeyValuePair<BarSizeCandlestick, string>(BarSizeCandlestick.TwelveHours, "12H"),
                new KeyValuePair<BarSizeCandlestick, string>(BarSizeCandlestick.OneDay, "1D"),
                new KeyValuePair<BarSizeCandlestick, string>(BarSizeCandlestick.OneWeek, "1W"),
                new KeyValuePair<BarSizeCandlestick, string>(BarSizeCandlestick.OneMonth, "1M"),
                new KeyValuePair<BarSizeCandlestick, string>(BarSizeCandlestick.ThreeMonths, "3M"),
                new KeyValuePair<BarSizeCandlestick, string>(BarSizeCandlestick.SixMonths, "6M"),
                new KeyValuePair<BarSizeCandlestick, string>(BarSizeCandlestick.OneYear, "1Y")

            };
    }
}
