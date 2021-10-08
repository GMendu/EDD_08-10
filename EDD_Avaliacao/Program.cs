using System;
using System.Collections.Generic;

//Crie um programa para fazer o controle de vendas de uma loja, ele deverá registrar dados de clientes, produtos e negociações de vendas. O programa deverá armazenar "n" dados e deverá ser construído atendendo às seguintes especificações:
//1.Deverá apresentar um menu principal, nele o usuário poderá acessar as funcionalidades relacionadas a clientes, produtos e vendas;

//2.O programa deverá possuir um menu para acesso das operações relacionadas a clientes;
//•	O programa deverá armazenar os dados de “n” clientes;
//•	Deverá permitir que apenas um cliente seja cadastrado por vez;
//•	O programa deverá listar todos os clientes cadastradas de uma só vez;
//•	Será necessário registrar o nome, CPF, e-mail, DDD, Telefone, observações e endereço de cada cliente;
//•	O menu de clientes deverá ainda informar a quantidade de pessoas que foram registradas;
//•	Entre as opções do menu de cliente deverá haver uma opção onde um nome seja localizado e os seus dados sejam exibidos (se houverem nomes iguais estes deverão ser exibidos também);

//3.O programa deverá possuir um menu para acesso das operações relacionadas a produtos;
//•	O programa deverá armazenar os dados de “n” produtos;
//•	Deverá permitir que apenas um produto seja cadastrado por vez;
//•	O programa deverá listar todos os produtos cadastradas de uma só vez;
//•	Será necessário registrar o nome, a quantidade, valor unitário e observações de cada produto;
//•	O menu de produto deverá ainda informar a quantidade de produtos que foram registradas;
//•	Entre as opções do menu de produtos deverá haver uma opção onde um nome do produto seja localizado e os seus dados sejam exibidos.

//4.	O programa deverá possuir um menu para acesso das operações relacionadas a vendas;
//•	Deverá armazenar os dados de “n” vendas;
//•	O programa deverá permitir que apenas a venda de um produto seja feita por vez;
//•	O programa deverá listar todas vendas cadastradas de uma só vez;
//•	Será necessário registrar a identificação do produto, a quantidade que será vendida, valor unitário no ato da compra, identificação do comprador e observações relacionadas a venda;
//•	O menu destinado a venda deverá ainda informar a quantidade de vendas que foram registradas;
//•	É desejável que entre as opções do menu de vendas exista uma ou mais opções para a localização de vendas para um determinado cliente;

//5.Restrições:
//●	O programa não deve permitir vendas de produtos quando a quantidade presente na operação for superior a quantidade existente no estoque;
//●	É desejável que o programa não permita produtos com a mesma identificação na relação de produtos;
//●	Não deverá ser permitido a venda de produtos que não existam;
//●	Não deve ser permitido o cadastro de clientes com o mesmo CPF's; 
//●	Não deverá ser permitida a exclusão do registro de clientes que tenham feito compras;
//●	Não deverá ser permitida a exclusão do registro de produtos que já estejam presentes em operações de venda;


namespace EDD_Avaliacao
{
    public struct clientes
    {
        public string nome;
        public string ddd;
        public string telefone;
        public string email;
        public string cpf;
        public string endereco;
        public string observ;
    }
    public struct produtos //nome; quant; valorUnit; observ;
    {
        public string nome;        
        public string quant;
        public string valorUnit;
        public string observ;
    }

    public struct vendas // produto; quant; valorUnit; comprador; observ;
    {
        public string produto;
        public string quant;
        public string valorUnit;
        public string comprador;
        public string observ;
    }

    class Program
    {

        static int Menu()
        {
            Console.WriteLine($"\nMenu" +
                "\ndigite 1 para Clientes" +
                "\ndigite 2 para Produto" +
                "\ndigite 3 para Venda" +
                "\ndigite 4 para finalizar");
            return int.Parse(Console.ReadLine());
        }
        static int MenuCliente()
        {
            Console.WriteLine($"\nMenu de clientes" +
                "\ndigite 1 para cadastrar" +
                "\ndigite 2 para listar" +
                "\ndigite 3 para procurar" +
                "\ndigite 4 para voltar");
            return int.Parse(Console.ReadLine());
        }

        static int MenuProduto()
        {
            Console.WriteLine($"\nMenu de produtos" +
                "\ndigite 1 para cadastrar" +
                "\ndigite 2 para listar" +
                "\ndigite 3 para procurar" +
                "\ndigite 4 para voltar");
            return int.Parse(Console.ReadLine());
        }

        static int MenuVenda()
        {
            Console.WriteLine($"\nMenu de vendas" +
                "\ndigite 1 para cadastrar" +
                "\ndigite 2 para listar" +
                "\ndigite 3 para procurar" +
                "\ndigite 4 para voltar");
            return int.Parse(Console.ReadLine());
        }

        static clientes CadastrarCliente(int quant)
        {
            clientes entrada = new clientes();
            Console.WriteLine($"Cadastro da pessoa nº{quant}");
            Console.WriteLine("Nome: ");
            entrada.nome = Console.ReadLine();
            Console.WriteLine("DDD: ");
            entrada.ddd = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            entrada.telefone = Console.ReadLine();
            Console.WriteLine("Email: ");
            entrada.email = Console.ReadLine();
            Console.WriteLine("CPF: ");
            entrada.cpf = Console.ReadLine();
            Console.WriteLine("Endereco: ");
            entrada.endereco = Console.ReadLine();
            Console.WriteLine("Observação: ");
            entrada.observ = Console.ReadLine();

            return entrada;
        }

        static produtos CadastrarProduto(int quant) //nome; quant; valorUnit; observ;
        {
            produtos entrada = new produtos();
            Console.WriteLine($"Cadastro de produto nº{quant}");
            Console.WriteLine("Nome: ");
            entrada.nome = Console.ReadLine();
            Console.WriteLine("Quantidade: ");
            entrada.quant = Console.ReadLine();
            Console.WriteLine("valor unitário: ");
            entrada.valorUnit = Console.ReadLine();
            Console.WriteLine("Observação: ");
            entrada.observ = Console.ReadLine();

            return entrada;
        }

        static vendas CadastrarVenda(int quant) // produto; quant; valorUnit; comprador; observ; //nome; quant; valorUnit; observ;
        {
            vendas entrada = new vendas();
            Console.WriteLine($"Cadastro de produto nº{quant}");
            Console.WriteLine("Nome do produto: ");
            entrada.produto = Console.ReadLine();
            Console.WriteLine("Quantidade: ");
            entrada.quant = Console.ReadLine();
            Console.WriteLine("valor unitário: ");
            entrada.valorUnit = Console.ReadLine();
            Console.WriteLine("Comprador: ");
            entrada.comprador = Console.ReadLine();
            Console.WriteLine("Observação: ");
            entrada.observ = Console.ReadLine();
            return entrada;
        }

        static void Main(string[] args)
        {
            int opcaoM = 5;
            int opcaoC = 5;
            int opcaoP = 5;
            int opcaoV = 5;
            List<clientes> ListClientes = new List<clientes>();
            List<produtos> ListProdutos = new List<produtos>();
            List<vendas> ListVendas = new List<vendas>();
            do
            {
                switch (opcaoM)
                {
                    case 1: //Cliente
                        {
                            do
                            {
                                switch (opcaoC)
                                {
                                    case 1:
                                        {
                                            ListClientes.Add(CadastrarCliente(ListClientes.Count + 1));
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.WriteLine($"Um total de {ListClientes.Count} pessoas foram armazenadas");
                                            foreach (clientes d in ListClientes)
                                            {
                                                Console.WriteLine($"|| Nome: {d.nome}|| Telefone: ({d.ddd}){d.telefone}|| Email: {d.email}|| Cpf: {d.cpf}|| Endereco: {d.endereco}; {d.observ}||");
                                            }
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.WriteLine("Digite o nome que deseja procurar");
                                            string procurar = Console.ReadLine();
                                            foreach (clientes d in ListClientes)
                                            {
                                                if (d.nome == procurar)
                                                {
                                                    Console.WriteLine($"|| Nome: {d.nome}|| Telefone: ({d.ddd}){d.telefone}|| Email: {d.email}|| Cpf: {d.cpf}|| Endereco: {d.endereco}; {d.observ}||");
                                                }
                                            }
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                opcaoC = MenuCliente();
                            } while (opcaoC != 4);
                            break;
                        }
                    case 2: //Produto
                        {
                            do
                            {
                                switch (opcaoP) //nome; quant; valorUnit; observ;
                                {
                                    case 1:
                                        {
                                            ListProdutos.Add(CadastrarProduto(ListProdutos.Count + 1));
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.WriteLine($"Um total de {ListProdutos.Count} produtos foram armazenadas");
                                            foreach (produtos d in ListProdutos)
                                            {
                                                Console.WriteLine($"|| Nome: {d.nome}|| Quantidade: {d.quant}|| valor unitário: {d.valorUnit}|| observação: {d.observ}||");
                                            }
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.WriteLine("Digite o nome do produto que deseja procurar");
                                            string procurar = Console.ReadLine();
                                            foreach (produtos d in ListProdutos)
                                            {
                                                if (d.nome == procurar)
                                                {
                                                    Console.WriteLine($"|| Nome: {d.nome}|| Quantidade: {d.quant}|| valor unitário: {d.valorUnit}|| observação: {d.observ}||");
                                                }
                                            }
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                opcaoP = MenuProduto();
                            } while (opcaoP != 4);
                            break;
                        }
                    case 3: //Venda
                        {
                            do
                            {
                                switch (opcaoV) // produto; quant; valorUnit; comprador; observ; 
                                {
                                    case 1:
                                        {
                                            ListVendas.Add(CadastrarVenda(ListVendas.Count + 1));
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.WriteLine($"Um total de {ListVendas.Count} vendas foram armazenadas");
                                            foreach (vendas d in ListVendas)
                                            {
                                                Console.WriteLine($"|| Nome: {d.produto}|| Quantidade: {d.quant}|| valor unitário: {d.valorUnit}|| comprador: {d.comprador}|| observação: {d.observ}||");
                                            }
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.WriteLine("Digite o nome do produto vendido que deseja procurar");
                                            string procurar = Console.ReadLine();
                                            foreach (vendas d in ListVendas)
                                            {
                                                if (d.produto == procurar)
                                                {
                                                    Console.WriteLine($"|| Nome: {d.produto}|| Quantidade: {d.quant}|| valor unitário: {d.valorUnit}|| comprador: {d.comprador}|| observação: {d.observ}||");
                                                }
                                            }
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                opcaoV = MenuVenda();
                            } while (opcaoV != 4);
                            break;
                        }
                    default:
                        break;
                }
                opcaoM = Menu();
            } while (opcaoM != 4);
        }
    }
}
