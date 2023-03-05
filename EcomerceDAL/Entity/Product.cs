using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomerceDAL.Entity
{
    public class Product
    {
        public int id { get; set; }
        [Required (ErrorMessage ="price is requird")]
        [DataType(DataType.Currency)]
        
        public decimal price { get; set; }
        [DataType(DataType.Currency)]
        public decimal Discount { get; set; }
        public ICollection<productLanguage> productLanguages { get; set;}=new HashSet<productLanguage>();
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<tag> tags { get; set; }=new HashSet<tag>();
        public virtual ICollection<payment> Payment { get; set; }=new HashSet<payment>();
        



    }
}
