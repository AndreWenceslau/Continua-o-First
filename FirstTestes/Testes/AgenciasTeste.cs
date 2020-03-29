using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Repository;
using Repository.Repositories;
using System.Linq;
using System.Collections.Generic;

namespace FirstTestes
{
    [TestClass]
    public class AgenciasTeste : AgenciaRepository
    {
        public void AgenciaRepository()
        {
            context = new SistemaContext();
        }
       

        [TestMethod]
        public void AlterarTeste()
        {
           var agencia = new Agencia();
            agencia.Id = 1000;
            agencia.Banco = "banco teste 02";
            agencia.NomeAgencia = "banco teste 2";
            agencia.NumeroAgencia = 5154;
            agencia.RegistroAtivo = true;
            bool Alterar(Agencia agencias)
            {
                agencia.Banco = "banco";
                agencia.NomeAgencia = "agencia";
                agencia.NumeroAgencia = 51546;
                int quantidadeAfetada = context.SaveChanges();
               return true;
            }
            var resultado = Alterar(agencia);
            
            Assert.AreEqual(true, Alterar(agencia));
        }
        [TestMethod]
        public void ApagarTeste()
        {
            bool Apagar(int id)
            {
                var agenciaApagar = new Agencia();
                agenciaApagar.Id = 1000;
                agenciaApagar.Banco = "banco teste 02";
                agenciaApagar.NomeAgencia = "banco teste 2";
                agenciaApagar.NumeroAgencia = 5154;
                agenciaApagar.RegistroAtivo = true;
                var agencia = agenciaApagar;

                if (agencia == null)
                {
                    return false;
                }

                agencia.RegistroAtivo = false;
                int quantidadeAfetada = context.SaveChanges();
                return quantidadeAfetada == 0;
            }
            var resultado = Apagar(1000);
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void InserirTeste()
        {
            var agencia = new Agencia();
            agencia.Banco = "banco teste 02";
            agencia.NomeAgencia = "banco teste 2";
            agencia.NumeroAgencia = 5154;
            agencia.RegistroAtivo = true;
            int Inserir(Agencia agencias)
            {
                context.Agencias.Add(agencia);
                context.SaveChanges();
                return agencia.Id;
            }
            var resultado = Inserir(agencia);
            Assert.AreEqual(agencia.Id, resultado);
        }
        [TestMethod]
        public void ObterPelodTeste()
        {
            var agencia = new Agencia();
            agencia.Banco = "banco teste 02";
            agencia.NomeAgencia = "banco teste 2";
            agencia.NumeroAgencia = 5154;
            agencia.RegistroAtivo = true;
            Agencia ObterPeloId(int id)
            {
                var agencias = agencia;
                return agencias;
            }
            var resultado = ObterPeloId(agencia.Id);
            Assert.AreEqual(agencia.Id, agencia.Id);
        }
        [TestMethod]
        public void ObterTodosTeste()
        {
            List<Agencia> ObterTodos()
            {
                return context.Agencias.Where(x => x.RegistroAtivo == true).OrderBy(x => x.Id).ToList();
               
            }
            var resultado = ObterTodos(); 
            
            Assert.IsNotNull(resultado);
        }

    }

}
