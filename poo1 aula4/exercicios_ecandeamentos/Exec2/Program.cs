using System;

class Program
{
    static void Main()
    {
        ListaDupla<string> playlist = new ListaDupla<string>();
        int op;
        do
        {
            Console.WriteLine("\n=== PLAYLIST ===");
            Console.WriteLine("1 - Adicionar música");
            Console.WriteLine("2 - Inserir música em posição");
            Console.WriteLine("3 - Verificar se música existe");
            Console.WriteLine("4 - Remover música");
            Console.WriteLine("5 - Encontrar posição da música");
            Console.WriteLine("6 - Listar músicas");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Música: ");
                    playlist.Adicionar(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Posição: ");
                    int p = int.Parse(Console.ReadLine());
                    Console.Write("Música: ");
                    playlist.Inserir(p, Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Música: ");
                    Console.WriteLine(playlist.Contem(Console.ReadLine()) ? "Sim." : "Não.");
                    break;
                case 4:
                    Console.Write("Música a remover: ");
                    Console.WriteLine(playlist.Remover(Console.ReadLine()) ? "Removida." : "Não encontrada.");
                    break;
                case 5:
                    Console.Write("Música: ");
                    int idx = playlist.IndiceDe(Console.ReadLine());
                    Console.WriteLine(idx >= 0 ? $"Posição: {idx}" : "Não está.");
                    break;
                case 6:
                    int i = 0;
                    foreach (var m in playlist)
                        Console.WriteLine($"[{i++}] {m}");
                    break;
            }
        } while (op != 0);
    }
}