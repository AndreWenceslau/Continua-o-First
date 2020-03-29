using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Repository;
using Repository.Repositories;
using System.Linq;
using System.Collections.Generic;
using TccFirst.Controllers;
using System.Web.Mvc;

namespace FirstTestes.Testes
{
    [TestClass]
    public class CadastroContaCorrenteTeste:CadastroContaCorrenteController
    {
        private CadastroContaCorrenteRepository repository;

        [TestMethod]
        public void CadastroContaCorrenteControllerTeste()
        {
            repository = new CadastroContaCorrenteRepository();
            var resultado = repository;
            Assert.IsNotNull(resultado);
        }
        [HttpGet, Route("cadastroContaCorrente")]
        public void  ObterPeloIdTeste(int id)
        {
            var retorno = Json(repository.ObterPeloId(id), JsonRequestBehavior.AllowGet);
            Assert.IsNotNull(retorno);
        }
        [HttpGet, Route("obtertodos")]
        public void ObterTodosTeste()
        {
            var cadastroContaCorrente = repository.ObterTodos();
            var resultado = new { data = cadastroContaCorrente };
            var retorno =  Json(resultado, JsonRequestBehavior.AllowGet);
            Assert.IsNotNull(retorno);
        }
        [HttpPost]
        public void InserirTeste(CadastroContaCorrente cadastroContaCorrente)
        {
            cadastroContaCorrente.RegistroAtivo = true;
            var id = repository.Inserir(cadastroContaCorrente);
            var resultado = new { id = id };
            var retorno =  Json(resultado);
            Assert.IsNotNull(retorno);
        }
        [HttpPost, Route("cadastro")]
        public void CadastroTeste(CadastroContaCorrente cadastroContaCorrente)
        {
            cadastroContaCorrente.RegistroAtivo = true;
            int id = repository.Inserir(cadastroContaCorrente);
            var resultado = new { id = id };
            var retorno = RedirectToAction("Index", resultado);
            Assert.IsNotNull(retorno);
        }

        [HttpPost]
        public void UpdateTeste(CadastroContaCorrente cadastroContaCorrente)
        {
            var alterou = repository.Alterar(cadastroContaCorrente);
            var resultado = new { status = alterou };
            var retorno = Json(resultado);
            Assert.IsNotNull(retorno);
        }

        [HttpGet, Route("apagar")]
        public void ApagarTeste(int id)
        {
            var apagou = repository.Apagar(id);
            var resultado = new { status = apagou };
            var retorno = Json(resultado, JsonRequestBehavior.AllowGet);
            Assert.IsNotNull(retorno);
        }

        public void IndexTeste()
        {
            var retorno = View();
            Assert.IsNotNull(retorno);
        }

        [HttpGet, Route("Index")]
        public void  CadastroTeste()
        {
            var retorno =  View();
            Assert.IsNotNull(retorno);
        }



    }
}
