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
        private SistemaContext context;


        [TestMethod]
        public void AlterarTeste()
        {

            bool Alterar(Agencia agencia)
            {

                var agenciaOriginal = context.Agencias.FirstOrDefault(x => x.Id == 1);

                if (agenciaOriginal == null)
                    return false;

                agenciaOriginal.Banco = agencia.Banco;
                agenciaOriginal.NomeAgencia = agencia.NomeAgencia;
                agenciaOriginal.NumeroAgencia = agencia.NumeroAgencia;
                int quantidadeAfetada = context.SaveChanges();
                return quantidadeAfetada == 1;

            }
        }
        [TestMethod]
        public void ApagarTeste()
        {
            bool Apagar(int id)
            {
                var agencia = context.Agencias.FirstOrDefault(x => x.Id == 10000);

                if (agencia == null)
                {
                    return false;
                }

                agencia.RegistroAtivo = false;
                int quantidadeAfetada = context.SaveChanges();
                return quantidadeAfetada == 1;
            }
        }
        [TestMethod]
        public void InserirTeste()
        {
            int Inserir(Agencia agencia)
            {
                context.Agencias.Add(agencia);
                context.SaveChanges();
                return agencia.Id;
            }
        }
        [TestMethod]
        public void ObterPelodTeste()
        {
            Agencia ObterPeloId(int id)
            {
                var agencia = context.Agencias.FirstOrDefault(x => x.Id == 1);
                return agencia;
            }
        }
        [TestMethod]
        public void ObterTodos()
        {
            List<Agencia> ObterTodos()
            {
                return context.Agencias.Where(x => x.RegistroAtivo == true).OrderBy(x => x.Id).ToList();

            }
        }
    }

}
