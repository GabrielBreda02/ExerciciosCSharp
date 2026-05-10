using System;

class Program
{
    static void Main()
    {
        ListaDupla<string> mao = new ListaDupla<string>();
        int op;
        do
        {
            Console.WriteLine("\n=== MÃO DE CARTAS ===");
            Console.WriteLine("1 - Adicionar carta");
            Console.WriteLine("2 - Inserir carta em posição");
            Console.WriteLine("3 - Verificar carta");
            Console.WriteLine("4 - Remover carta jogada");
            Console.WriteLine("5 - Posição da carta");
            Console.WriteLine("6 - Listar mão");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Carta (ex: A♠): ");
                    mao.Adicionar(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Posição: ");
                    int p = int.Parse(Console.ReadLine());
                    Console.Write("Carta: ");
                    mao.Inserir(p, Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Carta: ");
                    Console.WriteLine(mao.Contem(Console.ReadLine()) ? "Sim." : "Não.");
                    break;
                case 4:
                    Console.Write("Carta a jogar: ");
                    Console.WriteLine(mao.Remover(Console.ReadLine()) ? "Jogada." : "Carta não está na mão.");
                    break;
                case 5:
                    Console.Write("Carta: ");
                    int idx = mao.IndiceDe(Console.ReadLine());
                    Console.WriteLine(idx >= 0 ? $"Posição: {idx}" : "Não está na mão.");
                    break;
                case 6:
                    int i = 0;
                    foreach (var c in mao)
                        Console.WriteLine($"[{i++}] {c}");
                    break;
            }
        } while (op != 0);
    }
}