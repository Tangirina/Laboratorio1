using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente01 = new Cliente();
            float imc;
            float imcIdeal = 24.9f;
            float pesoIdeal;
            float perderPeso;

            Console.WriteLine("Informe o seu nome: ");
            cliente01.nome = Console.ReadLine();

            Console.WriteLine("Informe a sua idade: ");
            cliente01.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a sua altura: ");
            cliente01.altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o seu peso: ");
            cliente01.peso = float.Parse(Console.ReadLine());

            imc = cliente01.peso / (cliente01.altura * cliente01.altura);

            Console.WriteLine("O seu IMC é: " + imc);

            if (imc >= 18.5f && imc <= 24.9f)
            {
                Console.WriteLine("Parabéns — você está em seu peso normal!");
                Console.ReadLine();
                return;
            }
            if (imc >= 25f && imc <= 29.9f)
            {
                Console.WriteLine("Você está acima de seu peso (sobrepeso).");
            }
            if (imc >= 30f && imc <= 34.9f)
            {
                Console.WriteLine("Obesidade grau I.");
            }
            if (imc >= 35f && imc <= 39.9f)
            {
                Console.WriteLine("Obesidade grau II.");
            }
            if (imc >= 40)
            {
                Console.WriteLine("Obesidade grau III e IV.");
            }

            pesoIdeal = imcIdeal * (cliente01.altura * cliente01.altura);

            perderPeso = cliente01.peso - pesoIdeal;

            Console.WriteLine("O seu peso ideal: " + pesoIdeal);
            Console.WriteLine("Você precisa perder: " + perderPeso + " Kg para chegar em seu peso ideal");
            Console.ReadLine();
        }
    }
}
