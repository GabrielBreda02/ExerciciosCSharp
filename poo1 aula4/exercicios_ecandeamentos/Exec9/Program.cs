using System;

class Program
{
    static void Main()
    {
        ListaDupla<string> consultas = new ListaDupla<string>();
        int op;
        do
        {
            Console.WriteLine("\n=== CONSULTAS ===");
            Console.WriteLine("1 - Adicionar consulta");
            Console.WriteLine("2 - Inserir prioritária (posição)");
            Console.WriteLine("3 - Verificar agendamento");
            Console.WriteLine("4 - Cancelar consulta");
            Console.WriteLine("5 - Posição da consulta");
            Console.WriteLine("6 - Listar consultas");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Descrição (ex: Dr. Silva 10h): ");
                    consultas.Adicionar(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Posição: ");
                    int p = int.Parse(Console.ReadLine());
                    Console.Write("Descrição: ");
                    consultas.Inserir(p, Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Descrição: ");
                    Console.WriteLine(consultas.Contem(Console.ReadLine()) ? "Agendada." : "Não agendada.");
                    break;
                case 4:
                    Console.Write("Descrição a cancelar: ");
                    Console.WriteLine(consultas.Remover(Console.ReadLine()) ? "Cancelada." : "Não encontrada.");
                    break;
                case 5:
                    Console.Write("Descrição: ");
                    int idx = consultas.IndiceDe(Console.ReadLine());
                    Console.WriteLine(idx >= 0 ? $"Posição: {idx}" : "Não está.");
                    break;
                case 6:
                    int i = 0;
                    foreach (var c in consultas)
                        Console.WriteLine($"[{i++}] {c}");
                    break;
            }
        } while (op != 0);
    }
}