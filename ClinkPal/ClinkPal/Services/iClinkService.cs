namespace ClinkPal.Services;
using System.Threading.Tasks;
using Models;

public interface IClinkService
{
    Task<CryptoListResponse> GetCryptoListFromMessari();
}