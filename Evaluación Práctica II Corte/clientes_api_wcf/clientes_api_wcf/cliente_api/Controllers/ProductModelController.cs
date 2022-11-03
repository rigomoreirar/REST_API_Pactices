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
    public class ProductModelController : Controller
    {
        // GET: ProductModel
        public async Task<ActionResult> Index()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:8085/adventureworks2019_api/api/ProductModel");

            HttpContent content = response.Content;

            string data = await content.ReadAsStringAsync();

            var resultado = JsonConvert.DeserializeObject<List<ProductModelClass>>(data);

            return View(resultado);
        }
    }
}