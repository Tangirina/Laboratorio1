using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priova_1
{
    abstract class ItemLoja : iItemRelatorio
    {
        public List<ItemLoja> Produtos { get; set; }
        public long ID { get;  set; }
        public float PrecoCompra { get; set; }
        public float PrecoVenda { get; set; }
        public int QuantidadeEstoque { get; set; }
        public PessoaJuridica Fornecedor { get;set; }

        public ItemLoja(long iD, float precoCompra, float precoVenda, int quantidadeEstoque, PessoaJuridica fornecedor)
        {
            ID = iD;
            PrecoCompra = precoCompra;
            PrecoVenda = precoVenda;
            QuantidadeEstoque = quantidadeEstoque;
            Fornecedor = fornecedor;
        }

        public virtual void MostrarDescrição()
        {
            
        }
                  
       public virtual void MostrarQuantidadeEstoque()
        {

        }
       public virtual void DiminuirEstoque(int Qnt)
        {

        }
       public virtual void AumentarEstoque(int Qnt)
        {

        }


    }
}


