using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazendo_exercicio_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario bobNelson = new Usuario("Bob Nelson", 37, 78.0f, 1.70f);
            Console.WriteLine($"Situação  IMC Do {bobNelson.nome}: {bobNelson.InformarSituacaoIMC()}");
            Console.WriteLine($"Seu peso ideal é {bobNelson.InformarMetaPeso()}");
            Console.ReadLine();
        }
           
    }
}
