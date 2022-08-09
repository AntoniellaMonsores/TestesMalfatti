using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Malfatti.Context;
using Malfatti.Models;

namespace Malfatti.Controllers
{
    public class ProdutosController : Controller
    {
        private EFContext context = new EFContext();

        // GET : Produtos
        public ActionResult Index()
        {
            return View(context.Produtos.OrderBy(c => c.Nome));
        }
        
        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produto produto)
        {
            context.Produtos.Add(produto);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Delete
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Produto produto = context.Produtos.Find(id);

            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Produto produto = context.Produtos.Find(id);
            context.Produtos.Remove(produto);
            context.SaveChanges();
            TempData["Message"] = "Produto " + produto.Nome.ToUpper() + " removido";
            return RedirectToAction("Index");
        }
    }
}
