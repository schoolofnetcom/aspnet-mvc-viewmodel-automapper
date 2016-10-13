using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarrinhoComprasController : Controller
    {
        //
        // GET: /CarrinhoCompras/
        public ActionResult Index()
        {
            var produtos = new List<Produto>();
            for (int i = 1; i < 6; i++)
            {
                produtos.Add(new Produto() {
                    ID = i,
                    Nome = "Produto " + i,
                    Valor = i * 2.5M
                });
            }

            var model = new CarrinhoComprasViewModel()
            {
                Mensagem = "Parabéns, você fez uma excelente compra!",
                Produtos = produtos,
                ValorTotal = produtos.Sum(p => p.Valor)
            };

            return View(model);
        }
	}
}