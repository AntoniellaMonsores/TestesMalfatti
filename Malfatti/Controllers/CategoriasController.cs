using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Malfatti.Models;

namespace Malfatti.Controllers
{
    public class CategoriasController : Controller
    {
        private static IList<Categoria> categorias = new List<Categoria>()
        {
            new Categoria() { CategoriaId = 1, Nome = "Anéis"},
            new Categoria() { CategoriaId = 2, Nome = "Braceletes"},
            new Categoria() { CategoriaId = 3, Nome = "Brincos"},
            new Categoria() { CategoriaId = 4, Nome = "Colares"},
            new Categoria() { CategoriaId = 5, Nome = "Relógios"}
        };

        // GET: Categorias
        public ActionResult Index()
        {
            return View(categorias);
        }


    }
}
