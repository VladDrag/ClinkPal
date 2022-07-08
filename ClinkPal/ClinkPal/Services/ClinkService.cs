using System.Net.Http.Headers;
using System.Text.Json;

namespace ClinkPal.Services;
using System.Threading.Tasks;
using Models;

public class ClinkService : IClinkService
{
    private static Task<Stream> getHttpStreamTask(string url)
    {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        return client.GetStreamAsync(url);
    }
    
    public async Task<CryptoListResponse> GetCryptoListFromMessari()
    {
        var url =
            @"https://data.messari.io/api/v2/assets?fields=id,symbol,metrics/market_data/price_usd,metrics/market_data/price_btc,metrics/market_data/percent_change_usd_last_24_hours,metrics/marketcap/rank,metrics/supply/annual_inflation_percent,metrics/marketcap/liquid_marketcap_usd";
        return await JsonSerializer.DeserializeAsync<CryptoListResponse>(await getHttpStreamTask(url));
    }
    
}