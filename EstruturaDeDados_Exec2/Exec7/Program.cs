using System;

class Program
{
    static void Main()
    {
        var estoque = new ListaEncadeada<string>();
        int opcao;

        do
        {
            Console.WriteLine("\n--- Controle de Estoque ---");
            Console.WriteLine("1. Adicionar produto em posição específica");
            Console.WriteLine("2. Verificar se produto está disponível");
            Console.WriteLine("3. Remover produto vendido");
            Console.WriteLine("4. Encontrar posição de um produto");
            Console.WriteLine("5. Listar produtos");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Nome do produto: ");
                    string produto = Console.ReadLine();
                    Console.Write("Posição (0‑based): ");
                    int pos = int.Parse(Console.ReadLine());
                    if (estoque.Adicionar(pos, produto))
                        Console.WriteLine("Adicionado com sucesso.");
                    else
                        Console.WriteLine("Posição inválida.");
                    break;
                case 2:
                    Console.Write("Produto a verificar: ");
                    produto = Console.ReadLine();
                    Console.WriteLine(estoque.Contem(produto) ? "Disponível." : "Fora de estoque.");
                    break;
                case 3:
                    Console.Write("Produto vendido: ");
                    produto = Console.ReadLine();
                    if (estoque.Remover(produto))
                        Console.WriteLine("Removido do estoque.");
                    else
                        Console.WriteLine("Produto não encontrado.");
                    break;
                case 4:
                    Console.Write("Produto para buscar: ");
                    produto = Console.ReadLine();
                    int idx = estoque.PosicaoDe(produto);
                    if (idx >= 0)
                        Console.WriteLine($"Posição: {idx}");
                    else
                        Console.WriteLine("Não encontrado.");
                    break;
                case 5:
                    estoque.Imprimir();
                    break;
            }
        } while (opcao != 0);
    }
}