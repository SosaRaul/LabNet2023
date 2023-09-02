using LabNetPractica3.Data;
using LabNetPractica3.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica3.Logic
{
    public class ShippersLogic
    {
        private readonly NorthwindContext context;

        public ShippersLogic()
        {
            context = new NorthwindContext();
        }
    
        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }
    
    }
}
