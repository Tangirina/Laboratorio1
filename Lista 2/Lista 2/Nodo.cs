using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_2
{
    class Nodo
    {
        public Nodo(int dado)
        {
            Dado = dado;
        }

        public Nodo Esquerda { get; set; }
        public Nodo Direita { get; set; }
        public int Dado { get; set; }
    }
}
