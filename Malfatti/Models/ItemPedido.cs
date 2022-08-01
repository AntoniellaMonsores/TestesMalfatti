using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Malfatti.Models
{
    public class ItemPedido
    {
        public int IdProduto { get; set; }
        public int IdItemPedido { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
    }
}
