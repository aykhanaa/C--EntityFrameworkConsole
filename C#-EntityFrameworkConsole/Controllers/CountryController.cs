using C__EntityFrameworkConsole.Models;
using C__EntityFrameworkConsole.Services;
using C__EntityFrameworkConsole.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EntityFrameworkConsole.Controllers
{
    internal class CountryController
    {
        private readonly ICountryService _countryService;

        public CountryController()
        {
            _countryService = new CountryService();
        }

        public async Task CreateAsync()
        {
            Console.WriteLine("Add name:");
            string name = Console.ReadLine();

            Console.WriteLine("Add population:");
            int population = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add city:");
            string city = Console.ReadLine();


            await _countryService.CreateAsync(new Country { Name = name, Population = population, City = city });


        }
        public async Task GetByIdAsync()
        {
            Console.WriteLine("Add setting id:");
            int id = Convert.ToInt32(Console.ReadLine());

            try
            {
                var data = await _countryService.GetByIdAsync(id);
                string result = $"Name: {data.Name},Population: {data.Population}, City: {data.city}";
                Console.Out.WriteLine(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public async Task DeleteAsync()
        {
            Console.WriteLine("Add setting id:");
            int id = Convert.ToInt32(Console.ReadLine());
            try
            {
                await _countryService.DeleteAsync(id);
                Console.WriteLine("Data deleted");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
