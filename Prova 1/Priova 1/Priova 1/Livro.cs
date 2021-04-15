using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priova_1
{
    class Livro : ItemLoja, iItemRelatorio
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public Genero Genero { get; set; }
        public Livro(long iD, float precoCompra, float precoVenda, int quantidadeEstoque, PessoaJuridica fornecedor, string titulo, string autor, string editora, Genero genero) 
            : base(iD, precoCompra, precoVenda, quantidadeEstoque, fornecedor)
        {
            ID = iD;
            Titulo = titulo;
            Editora = editora;
            Autor = autor;
            PrecoCompra = precoCompra;
            PrecoVenda = precoVenda;
            QuantidadeEstoque = quantidadeEstoque;
            Fornecedor = fornecedor;
            Genero = genero;

        }
        public override void MostrarDescrição()
        {
            Console.WriteLine($"Titulo do livro:{Titulo}");
            Console.WriteLine($"Genero :{Genero}");
            Console.WriteLine($"Nome do autor:{Autor}");
            Console.WriteLine($"Nome da editora:{Editora}");
            Console.WriteLine($"Id do Livro:{ID}");
            Console.WriteLine($"Preço de compra:{PrecoCompra:c}");
            Console.WriteLine($"Preço de Venda:{PrecoVenda:c}");
            Console.WriteLine($"Nome do Fornecedor:{Fornecedor.nome}");
            Console.WriteLine("------------------------");
            MostrarQuantidadeEstoque();
        }
        public override void MostrarQuantidadeEstoque()
        {

        }
        public void DiminuirEstoque(int Qnt)
        {
            QuantidadeEstoque -= Qnt;
            if(QuantidadeEstoque <= 0)
            {
                QuantidadeEstoque = 0;
            }
        }
    }
    
    enum Genero
    {
        ficcao = 1,
        informatica,
        games,
        negocios
    }
}
