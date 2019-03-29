using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Models
{
    class Book
    {
        public int BookId { get; set; }
        public Car Car { get; set; }
        public User User { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
    }
}
