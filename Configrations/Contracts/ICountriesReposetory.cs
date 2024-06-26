using HotelListAPI.Data;

namespace HotelListAPI.Configrations.Contracts
{
    public interface ICountriesRepository :IGenericRepository<Country> 
    {
        Task<Country> GetDetails(int id);
    }
}
