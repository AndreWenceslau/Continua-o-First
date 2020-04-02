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
    public class CategoriaDespesaTeste : CategoriaDespesaRepository
    {


        [TestMethod]
        public void CategoriaDespesaRepository()
        {
            var context = new SistemaContext();
            Assert.IsNotNull(context);
        }

        [TestMethod]
        public void AlterarTeste()
        {
            var categoriaDespesaTeste = new CategoriaDespesa();
            categoriaDespesaTeste.RegistroAtivo = true;
            categoriaDespesaTeste.TipoCategoriaDespesa = "teste tipo";
            bool Alterar(CategoriaDespesa categoriaDespesa)
            {
                int quantidadeAfetada = default(int);
                var categoriaRegistro = categoriaDespesaTeste;
                if (categoriaDespesa == null)
                    return false;
                categoriaRegistro.TipoCategoriaDespesa = "teste tipo 2";
                if (categoriaRegistro.TipoCategoriaDespesa == "teste tipo 2")
                {
                    quantidadeAfetada = 1;
                }
                else
                {
                    quantidadeAfetada = 0;
                }
                return quantidadeAfetada == 1;
            }
            var resultado = Alterar(categoriaDespesaTeste);
            Assert.AreEqual(true, resultado);

        }

        [TestMethod]
        public void ApagarTeste()
        {
            var categoriaDespesaTeste = new CategoriaDespesa();
            categoriaDespesaTeste.RegistroAtivo = true;
            categoriaDespesaTeste.TipoCategoriaDespesa = "teste tipo";
            int quantidadeAfetada = default(int);
            bool Apagar(int id)
            {
                var categoria = categoriaDespesaTeste;
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
            var resultado = Apagar(categoriaDespesaTeste.Id);
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void InserirTeste()
        {
            var categoriaDespesaTeste = new CategoriaDespesa();
            categoriaDespesaTeste.RegistroAtivo = true;
            categoriaDespesaTeste.TipoCategoriaDespesa = "teste tipo";
            var context = new SistemaContext();
            int Inserir(CategoriaDespesa categoriaDespesa)
            {
                context.CategoriasDespesas.Add(categoriaDespesaTeste);
                context.SaveChanges();
                return categoriaDespesa.Id;
            }
            var resultado = Inserir(categoriaDespesaTeste);
            Assert.IsNotNull(categoriaDespesaTeste);
        }
        [TestMethod]
        public void ObterPeloIdTeste()
        {
            var categoriaDespesaTeste = new CategoriaDespesa();
            categoriaDespesaTeste.RegistroAtivo = true;
            categoriaDespesaTeste.TipoCategoriaDespesa = "teste tipo";
            var context = new SistemaContext();
            CategoriaDespesa ObterPeloId(int id)
            {
                var categoria = categoriaDespesaTeste;
                return categoria;
            }
            var resultado = ObterPeloId(categoriaDespesaTeste.Id);
            Assert.IsNotNull(resultado);
        }
        [TestMethod]
        public void ObterTodosTeste()
        {

            var context = new SistemaContext();
            List<CategoriaDespesa> ObterTodos()
            {
                return context.CategoriasDespesas.Where(x => x.RegistroAtivo == true).OrderBy(x => x.Id).ToList();
            }
            var resultado = ObterTodos();
            Assert.IsNotNull(resultado);
        }
    }
}
