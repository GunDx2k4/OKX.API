namespace OKX.API.Extensions
{
    public static class DictionaryExtension
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
