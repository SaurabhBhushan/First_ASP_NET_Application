using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIRST_ASP_NET_APPLICATION.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }
    }

    public class Register
    {
        
        public string Name { get; set; }
       
        public string Email { get; set; }
    }
}