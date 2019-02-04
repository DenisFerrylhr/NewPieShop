using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewPieShop.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        [Display(Name = "Pie")]
        public int PieId { get; set; }
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
    }
}
