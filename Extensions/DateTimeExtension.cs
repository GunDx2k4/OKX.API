namespace OKX.API.Extensions
{
    public static class DateTimeExtension
    {
        public static DateTime ConvertFromMilliseconds(this long milliseconds) => DateTimeOffset.FromUnixTimeMilliseconds(milliseconds).LocalDateTime;

        public static long ToUnixTimeMilliseconds(this DateTime dateTime) => new DateTimeOffset(dateTime).ToUnixTimeMilliseconds();
    }
}
