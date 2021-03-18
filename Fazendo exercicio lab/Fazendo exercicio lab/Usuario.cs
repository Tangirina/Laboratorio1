using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazendo_exercicio_lab
{
    class Usuario
    {
        public string nome;
        public int idade;
        public float peso;
        public float altura;

        public Usuario(string nome, int idade, float peso, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
        }
        private float calcularIMC()
        {
            return this.peso / (this.altura * this.altura);
        }
        public string InformarSituacaoIMC()
        {
            string situaçaoIMC = "Erro na indentificação da situação";
            float imc = calcularIMC();

            if (imc >= 18.5f & imc <= 24.9f)
                situaçaoIMC = "Parabens seu peso esta normal";
            if (imc >= 25.0f & imc <= 89.9f)
                situaçaoIMC = "Acima do peso";
            if (imc >= 30.0f & imc <= 34.9f)
                situaçaoIMC = "Obesidade grau 1";
            if (imc >= 35.0f & imc <= 39.9f)
                situaçaoIMC = "Obesidade grau 2";
            if (imc >= 40.0f)
                situaçaoIMC = "Obesidade grau 3 e 4";
            return situaçaoIMC;
        }
        public float InformarMetaPeso()
        { 
    float imcIdeal = 24.9f;
    return imcIdeal * (this.altura) * (this.altura);
        }
    }
}
