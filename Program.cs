namespace OKX.API
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var API = new RestClientAPI("keyAPI", "secretKey", "passPhrase", true);
            var data = await API.CheckResponse();

            Console.WriteLine("Connected API");
        }
    }
}
