using Newtonsoft.Json;
using OKX.API.Account.Converters;
using OKX.API.Account.Enums;
using OKX.API.Account.Models;
using OKX.API.Authentication;
using OKX.API.Base;
using OKX.API.Base.Models;

namespace OKX.API.Account
{
    public class AccountRestClient : BaseRestClient
    {
        public AccountRestClient(CredentialsAPI Credentials) : base(Credentials)
        {
        }

        public async Task<DataResponse<List<BalanceResponse>>> GetBalanceAsync(Currency currency = Currency.All)
        {
            if (currency != Currency.All)
            {
                var bodyParameters = new Dictionary<string, string>();
                bodyParameters.Add("ccy", JsonConvert.SerializeObject(currency, new CurrencyConverter(false)));
                return await GetAPI<BalanceResponse>(EndPointAPI.ACCOUNT_BALANCE, bodyParameters);
            }
            return await GetAPI<BalanceResponse>(EndPointAPI.ACCOUNT_BALANCE);
        }
    }
}
