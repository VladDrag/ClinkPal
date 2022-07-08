using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClinkPal.Models;
using ClinkPal.Services;
using Microsoft.Data.SqlClient;

public class cryptoContext : DbContext
{
    public cryptoContext(DbContextOptions<cryptoContext> options)
        : base(options)
    {
    }

    public DbSet<ClinkPal.Models.DbCryptoModel>? DbCryptoModel { get; set; }
}

public static class SeedData
{
    public static async void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new cryptoContext(
                   serviceProvider.GetRequiredService<
                       DbContextOptions<cryptoContext>>()))
        {
            if (context.DbCryptoModel.Any())
            {
                return;
            }

            var service = new ClinkService();
            var data = await service.GetCryptoListFromMessari();
            var cryptoList = data.Cryptos;
            var dataBaseList = new List<DbCryptoModel>{};
            foreach (var crypto in cryptoList)
            {
                // Console.WriteLine(crypto.Metrics.Marketcap.LiquidMarketCapUSD);
                var id = crypto.Id;
                var rank = crypto.Metrics.Marketcap.Rank;
                var symbol = crypto.Symbol;
                var liquidity = crypto.Metrics.Marketcap.LiquidMarketCapUSD;
                var usdPrice = crypto.Metrics.MarketData.PriceUSD;
                var btcPrice = crypto.Metrics.MarketData.PriceBTC;
                var percentChangePerDay = crypto.Metrics.MarketData.PercentChangePerDay;
                var inflation = crypto.Metrics.Supply.AnnualInflationPercent;
                var tempCrypto = new DbCryptoModel(id, symbol, rank, liquidity, usdPrice, btcPrice, percentChangePerDay, inflation);
                dataBaseList.Add(tempCrypto);
            }
            context.DbCryptoModel.AddRange(dataBaseList);
            context.SaveChanges();
        }
    }
}
