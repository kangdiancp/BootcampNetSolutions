using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Step04
{
    internal class Customer : Person
    {
        public Customer(string nationalId, string firstName, string lastName, string email, DateTime birthDay,string accountNumber) 
            : base(nationalId, firstName, lastName, email, birthDay)
        {
            AccountNumber = accountNumber;
        }

        public string AccountNumber {  get; set; }  


    }
}
