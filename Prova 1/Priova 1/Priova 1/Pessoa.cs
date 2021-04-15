using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priova_1
{
    abstract class Pessoa
    {
        public long id;
        public Endereco endereco;
        public string nome;
        public string email;

        protected Pessoa(long id, Endereco endereco, string nome, string email)
        {
            this.id = id;
            this.endereco = endereco;
            this.nome = nome;
            this.email = email;
        }
    }
}
