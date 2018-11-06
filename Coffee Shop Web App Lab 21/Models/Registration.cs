using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coffee_Shop_Web_App_Lab_21.Models
{
    public class Registration
    {
        public string firstName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmPW { get; set; }
        public string phoneNum { get; set; }
        public string ninFav { get; set; }
        public bool marketing { get; set; }
    }
}