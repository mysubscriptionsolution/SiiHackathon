using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiiHackathon.Models.Requests
{
    internal class Item
    {
        public int ProductId { get; set; }
        public string Type { get; set; }
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal PriceTaxExcluded { get; set; }
        public decimal PriceTaxIncluded { get; set; }
        public string Category { get; set; }
    }

}
