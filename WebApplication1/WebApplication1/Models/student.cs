using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class student
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name ="Student Name")]
        public string Name { get; set; }
        public int ADM { get; set; }
        public string cOUNTY { get; set; }
    }
}