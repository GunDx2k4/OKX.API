namespace OKX.API.Extensions
{
    public static class DictionaryExtensions
    {
        public static void AddOptionalParameter(this Dictionary<string, string> parameters, string key, string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (!string.IsNullOrWhiteSpace(value) && value != "null")
                {
                    parameters.Add(key, value);
                }
            }
        }
    }
}
