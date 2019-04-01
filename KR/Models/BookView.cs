using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Models
{
    public class BookView
    {
        public int BookId { get; set; }
        public string Car { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
    }
}
