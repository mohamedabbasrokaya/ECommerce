using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomerceDAL.Entity
{
    public enum paymentType
    {
        DirectBankTransfare = 10 , ChequePayment=20 , paypal = 30,visa = 40 , Mastercard = 50 , OnDilivery = 60

    
        }
    public class payment
    {
        public int id { get; set; }
        public paymentType Type { get; set; }
        public virtual Product Products { get; set; }


    }
}
