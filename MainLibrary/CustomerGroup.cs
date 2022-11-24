using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLibrary
{
    public class CustomerGroup
    {
        public List<Customer> customers { get; set; }
        public string category { get; set; }
        public int count { get; set; }
        public CustomerGroup()
        {
            customers = new List<Customer>()
            {
                new Customer{CustomerID=1,FirstName="Nada",LasName="Salami",DisplayName="Nada S. S.",DOB=new DateTime(2000,11,22),Salary=1000},
                new Customer{CustomerID=2,FirstName="Samir",LasName="Kfoury",DisplayName="Samir K.",DOB=new DateTime(1999,3,7),Salary=1500},
                new Customer{CustomerID=3,FirstName="Kareem",LasName="Tawil",DisplayName="Kareem T.",DOB=new DateTime(2005,1,2),Salary=2000},
            };
        }
    }
}
