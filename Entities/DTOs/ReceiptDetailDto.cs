using Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ReceiptDetailDto : IDto
    {
   
        public string Date { get; set; }
        public string ReceiptNo { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string ReceiptType { get; set; }
        public double TotalCost { get; set; }
        public double Vat { get; set; }
        public string Image { get; set; }
        public string Person { get; set; }

    }    
}
