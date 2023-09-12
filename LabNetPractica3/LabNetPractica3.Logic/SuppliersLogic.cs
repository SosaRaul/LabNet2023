using LabNetPractica3.Data;
using LabNetPractica3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica3.Logic
{
    public class SuppliersLogic : BaseLogic, ILogic<Suppliers>
    {
        public SuppliersLogic() : base() { }

        public void Add(Suppliers entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }

        public void Update(Suppliers entity)
        {
            throw new NotImplementedException();
        }
    }
}
