using Service.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PessoaController : Controller
    {
        //
        // GET: /Pessoa/
        public ActionResult Index()
        {
            ViewBag.Mensagem = "Minha primeira View";
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PessoaViewModel model)
        {
            ModelState.Remove("Codigo");

            if (ModelState.IsValid)
            {
                if (model.Captcha == "123#$")
                {
                    //MODO HARD
                    //Pessoa p = new Pessoa();

                    //p.Codigo = model.Codigo;
                    //p.Nome = model.Nome;
                    //p.Sobrenome = model.Sobrenome;
                    //p.Cpf = model.Cpf;
                    //p.DataNascimento = model.DataNascimento;
                    //p.Email = model.Email;
                    //p.Telefone = model.Telefone;
                    //p.NomeMae = model.NomeMae;



                    //MODO EASY
                    //Criar o Mapeamento por demanda
                    //AutoMapper.Mapper.CreateMap<PessoaViewModel, Pessoa>();

                    //Transformar um objeto em outro
                    var p = AutoMapper.Mapper.Map<PessoaViewModel, Pessoa>(model);

                    PessoaService srv = new PessoaService();
                    srv.Salvar(p);

                    return View("List", srv.Listar());
                }
                return View(model);
            }
            else
                return View(model);
        }

        public ActionResult List()
        {
            PessoaService srv = new PessoaService();
            return View(srv.Listar());
        }

        public ActionResult Edit(int id)
        {
            var srv = new PessoaService();
            var p = srv.Obter(id);

            //MODO EASY
            //AutoMapper.Mapper.CreateMap<Pessoa, PessoaViewModel>();
            var pVM = AutoMapper.Mapper.Map<Pessoa, PessoaViewModel>(p);

            return View("Create", pVM);
        }

        [HttpPost]
        public ActionResult Edit(Pessoa model)
        {
            if (ModelState.IsValid)
            {
                PessoaService srv = new PessoaService();
                srv.Salvar(model);

                return View("List", srv.Listar());
            }
            else
                return View("Create", model);
        }

        public ActionResult Delete(int id)
        {
            PessoaService srv = new PessoaService();
            srv.Deletar(id);

            return View("List", srv.Listar());
        }
	}
}