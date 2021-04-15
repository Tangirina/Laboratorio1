using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priova_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            

            Cadastro Cadastro = new Cadastro();
            Estado RJ = new Estado("Rio de Janeiro","Rj");
            Estado DF = new Estado("Distrito Federal", "DF");
            Estado MG = new Estado("Minas Gerais","MG");
            Estado GO = new Estado("Goiás","GO");

            Cidade RJCidade = new Cidade("Rio De Janeiro", RJ);
            Cidade DFCidade = new Cidade("Distrito Federal", DF);
            Cidade MGCidade = new Cidade("Minas Gerais",MG);
            Cidade GOCidade = new Cidade("Goiás", GO);

            Bairro Copacabana = new Bairro("Copacabana");
            Bairro JardimDasOliveiras = new Bairro("Jardim Das Oliveiras");
            Bairro Operarios = new Bairro("Bairro Operarios");
            Bairro MongesUnidos = new Bairro("Bairro Monges Unidos");            

            Endereco EnderecoLivrosAssociados = new Endereco(45,"Domingos Ferreira",Copacabana,RJCidade);
            Endereco EnderecoBN = new Endereco(23, "Rua das Classes", JardimDasOliveiras, DFCidade);
            Endereco EnderecoTR = new Endereco(4, "Avenida Abstrata", Operarios, GOCidade);
            Endereco EnderecoBT = new Endereco(26, "Vale das Heranças", MongesUnidos, MGCidade);


            PessoaJuridica LivrosAssociados = new PessoaJuridica(300, EnderecoLivrosAssociados, "Livros Associados SA", "faleconosco@associados.com", "99.8888.7777-77");
            PessoaFisica BobNelson = new PessoaFisica(100,EnderecoLivrosAssociados , "Bob Nelson", "bobNelson@gmail.com", "111.222.333-99", false);
            PessoaFisica TestolfoRocha = new PessoaFisica(200, EnderecoLivrosAssociados, "Testolfo Rocha", "testolfoRocha26@gmail.com", "444.555.666-11", true);
            PessoaFisica BeloTeste = new PessoaFisica(100, EnderecoLivrosAssociados, "Belo Teste", "Testebelo@gmail.com", "999.888.777-72", true);

            Cadastro.Clientes.Add(BobNelson);
            Cadastro.Clientes.Add(TestolfoRocha);
            Cadastro.Clientes.Add(BeloTeste);
            Cadastro.Fornecedores.Add(LivrosAssociados);


            Livro DomCasmurro = new Livro(100, 19.99f, 31.99f, 10, LivrosAssociados, "DomCasmurro", "Machado de Assis", "Universal", Genero.ficcao);
            Livro Unity = new Livro(150, 24.35f, 58.99f, 10, LivrosAssociados, "Unity", "William Pereira Alves", "Universal", Genero.games);
            Caderno Caderno100 = new Caderno(170, 10.99f, 25.99f, 25, LivrosAssociados, 100, "Caderno Capa Dura - Jaspion");

            Cadastro.Livros.Add(DomCasmurro);
            Cadastro.Livros.Add(Unity);
            Cadastro.Cadernos.Add(Caderno100);

            Console.WriteLine("\n Clientes cadastrados:\n");
            Cadastro.RelacionarClientes();
            

            Console.WriteLine("\n Fornecedores Cadastrados: \n");
            Cadastro.RelacionarFornecedores();

            Console.WriteLine("Enter para avançar");
            Console.ReadLine();
            Console.Clear();
            MenuInicial();

            void MenuInicial()
            {

                Console.WriteLine("\n Qual opção deseja selecionar? Digite o numero de acordo com o que deseja fazer \n");
                Console.WriteLine("\n 1- Opções de livros e cadernos de acordo com a ID \n");
                Console.WriteLine("\n 2- Adicionar Cliente: \n");
                Console.WriteLine("\n 3- Remover Cliente: \n");
                Console.WriteLine("\n 4- Adicionar Fornecedor:\n");
                Console.WriteLine("\n 5- Remover Fornecedor\n");
                Console.WriteLine("\n 6- Adicionar Livro:\n");
                Console.WriteLine("\n 7- Remover Livro:\n");
                Console.WriteLine("\n 8- Comprar / Vender Livros:\n");
                Console.WriteLine("\n 9- Vender / Comprar Cadernos:\n");
                Console.WriteLine("\n 10- Mostrar todos os livros:\n");
                Console.WriteLine("\n 11- Mostrar todos os cadernos:\n");

                Console.WriteLine("\n------------------------\n");
                int EscolheOpcao = int.Parse(Console.ReadLine());
                Console.WriteLine("\n------------------------\n");
                switch (EscolheOpcao)
                {
                    case 1:
                        Console.WriteLine("ID Do produto.");
                        int id = int.Parse(Console.ReadLine());
                        Cadastro.RelacionarLivro(id);
                        Cadastro.RelacionarCaderno(id);
                        Console.ReadLine();
                        Console.Clear();
                        MenuInicial();
                        break;
                    case 2:
                        Cadastro.AdicionarCliente();

                        Console.WriteLine("[Enter para avançar]");
                        Console.ReadLine();
                        Console.Clear();
                        MenuInicial();
                        break;
                    case 3:
                        Console.WriteLine("ID Do Cliente.");
                        int idCliente = int.Parse(Console.ReadLine());
                        Cadastro.RemoverCliente(idCliente);

                        Console.WriteLine("[Enter para avançar]");
                        Console.ReadLine();
                        Console.Clear();
                        MenuInicial();
                        break;
                    case 4:
                        Cadastro.AdicionarFornecedor();

                        Console.WriteLine("[Enter para avançar]");
                        Console.ReadLine();
                        Console.Clear();
                        MenuInicial();
                        break;
                    case 5:
                        Console.WriteLine("ID Do Fornecedor.");
                        int idFornecedor = int.Parse(Console.ReadLine());
                        Cadastro.RemoverFornecedor(idFornecedor);

                        Console.WriteLine("[Enter para avançar]");
                        Console.ReadLine();
                        Console.Clear();
                        MenuInicial();
                        break;
                    case 6:
                        Cadastro.AdicionarLivro();

                        Console.WriteLine("[Enter para avançar]");
                        Console.ReadLine();
                        Console.Clear();
                        MenuInicial();
                        break;
                    case 7:
                        Console.WriteLine("ID Do Livro.");
                        int idLivro = int.Parse(Console.ReadLine());
                        Cadastro.RemoverLivro(idLivro);

                        Console.WriteLine("[Enter para avançar]");
                        Console.ReadLine();
                        Console.Clear();
                        MenuInicial();
                        break;
                    case 8:
                        Console.Clear();
                        Cadastro.VendaOuCompraLivros();
                        MenuInicial();
                        break;
                    case 9:
                        Console.Clear();
                        Cadastro.VendaOuCompraCadernos();
                        MenuInicial();
                        break;
                    case 10:
                        Cadastro.MostrarLivros();
                        Console.Clear();
                        MenuInicial();
                        break;
                    case 11:
                        Cadastro.MostrarCadernos();
                        Console.Clear();
                        MenuInicial();
                        break;
                    default:
                        break;

                }
                Console.ReadLine();
            }
        }
    }
}
