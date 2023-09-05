using LabNetPractica4.Data;
using LabNetPractica4.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica4.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public List<Customer> GetAll()
        {
            return context.Customers.ToList();
        }
        public Customer Punto1()
        {
            Customer customer = context.Customers.FirstOrDefault();
            return customer;
        }
        public List<Customer> Punto4()
        {
            var customers = from customer in context.Customers
                            where customer.Region == "WA"
                            select customer;
            return customers.ToList();
        }

        public List<string> Punto6()
        {
            var customers = from customer in context.Customers
                            select customer.ContactName;
            return customers.Distinct().ToList();
        } 

        public List<Customer> Punto8()
        {
            var customers = from customer in context.Customers
                            where customer.Region == "WA"
                            select customer;
            return customers.Take(3).ToList();
        }




    }
}
