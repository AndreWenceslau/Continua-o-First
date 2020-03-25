﻿using Model;
using System;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    interface ITransacoes
    {
        int Inserir(Transacao transacao);

        bool Alterar(Transacao
            contaCorrente);

        List<Transacao> ObterTodos();

        bool Apagar(int id);

        Transacao ObterPeloId(int id);

        List<FluxoCaixa> ObterDadosSumarizados(DateTime dataInicial, DateTime dataFinal);

        List<Transacao> ObterTodosRelatorio(int idReceita, int IdDespesa, string documento);
    }
}