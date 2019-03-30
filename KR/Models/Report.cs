using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public Car Car { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
        public int Mark { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
