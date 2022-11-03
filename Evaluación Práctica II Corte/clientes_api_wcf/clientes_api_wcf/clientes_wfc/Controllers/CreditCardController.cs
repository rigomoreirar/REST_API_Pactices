using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using clientes_wfc.Models;
using clientes_wfc.ServiceReference1;

namespace clientes_wfc.Controllers
{
    public class CreditCardController : Controller
    {
        Service1Client client = new Service1Client();
        // GET: CreditCard
        public ActionResult Index()
        {
            var lista = client.CreditCardLista();
            return View(lista);
        }

        // GET: CreditCard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CreditCard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CreditCard/Create
        [HttpPost]
        public ActionResult Create(CreditCardClass creditCardClass)
        {
            try
            {
                // TODO: Add insert logic here
                int estado = 0;
                string mensaje = string.Empty;

                client.CreditCardSave(0, creditCardClass.CardType, creditCardClass.CardNumber, creditCardClass.ExpMonth, creditCardClass.ExpYear);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CreditCard/Edit/5
        public ActionResult Edit(int CreditCardID)
        {
            CreditCardClass creditCardClass = new CreditCardClass();

            var datos = client.CreditCardDatos(CreditCardID);

            creditCardClass.CreditCardID = datos.CreditCardID;
            creditCardClass.CardType = datos.CardType;
            creditCardClass.CardNumber = datos.CardNumber;
            creditCardClass.ExpMonth = datos.ExpMonth;
            creditCardClass.ExpYear = datos.ExpYear;

            return View(creditCardClass);
        }

        // POST: CreditCard/Edit/5
        [HttpPost]
        public ActionResult Edit(CreditCardClass creditCardClass)
        {
            try
            {
                // TODO: Add update logic here
                int estado = 0;

                client.CreditCardSave(creditCardClass.CreditCardID, creditCardClass.CardType, creditCardClass.CardNumber, creditCardClass.ExpMonth, creditCardClass.ExpYear);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CreditCard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CreditCard/Delete/5
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
