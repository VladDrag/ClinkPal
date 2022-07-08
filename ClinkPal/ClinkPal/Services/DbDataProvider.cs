using ClinkPal.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinkPal.Services;

public class DbDataProvider
{
    public class MyContext : DbContext
    {
        public DbSet<DbCryptoModel> Cryptos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost;Database=cryptoBase;User Id=sa;password=Password_2_Change_4_Real_Cases_&");
        }

        public List<DbCryptoModel> RetrieveCryptoData()
        {
            var table = new MyContext().Cryptos;
            return table.ToList().OrderBy(elem => elem.Rank).ToList();
        }
    }

    private readonly MyContext _myContext = new ();
    public List<DbCryptoModel> CryptoInfo => _myContext.RetrieveCryptoData();
}