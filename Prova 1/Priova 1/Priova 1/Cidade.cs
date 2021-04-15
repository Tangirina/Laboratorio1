using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priova_1
{
    class Cidade
    {
        public string Nome;
        public Estado Estado;
        

        public Cidade(string cidadeNome, Estado estado)
        {
            Estado = estado;
        }
    }
}
