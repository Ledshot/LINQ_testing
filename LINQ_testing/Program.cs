using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LINQ_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the customer data base.");
            List<Customer> custList = new List<Customer>
                    {new Customer()
                          { CustomerId = 1,
                            FirstName="Troy",
                            LastName = "Masterson",
                            EmailAddress = "TMasterson@Yahoo.com",
                            Age=19
                    },
                    new Customer()
                          { CustomerId = 2,
                            FirstName="Gorge",
                            LastName = "Lock",
                            EmailAddress = "GLock@Hotmail.com",
                            Age=23
                    },
                    new Customer()
                          { CustomerId = 3,
                            FirstName="Robert",
                            LastName = "Girlyman",
                            EmailAddress = "Emporers1stSon@outlook.com",
                            Age=35
                    },
                    new Customer()
                          { CustomerId = 4,
                            FirstName="John",
                            LastName = "Carter",
                            EmailAddress = "Mars4Me@youlook.com",
                            Age=21
                    }
            };

            var query = custList.Select(c => new
            {
                Name = c.FirstName + ", " + c.LastName,
                c.EmailAddress
            });

            foreach (var item in query)
            {
                Console.WriteLine(item.Name + "  :  " + item.EmailAddress);
            }
        }
    }
}
