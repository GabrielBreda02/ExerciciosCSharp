using System;

class Program
{
    static void Main()
    {
        ListaDupla<string> tarefas = new ListaDupla<string>();
        int op;
        do
        {
            Console.WriteLine("\n=== TAREFAS ===");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Inserir tarefa em posição");
            Console.WriteLine("3 - Verificar se tarefa existe");
            Console.WriteLine("4 - Remover tarefa concluída");
            Console.WriteLine("5 - Encontrar posição de uma tarefa");
            Console.WriteLine("6 - Listar tarefas");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Tarefa: ");
                    tarefas.Adicionar(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Posição: ");
                    int p = int.Parse(Console.ReadLine());
                    Console.Write("Tarefa: ");
                    tarefas.Inserir(p, Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Tarefa: ");
                    Console.WriteLine(tarefas.Contem(Console.ReadLine()) ? "Sim." : "Não.");
                    break;
                case 4:
                    Console.Write("Tarefa a remover: ");
                    Console.WriteLine(tarefas.Remover(Console.ReadLine()) ? "Removida." : "Não encontrada.");
                    break;
                case 5:
                    Console.Write("Tarefa: ");
                    int idx = tarefas.IndiceDe(Console.ReadLine());
                    Console.WriteLine(idx >= 0 ? $"Posição: {idx}" : "Não está na lista.");
                    break;
                case 6:
                    int i = 0;
                    foreach (var t in tarefas)
                        Console.WriteLine($"[{i++}] {t}");
                    break;
            }
        } while (op != 0);
    }
}