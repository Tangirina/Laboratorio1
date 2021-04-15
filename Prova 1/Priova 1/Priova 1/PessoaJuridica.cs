using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priova_1
{
    class PessoaJuridica : Pessoa
    {
        public string cnpj { get; set; }
        public PessoaJuridica(long id, Endereco endereco, string nome, string email, string cnpj) : base(id, endereco, nome, email)
        {
            this.cnpj = cnpj;
        }
    }
}
