namespace OKX.API.Authentication
{
    public class CredentialsAPI
    {
        public string KeyAPI { get; }
        public string SecretKey { get; }
        public string PassPhrase { get; }
        public string TimeStamp => DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.sssZ");
        public bool IsDemoTrading { get; }

        public CredentialsAPI(string keyAPI, string secretKey, string passPhrase, bool isDemoTrading)
        {
            KeyAPI = keyAPI;
            SecretKey = secretKey;
            PassPhrase = passPhrase;
            IsDemoTrading = isDemoTrading;
        }
    }
}
