using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Malfatti.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public int MarcaId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public bool Disponivel { get; set; }
    }
}
