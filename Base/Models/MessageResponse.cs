using Newtonsoft.Json;

namespace OKX.API.Base.Models
{
    public class MessageResponse
    {
        [JsonProperty("sCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("sMsg")]
        public string ErrorMessage { get; set; }
    }
}
