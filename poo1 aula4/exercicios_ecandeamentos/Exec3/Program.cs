using System;

class Program
{
    static void Main()
    {
        ListaDupla<string> compras = new ListaDupla<string>();
        int op;
        do
        {
            Console.WriteLine("\n=== COMPRAS ===");
            Console.WriteLine("1 - Adicionar produto");
            Console.WriteLine("2 - Inserir produto em posição");
            Console.WriteLine("3 - Verificar produto");
            Console.WriteLine("4 - Remover produto (devolução)");
            Console.WriteLine("5 - Encontrar posição");
            Console.WriteLine("6 - Listar produtos");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Produto: ");
                    compras.Adicionar(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Posição: ");
                    int p = int.Parse(Console.ReadLine());
                    Console.Write("Produto: ");
                    compras.Inserir(p, Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Produto: ");
                    Console.WriteLine(compras.Contem(Console.ReadLine()) ? "Sim." : "Não.");
                    break;
                case 4:
                    Console.Write("Produto a remover: ");
                    Console.WriteLine(compras.Remover(Console.ReadLine()) ? "Removido." : "Não encontrado.");
                    break;
                case 5:
                    Console.Write("Produto: ");
                    int idx = compras.IndiceDe(Console.ReadLine());
                    Console.WriteLine(idx >= 0 ? $"Posição: {idx}" : "Não está.");
                    break;
                case 6:
                    int i = 0;
                    foreach (var pr in compras)
                        Console.WriteLine($"[{i++}] {pr}");
                    break;
            }
        } while (op != 0);
    }
}