using OKX.API.Authentication;
using OKX.API.Base;
using OKX.API.Base.Models;

namespace OKX.API.Public
{
    public class PublicRestClient : BaseRestClient
    {
        public PublicRestClient(CredentialsAPI Credentials) : base(Credentials)
        {
        }

        public async Task<DataResponse<List<SystemTimeResponse>>> GetSystemTime()
        {
            return await GetAPI<SystemTimeResponse>(EndPointAPI.SYSTEM_TIME);
        }
    }
}
