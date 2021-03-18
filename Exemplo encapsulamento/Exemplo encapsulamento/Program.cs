using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carroDoXesque = new Carro("Fuquinha", "Fosco", 1990, 120);
            carroDoXesque.Ligar();
            Console.ReadLine();
            carroDoXesque.Desligar();
            Console.ReadLine();

        }
    }
}
