using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class JogoDigital : Produto
    {
        public string Plataforma { get; private set; }

        public JogoDigital(string titulo, double preco, string plataforma) : base(titulo, preco)
        {
            Plataforma = plataforma;
        }

        public override void InformarDescricao()
        {
            Console.WriteLine($"O jogo {Titulo} para a plataforma {Plataforma}");
        }

    }
}