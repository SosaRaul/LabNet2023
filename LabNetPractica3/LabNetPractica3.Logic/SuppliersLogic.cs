using LabNetPractica3.Data;
using LabNetPractica3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica3.Logic
{
    public class SuppliersLogic
    {
        private readonly NorthwindContext context;

        public SuppliersLogic()
        {
            context = new NorthwindContext();
        }

        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }
    }
}
