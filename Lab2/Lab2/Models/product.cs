using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab2.Models
{
    public class product
    {
        [Required]
        public string Id { get; set; }
        [Required][MaxLength(10)]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}