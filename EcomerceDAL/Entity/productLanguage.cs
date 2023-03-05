using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomerceDAL.Entity
{
    public class productLanguage
    {
        public int id { get; set; }
        [Required (ErrorMessage ="Name is requird")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Description is requird")]
        public string Description { get; set; }
        public int LanguageId { get; set; }
        
        public virtual Language Language { get; set; }

    }
}
