using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EntityFrameworkConsole.Models
{
    internal class City:BaseEntity
    {
        public string Name { get; set; }
        public int Population {  get; set; }
        public Country Country { get; set; }
        public string City { get; internal set; }
    }
}
