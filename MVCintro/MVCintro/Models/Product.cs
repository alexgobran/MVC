using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCintro.Models {
    public class Product {


     
        //Primary Key
        [Key]
        public int ProductID { get; set; }
        [MaxLength (80)]
        [Display(Description = "Product Full Name")]
        [Required(ErrorMessage ="You must enter your name")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        

        

    }
}
