using C__EntityFrameworkConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EntityFrameworkConsole.Services.Interfaces
{
    internal interface ICountryService
    {
        Task<List<Country>> GetAllAsync();
        Task<Country> GetByIdAsync(int id);
        Task CreateAsync(Country country);
        Task DeleteAsync(int? id);
    }
}
