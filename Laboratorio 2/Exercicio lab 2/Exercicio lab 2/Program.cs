using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cliente1 = new ContaCorrente("Bob Nelson", 123456, 0);
            cliente1.DepositarDinheiro(5000);
            Console.ReadLine();
            cliente1.TransferirDinheiro(1500, "Testolfo Rocha");
            cliente1.DinheiroTransferido(1000, "Testolfo Rocha");
            Console.ReadLine();
            cliente1.SacarDinheiro(900);
            cliente1.TransferirDinheiro(1500, "Lisa Leite");
            Console.ReadLine();
            cliente1.SacarDinheiro(2000);
            cliente1.DinheiroTransferido(700, "Testolfo Rocha");
            cliente1.VerificarSaldo();
            Console.ReadLine();


            ContaPoupanca cliente2 = new ContaPoupanca("Testolfo Rocha", 717171, 0);
            cliente2.DepositarDinheiro(1500);
            Console.ReadLine();
            cliente2.TransferirDinheiro(1000, "Bob Nelson");
            cliente2.DinheiroTransferido(1500, "Bob Nelson");
            Console.ReadLine();
            cliente2.DinheiroTransferido(400, "Lisa Leite");
            cliente2.TransferirDinheiro(1200, "Lisa Leite");
            Console.ReadLine();
            cliente2.TransferirDinheiro(700, "Bob Nelson");
            cliente2.VerificarSaldo();
            Console.ReadLine();



            ContaCorrente cliente3 = new ContaCorrente("Lisa Leite", 654321, 0);
            cliente3.DepositarDinheiro(2000);
            Console.ReadLine();
            cliente3.SacarDinheiro(250);
            Console.ReadLine();
            cliente3.TransferirDinheiro(400, "Testolfo Rocha");
            cliente3.DinheiroTransferido(1500, "Bob Nelson");
            Console.ReadLine();
            cliente3.DepositarDinheiro(100);
            cliente3.VerificarSaldo();
            Console.ReadLine();
        }
    }
}