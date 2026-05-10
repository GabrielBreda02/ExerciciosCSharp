using System;

class Program
{
    static void Main()
    {
        ListaDupla<string> participantes = new ListaDupla<string>();
        int op;
        do
        {
            Console.WriteLine("\n=== INSCRIÇÕES ===");
            Console.WriteLine("1 - Adicionar participante");
            Console.WriteLine("2 - Inserir com prioridade (posição)");
            Console.WriteLine("3 - Verificar inscrição");
            Console.WriteLine("4 - Remover inscrição");
            Console.WriteLine("5 - Encontrar posição");
            Console.WriteLine("6 - Listar participantes");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Nome: ");
                    participantes.Adicionar(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Posição: ");
                    int p = int.Parse(Console.ReadLine());
                    Console.Write("Nome: ");
                    participantes.Inserir(p, Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Nome: ");
                    Console.WriteLine(participantes.Contem(Console.ReadLine()) ? "Inscrito." : "Não inscrito.");
                    break;
                case 4:
                    Console.Write("Nome a remover: ");
                    Console.WriteLine(participantes.Remover(Console.ReadLine()) ? "Removido." : "Não encontrado.");
                    break;
                case 5:
                    Console.Write("Nome: ");
                    int idx = participantes.IndiceDe(Console.ReadLine());
                    Console.WriteLine(idx >= 0 ? $"Posição: {idx}" : "Não está.");
                    break;
                case 6:
                    int i = 0;
                    foreach (var nome in participantes)
                        Console.WriteLine($"[{i++}] {nome}");
                    break;
            }
        } while (op != 0);
    }
}