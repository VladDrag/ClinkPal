using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ClinkPal.Models;

[Table("CryptoTable")]
public class DbCryptoModel
{
    public DbCryptoModel(string id, string symbol, int rank, double? usdLiquidity, double? usdPrice, double? btcPrice, double? percentageChange, double? annualInflation)
    {
        Id = id;
        Symbol = symbol;
        Rank = rank;
        UsdLiquidity = usdLiquidity;
        UsdPrice = usdPrice;
        BtcPrice = btcPrice;
        PercentChangePerDay = percentageChange;
        AnnualInflation = annualInflation;
    }

    public DbCryptoModel()
    {
        
    }
    [Key]
    public string Id { get; set; }
    public string Symbol { get; set; }
    public int Rank { get; set;}
    public double? UsdLiquidity { get; set; }
    public double? UsdPrice { get; set; }
    public double? BtcPrice { get; set; }
    private double? PercentChangePerDay { get; set;}
    
    public double? AnnualInflation { get; set; }

}