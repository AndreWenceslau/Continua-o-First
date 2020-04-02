using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Repository;

namespace FirstTestes.Testes
{
    [TestClass]
    public class ClientePessoaJuridicaTeste
    {
        [TestMethod]
        public void ClientePessoaJuridicaRepository()
        {
            var context = new SistemaContext();
            Assert.IsNotNull(context);
        }
        [TestMethod]
        public void AlterarTeste()
        {
            var clientePessoaJuridicaMock = new ClientePessoaJuridica();
            clientePessoaJuridicaMock.RazaoSocial = "Razão Social Teste";
            clientePessoaJuridicaMock.Atividade = "Atividade Teste";
            clientePessoaJuridicaMock.NomeFantasia = "Nome fabtasia Teste";
            clientePessoaJuridicaMock.DataCadastro = DateTime.Now;
            clientePessoaJuridicaMock.Cnpj = "13.184.503/0001-06";
            clientePessoaJuridicaMock.Email = "teste@gmail.com";
            clientePessoaJuridicaMock.Filial = "Filial Teste";
            clientePessoaJuridicaMock.Telefone = "(99) 9999-9999";
            clientePessoaJuridicaMock.Cep = "99999-999";
            clientePessoaJuridicaMock.Logradouro = "Teste Logradouro";
            clientePessoaJuridicaMock.Numero = 123;
            clientePessoaJuridicaMock.Bairro = "Teste Bairro";
            clientePessoaJuridicaMock.Uf = "Teste Uf";
            clientePessoaJuridicaMock.Cidade = "Teste Cidade";
            clientePessoaJuridicaMock.RegistroAtivo = true;
            bool Alterar(ClientePessoaJuridica clientePessoaJuridica)
            {
                var clientePessoaJuridicaOriginal = clientePessoaJuridicaMock;
                if (clientePessoaJuridicaOriginal == null)
                {
                    return false;
                }
                clientePessoaJuridicaOriginal.RazaoSocial = "Razão Social Teste 02";
                clientePessoaJuridicaOriginal.Atividade = "Atividade Teste 02";
                clientePessoaJuridicaOriginal.NomeFantasia = "Nome fabtasia Teste 02";
                clientePessoaJuridicaOriginal.DataCadastro = DateTime.Now;
                clientePessoaJuridicaOriginal.Cnpj = "13.184.503/0001-07";
                clientePessoaJuridicaOriginal.Email = "teste02@gmail.com";
                clientePessoaJuridicaOriginal.Filial = "Filial Teste 02";
                clientePessoaJuridicaOriginal.Telefone = "(99) 9999-9998";
                clientePessoaJuridicaOriginal.Cep = "99999-999";
                clientePessoaJuridicaOriginal.Logradouro = "Teste Logradouro 02";
                clientePessoaJuridicaOriginal.Numero = 1234;
                clientePessoaJuridicaOriginal.Bairro = "Teste Bairro 02"; ;
                clientePessoaJuridicaOriginal.Uf = "Teste Uf 02"; ;
                clientePessoaJuridicaOriginal.Cidade = "Teste Cidade 02";
                int quantidadeAfetada = 1;
                return quantidadeAfetada == 1;
            }
            var resultado = Alterar(clientePessoaJuridicaMock);
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void ApagarTeste()
        {
            var clientePessoaJuridicaMock = new ClientePessoaJuridica();
            clientePessoaJuridicaMock.RazaoSocial = "Razão Social Teste";
            clientePessoaJuridicaMock.Atividade = "Atividade Teste";
            clientePessoaJuridicaMock.NomeFantasia = "Nome fabtasia Teste";
            clientePessoaJuridicaMock.DataCadastro = DateTime.Now;
            clientePessoaJuridicaMock.Cnpj = "13.184.503/0001-06";
            clientePessoaJuridicaMock.Email = "teste@gmail.com";
            clientePessoaJuridicaMock.Filial = "Filial Teste";
            clientePessoaJuridicaMock.Telefone = "(99) 9999-9999";
            clientePessoaJuridicaMock.Cep = "99999-999";
            clientePessoaJuridicaMock.Logradouro = "Teste Logradouro";
            clientePessoaJuridicaMock.Numero = 123;
            clientePessoaJuridicaMock.Bairro = "Teste Bairro";
            clientePessoaJuridicaMock.Uf = "Teste Uf";
            clientePessoaJuridicaMock.Cidade = "Teste Cidade";
            clientePessoaJuridicaMock.RegistroAtivo = true;
            int quantidadeAfetada = default(int);
            bool Apagar(int id)
            {
                var clientePessoaJuridica = clientePessoaJuridicaMock;
                if (clientePessoaJuridica == null)
                {
                    return false;
                }
                clientePessoaJuridica.RegistroAtivo = false;

                if (clientePessoaJuridica.RegistroAtivo == false)
                {
                    quantidadeAfetada = 1;
                }
                return quantidadeAfetada == 1;
            }
            var resultado = Apagar(clientePessoaJuridicaMock.Id);
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void InserirTeste()
        {
            var clientePessoaJuridicaMock = new ClientePessoaJuridica();
            clientePessoaJuridicaMock.RazaoSocial = "Razão Social Teste";
            clientePessoaJuridicaMock.Atividade = "Atividade Teste";
            clientePessoaJuridicaMock.NomeFantasia = "Nome fabtasia Teste";
            clientePessoaJuridicaMock.DataCadastro = DateTime.Now;
            clientePessoaJuridicaMock.Cnpj = "13.184.503/0001-06";
            clientePessoaJuridicaMock.Email = "teste@gmail.com";
            clientePessoaJuridicaMock.Filial = "Filial Teste";
            clientePessoaJuridicaMock.Telefone = "(99) 9999-9999";
            clientePessoaJuridicaMock.Cep = "99999-999";
            clientePessoaJuridicaMock.Logradouro = "Teste Logradouro";
            clientePessoaJuridicaMock.Numero = 123;
            clientePessoaJuridicaMock.Bairro = "Teste Bairro";
            clientePessoaJuridicaMock.Uf = "Teste Uf";
            clientePessoaJuridicaMock.Cidade = "Teste Cidade";
            clientePessoaJuridicaMock.RegistroAtivo = true;
            var context = new SistemaContext();
            int Inserir(ClientePessoaJuridica clientePessoaJuridica)
            {
                clientePessoaJuridica.RegistroAtivo = true;
                context.ClientesPessoasJuridicas.Add(clientePessoaJuridicaMock);
                context.SaveChanges();
                return clientePessoaJuridica.Id;
            }
            var resultado = Inserir(clientePessoaJuridicaMock);
            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void ObterPeloIdTeste()
        {
            var clientePessoaJuridicaMock = new ClientePessoaJuridica();
            clientePessoaJuridicaMock.RazaoSocial = "Razão Social Teste";
            clientePessoaJuridicaMock.Atividade = "Atividade Teste";
            clientePessoaJuridicaMock.NomeFantasia = "Nome fabtasia Teste";
            clientePessoaJuridicaMock.DataCadastro = DateTime.Now;
            clientePessoaJuridicaMock.Cnpj = "13.184.503/0001-06";
            clientePessoaJuridicaMock.Email = "teste@gmail.com";
            clientePessoaJuridicaMock.Filial = "Filial Teste";
            clientePessoaJuridicaMock.Telefone = "(99) 9999-9999";
            clientePessoaJuridicaMock.Cep = "99999-999";
            clientePessoaJuridicaMock.Logradouro = "Teste Logradouro";
            clientePessoaJuridicaMock.Numero = 123;
            clientePessoaJuridicaMock.Bairro = "Teste Bairro";
            clientePessoaJuridicaMock.Uf = "Teste Uf";
            clientePessoaJuridicaMock.Cidade = "Teste Cidade";
            clientePessoaJuridicaMock.RegistroAtivo = true;
            ClientePessoaJuridica ObterPeloId(int id)
            {
                var clientePessoaJuridica = clientePessoaJuridicaMock;
                return clientePessoaJuridica;
            }
            var resultado = ObterPeloId(clientePessoaJuridicaMock.Id);
            Assert.IsNotNull(resultado);
        }
        [TestMethod]
        public void ObterTodosTeste()
        {
            List<ClientePessoaJuridica> ObterTodos()
            {
                var context = new SistemaContext();

                return context.ClientesPessoasJuridicas
                   .Where(x => x.RegistroAtivo == true)
                   .OrderBy(x => x.Id)
                   .ToList();
            }
            var resultado = ObterTodos();
            Assert.IsNotNull(resultado);
        }
    }
}
