using OKX.API.Account;
using OKX.API.Authentication;
using OKX.API.Market;
using OKX.API.Public;

namespace OKX.API
{
    public class RestClientAPI
    {
        public const string API_URL = "https://www.okx.com";

        public CredentialsAPI Credentials { get; }

        public PublicRestClient Public { get; private set; }
        public AccountRestClient Account { get; private set; }
        public MarketRestClient Market { get; private set; }

        public RestClientAPI(bool isDemoTrading) : this(new CredentialsAPI("", "", "", isDemoTrading))
        {

        }

        public RestClientAPI(string keyAPI, string secretKey, string passPhrase, bool isDemoTrading) : this(new CredentialsAPI(keyAPI, secretKey, passPhrase, isDemoTrading))
        {

        }

        public RestClientAPI(CredentialsAPI credentials)
        {
            Credentials = credentials;
            SetAPICredentials();
        }

        private void SetAPICredentials()
        {
            Public = new PublicRestClient(Credentials);
            Account = new AccountRestClient(Credentials);
            Market = new MarketRestClient(Credentials);
        }

        public async Task<bool> CheckResponse()
        {
            var data = await Account.GetBalanceAsync();
            return data.Data != null;
        }
    }
}
