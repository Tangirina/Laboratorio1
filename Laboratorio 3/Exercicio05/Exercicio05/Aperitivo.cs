using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Aperitivo : ItemMenu
    {
        public Aperitivo(string nome, double preco) : base(nome, preco)
        {
        }

        public override void ImprimirPreco()
        {
            Console.WriteLine($"{Preco.ToString("C")}");
        }
    }
}