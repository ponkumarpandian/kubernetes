using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSVC.DAL
{
    public class Customer
    {
        public long CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  int Age { get; set; }
        public int Gender { get; set; }
    }
}
