using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priova_1
{
    class Caderno : ItemLoja,iItemRelatorio
    {
        public int QuantidadeDeFolhas { get; set; }
        public string Nome { get; set; }
        public Caderno(long iD, float precoCompra, float precoVenda, int quantidadeEstoque, PessoaJuridica fornecedor, int quantidadeDeFolhas, string nome) 
            : base(iD, precoCompra, precoVenda, quantidadeEstoque, fornecedor)
        {

            QuantidadeDeFolhas = quantidadeDeFolhas;
            Nome = nome;
            Fornecedor = fornecedor;

        }
        public override void MostrarDescrição()
        {
            Console.WriteLine($"Nome do caderno:{Nome}");
            Console.WriteLine($"Quantidade de folhas:{QuantidadeDeFolhas}");
            Console.WriteLine($"Id do caderno:{ID}");
            Console.WriteLine($"Preço de compra:{PrecoCompra:c}");
            Console.WriteLine($"Preço de Venda:{PrecoVenda:c}");
            Console.WriteLine($"Nome do Fornecedor:{Fornecedor.nome}");
            Console.WriteLine("------------------------");
            MostrarQuantidadeEstoque();

        }

        public override void MostrarQuantidadeEstoque()
        {
            Console.WriteLine($"Quantidade em estoque:{QuantidadeEstoque}");
        }

        public override void DiminuirEstoque(int Qnt)
        {
            QuantidadeEstoque -= Qnt;
            if (QuantidadeEstoque <= 0)
            {
                QuantidadeEstoque = 0;
            }
        }
    }
}
