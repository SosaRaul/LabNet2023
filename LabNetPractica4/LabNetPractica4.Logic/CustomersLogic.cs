﻿using LabNetPractica4.Data;
using LabNetPractica4.Entities;
using System;
using System.Collections.Generic;
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
    }
}
