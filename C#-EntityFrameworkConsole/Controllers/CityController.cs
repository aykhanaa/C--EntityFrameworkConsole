using C__EntityFrameworkConsole.Models;
using C__EntityFrameworkConsole.Services;
using C__EntityFrameworkConsole.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EntityFrameworkConsole.Controllers
{
    internal class CityController
    {
        private readonly ICityService _cityService;

        public CityController()
        {
            _cityService = new CityService();
        }
        public async Task GetAllByCountryId()
        {
          Console.WriteLine("Add country id:");
            int countryId = int.Parse(Console.ReadLine());

            var cities = await _cityService.GetAllByCountrIdAsync(countryId);

            foreach (var item in cities)
            {
                string data = $"Name: {item.Name},Counry: {item.Country.Name}";
                Console.Out.WriteLine(data);
            }
        }

        public async Task GetAllAsync()
        {
            var datas = await _cityService.GetAllAsync();
            foreach (var item in datas)
            {
                string data = $"Name: {item.Name},CountryId: {item.Population}, Country: {item.Country}";
                Console.Out.WriteLine(data);
            }
        }
        public async Task CreateAsync()
        {
            Console.WriteLine("Add name:");
            string name = Console.ReadLine();

            Console.WriteLine("Add countryId:");
            int countryId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add country:");
            string country = Console.ReadLine();



            await _cityService.CreateAsync(new City { Name = name, Population = countryId, Country = country });
        }
        public async Task GetByIdAsync()
        {
            Console.WriteLine("Add setting id:");
            int id = Convert.ToInt32(Console.ReadLine());

            try
            {
                var data = await _cityService.GetByIdAsync(id);
                string result = $"Name: {data.Name},CountryId: {data.Population}, Country: {data.Country}";
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
                await _cityService.DeleteAsync(id);
                Console.WriteLine("Data deleted");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
