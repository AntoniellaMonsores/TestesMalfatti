using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Malfatti.Context;
using Malfatti.Models;

namespace Malfatti.Controllers
{
    public class FabricantesController : Controller
    {
        private EFContext context = new EFContext();

        public ActionResult Index()
        {
            return View(context.Fabricantes.OrderBy(c => c.Nome));

        }

        // GET: Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Fabricante fabricante)
        {
            context.Fabricantes.Add(fabricante);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Fabricantes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Fabricante fabricante = context.Fabricantes.Find(id);

            //Fabricante fabricante = fabricantes.Where(m => m.FabricanteId == id).First();
            if (fabricante == null)
            {
                return HttpNotFound();
            }
            return View(fabricante);
        }

        // POST: Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Fabricante fabricante = context.Fabricantes.Find(id);
            //Fabricante fabricante = fabricantes.Where(m => m.FabricanteId == id).First();
            context.Fabricantes.Remove(fabricante);
            //fabricantes.Remove(fabricante);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}