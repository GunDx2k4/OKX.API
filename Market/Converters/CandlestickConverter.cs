using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OKX.API.Base.Converters;
using OKX.API.Market.Models;

namespace OKX.API.Market.Converters
{
    public class CandlestickConverter : JsonConverter<CandlestickResponse>
    {
        public override bool CanRead => true;
        public override bool CanWrite => false;

        public override CandlestickResponse ReadJson(JsonReader reader, Type objectType, CandlestickResponse existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            JArray array = JArray.Load(reader);

            if (array == null || array.Count != 9)
            {
                throw new JsonSerializationException($"Invalid array length. Expected 9 elements but got {array?.Count ?? 0}.");
            }

            return new CandlestickResponse
            {
                Timestamp = array[0].ToObject<long>(),
                Open = array[1].ToObject<decimal>(),
                High = array[2].ToObject<decimal>(),
                Low = array[3].ToObject<decimal>(),
                Close = array[4].ToObject<decimal>(),
                TradingVolume = array[5].ToObject<decimal>(),
                BaseVolume = array[6].ToObject<decimal>(),
                QuoteVolume = array[7].ToObject<decimal>(),
                Confirm = JsonConvert.DeserializeObject<bool>(array[8].ToString(), new BooleanOKXConverter(false))
            };
        }

        public override void WriteJson(JsonWriter writer, CandlestickResponse value, JsonSerializer serializer)
        {

        }
    }
}
