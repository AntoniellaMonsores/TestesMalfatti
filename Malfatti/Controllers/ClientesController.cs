using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Malfatti.Models;

namespace Malfatti.Controllers
{
    public class ClientesController : Controller
    {
        private static IList<Cliente> clientes = new List<Cliente>()
        {
            new Cliente() { ClienteId = 1, Nome = "A"},
            new Cliente() { ClienteId = 2, Nome = "B"},
            new Cliente() { ClienteId = 3, Nome = "C"},
            new Cliente() { ClienteId = 4, Nome = "D"},
            new Cliente() { ClienteId = 5, Nome = "E"}
        };

        // GET: Cliente
        public ActionResult Index()
        {
            return View(clientes);
        }
    }
}
