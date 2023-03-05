using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomerceDAL.Entity
{
    public class Language
    {
        public int id { get; set; }
        [Required (ErrorMessage ="Name is requird")]
        public string Name { get; set; }
        
    }
}
