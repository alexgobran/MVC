using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCdemo.Models {
    public class Vendor {

        public int VendorID { get; set; }

        [Required]  
        [StringLength(80)]
        public string Name { get; set; }

        [Required]
        [StringLength(8)]
        public string  Status { get; set; }

            [Required]
        [RegularExpression(@"^\d(3)-\d(3)-\d(4)$")] 
        //@ sign in front of RegularExpression means everything following should be read literally as string-Do Not Interpret 
        public string  Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string  Email { get; set; }

        //virtual refers to a multi-directional relationship from one table to another
        //virtual is a hint to EF 
        public virtual ICollection<Product> Products { get; set; }
    }

    
}
