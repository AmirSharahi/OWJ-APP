using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OWJ_APP.enums;
namespace OWJ_APP.models
{
    public class Person
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public double IDNumber { get; set; }
        public Languages languages { get; set; }
        public string Email { get; set; }
        public string TelOffice { get; set; }
        public string AdditinalInformation { get; set; }

    }
}
