using Kaddis.Framework.Common.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Kaddis.Framework.Clients.Lab.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync("http://localhost:65476/api/v1/test/getall");
            response.EnsureSuccessStatusCode();

            var contents = await response.Content.ReadAsStringAsync();
            List<TestDto> list = JsonConvert.DeserializeObject<List<TestDto>>(contents);
            return View(response);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}