﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Models
{
    class Report
    {
        public int ReportId { get; set; }
        public Car Car { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
        public int Mark { get; set; }
    }
}
