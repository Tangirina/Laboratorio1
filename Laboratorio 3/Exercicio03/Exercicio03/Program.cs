using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto jogo0 = new JogoDigital("FIFA20", 200, "PS5");
            Produto jogo1 = new JogoDigital("God of War", 5, "PS2");

            Produto livro0 = new Livro("O principe", 40, "Maquiavel");
            Produto livro1 = new Livro("Arte da Guerra", 60, "Sun Tzu");

            Produto[] produtos = { jogo0, jogo1, livro0, livro1 };

            foreach (Produto item in produtos)
            {
                item.InformarDescricao();
                item.InformarPreco();
                Console.WriteLine("\n---------------------------------");
                Console.ReadLine();
            }

        }
    }
}