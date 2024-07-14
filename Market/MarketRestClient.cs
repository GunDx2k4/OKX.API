using Newtonsoft.Json;
using OKX.API.Authentication;
using OKX.API.Base;
using OKX.API.Base.Models;
using OKX.API.Extensions;
using OKX.API.Market.Converters;
using OKX.API.Market.Enums;
using OKX.API.Market.Models;

namespace OKX.API.Market
{
    public class MarketRestClient : BaseRestClient
    {
        public MarketRestClient(CredentialsAPI Credentials) : base(Credentials)
        {
        }

        public async Task<DataResponse<List<CandlestickResponse>>>  GetCandlesticksAsync(string instrumentId, BarSizeCandlestick barSizeCandlestick = BarSizeCandlestick.OneMinute, long? after = null, long? before = null, int limit = 100)
        {
            var bodyParameters = new Dictionary<string, string>();

            bodyParameters.AddOptionalParameter("instId", instrumentId);
            bodyParameters.AddOptionalParameter("bar", JsonConvert.SerializeObject(barSizeCandlestick, new BarSizeCandlestickConverter(false)));
            bodyParameters.AddOptionalParameter("after", after.ToString());
            bodyParameters.AddOptionalParameter("before", before.ToString());
            bodyParameters.AddOptionalParameter("limit", limit.ToString());
            
            return await GetAPI<CandlestickResponse>(EndPointAPI.CANDLESTICKS, bodyParameters);
        }
          
    }
}
