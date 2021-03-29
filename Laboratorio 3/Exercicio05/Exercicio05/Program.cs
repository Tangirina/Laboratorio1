using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        const double PRECO_APERITIVO = 12.50f;

        static void Main(string[] args)
        {
            ItemMenu bebida0 = new Bebida("Cerveja", 9.50);
            ItemMenu bebida1 = new Bebida("Refrigerante", 7.50);
            ItemMenu bebida2 = new Bebida("Suco", 6);

            ItemMenu aperitivo0 = new Aperitivo("Batata Frita", PRECO_APERITIVO);
            ItemMenu aperitivo1 = new Aperitivo("Macaxeira Frita", PRECO_APERITIVO);

            ItemMenu[] cardapio = { aperitivo0, aperitivo1, bebida0, bebida1, bebida2 };

            foreach (ItemMenu item in cardapio)
            {
                item.ImprimirNome();
                item.ImprimirPreco();
                Console.WriteLine("\n*****************************");
                Console.ReadLine();
            }
        }
    }
}