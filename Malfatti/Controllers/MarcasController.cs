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
    public class MarcasController : Controller
    {
        private EFContext context = new EFContext();

        public ActionResult Index()
        {
            return View(context.Marcas.OrderBy(c => c.Nome));

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
        public ActionResult Create(Marca marca)
        {
            context.Marcas.Add(marca);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
