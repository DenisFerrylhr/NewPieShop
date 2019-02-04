using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewPieShop.Models
{
    public class Pie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Short Desccription")]
        public string ShortDescription { get; set; }
        [Display(Name = "Full Desccription")]
        public string LongDescription { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
    }
}
