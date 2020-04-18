using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group9Project
{
    class User
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Money { get; set; }
        public string PhoneNo { get; set; }
        public string Username { get; set; }

        public User()
        {
            Money = 100;
        }
    }
}
