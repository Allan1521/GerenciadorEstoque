using System;
using System.Collections.Generic;



namespace GerenciadorEstoque
{
    // Classe Produto que representa os itens do estoque
    class Produto
    {
        public string Nome { get; set; } // Nome do produto
        public int Quantidade { get; set; } // Quantidade em estoque
        public double Preco { get; set; } // Preço do produto



        // Método para exibir as informações do produto
        public void ExibirProduto()
        {
            Console.WriteLine($"Nome: {Nome}, Quantidade: {Quantidade}, Preço: {Preco}");
        }
    }



    // Classe Program que contém o método principal
    class Program
    {
        static void Main(string[] args)
        {
            // Lista para armazenar os produtos
            List<Produto> produtos = new List<Produto>();



            // Loop do menu
            while (true)
            {
                // Exibe o menu principal
                Console.WriteLine("\n--- Gerenciador de Estoque ---");
                Console.WriteLine("1. Cadastrar Produto: ");
                Console.WriteLine("2. Mostrar Estoque:");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");



                // Lê a opção do usuário
                string opcao = Console.ReadLine();



                if (opcao == "1") // Cadastrar Produto
                {
                    // Criação de um novo produto
                    Produto novoProduto = new Produto();



                    // Entrada de dados
                    Console.Write("Digite o nome do produto: ");
                    novoProduto.Nome = Console.ReadLine();



                    Console.Write("Digite a quantidade: ");
                    novoProduto.Quantidade = int.Parse(Console.ReadLine());



                    Console.Write("Digite o preço: ");
                    novoProduto.Preco = double.Parse(Console.ReadLine());



                    // Adiciona o novo produto à lista
                    produtos.Add(novoProduto);



                    Console.WriteLine("\nProduto cadastrado com sucesso!");
                }
                else if (opcao == "2") // Mostrar Estoque
                {
                    Console.WriteLine("\n--- Estoque Atual ---");



                    if (produtos.Count == 0)
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
                    }
                    else
                    {
                        // Exibe os produtos cadastrados
                        foreach (Produto produto in produtos)
                        {
                            produto.ExibirProduto();
                        }
                    }
                }
                else if (opcao == "3") // Sair do sistema
                {
                    Console.WriteLine("Saindo do sistema...");
                    break;
                }
                else
                {
                    // Opção inválida
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }
            }
        }
    }
}




