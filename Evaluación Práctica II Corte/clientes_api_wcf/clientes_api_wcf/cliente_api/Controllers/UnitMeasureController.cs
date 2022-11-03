using cliente_api.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace cliente_api.Controllers
{
    public class UnitMeasureController : Controller
    {
        // GET: UnitMeasure
        public async Task<ActionResult> Index()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:8085/adventureworks2019_api/api/UnitMeasure");

            HttpContent content = response.Content;

            string data = await content.ReadAsStringAsync();

            var resultado = JsonConvert.DeserializeObject<List<UnitMeasureClass>>(data);

            return View(resultado);
        }
    }
}