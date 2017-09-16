using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitFire.Models
{
    public class NativeTicker
    {
        public DateTime Date { get; set; }

        [JsonProperty("buy")]
        public decimal Buy { get; set; }

        [JsonProperty("sell")]
        public decimal Sell { get; set; }

        public static NativeTicker OkCoinTickerFromString(string tickerStr)
        {
            JObject tObj = (JObject)JsonConvert.DeserializeObject(tickerStr);

            var unixDate = long.Parse(tObj["date"].ToString());
            var date =DateTimeOffset.FromUnixTimeSeconds(unixDate).UtcDateTime;

            var ticker = JsonConvert.DeserializeObject<NativeTicker>(tObj["ticker"].ToString());
            ticker.Date = date.ToLocalTime();
            return ticker;
        }

        public static NativeTicker ViabtcTickerFromString(string tickerStr)
        {
            JObject tObj = (JObject)JsonConvert.DeserializeObject(tickerStr);

            var unixDate = long.Parse(tObj["data"]["date"].ToString());
            var date = DateTimeOffset.FromUnixTimeMilliseconds(unixDate).UtcDateTime;

            var ticker = JsonConvert.DeserializeObject<NativeTicker>(tObj["data"]["ticker"].ToString());
            ticker.Date = date.ToLocalTime();
            return ticker;
        }
    }
}
