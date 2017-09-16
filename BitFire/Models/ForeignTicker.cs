using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitFire.Models
{
    public class ForeignTicker
    {
        public DateTime Date { get; set; }

        [JsonProperty("bid")]
        public decimal Buy { get; set; }

        [JsonProperty("ask")]
        public decimal Sell { get; set; }

        public static ForeignTicker BitfinexTickerFromString(string tickerStr)
        {
            JObject tObj = (JObject)JsonConvert.DeserializeObject(tickerStr);

            var unixDate = (long)(double.Parse(tObj["timestamp"].ToString()) * 1000);
            var date =DateTimeOffset.FromUnixTimeMilliseconds(unixDate).UtcDateTime;

            var ticker = JsonConvert.DeserializeObject<ForeignTicker>(tickerStr);
            ticker.Date = date.ToLocalTime();
            return ticker;
        }

       
    }
}
