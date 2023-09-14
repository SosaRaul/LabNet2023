using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebAPI.Models;


namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly RestClient _client;
        public HomeController()
        {
            _client = new RestClient("https://dolarapi.com/");
        }
        public async Task<ActionResult> Index()
        {

            var request = new RestRequest("v1/dolares");
            var response = await _client.ExecuteGetAsync(request);
            if (!response.IsSuccessful)
            {
                return View("Error");
            }
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            List<CotizacionDolar> userList = JsonConvert.DeserializeObject<List<CotizacionDolar>>(response.Content,settings);
            return View(userList);

        }   
           
    }
}
