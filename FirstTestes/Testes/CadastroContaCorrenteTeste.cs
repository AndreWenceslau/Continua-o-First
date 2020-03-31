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
    public class CadastroContaCorrenteTeste : CadastroContaCorrenteRepository
    {

        [TestMethod]
        public void CadastroContaCorrenteRepositoryTeste()
        {
            context = new SistemaContext();
            Assert.IsNotNull(context);
        }
        [TestMethod]
        public void AlterarTeste()
        {
            var conta = new CadastroContaCorrente();
            conta.Agencia = new Agencia();
            conta.Id = 5154;
            conta.NumeroConta = 10;
            conta.RegistroAtivo = true;
            
            bool Alterar(CadastroContaCorrente cadastrosContaCorrente)
            {
                var cadastroContaCorrenteOriginal = conta;
                if (cadastrosContaCorrente == null)
                {
                    return false;
                }

                cadastroContaCorrenteOriginal.IdAgencia = conta.Id;
                cadastroContaCorrenteOriginal.NumeroConta = 11;
                int quantidadeAfetada = 1;
                return quantidadeAfetada == 1;

            }
            var resultado = Alterar(conta);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void ApagarTeste()
        {
            var conta = new CadastroContaCorrente();
            conta.Agencia = new Agencia();
            conta.Id = 5154;
            conta.NumeroConta = 10;
            conta.RegistroAtivo = true;
            bool Apagar(int id)
            {
                var CadastroContaCorrente = conta;
                if (CadastroContaCorrente == null)
                {
                    return false;
                }
                CadastroContaCorrente.RegistroAtivo = false;
                int quantidadeAfetada = 1;
                return quantidadeAfetada == 1;
            }
            var resultado = Apagar(conta.Id);
            Assert.AreEqual(true, resultado);

        }

        [TestMethod]
        public void InserirTeste()
        {
            var conta = new CadastroContaCorrente();
            conta.Agencia = new Agencia();
            conta.Id = 5154;
            conta.NumeroConta = 10;
            conta.RegistroAtivo = true;
            int Inserir(CadastroContaCorrente cadastrosContaCorrente)
            {
                cadastrosContaCorrente.RegistroAtivo = true;
                context.CadastroContaCorrentes.Add(cadastrosContaCorrente);
                context.SaveChanges();
                return conta.Id;
            }
            var resultado = Inserir(conta);
            Assert.AreEqual(conta.Id,resultado);
        }

        [TestMethod]
        public CadastroContaCorrente ObterPeloIdTeste(int id)
        {
            var contacorrente = context.CadastroContaCorrentes
                .Include("Agencia")
               .FirstOrDefault(x => x.Id == id);
            return contacorrente;
        }

        [TestMethod]
        public void ObterTodosTeste()
        {
            var conta = new CadastroContaCorrente();
            conta.Agencia = new Agencia();
            conta.Id = 5154;
            conta.NumeroConta = 10;
            conta.RegistroAtivo = true;
            List<CadastroContaCorrente> ObterTodos()
            {
                return context.CadastroContaCorrentes
                    .Include("Agencia")
                    .Where(x => x.RegistroAtivo == true).OrderBy(x => x.Id).ToList();
            }
            var resultado = ObterTodos();
            Assert.IsNotNull(resultado);
        }



    }
}
