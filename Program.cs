using Newtonsoft.Json;

namespace OKX.API
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var API = new RestClientAPI("keyAPI", "secretKey", "passPhrase", true);
            var data = await API.Market.GetCandlesticksAsync("BTC-USDT");

            Console.WriteLine($"{JsonConvert.SerializeObject(data.Data)}");
        }
    }
}
