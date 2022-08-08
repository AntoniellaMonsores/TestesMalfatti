using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
