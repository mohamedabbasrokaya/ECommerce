﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomerceDAL.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string value { get; set; }
        
        public virtual ICollection<Product> Products { get; set; }=new HashSet<Product>();
        
    }
}
