using Newtonsoft.Json;
using OKX.API.Authentication;
using OKX.API.Base;
using OKX.API.Base.Converters;
using OKX.API.Base.Enums;
using OKX.API.Base.Models;
using OKX.API.Extensions;
using OKX.API.Public.Models;

namespace OKX.API.Public
{
    public class PublicRestClient : BaseRestClient
    {
        public PublicRestClient(CredentialsAPI Credentials) : base(Credentials)
        {
        }

        public async Task<DataResponse<List<SystemTimeResponse>>> GetSystemTimeAsync()
        {
            return await GetAPI<SystemTimeResponse>(EndPointAPI.SYSTEM_TIME);
        }

        public async Task<DataResponse<List<InstrumentResponse>>> GetInstrumentAsync(InstrumentType instrumentType, string uly = "", string instFamily = "", string instId = "")
        {
            var bodyParameters = new Dictionary<string, string>();

            bodyParameters.AddOptionalParameter("instType", JsonConvert.SerializeObject(instrumentType, new InstrumentTypeConverter(false)));
            bodyParameters.AddOptionalParameter("uly", uly);
            bodyParameters.AddOptionalParameter("instFamily", instFamily);
            bodyParameters.AddOptionalParameter("instId", instId);
            
            return await GetAPI<InstrumentResponse>(EndPointAPI.INSTRUMENTS, bodyParameters);
        }
    }
}
