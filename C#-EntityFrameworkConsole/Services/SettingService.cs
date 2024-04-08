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
    internal class SettingService : ISettingService
    {
        private readonly AppDbContext _context;
        public SettingService()
        {
            _context = new AppDbContext();
        }
        public async Task CreateAsync(Setting setting)
        {
            await _context.Settings.AddAsync(setting);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int? id)
        {
            if(id is null) throw new ArgumentNullException(nameof(id));

            var data = _context.Settings.FirstOrDefault(m => m.Id == id);
            if (data is null) throw new NotFoundException("Data not found");

            _context.Settings.Remove(data);
            await _context.SaveChangesAsync(); 
        }



        public async Task<List<Setting>> GetAllAsync()
        {
            return await _context.Settings.ToListAsync();
        } 

        public  async Task<Setting> GetByIdAsync(int id)
        {
            var data =_context.Settings.FirstOrDefault(m=>m.Id==id);
            if (data is null) throw new NotFoundException("Data not found");
            return data;

        }


        public Task UpdateAsync(Setting setting)
        {
            throw new NotImplementedException();
        }
    }
}
