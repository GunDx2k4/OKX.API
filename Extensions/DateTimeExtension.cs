namespace OKX.API.Extensions
{
    public static class DateTimeExtension
    {
        private static readonly DateTime _epoch = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime ConvertFromMilliseconds(this long milliseconds) => _epoch.AddTicks(milliseconds * TimeSpan.TicksPerMillisecond);
    }
}
