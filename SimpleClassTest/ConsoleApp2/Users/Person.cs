using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNS
{
    
        public class Person
        {
            public string firstName;
            public string lastName;

            public string introduce()
            {
                return ("My Name is " + firstName + " lastName " + lastName);

            }
        }
    
}
