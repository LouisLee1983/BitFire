using BitFire.Models;
using Newtonsoft.Json;
using OKCoinRestAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitFire
{
    public partial class Form1 : Form
    {
        const string okCoinUrl = "https://www.okcoin.cn";
        StockRestApi okCoinClient = new StockRestApi(okCoinUrl);

        const string viabtcUrl = "https://api.viabtc.com/v1/market/ticker?market=ethcny";
        HttpClient viabtcClient = new HttpClient();

        const string bitfinexUrl = "https://api.bitfinex.com/v1/pubticker/ethusd";
        HttpClient bitfinexClient = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRefreshOKCoinEth_Click(object sender, EventArgs e)
        {
            //
           
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var okCoinTickerStr = okCoinClient.ticker("eth_cny");
            var okCoinTicker = NativeTicker.OkCoinTickerFromString(okCoinTickerStr);

            labelOKCoinEthTime.Text = okCoinTicker.Date.ToString();
            labelOKCoinEthBuyPrice.Text = okCoinTicker.Buy.ToString();
            labelOKCoinEthSellPrice.Text = okCoinTicker.Sell.ToString();

            var viabtcTickerStr = viabtcClient.GetStringAsync(viabtcUrl).Result;
            var viabtcTicker = NativeTicker.ViabtcTickerFromString(viabtcTickerStr);

            labelViabtcEthTime.Text = viabtcTicker.Date.ToString();
            labelViabtcEthBuyPrice.Text = viabtcTicker.Buy.ToString();
            labelViabtcEthSellPrice.Text = viabtcTicker.Sell.ToString();

            var bitfinexTickerStr = bitfinexClient.GetStringAsync(bitfinexUrl).Result;
            var bitfinexTicker = ForeignTicker.BitfinexTickerFromString(bitfinexTickerStr);

            var usdExchangeRate = decimal.Parse(textBoxUsdExchangeRate.Text);
            labelBitfinexEthTime.Text = bitfinexTicker.Date.ToString();
            labelBitfinexEthBuyPrice.Text = bitfinexTicker.Buy 
                + "(" + bitfinexTicker.Buy * usdExchangeRate + ")";
            labelBitfinexEthSellPrice.Text = bitfinexTicker.Sell
                + "(" + bitfinexTicker.Sell * usdExchangeRate + ")";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
