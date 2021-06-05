using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_2
{
    class Arvore
    {
        public Nodo Raiz { get; set; }

        public void AdicionarNodosNaArvore(int dado)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo(dado);
                return;
            }
            Nodo auxiliar;
            auxiliar = Raiz;
            bool SeAlocou = false;

            while (!SeAlocou)
            {
                if (dado < auxiliar.Dado)
                {
                    if (auxiliar.Esquerda == null)
                    {
                        auxiliar.Esquerda = new Nodo(dado);
                        SeAlocou = true;
                    }
                    else
                    {
                        auxiliar = auxiliar.Esquerda;
                    }
                }
                else if (dado > auxiliar.Dado)
                {
                    if (auxiliar.Direita == null)
                    {
                        auxiliar.Direita = new Nodo(dado);
                        SeAlocou = true;
                    }
                    else
                    {
                        auxiliar = auxiliar.Direita;
                    }

                }
            }
        }

        public void AdicionarListaNaArvore(List<int> lista)
        {
            foreach (var item in lista)
            {
                AdicionarNodosNaArvore(item);
            }
        }

        public void ImprimirArvoreIn(Nodo nodoPai)
        {

            if (nodoPai != null)
            {
                ImprimirArvoreIn(nodoPai.Esquerda);
                Console.Write($"{nodoPai.Dado}");
                ImprimirArvoreIn(nodoPai.Direita);
            }
            else
            {
                return;
            }
        }
        public virtual int VerificarNo(Nodo nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            else
            {
                return (VerificarNo(nodo.Esquerda) + 1 + VerificarNo(nodo.Direita));
            }
        }

        public static int Maximo(Nodo nodo)
        {
            if (nodo == null)
            {
                return int.MinValue;
            }

            int res = nodo.Dado;
            int lres = Maximo(nodo.Esquerda);
            int rres = Maximo(nodo.Direita);

            if (lres > res)
            {
                res = lres;
            }
            if (rres > res)
            {
                res = rres;
            }
            return res;
        }

        public static int Soma(Nodo nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            return (Soma(nodo.Esquerda) + Soma(nodo.Direita));
        }
    }
}