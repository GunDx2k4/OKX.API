using OKX.API.Base.Enums;

namespace OKX.API.Base.Converters
{
    public class InstrumentTypeConverter : BaseConverter<InstrumentType>
    {
        public InstrumentTypeConverter(bool useQuotes) : base(useQuotes) { }
        public InstrumentTypeConverter() : base(true) { }

        protected override List<KeyValuePair<InstrumentType, string>> Mapping =>
            new List<KeyValuePair<InstrumentType, string>>
            {
                new KeyValuePair<InstrumentType, string>(InstrumentType.Spot, "SPOT"),
                new KeyValuePair<InstrumentType, string>(InstrumentType.Margin, "MARGIN"),
                new KeyValuePair<InstrumentType, string>(InstrumentType.Swap, "SWAP"),
                new KeyValuePair<InstrumentType, string>(InstrumentType.Futures, "FUTURES"),
                new KeyValuePair<InstrumentType, string>(InstrumentType.Option, "OPTION"),

            };
    }
}
