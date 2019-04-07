using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Doors { get; set; }
        public decimal Consumption { get; set; }
        public string Description { get; set; }
        public string Fuel { get; set; }

    }
}
