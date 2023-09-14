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
            if (String.IsNullOrWhiteSpace(newShipper.CompanyName) || String.IsNullOrWhiteSpace(newShipper.Phone))
            {
                throw new Exception("Campos no deben ser vacios ");
            }
            context.Shippers.Add(newShipper);
            context.SaveChanges();
        }
        public bool Delete(int id)
        {
            bool entityDeleted = false;
            Shippers shipperToDelete = context.Shippers.Find(id);
            if (shipperToDelete == null)
            {
                throw new Exception("No existe lo que se intenta borrar");
            }
            context.Shippers.Remove(shipperToDelete);
            context.SaveChanges();
            entityDeleted = true;
            return entityDeleted;
        }

        public void Update(Shippers shipper)
        {
            Shippers shipperToUpdate = context.Shippers.Find(shipper.ShipperID);
            if(shipperToUpdate == null)
            {
                throw new Exception("No existe lo que se intenta actualizar");
            }
            shipperToUpdate.Phone = shipper.Phone;
            shipperToUpdate.CompanyName = shipper.CompanyName;
            context.SaveChanges();
        }

        public void Update(int id,Shippers shipper)
        {
            Shippers shipperToUpdate = context.Shippers.Find(id);
            if (String.IsNullOrWhiteSpace(shipper.CompanyName) || String.IsNullOrWhiteSpace(shipper.Phone))
            {
                throw new Exception("Campos no deben ser vacios ");
            }
            shipperToUpdate.Phone = shipper.Phone;
            shipperToUpdate.CompanyName = shipper.CompanyName;
            context.SaveChanges();
        }
    }
}
