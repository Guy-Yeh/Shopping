using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Shopping.Models
{
    public class OrdersModel
    {
        public int ID { get; set; }
        public string serial { get; set; }
        
        public string customerAccount { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public int totalPrice { get; set; }
        public string status { get; set; }
        public DateTime initdate { get; set; }

    }

}