using System;
using System.Collections.Generic;

namespace Lista_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arvore arvoreDeTestes = new Arvore();

            List<int> listaNumeros = new List<int>(12);
            listaNumeros.Add(59);
            listaNumeros.Add(38);
            listaNumeros.Add(35);
            listaNumeros.Add(1);
            listaNumeros.Add(48);
            listaNumeros.Add(51);
            listaNumeros.Add(121);
            listaNumeros.Add(103);
            listaNumeros.Add(79);
            listaNumeros.Add(223);
            listaNumeros.Add(161);
            listaNumeros.Add(235);

            arvoreDeTestes.AdicionarListaNaArvore(listaNumeros);
        }

    }
}