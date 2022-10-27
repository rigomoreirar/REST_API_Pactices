using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using clientes_wfc.Models;
using clientes_wfc.ServiceReference1;

namespace clientes_wfc.Controllers
{
    public class DepartmentController : Controller
    {
        Service1Client client = new Service1Client();
        // GET: Department
        public ActionResult Index()
        {
            var lista = client.DepartmentLista();
            return View(lista);
        }

        // GET: Department/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Department/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Department/Create
        [HttpPost]
        public ActionResult Create(DepartmentClass departmentClass)
        {
            try
            {
                // TODO: Add insert logic here
                int estado = 0;
                string mensaje = string.Empty;

                client.DepartmentSave(0, departmentClass.Name, departmentClass.GroupName);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Department/Edit/5
        public ActionResult Edit(short DepartmentID)
        {
            DepartmentClass departmentClass = new DepartmentClass();

            var datos = client.DepartmentDatos(DepartmentID);

            departmentClass.DepartmentID = datos.DepartmentID;
            departmentClass.Name = datos.Name;
            departmentClass.GroupName = datos.GroupName;

            return View(departmentClass);
        }

        // POST: Department/Edit/5
        [HttpPost]
        public ActionResult Edit(DepartmentClass departmentClass)
        {
            try
            {
                // TODO: Add update logic here
                int estado = 0;

                client.DepartmentSave(departmentClass.DepartmentID, departmentClass.Name, departmentClass.GroupName);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Department/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Department/Delete/5
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
