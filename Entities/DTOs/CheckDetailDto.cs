using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CheckDetailDto
    {
        public string Date { get; set; }
        public double CheckCost { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Company { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
    }
}
