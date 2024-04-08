using C__EntityFrameworkConsole.Models;


namespace C__EntityFrameworkConsole.Services.Interfaces
{
    internal interface ICityService
    {
        Task<List<City>> GetAllByCountrIdAsync(int countryId);
        Task<List<City>> GetAllAsync();
        Task<City> GetByIdAsync(int id);
        Task CreateAsync(City city);
        Task DeleteAsync(int? id);
    }
}
