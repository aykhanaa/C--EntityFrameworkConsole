using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EntityFrameworkConsole.Models
{
    internal class Country:BaseEntity
    {
        internal string City;
        internal object city;

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int Population { get; set; }
        public ICollection<City> Cities { get; set; }

        public static implicit operator Country(string v)
        {
            throw new NotImplementedException();
        }
    }
}
