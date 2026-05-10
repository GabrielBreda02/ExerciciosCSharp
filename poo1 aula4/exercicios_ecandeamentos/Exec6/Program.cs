using System;

class Program
{
    static void Main()
    {
        ListaDupla<string> historico = new ListaDupla<string>();
        int op;
        do
        {
            Console.WriteLine("\n=== HISTÓRICO ===");
            Console.WriteLine("1 - Adicionar página");
            Console.WriteLine("2 - Inserir em posição");
            Console.WriteLine("3 - Verificar página");
            Console.WriteLine("4 - Remover página");
            Console.WriteLine("5 - Posição da página");
            Console.WriteLine("6 - Listar histórico");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("URL: ");
                    historico.Adicionar(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Posição: ");
                    int p = int.Parse(Console.ReadLine());
                    Console.Write("URL: ");
                    historico.Inserir(p, Console.ReadLine());
                    break;
                case 3:
                    Console.Write("URL: ");
                    Console.WriteLine(historico.Contem(Console.ReadLine()) ? "Sim." : "Não.");
                    break;
                case 4:
                    Console.Write("URL a remover: ");
                    Console.WriteLine(historico.Remover(Console.ReadLine()) ? "Removida." : "Não encontrada.");
                    break;
                case 5:
                    Console.Write("URL: ");
                    int idx = historico.IndiceDe(Console.ReadLine());
                    Console.WriteLine(idx >= 0 ? $"Posição: {idx}" : "Não está no histórico.");
                    break;
                case 6:
                    int i = 0;
                    foreach (var url in historico)
                        Console.WriteLine($"[{i++}] {url}");
                    break;
            }
        } while (op != 0);
    }
}