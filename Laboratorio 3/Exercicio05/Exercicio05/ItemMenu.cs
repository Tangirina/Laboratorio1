using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class ItemMenu
    {
        public string Nome { get; set; }
        public double Preco { get; protected set; }

        public ItemMenu(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void ImprimirNome()
        {
            Console.WriteLine($"{Nome}");
        }

        public virtual void ImprimirPreco()
        {
            Console.WriteLine($"{Preco}");
        }
    }

}