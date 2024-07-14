using OKX.API.Base;
using OKX.API.Public.Enums;

namespace OKX.API.Public.Converters
{
    public class InstrumentAliasConverter : BaseConverter<InstrumentAlias>
    {
        public InstrumentAliasConverter(bool useQuotes) : base(useQuotes) { }
        public InstrumentAliasConverter() : base(true) { }

        protected override List<KeyValuePair<InstrumentAlias, string>> Mapping =>
            new List<KeyValuePair<InstrumentAlias, string>>
            {
                new KeyValuePair<InstrumentAlias, string>(InstrumentAlias.ThisWeek, "this_week"),
                new KeyValuePair<InstrumentAlias, string>(InstrumentAlias.NextWeek, "next_week"),
                new KeyValuePair<InstrumentAlias, string>(InstrumentAlias.Quarter, "quarter"),
                new KeyValuePair<InstrumentAlias, string>(InstrumentAlias.NextQuarter, "next_quarter")

            };
    }
}
