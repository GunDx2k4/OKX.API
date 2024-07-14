using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace OKX.API.Authentication
{
    public class AuthenticationProvider
    {
        private readonly CredentialsAPI _credentials;

        public AuthenticationProvider(CredentialsAPI Credentials)
        {
            this._credentials = Credentials;
        }

        public async Task AuthenticateRequest(HttpRequestMessage request)
        {
            request.Headers.Accept.Clear();
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (_credentials.IsDemoTrading)
                request.Headers.Add("x-simulated-trading", "1");
            request.Headers.Add("OK-ACCESS-KEY", _credentials.KeyAPI); 
            if (request.Content != null)
            {
                var requestBody = await request.Content.ReadAsStringAsync();
                request.Headers.Add("OK-ACCESS-SIGN", GenerateSignature(request.Method.Method, request.RequestUri.LocalPath, requestBody));
            }
            else
                request.Headers.Add("OK-ACCESS-SIGN", GenerateSignature(request.Method.Method, request.RequestUri.LocalPath + request.RequestUri.Query));
            request.Headers.Add("OK-ACCESS-TIMESTAMP", _credentials.TimeStamp);
            request.Headers.Add("OK-ACCESS-PASSPHRASE", _credentials.PassPhrase);
        }

        private string GenerateSignature(string method, string requestPath, string requestBody = "")
        {
            string prehash = _credentials.TimeStamp + method.ToUpper() + requestPath + requestBody;
            byte[] secretKeyBytes = Encoding.UTF8.GetBytes(_credentials.SecretKey);
            byte[] prehashBytes = Encoding.UTF8.GetBytes(prehash);

            using (var hmacsha256 = new HMACSHA256(secretKeyBytes))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(prehashBytes);
                return Convert.ToBase64String(hashmessage);
            }
        }
    }
}
