using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewPieShop.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Your name is required")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public bool Contact { get; set; }
    }
}
