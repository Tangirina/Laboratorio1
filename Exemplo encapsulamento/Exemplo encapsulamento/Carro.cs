using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_encapsulamento
{
    class Carro
    {
        string modelo;
        string cor;
        int anoFabricação;
        int velocidadeAtual = 0;
        int velocidadeMaxima;
        bool seLigado = false;

        public string Modelo { get => modelo; }
        public string Cor { get => cor; }
        public int AnoFabricação { get => anoFabricação; }
        public int VelocidadeAtual { get => VelocidadeAtual; }
        public int VelocidadeMaxima { get => VelocidadeMaxima; }
        public bool SeLigado { get => seLigado; }

        public void Ligar()
        {
            if (seLigado)
                Console.WriteLine("O carro ja está ligado!");
            else
            {
                this.seLigado = true;
                Console.WriteLine("O carrro ja foi ligado!");
            }

        }
        public void Desligar()
        {
            if (seLigado)
            {
                Console.WriteLine("O carro foi desligado!");
                seLigado = false;
            }
            else
                Console.WriteLine("O carro ja está desligado");
        }

        public void Acelerar()
        {
            if (seLigado) { 
            if ((this.velocidadeAtual + 10) <= this.VelocidadeMaxima)
            {
                this.velocidadeAtual += 10;
            }
            else
            {
                this.velocidadeAtual = this.velocidadeMaxima;
               } 
            }
        }

        public void Frear()
        {
            if ((this.velocidadeAtual - 10) >= 0)
            {
                this.velocidadeAtual -= 10;
            }
            else
            {
                this.velocidadeAtual = 0;
            }


        }

    }
}
