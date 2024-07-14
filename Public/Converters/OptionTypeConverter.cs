using OKX.API.Base.Enums;
using OKX.API.Base;
using OKX.API.Public.Enums;

namespace OKX.API.Public.Converters
{
    public class OptionTypeConverter : BaseConverter<OptionType>
    {
        public OptionTypeConverter(bool useQuotes) : base(useQuotes) { }
        public OptionTypeConverter() : base(true) { }

        protected override List<KeyValuePair<OptionType, string>> Mapping =>
            new List<KeyValuePair<OptionType, string>>
            {
                new KeyValuePair<OptionType, string>(OptionType.Call, "C"),
                new KeyValuePair<OptionType, string>(OptionType.Put, "P")
            };
    }
}
