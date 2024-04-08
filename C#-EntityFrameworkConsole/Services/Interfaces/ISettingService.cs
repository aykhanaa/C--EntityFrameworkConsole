using C__EntityFrameworkConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EntityFrameworkConsole.Services.Interfaces
{
    internal interface ISettingService
    {
        Task<List<Setting>> GetAllAsync();
        Task<Setting> GetByIdAsync(int id);
        Task CreateAsync(Setting setting);
        Task UpdateAsync(Setting setting);
        Task DeleteAsync(int? id);
    }
}
