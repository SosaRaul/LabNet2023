using LabNetPractica3.Entities;
using LabNetPractica3.Logic;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    
    public class ShipperController : Controller
    {
        ShippersLogic shippersLogic = new ShippersLogic();
        public ActionResult Index()
        {
            
            List<Shippers> shippers = shippersLogic.GetAll();

            List<ShipperView> shippersViews = shippers.Select(shipper => new ShipperView
            {
                Id = shipper.ShipperID,
                Phone = shipper.Phone,
                CompanyName = shipper.CompanyName
            }).ToList();
            
            return View(shippersViews);
        }

        public ActionResult Insert()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Insert(ShipperView shipperView)
        {
            try
            {
                Shippers shipper = new Shippers
                {
                    CompanyName = shipperView.CompanyName,
                    Phone = shipperView.Phone,
                };
                shippersLogic.Add(shipper);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }

        }


        public ActionResult Update(int id)
        {

            Shippers shipper = new Shippers
            {
                ShipperID = id,
                CompanyName = "xx",
                Phone = "xx"
            };
                shippersLogic.Update(shipper);
                return RedirectToAction("Index");
        }


        public ActionResult Delete(int id) 
        {
            shippersLogic.Delete(id);
            return RedirectToAction("Index");
        }
 
    }
}