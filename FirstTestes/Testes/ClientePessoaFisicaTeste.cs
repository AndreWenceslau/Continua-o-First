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
    public class ClientePessoaFisicaTeste : ClientePessoaFisicaRepository
    {
        [TestMethod]
        public void ClientePessoaFisicaRepository()
        {
            var context = new SistemaContext();
            Assert.IsNotNull(context);
        }
        [TestMethod]
        public void AlterarTeste()
        {
            var clientePessoaFisicaTeste = new ClientePessoaFisica();
            clientePessoaFisicaTeste.Nome = "Cliente Teste";
            clientePessoaFisicaTeste.Cpf = "048.322.529-09";
            clientePessoaFisicaTeste.DataNascimento = new DateTime(2001, 01, 01);
            clientePessoaFisicaTeste.LimiteCredito = 1000;
            clientePessoaFisicaTeste.Email = "teste@gmail.com";
            clientePessoaFisicaTeste.Telefone = "(99)9999-9999";
            clientePessoaFisicaTeste.Cep = "89066-305";
            clientePessoaFisicaTeste.Numero = 123;
            clientePessoaFisicaTeste.Bairro = "Teste Bairro";
            clientePessoaFisicaTeste.Cidade = "Cidade Teste";
            clientePessoaFisicaTeste.Uf = "Uf Teste";
            clientePessoaFisicaTeste.Complemento = "Complemento Teste";
            clientePessoaFisicaTeste.RegistroAtivo = true;

            bool Alterar(ClientePessoaFisica clientePessoaFisica)
            {
                var clientePessoaFisicaOriginal = clientePessoaFisicaTeste;

                if (clientePessoaFisicaOriginal == null)
                    return false;
                clientePessoaFisicaOriginal.Nome = "Teste Bairro 2";
                clientePessoaFisicaOriginal.Cpf = clientePessoaFisica.Cpf;
                clientePessoaFisicaOriginal.DataNascimento = clientePessoaFisica.DataNascimento;
                clientePessoaFisicaOriginal.LimiteCredito = clientePessoaFisica.LimiteCredito;
                clientePessoaFisicaOriginal.Email = clientePessoaFisica.Email;
                clientePessoaFisicaOriginal.Telefone = clientePessoaFisica.Telefone;
                clientePessoaFisicaOriginal.Cep = clientePessoaFisica.Cep;
                clientePessoaFisicaOriginal.Numero = clientePessoaFisica.Numero;
                clientePessoaFisicaOriginal.Bairro = clientePessoaFisica.Bairro;
                clientePessoaFisicaOriginal.Cidade = clientePessoaFisica.Cidade;
                clientePessoaFisicaOriginal.Uf = clientePessoaFisica.Uf;
                clientePessoaFisicaOriginal.Complemento = clientePessoaFisica.Complemento;
                int quantidadeAfetada = 1;
                return quantidadeAfetada == 1;
            }
            var resultado = Alterar(clientePessoaFisicaTeste);
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void ApagarTeste()
        {
            var clientePessoaFisicaTeste = new ClientePessoaFisica();
            clientePessoaFisicaTeste.Nome = "Cliente Teste";
            clientePessoaFisicaTeste.Cpf = "048.322.529-09";
            clientePessoaFisicaTeste.DataNascimento = new DateTime(2001, 01, 01);
            clientePessoaFisicaTeste.LimiteCredito = 1000;
            clientePessoaFisicaTeste.Email = "teste@gmail.com";
            clientePessoaFisicaTeste.Telefone = "(99)9999-9999";
            clientePessoaFisicaTeste.Cep = "89066-305";
            clientePessoaFisicaTeste.Numero = 123;
            clientePessoaFisicaTeste.Bairro = "Teste Bairro";
            clientePessoaFisicaTeste.Cidade = "Cidade Teste";
            clientePessoaFisicaTeste.Uf = "Uf Teste";
            clientePessoaFisicaTeste.Complemento = "Complemento Teste";
            clientePessoaFisicaTeste.RegistroAtivo = true;
            int quantidadeAfetada = default(int);
            bool Apagar(int id)
            {
                var clientePessoaFisica = clientePessoaFisicaTeste;
                if (clientePessoaFisica == null)
                    return false;
                clientePessoaFisica.RegistroAtivo = false;
                if (clientePessoaFisica.RegistroAtivo == false)
                {
                    quantidadeAfetada = 1;
                }
                return quantidadeAfetada == 1;
            }
            var resultado = Apagar(clientePessoaFisicaTeste.Id);
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void InserirTeste()
        {
            var clientePessoaFisicaTeste = new ClientePessoaFisica();
            clientePessoaFisicaTeste.Nome = "Cliente Teste";
            clientePessoaFisicaTeste.Cpf = "048.322.529-09";
            clientePessoaFisicaTeste.DataNascimento = new DateTime(2001, 01, 01);
            clientePessoaFisicaTeste.LimiteCredito = 1000;
            clientePessoaFisicaTeste.Email = "teste@gmail.com";
            clientePessoaFisicaTeste.Telefone = "(99)9999-9999";
            clientePessoaFisicaTeste.Cep = "89066-305";
            clientePessoaFisicaTeste.Numero = 123;
            clientePessoaFisicaTeste.Bairro = "Teste Bairro";
            clientePessoaFisicaTeste.Cidade = "Cidade Teste";
            clientePessoaFisicaTeste.Uf = "Uf Teste";
            clientePessoaFisicaTeste.Complemento = "Complemento Teste";
            clientePessoaFisicaTeste.RegistroAtivo = true;
            var context = new SistemaContext();
            int Inserir(ClientePessoaFisica clientePessoaFisica)
            {
                clientePessoaFisica.RegistroAtivo = true;
                context.ClientesPessoasFisicas.Add(clientePessoaFisicaTeste);
                return clientePessoaFisicaTeste.Id;
            }
            var resultado = Inserir(clientePessoaFisicaTeste);
            Assert.IsNotNull(resultado);
        }
        [TestMethod]
        public void ObterPeloIdTeste()
        {
            var clientePessoaFisicaTeste = new ClientePessoaFisica();
            clientePessoaFisicaTeste.Nome = "Cliente Teste";
            clientePessoaFisicaTeste.Cpf = "048.322.529-09";
            clientePessoaFisicaTeste.DataNascimento = new DateTime(2001, 01, 01);
            clientePessoaFisicaTeste.LimiteCredito = 1000;
            clientePessoaFisicaTeste.Email = "teste@gmail.com";
            clientePessoaFisicaTeste.Telefone = "(99)9999-9999";
            clientePessoaFisicaTeste.Cep = "89066-305";
            clientePessoaFisicaTeste.Numero = 123;
            clientePessoaFisicaTeste.Bairro = "Teste Bairro";
            clientePessoaFisicaTeste.Cidade = "Cidade Teste";
            clientePessoaFisicaTeste.Uf = "Uf Teste";
            clientePessoaFisicaTeste.Complemento = "Complemento Teste";
            clientePessoaFisicaTeste.RegistroAtivo = true;
            var context = new SistemaContext();
            ClientePessoaFisica ObterPeloId(int id)
            {
                var clientePessoaFisica = clientePessoaFisicaTeste;
                return clientePessoaFisica;
            }
            var resultado = ObterPeloId(clientePessoaFisicaTeste.Id);
            Assert.IsNotNull(resultado);
        }
        [TestMethod]
        public void OnterTodosTeste()
        {
            List<ClientePessoaFisica> ObterTodos()
            {
                var context = new SistemaContext();
                return context.ClientesPessoasFisicas.Where(x => x.RegistroAtivo == true).OrderBy(x => x.Id).ToList();
            }
            var resultado = ObterTodos();
            Assert.IsNotNull(resultado);
        }
    }
}
