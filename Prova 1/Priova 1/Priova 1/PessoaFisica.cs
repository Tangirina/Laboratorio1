using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priova_1
{
    class PessoaFisica : Pessoa
    {
        
        public string cpf { get; set; }
        public bool vip { get; set; }
        public PessoaFisica(long id, Endereco endereco, string nome, string email, string cpf, bool vip) : base(id, endereco, nome, email)
        {
            this.vip = vip;
            this.cpf = cpf;
        }

    }
}
