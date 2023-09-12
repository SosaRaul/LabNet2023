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
                Phone = shipper.Phone,
                CompanyName = shipper.CompanyName
            }).ToList();
            
            return View(shippersViews);
        }
        [HttpPost]
        public ActionResult Insert(ShipperView shipperView)
        {
            try
            {
                Shippers shipper = new Shippers {
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

   /*     public ActionResult Update() 
        { 
        
        }

        public ActionResult Delete() 
        { 
        }
   */
    }
}