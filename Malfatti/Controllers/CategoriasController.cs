﻿using System;
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

        /*private static IList<Categoria> categorias = new List<Categoria>()
        {
            new Categoria() { CategoriaId = 1, Nome = "Anéis"},
            new Categoria() { CategoriaId = 2, Nome = "Braceletes"},
            new Categoria() { CategoriaId = 3, Nome = "Brincos"},
            new Categoria() { CategoriaId = 4, Nome = "Colares"},
            new Categoria() { CategoriaId = 5, Nome = "Relógios"}
        };*/

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
    }
}
