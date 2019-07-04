using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication3;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            InSimularAcordo simularAcordo = new InSimularAcordo();

            InOperacoes inOperacoes = new InOperacoes();

            inOperacoes.Operacao = new List<InOperacao>()
            {
                new InOperacao(){CodigoOperacao="12",ValorOperacao=53},
                new InOperacao(){CodigoOperacao="21",ValorOperacao=78}
            };

            simularAcordo.OperacoesAcordadas = inOperacoes;

            var headers = Request.Headers;

            

            return View(InserirAcordo(simularAcordo));
        }

        
        public virtual double InserirAcordo(InSimularAcordo entrada)
        {
            if (ModelState.IsValid)
            {
                WebService1 ws = new WebService1();              

                 var dadosAcordo= AutoMapper.Mapper.Map<WebApplication3.IndadosAcordo>(entrada);

                var valor = ws.Quantidade(dadosAcordo);

                return valor;
            }
            return 0;
            
        }
    }
}
