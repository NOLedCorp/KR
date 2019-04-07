using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Models
{
    class CarRating
    {
        public int? Id { get; set; }
        public string Model { get; set; }
        public int ReportsNumber { get; set; }
        public double Mark { get; set; }
    }
}
