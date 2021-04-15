using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priova_1
{
    interface iItemRelatorio
    {
         void MostrarDescrição();
         void MostrarQuantidadeEstoque();
         void DiminuirEstoque(int Qnt);
         void AumentarEstoque(int Qnt);
    }
}
