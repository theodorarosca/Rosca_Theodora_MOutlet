using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosca_Theodora_MOutlet.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
