using System;

class Program
{
    static void Main()
    {
        ListaDupla<string> estoque = new ListaDupla<string>();
        int op;
        do
        {
            Console.WriteLine("\n=== ESTOQUE ===");
            Console.WriteLine("1 - Adicionar produto");
            Console.WriteLine("2 - Inserir em posição");
            Console.WriteLine("3 - Verificar produto");
            Console.WriteLine("4 - Remover produto (vendido)");
            Console.WriteLine("5 - Posição do produto");
            Console.WriteLine("6 - Listar estoque");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Produto: ");
                    estoque.Adicionar(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Posição: ");
                    int p = int.Parse(Console.ReadLine());
                    Console.Write("Produto: ");
                    estoque.Inserir(p, Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Produto: ");
                    Console.WriteLine(estoque.Contem(Console.ReadLine()) ? "Disponível." : "Indisponível.");
                    break;
                case 4:
                    Console.Write("Produto a remover: ");
                    Console.WriteLine(estoque.Remover(Console.ReadLine()) ? "Removido." : "Não encontrado.");
                    break;
                case 5:
                    Console.Write("Produto: ");
                    int idx = estoque.IndiceDe(Console.ReadLine());
                    Console.WriteLine(idx >= 0 ? $"Posição: {idx}" : "Não está.");
                    break;
                case 6:
                    int i = 0;
                    foreach (var prod in estoque)
                        Console.WriteLine($"[{i++}] {prod}");
                    break;
            }
        } while (op != 0);
    }
}