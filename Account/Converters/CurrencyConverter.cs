using OKX.API.Account.Enums;
using OKX.API.Base;

namespace OKX.API.Account.Converters
{
    public class CurrencyConverter : BaseConverter<Currency>
    {
        public CurrencyConverter(bool useQuotes) : base(useQuotes) { }
        public CurrencyConverter() : base(true) { }

        protected override List<KeyValuePair<Currency, string>> Mapping =>
            new List<KeyValuePair<Currency, string>>
            {
                new KeyValuePair<Currency, string>(Currency.All, "none"),
                new KeyValuePair<Currency, string>(Currency.BTC, "BTC"),
                new KeyValuePair<Currency, string>(Currency.ETH, "ETH"),
                new KeyValuePair<Currency, string>(Currency.USDT, "USTD")
            };
    }
}
