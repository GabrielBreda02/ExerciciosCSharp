using System;

class Program
{
    static void Main()
    {
        var historico = new ListaEncadeada<string>();
        int opcao;

        do
        {
            Console.WriteLine("\n--- Histórico de Navegação ---");
            Console.WriteLine("1. Adicionar página visitada (final)");
            Console.WriteLine("2. Verificar se página está no histórico");
            Console.WriteLine("3. Remover página");
            Console.WriteLine("4. Encontrar posição de uma página");
            Console.WriteLine("5. Exibir histórico");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("URL da página: ");
                    string url = Console.ReadLine();
                    historico.Adicionar(url);
                    Console.WriteLine("Página adicionada.");
                    break;
                case 2:
                    Console.Write("URL para verificar: ");
                    url = Console.ReadLine();
                    Console.WriteLine(historico.Contem(url) ? "Está no histórico." : "Não está no histórico.");
                    break;
                case 3:
                    Console.Write("URL para remover: ");
                    url = Console.ReadLine();
                    if (historico.Remover(url))
                        Console.WriteLine("Removida.");
                    else
                        Console.WriteLine("Página não encontrada.");
                    break;
                case 4:
                    Console.Write("URL para buscar posição: ");
                    url = Console.ReadLine();
                    int pos = historico.PosicaoDe(url);
                    if (pos >= 0)
                        Console.WriteLine($"Posição: {pos}");
                    else
                        Console.WriteLine("Página não encontrada.");
                    break;
                case 5:
                    Console.WriteLine("Histórico (do início ao fim):");
                    historico.Imprimir();
                    break;
            }
        } while (opcao != 0);
    }
}