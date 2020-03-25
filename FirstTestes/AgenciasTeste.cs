using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Repository;
using Repository.Repositories;
using System.Linq;

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
    }

}
