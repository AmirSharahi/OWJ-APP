using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OWJ_APP.enums;
namespace OWJ_APP.models
{
    public class Order_details
    {
        public int id { get; set; }
        public Priority priority { get; set; }
        public OWJ_APP.enums.Type type { get; set; }
        public Verificator verificator { get; set; }
        public double price { get; set; }
    }
}
