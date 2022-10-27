using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using cliente_api.Models;

namespace cliente_api.Controllers
{
    public class ProductCategoryController : Controller
    {
        public async Task<ActionResult> Index()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:8085/adventureworks2019_api/api/ProductCategory");

            HttpContent content = response.Content;

            string data = await content.ReadAsStringAsync();

            var resultado = JsonConvert.DeserializeObject<List<ProductCategoryClass>>(data);

            return View(resultado);
        }
    }
}