using LabNetPractica3.Entities;
using System;
using System.Collections.Generic;
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
        public void Delete(int id)
        {
            var shipperToDelete = context.Shippers.Find(id);
            context.Shippers.Remove(shipperToDelete);
            context.SaveChanges();
        }

        public void Update(Shippers shipper)
        {
            var shipperToUpdate = context.Shippers.Find(shipper.ShipperID);
            shipperToUpdate.Phone = shipper.Phone;
            shipperToUpdate.ShipperID = shipper.ShipperID;
            shipperToUpdate.CompanyName = shipper.CompanyName;
            context.SaveChanges();
        }
    }
}
