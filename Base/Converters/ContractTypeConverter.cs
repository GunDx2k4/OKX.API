using OKX.API.Base.Enums;

namespace OKX.API.Base.Converters
{
    public class ContractTypeConverter : BaseConverter<ContractType>
    {
        public ContractTypeConverter(bool useQuotes) : base(useQuotes) { }
        public ContractTypeConverter() : base(true) { }

        protected override List<KeyValuePair<ContractType, string>> Mapping =>
            new List<KeyValuePair<ContractType, string>>
            {
                new KeyValuePair<ContractType, string>(ContractType.Linear, "linear"),
                new KeyValuePair<ContractType, string>(ContractType.Inverse, "inverse")

            };
    }
}
