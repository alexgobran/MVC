using System.ComponentModel.DataAnnotations;

namespace MVCdemo.Models {

    public class Product {

        public int ProductID { get; set; }



        [StringLength(80)]
        public string Description { get; set; }

        [Range(0, 1000)]
        public int QtyonHand { get; set; }

        
        [Range(0, 1000)]
        public int? ReorderPoint { get; set; }// '?' makes int nullable(optional)

        
        [StringLength(8)]
        public string Status { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public string Cost { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public string Price { get; set; }

        public int VendorID { get; set; }

        public virtual Vendor Vendor { get; set; }

    }

    
}