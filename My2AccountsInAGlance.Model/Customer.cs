﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My2AccountsInAGlance.Model
{
    public class Customer
    {
        public Customer()
        {
            BrokerageAccounts = new HashSet<BrokerageAccount>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string CustomerCode { get; set; }

        //Navigation properties
        public ICollection<BrokerageAccount> BrokerageAccounts { get; set; }
    }
}
