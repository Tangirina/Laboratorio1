using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priova_1
{
    class Endereco
    {
        public long Numero;
        public string Rua;
        public Bairro Bairro;
        public Cidade Cidade;

        public Endereco(long enderecoNumero, string enderecoRua, Bairro bairro, Cidade cidade)
        {
            Bairro = bairro;
            Cidade = cidade;
        }
    }
}
