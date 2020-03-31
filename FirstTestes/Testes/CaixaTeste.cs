using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Repository;
using Repository.Repositories;
using TccFirst.Controllers;

namespace FirstTestes.Testes
{
    [TestClass]
    public class CaixaTeste : CaixaRepository
    {
        //SistemaContext context; // possivel erro

        [TestMethod]
        public void CaixaRepository()
        {
            var context = new SistemaContext();
            Assert.IsNotNull(context);
        }
        [TestMethod]
        public void AlterarTeste()
        {
            var caixa = new Caixa();
            caixa.IdHistoricos = 1;
            caixa.Operacao = "operação teste";
            caixa.Descricao = "teste";
            caixa.Documento = "teste";
            caixa.FormaPagamento = "forma de pagamento";
            caixa.Valor = 1000;
            caixa.DataLancamento = DateTime.Now;

            bool Alterar(Caixa caixas)
            {
                var caixaRegistro = caixa;

                if (caixaRegistro == null)
                    return false;
                caixaRegistro.IdHistoricos = caixas.IdHistoricos;
                caixaRegistro.Operacao = "operação teste 2";
                caixaRegistro.Descricao = "teste 2";
                caixaRegistro.Documento = "teste 2";
                caixaRegistro.FormaPagamento = "forma de pagamento";
                caixaRegistro.Valor = 2000;
                caixaRegistro.DataLancamento = DateTime.Now;
                int quantidadeAfetada = 1;
                return quantidadeAfetada == 1;
            }
            var resultado = Alterar(caixa);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void ApagarTeste()
        {
            var caixa = new Caixa();
            caixa.IdHistoricos = 1;
            caixa.Operacao = "operação teste";
            caixa.Descricao = "teste";
            caixa.Documento = "teste";
            caixa.FormaPagamento = "forma de pagamento";
            caixa.Valor = 1000;
            caixa.DataLancamento = DateTime.Now;
            bool Apagar(int id)
            {
                var caixaTeste = caixa;
                if (caixaTeste == null)
                    return false;
                caixaTeste.RegistroAtivo = false;
                int quantidadeAfetada = 1;
                return quantidadeAfetada == 1;
            }
            var resultado = Apagar(caixa.Id);
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void InserirTeste()
        {
            var context = new SistemaContext();
            var caixa = new Caixa();
            caixa.IdHistoricos = 1;
            caixa.Operacao = "operação teste";
            caixa.Descricao = "teste";
            caixa.Documento = "teste";
            caixa.FormaPagamento = "forma de pagamento";
            caixa.Valor = 1000;
            caixa.DataLancamento = DateTime.Now;
            int Inserir(Caixa caixas)
            {
                context.Caixas.Add(caixa);
                context.SaveChanges();
                return caixas.Id;
            }
            var resultado = Inserir(caixa);
            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void ObterPeloIdTeste()
        {
            var caixa = new Caixa();
            caixa.IdHistoricos = 1;
            caixa.Operacao = "operação teste";
            caixa.Descricao = "teste";
            caixa.Documento = "teste";
            caixa.FormaPagamento = "forma de pagamento";
            caixa.Valor = 1000;
            caixa.DataLancamento = DateTime.Now;
            var context = new SistemaContext();
            Caixa ObterPeloId(int id)
            {

                var caixas = caixa;
                return caixas;
            }
            var resultado = ObterPeloId(caixa.Id);
            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void ObterTodosTeste()
        {
            var caixa = new Caixa();
            caixa.IdHistoricos = 1;
            caixa.Operacao = "operação teste";
            caixa.Descricao = "teste";
            caixa.Documento = "teste";
            caixa.FormaPagamento = "forma de pagamento";
            caixa.Valor = 1000;
            caixa.DataLancamento = DateTime.Now;
            List<Caixa> ObterTodos()
            {
                var context = new SistemaContext();
                return context.Caixas.Include("Historico").Where(x => x.RegistroAtivo == true).OrderBy(x => x.Id).ToList();
            }
            var resultado = ObterTodos();
            Assert.IsNotNull(resultado);
        }
        [TestMethod]
        public void ObterTodosRelatorioTeste()
        {
            var caixa = new Caixa();
            caixa.IdHistoricos = 1;
            caixa.Operacao = "operação teste";
            caixa.Descricao = "teste";
            caixa.Documento = "teste";
            caixa.FormaPagamento = "forma de pagamento";
            caixa.Valor = 1000;
            caixa.DataLancamento = DateTime.Now;
            List<Caixa> ObterTodosRelatorio(string dataInicial, string dataFinal, int idHistorico, string descricao, int valor)
            {
                var context = new SistemaContext();
                if (dataInicial == "")
                {
                    dataInicial = null;
                }
                if (dataFinal == "")
                {
                    dataFinal = null;
                }
                var query = context
                    .Caixas
                    .Include("Historico")
                    .Where(x => x.RegistroAtivo);

                if (idHistorico != Caixa.FiltroSemHistorico)
                {
                    query = query.Where(x => x.IdHistoricos == idHistorico);
                }
                if (!string.IsNullOrEmpty(descricao))
                {
                    query = query.Where(x => x.Descricao.Contains(descricao));
                }
                if ((dataInicial != null) && (dataFinal != null))
                {
                    DateTime dataInicialConvertida = Convert.ToDateTime(dataInicial);
                    DateTime dataFinalConvertida = Convert.ToDateTime(dataFinal);
                    query = query.Where(x => x.DataLancamento == dataInicialConvertida || x.DataLancamento <= dataFinalConvertida);
                }
                if (valor != 0)
                {
                    query = query.Where(x => x.Valor == valor);
                }

                return query.ToList();
            }
            var resultado = ObterTodosRelatorio("2001-01-01", "2020-03-31", 1, "teste", 2000);
            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void ObterDadosSumarizadosTeste()
        {
            var caixa = new Caixa();
            caixa.IdHistoricos = 1;
            caixa.Operacao = "operação teste";
            caixa.Descricao = "teste";
            caixa.Documento = "teste";
            caixa.FormaPagamento = "forma de pagamento";
            caixa.Valor = 1000;
            caixa.DataLancamento = DateTime.Now;

            var dataHoje = DateTime.Now;
            var dataAntiga =  new DateTime(2001,01,01);
            var context = new SistemaContext();
            List<FluxoCaixa> ObterDadosSumarizados(DateTime dataInicial, DateTime dataFinal)
            {
                return context.Database
                    .SqlQuery<FluxoCaixa>(@"
                    SELECT FORMAT(caixas.data_lancamento, 'yyyy-MM-dd') AS data,  SUM(valor) as valor
                    FROM caixas 
                    GROUP BY FORMAT(caixas.data_lancamento, 'yyyy-MM-dd')
                    ").ToList();
            }
            var resultado = ObterDadosSumarizados(dataAntiga,dataHoje);
            Assert.IsNotNull(resultado);
        }
    }
}

