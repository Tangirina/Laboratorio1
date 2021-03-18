using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_lab_2
{
    class Conta
    {
        string nomeCorrentista;
        int numeroIdentificacao;
        float saldoAtual;

        public Conta(string nomeCorrentista, int numeroIdentificacao, float saldoAtual)
        {
            this.nomeCorrentista = nomeCorrentista;
            this.numeroIdentificacao = numeroIdentificacao;
            this.saldoAtual = saldoAtual;
        }

        public string NomeCorrentista { get => nomeCorrentista; }
        public int NumeroIdentificacao { get => numeroIdentificacao; }
        public float SaldoAtual { get => saldoAtual; set => saldoAtual = value; }



    }
}