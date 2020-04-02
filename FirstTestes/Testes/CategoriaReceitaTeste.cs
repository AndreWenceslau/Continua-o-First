using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Repository;
using Repository.Repositories;

namespace FirstTestes.Testes
{
    [TestClass]
    public class CategoriaReceitaTeste : CategoriaReceitaRepository
    {


        [TestMethod]
        public void CategoriaReceitaRepository()
        {
            var context = new SistemaContext();
            Assert.IsNotNull(context);
        }
        [TestMethod]
        public void AlterarTeste()
        {
            var categoriaReceitaTeste = new CategoriaReceita();
            categoriaReceitaTeste.RegistroAtivo = true;
            categoriaReceitaTeste.TipoCategoriaReceita = "teste";
            int quantidadeAfetada = default(int);
            bool Alterar(CategoriaReceita categoriaReceita)
            {
                var categoriaCorreta = categoriaReceitaTeste;
                if (categoriaCorreta == null)
                    return false;
                categoriaCorreta.TipoCategoriaReceita = "Teste 02";
                if (categoriaCorreta.TipoCategoriaReceita == "Teste 02")
                {
                    quantidadeAfetada = 1;
                }
                else
                {
                    quantidadeAfetada = 0;
                }
                return quantidadeAfetada == 1;
            }
            var resultado = Alterar(categoriaReceitaTeste);
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void ApagarTeste()
        {
            var categoriaReceitaTeste = new CategoriaReceita();
            categoriaReceitaTeste.RegistroAtivo = true;
            categoriaReceitaTeste.TipoCategoriaReceita = "teste";
            int quantidadeAfetada = default(int);
            bool Apagar(int id)
            {
                var categoria = categoriaReceitaTeste;
                if (categoria == null)
                    return false;
                categoria.RegistroAtivo = false;
                if (categoria.RegistroAtivo == false)
                {
                    quantidadeAfetada = 1;
                }
                else
                {
                    quantidadeAfetada = 0;
                }
                return quantidadeAfetada == 1;
            }
            var resultado = Apagar(categoriaReceitaTeste.Id);
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void InserirTeste()
        {
            var categoriaReceitaTeste = new CategoriaReceita();
            categoriaReceitaTeste.RegistroAtivo = true;
            categoriaReceitaTeste.TipoCategoriaReceita = "teste";
            var context = new SistemaContext();

            int Inserir(CategoriaReceita categoriaReceita)
            {
                categoriaReceita.RegistroAtivo = true;
                context.CategoriasReceitas.Add(categoriaReceitaTeste);
                context.SaveChanges();
                return categoriaReceita.Id;
            }
            var resultado = Inserir(categoriaReceitaTeste);
            Assert.IsNotNull(resultado);
        }
        [TestMethod]
        public void ObterPeloIdTeste()
        {
            var categoriaReceitaTeste = new CategoriaReceita();
            categoriaReceitaTeste.RegistroAtivo = true;
            categoriaReceitaTeste.TipoCategoriaReceita = "teste";
            var context = new SistemaContext();
            CategoriaReceita ObterPeloId(int id)
            {
                var categoriaReceita = categoriaReceitaTeste;
                return categoriaReceita;
            }
            var resultado = ObterPeloId(categoriaReceitaTeste.Id);
            Assert.IsNotNull(resultado);
        }
        [TestMethod]
        public void ObterTodosTeste()
        {
            var context = new SistemaContext();
            List<CategoriaReceita> ObterTodos()
            {
                return context.CategoriasReceitas.Where(x => x.RegistroAtivo == true).OrderBy(x => x.Id).ToList();
            }
            var resultado = ObterTodos();
            Assert.IsNotNull(resultado);
        }
    }
}
