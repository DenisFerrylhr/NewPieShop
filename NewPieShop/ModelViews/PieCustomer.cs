using NewPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPieShop.ModelViews
{
    public class PieCustomer
    {
        public Pie Pie { get; set; }
        public Customer Customer { get; set; }
        public Purchase Purchase { get; set; }
    }
}
