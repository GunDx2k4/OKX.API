using OKX.API.Base.Enums;
using OKX.API.Base;
using OKX.API.Public.Enums;

namespace OKX.API.Public.Converters
{
    public class InstrumentStateConverter : BaseConverter<InstrumentState>
    {
        public InstrumentStateConverter(bool useQuotes) : base(useQuotes) { }
        public InstrumentStateConverter() : base(true) { }

        protected override List<KeyValuePair<InstrumentState, string>> Mapping =>
            new List<KeyValuePair<InstrumentState, string>>
            {
                new KeyValuePair<InstrumentState, string>(InstrumentState.Live, "live"),
                new KeyValuePair<InstrumentState, string>(InstrumentState.Suspend, "suspend"),
                new KeyValuePair<InstrumentState, string>(InstrumentState.PreOpen, "preopen")

            };
    }
}
