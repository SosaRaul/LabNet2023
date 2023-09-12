using LabNetPractica3.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;

namespace LabNetPractica3.Logic
{
    public class ShippersLogic : BaseLogic,ILogic<Shippers>
    {
        public ShippersLogic() : base() { }

        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }
        public void  Add(Shippers newShipper)
        {
            context.Shippers.Add(newShipper);
            context.SaveChanges();
        }
        public bool Delete(int id)
        {
            bool entityDeleted = false;
            Shippers shipperToDelete = context.Shippers.Find(id);
            if (shipperToDelete != null)
            {
                context.Shippers.Remove(shipperToDelete);
                context.SaveChanges();
                entityDeleted = true;
            }
            return entityDeleted;
        }

        public void Update(Shippers shipper)
        {
            Shippers shipperToUpdate = context.Shippers.Find(shipper.ShipperID);
            shipperToUpdate.Phone = shipper.Phone;
           
            shipperToUpdate.CompanyName = shipper.CompanyName;
            context.SaveChanges();
        }
    }
}
