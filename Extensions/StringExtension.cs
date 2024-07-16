namespace OKX.API.Extensions
{
    public static class StringExtension
    {
        public static string ToOKXString(this object @this)
        {
            bool isNull = @this is null;
            bool isDBNull = @this is not null && @this.GetType() == typeof(DBNull);

            if (isNull) return string.Empty;
            if (isDBNull) return string.Empty;
            if (@this is float s02) return s02.ToString("0.##");
            if (@this is double s03) return s03.ToString("0.##");
            if (@this is decimal s01) return s01.ToString("0.##");
            if (@this is short s06) return s06.ToString();
            if (@this is int s04) return s04.ToString();
            if (@this is long s05) return s05.ToString();

            return @this.ToString();
        }

        public static string ToOKXFormattedNumber(this object @this)
        {
            if (@this is float s02) return s02.ToString($"+0.############################;-0.###############");
            if (@this is double s03) return s03.ToString($"+0.############################;-0.###############");
            if (@this is decimal s01) return s01.ToString($"+0.############################;-0.###############");
            if (@this is short s06) return s06.ToString($"+0.###############;-0.###############");
            if (@this is int s04) return s04.ToString($"+0.###############;-0.###############");
            if (@this is long s05) return s05.ToString($"+0.###############;-0.###############");

            return @this.ToString();
        }
    }
}
