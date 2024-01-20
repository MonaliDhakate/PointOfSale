using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    public class finalpayment
    {
        [Key]
        [Required]// does not blank
        [DisplayName("ID")]
        public int id { get; set; }

        [Required]
        [DisplayName("CustomerName")]
        public string? customername { get; set; }  //? is for null value is allowed

        [Required]
        [DisplayName("productname")]
        public string? productname { get; set; }

        [Required]
        [DisplayName("totalamount")]
        public double? totalamount { get; set; }

        [Required]
        [DisplayName("discount")]
        public int? discount { get; set; }

        [Required]
        [DisplayName("date")]
        public DateTime? date { get; set; }




    }
}
