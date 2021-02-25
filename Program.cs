using System;
using System.Collections.Generic;
using System.Linq;

namespace Db
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                // context.Database.EnsureCreated();
                // var customer = new Customer()
                // {
                //     Name = "Josep",
                //     Address = "bangkok",
                //     CreateDate = DateTime.Now
                // };

                // context.Customers.Add(customer);
                // context.SaveChanges();

                // var a = context.Customers.FirstOrDefault(p => p.Address == "bangkok");
                // if (a != null)
                // {
                //     Console.WriteLine(a.Name);
                //     Console.WriteLine(a.Address);
                // }

        
                var list = context.Customers.Where(p => p.Address == "bangkok").First();

                foreach (var item in list)
                {
                    Console.WriteLine(list);
                }

            }
        }
    }
}