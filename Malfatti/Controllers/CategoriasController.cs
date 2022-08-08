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
    public class CategoriasController : Controller
    {
        private EFContext context = new EFContext();

        public ActionResult Index()
        {
            return View(context.Categorias.OrderBy(c => c.Nome));

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
        public ActionResult Create(Categoria categoria)
        {
            context.Categorias.Add(categoria);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET: Categorias/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = context.Categorias.Find(id);
            //Fabricante fabricante = fabricantes.Where(m => m.FabricanteId == id).First();
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        // POST: Categorias/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Categoria categoria = context.Categorias.Find(id);
            //Categoria categoria = categorias.Where(m => m.CategoriaId == id).First();
            context.Categorias.Remove(categoria);
            //Categorias.Remove(categoria);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}