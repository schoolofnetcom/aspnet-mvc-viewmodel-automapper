using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CarrinhoComprasViewModel
    {
        public List<Produto> Produtos { get; set; }
        public decimal ValorTotal { get; set; }
        public string Mensagem { get; set; }
    }
}