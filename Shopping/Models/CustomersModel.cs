using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Models
{
    public class CustomersModel
    {
        public int ID { get; set; }
        public string account { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string discount { get; set; }
        public DateTime initdate { get; set; }

    }


}