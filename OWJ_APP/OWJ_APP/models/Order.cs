using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OWJ_APP.enums;
namespace OWJ_APP.models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date_Of_Acception { get; set; }
        public DateTime Date_Of_Delivery { get; set; }
        public Documents documents { get; set; }
        public Order_details order_details { get; set; }

    }
}
