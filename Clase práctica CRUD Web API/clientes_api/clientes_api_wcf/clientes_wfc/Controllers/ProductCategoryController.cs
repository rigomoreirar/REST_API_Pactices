using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using clientes_wfc.Models;
using clientes_wfc.ServiceReference1;

namespace clientes_wfc.Controllers
{
    public class ProductCategoryController : Controller
    {
        Service1Client client = new Service1Client();
        // GET: ProductCategory
        public ActionResult Index()
        {
            var lista = client.ProductCategoryLista();
            return View(lista);
        }

        // GET: ProductCategory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductCategory/Create
        [HttpPost]
        public ActionResult Create(ProductCategoryClass productCategoryClass)
        {
            try
            {
                // TODO: Add insert logic here
                int estado = 0;
                string mensaje = string.Empty;

                client.ProductCategorySave(0, productCategoryClass.Name);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductCategory/Edit/5
        public ActionResult Edit(int ProductCategoryID)
        {
            ProductCategoryClass productCategoryClass = new ProductCategoryClass();

            var datos = client.ProductCategoryDatos(ProductCategoryID);

            productCategoryClass.ProductCategoryID = datos.ProductCategoryID;
            productCategoryClass.Name = datos.Name;

            return View(productCategoryClass);
        }

        // POST: ProductCategory/Edit/5
        [HttpPost]
        public ActionResult Edit(ProductCategoryClass productCategoryClass)
        {
            try
            {
                // TODO: Add update logic here
                int estado = 0;

                client.ProductCategorySave(productCategoryClass.ProductCategoryID, productCategoryClass.Name);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductCategory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductCategory/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
