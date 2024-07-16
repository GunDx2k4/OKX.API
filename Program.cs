using Newtonsoft.Json;
using OKX.API.Extensions;

namespace OKX.API
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var API = new RestClientAPI(true);
            var data = await API.Market.GetCandlesticksAsync("BTC-USDT");

            Console.WriteLine($"{JsonConvert.SerializeObject(data.Data[0].Open.ToOKXString())}");
        }
    }
}
