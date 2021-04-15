using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priova_1
{
    class Cadastro
    {
        public List<PessoaFisica> Clientes { get; set; }
        public List<PessoaJuridica> Fornecedores { get; set; }
        public List<Livro> Livros { get; set; }
        public List<Caderno> Cadernos { get; set; }
        public Cadastro()
        {
            Clientes = new List<PessoaFisica>();
            Fornecedores = new List<PessoaJuridica>();
            Livros = new List<Livro>();
            Cadernos = new List<Caderno>();
        }

        public void RelacionarClientes()
        {
            foreach (PessoaFisica item in Clientes)
            {

                Console.WriteLine($"Nome: {item.nome}");
                Console.WriteLine($"cpf: {item.cpf}");
                Console.WriteLine($"ID: {item.id}");
                Console.WriteLine($"email: {item.id}");
                Console.WriteLine($"VIP: {item.vip}");
                Console.WriteLine("------------------------");


            }
        }
        public void RelacionarFornecedores()
        {
            foreach (PessoaJuridica item in Fornecedores)
            {

                Console.WriteLine($"Nome: {item.nome}");
                Console.WriteLine($"cnpj: {item.cnpj}");
                Console.WriteLine($"email: {item.email}");
                Console.WriteLine($"id: {item.id}");
                Console.WriteLine("------------------------");

            }
        }


        public void RelacionarLivro(int id)
        {
            foreach (Livro item in Livros)
            {
                if (item.ID == id)
                {
                    item.MostrarDescrição();
                    Console.WriteLine("-------------------------------");
                    return;
                }
            }

        }
        public void RelacionarCaderno(int id)
        {
            foreach (Caderno item in Cadernos)
            {
                if (item.ID == id)
                {
                    item.MostrarDescrição();
                    Console.WriteLine("-------------------------------");
                    return;
                }
            }

        }

        public void AdicionarCliente()
        {
            Console.WriteLine("Id do cliente:");
            long id = long.Parse(Console.ReadLine());

            Console.WriteLine("Nome do cliente:");
            string nome = Console.ReadLine();

            Console.WriteLine("Email do cliente:");
            string email = Console.ReadLine();

            Console.WriteLine("Cpf do cliente:");
            string cpf = Console.ReadLine();

            Console.WriteLine("O cliente é vip? true/false ");
            bool vip = bool.Parse(Console.ReadLine());

            Console.WriteLine(" Nome do bairro do cliente:");
            string BairroNome = Console.ReadLine();

            Console.WriteLine("Esado do cliente:");
            string EstadoNome = Console.ReadLine();

            Console.WriteLine("Sigla do estado do cliente:");
            string EstadoSigla = Console.ReadLine();

            Console.WriteLine("Nome da cidade do do cliente:");
            string CidadeNome = Console.ReadLine();

            Console.WriteLine("Numero de endereço do cliente:");
            long EnderecoNumero = long.Parse(Console.ReadLine());

            Console.WriteLine("Rua do cliente:");
            string EnderecoRua = Console.ReadLine();

            Bairro bairro = new Bairro(BairroNome);
            Estado estado = new Estado(EstadoNome, EstadoSigla);
            Cidade cidade = new Cidade(CidadeNome, estado);
            Endereco endereco = new Endereco(EnderecoNumero, EnderecoRua, bairro, cidade);

            Clientes.Add(new PessoaFisica(id, endereco, nome, email, cpf, vip));
        }
        public void RemoverCliente(int id)
        {

            foreach (PessoaFisica item in Clientes)
            {
                if (item.id == id)
                {
                    Clientes.Remove(item);
                    return;
                }

            }
        }

        public void AdicionarFornecedor()
        {
            Console.WriteLine("Id do Fornecedor:");
            long id = long.Parse(Console.ReadLine());

            Console.WriteLine("Nome do Fornecedor:");
            string nome = Console.ReadLine();

            Console.WriteLine("Email do Fornecedor:");
            string email = Console.ReadLine();

            Console.WriteLine("Cnpj do Fornecedor:");
            string cnpj = Console.ReadLine();

            Console.WriteLine(" Nome do bairro do Fornecedor:");
            string BairroNome = Console.ReadLine();

            Console.WriteLine("Esado do Fornecedor:");
            string EstadoNome = Console.ReadLine();

            Console.WriteLine("Sigla do estado do Fornecedor:");
            string EstadoSigla = Console.ReadLine();

            Console.WriteLine("Nome da cidade do do Fornecedor:");
            string CidadeNome = Console.ReadLine();

            Console.WriteLine("Numero de endereço do Fornecedor:");
            long EnderecoNumero = long.Parse(Console.ReadLine());

            Console.WriteLine("Rua do Fornecedor:");
            string EnderecoRua = Console.ReadLine();

            Bairro bairro = new Bairro(BairroNome);
            Estado estado = new Estado(EstadoNome, EstadoSigla);
            Cidade cidade = new Cidade(CidadeNome, estado);
            Endereco endereco = new Endereco(EnderecoNumero, EnderecoRua, bairro, cidade);

            Fornecedores.Add(new PessoaJuridica(id, endereco, nome, email, cnpj));

        }
        public void RemoverFornecedor(int id)
        {
            foreach (PessoaJuridica item in Fornecedores)
            {
                if (item.id == id)
                {
                    Fornecedores.Remove(item);
                    return;
                }

            }
        }


        public void AdicionarLivro()
        {
            int iD = int.Parse(Console.ReadLine());

            PessoaJuridica fornecedor = Fornecedores[0];

            foreach (PessoaJuridica elemento in Fornecedores)
            {
                if (elemento.id == iD)
                {
                    fornecedor = elemento;
                }
            }
            Console.WriteLine("Titulo:");
            string titulo = Console.ReadLine();

            Console.WriteLine("Genero do Livro (0= Ficção; 1= Informatica; 2 = Games; 3 = Negocios;)");
            int Alegenero = 3;

            Console.WriteLine("Autor do livro:");
            string autor = Console.ReadLine();

            Console.WriteLine("Editora do Livro:");
            string editora = Console.ReadLine();

            Console.WriteLine("Id do livro:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Preço de compra:");
            float precoCompra = float.Parse(Console.ReadLine());

            Console.WriteLine("Preço de venda:");
            float precoVenda = float.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade em estoque:");
            int quantidadeEstoque = int.Parse(Console.ReadLine());


            Genero genero = Genero.ficcao;
            bool escolheu = false;
            while (!escolheu)
            {
                Alegenero = int.Parse(Console.ReadLine());
                switch (Alegenero)
                {
                    case 1:
                        escolheu = true;
                        break;
                    case 2:
                        genero = Genero.informatica;
                        escolheu = true;
                        break;
                    case 3:
                        genero = Genero.games;
                        escolheu = true;
                        break;
                    case 4:
                        genero = Genero.negocios;
                        escolheu = true;
                        break;
                    default:
                        Console.WriteLine("Impossivel encontrar o id , Por favor Tente novamente!");
                        break;


                }
            }
            Livros.Add(new Livro(1, precoCompra, precoVenda, quantidadeEstoque, fornecedor, titulo, autor, editora, genero));

        }
        public void RemoverLivro(int id)
        {
            foreach (Livro item in Livros)
            {
                if (item.ID == id)
                {
                    Livros.Remove(item);
                    return;
                }
            }



        }


        public void VendaOuCompraLivros()
        {
            bool vender = false;
            int quantidade = int.Parse(Console.ReadLine());
            long Id = long.Parse(Console.ReadLine());
            int opcao = 3;
            while (opcao < 1 || opcao > 2)
            {
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        vender = true;
                        break;
                    case 2:
                        break;
                    default:
                        Console.WriteLine("Digite novamente.");
                        break;
                }
            }
            if (vender == false)
                quantidade *= -1;

            foreach (Livro elemento in Livros)
            {
                if (elemento.ID == Id)
                {
                    elemento.DiminuirEstoque(quantidade);
                }
            }
        }
        public void VendaOuCompraCadernos()
        {
            {
                bool vender = false;
                int quantidade = int.Parse(Console.ReadLine());
                long Id = long.Parse(Console.ReadLine());
                int opcao = 3;
                while (opcao < 1 || opcao > 2)
                {
                    opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            vender = true;
                            break;
                        case 2:
                            break;
                        default:
                            Console.WriteLine("Digite novamente.");
                            break;
                    }
                }
                if (vender == false)
                    quantidade *= -1;

                foreach (Caderno elemento in Cadernos)
                {
                    if (elemento.ID == Id)
                    {
                        elemento.DiminuirEstoque(quantidade);
                    }
                }
            }
        }
        public void MostrarLivros()
        {
            foreach (Livro elemento in Livros)
            {
                elemento.MostrarDescrição();
            }
        }
        public void MostrarCadernos()
        {
            foreach (Caderno elemento in Cadernos)
            {
                elemento.MostrarDescrição();
            }
        }
    }
}
