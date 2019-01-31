using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPieShop.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
        public override string ToString()
        {
            return "Customer: " + Id + " " + "Name: " + Name;
        }
    }
}
