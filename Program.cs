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
                //Create Table
                // context.Database.EnsureCreated();

                // var customer = new Customer()
                // {
                //     Name = "Josep",
                //     Address = "bangkok",
                //     CreateDate = DateTime.Now
                // };

                // Insert
                // context.Customers.Add(customer);
                // context.SaveChanges();

                //Search
                // var a = context.Customers.FirstOrDefault(p => p.Address == "bangkok");
                // if (a != null)
                // {
                //     Console.WriteLine(a.Name);
                //     Console.WriteLine(a.Address);
                // }


                // var list = context.Customers.Where(p => p.Address == "bangkok").ToList();

                // foreach (var item in list)
                // {
                //     Console.WriteLine(item.Name);
                // }

                //Update
                // var customer = context.Customers.FirstOrDefault(p => p.Name == "Chen");
                // if (customer != null)
                // {
                //     customer.Name = "Update";
                // }

                var customer = context.Customers.Where(p => p.Address == "bangkok").ToList();

                foreach (var item in customer)
                {
                    item.Address = "กรุงเทพ";
                }

                context.SaveChanges();
            }
        }
    }
}