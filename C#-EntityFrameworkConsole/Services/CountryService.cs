using C__EntityFrameworkConsole.Data;
using C__EntityFrameworkConsole.Helpers.Exceptions;
using C__EntityFrameworkConsole.Models;
using C__EntityFrameworkConsole.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EntityFrameworkConsole.Services
{
    internal class CountryService : ICountryService
    {
        private readonly AppDbContext _context;
        public CountryService()
        {
            _context = new AppDbContext();
        }
        public async Task CreateAsync(Country country)
        {
            await _context.Countries.AddAsync(country);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int? id)
        {
            if (id is null) throw new ArgumentNullException(nameof(id));

            var data = _context.Countries.FirstOrDefault(m => m.Id == id);
            if (data is null) throw new NotFoundException("Data not found");

            _context.Countries.Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Country>> GetAllAsync()
        {
            return await _context.Countries.ToListAsync();
        }


        public async Task<Country> GetByIdAsync(int id)
        {

            var data = _context.Countries.FirstOrDefault(m => m.Id == id);
            if (data is null) throw new NotFoundException("Data not found");
            return data;
        }
    }
}
