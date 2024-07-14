namespace OKX.API.Base.Converters
{
    public class BooleanOKXConverter : BaseConverter<bool>
    {
        public BooleanOKXConverter(bool useQuotes) : base(useQuotes) { }
        public BooleanOKXConverter() : base(true) { }

        protected override List<KeyValuePair<bool, string>> Mapping =>
            new List<KeyValuePair<bool, string>>
            {
                new KeyValuePair<bool, string>(true, "1"),
                new KeyValuePair<bool, string>(true, "True"),
                new KeyValuePair<bool, string>(true, "true"),
                new KeyValuePair<bool, string>(true, "Yes"),
                new KeyValuePair<bool, string>(true, "yes"),
                new KeyValuePair<bool, string>(true, "T"),
                new KeyValuePair<bool, string>(true, "t"),
                new KeyValuePair<bool, string>(true, "Y"),
                new KeyValuePair<bool, string>(true, "y"),
                new KeyValuePair<bool, string>(false, "0"),
                new KeyValuePair<bool, string>(false, "False"),
                new KeyValuePair<bool, string>(false, "flase"),
                new KeyValuePair<bool, string>(false, "No"),
                new KeyValuePair<bool, string>(false, "no"),
                new KeyValuePair<bool, string>(false, "F"),
                new KeyValuePair<bool, string>(false, "f"),
                new KeyValuePair<bool, string>(false, "N"),
                new KeyValuePair<bool, string>(false, "n")

            };
    }
}
