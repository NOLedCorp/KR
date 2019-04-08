﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Models
{
    public class Profit
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public string Model { get; set; }
        public decimal Sum { get; set; }
    }
}
