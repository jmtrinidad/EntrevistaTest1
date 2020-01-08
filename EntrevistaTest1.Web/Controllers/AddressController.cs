using EntrevistaTest1.DataAccess.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EntrevistaTest1.Web.Controllers
{
    public class AddressController : Controller
    {
        private readonly DataAccess.Data.DataAccess dataAccess;

        public AddressController()
        {
            dataAccess = new DataAccess.Data.DataAccess();
        }
        // GET: Address
        public ActionResult Index(string txtFilter = "")
        {
            List<Address> addreses;
            if (!string.IsNullOrEmpty(txtFilter))
            {
                ViewBag.Filter = txtFilter;
                addreses = dataAccess.GetAddressesEntrevista1TestWithFilter(txtFilter);
                if (addreses == null)
                {
                    return View(new List<Address>());
                }
                else
                {
                    return View(addreses);
                }
            }
            return View(new List<Address>());
        }

        // GET: Address/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Address/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Address/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Address/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Address/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Address/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Address/Delete/5
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
