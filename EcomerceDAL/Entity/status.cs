using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomerceDAL.Entity
{
    public enum statusType
    {
        OnSale = 100 , NotOnSale = 200
    }
    public class status
    {
        public int id { get; set; }
        public statusType value { get; set; }
    }
}
