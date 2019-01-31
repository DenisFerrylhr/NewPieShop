using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPieShop.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int PieId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
