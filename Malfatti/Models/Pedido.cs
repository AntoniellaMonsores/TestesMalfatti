using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Malfatti.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public double Preco { get; set; }
        public string Situacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string EnvioRastreio { get; set; }
    }
}
