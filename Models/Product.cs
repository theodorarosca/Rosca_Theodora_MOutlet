using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Rosca_Theodora_MOutlet.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Display(Name="Product Name")]
        public string Name { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        [Column(TypeName="decimal(6,2)")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; }
        public int CompanyID { get; set; }
        public Company Company { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
