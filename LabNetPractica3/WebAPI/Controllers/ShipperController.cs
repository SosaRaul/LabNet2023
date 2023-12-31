﻿using LabNetPractica3.Entities;
using LabNetPractica3.Logic;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    public class ShipperController : ApiController
    {
        ShippersLogic shippersLogic = new ShippersLogic();
        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        public IHttpActionResult GetShippers()
        {
            try
            {
                List<Shippers> shippers = shippersLogic.GetAll();
                return Ok(shippers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        public IHttpActionResult PostAddShipper([FromBody] ShipperView request)
        {
            try
            {
                Shippers newShipper = new Shippers()
                {
                    CompanyName = request.CompanyName,
                    Phone = request.Phone
                };
                shippersLogic.Add(newShipper);
                return Content(HttpStatusCode.Created, newShipper);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        public IHttpActionResult DeleteShipper(int id)
        {
            try
            {
                shippersLogic.Delete(id);
                return Ok(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        public IHttpActionResult PutShipper(int id, [FromBody] ShipperView request)
        {
            try
            {
                Shippers newShipper = new Shippers()
                {
                    ShipperID = id,
                    CompanyName = request.CompanyName,
                    Phone = request.Phone
                };
                shippersLogic.Update(id,newShipper);
                return Content(HttpStatusCode.OK,newShipper);
            }
            catch (Exception ex)
            {
                return Content (HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
    
}
