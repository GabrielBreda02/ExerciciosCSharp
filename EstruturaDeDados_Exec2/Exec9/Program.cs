using System;

class Program
{
    static void Main()
    {
        var consultas = new ListaEncadeada<string>();
        int opcao;

        do
        {
            Console.WriteLine("\n--- Agendamento de Consultas ---");
            Console.WriteLine("1. Adicionar consulta (prioridade: posição específica)");
            Console.WriteLine("2. Verificar se consulta está agendada");
            Console.WriteLine("3. Remover consulta cancelada");
            Console.WriteLine("4. Encontrar posição de uma consulta");
            Console.WriteLine("5. Listar consultas");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Descrição da consulta (paciente, horário): ");
                    string desc = Console.ReadLine();
                    Console.Write("Posição de prioridade (0 = maior prioridade): ");
                    int pos = int.Parse(Console.ReadLine());
                    if (consultas.Adicionar(pos, desc))
                        Console.WriteLine("Consulta agendada.");
                    else
                        Console.WriteLine("Posição inválida.");
                    break;
                case 2:
                    Console.Write("Descrição para verificar: ");
                    desc = Console.ReadLine();
                    Console.WriteLine(consultas.Contem(desc) ? "Agendada." : "Não agendada.");
                    break;
                case 3:
                    Console.Write("Descrição da consulta cancelada: ");
                    desc = Console.ReadLine();
                    if (consultas.Remover(desc))
                        Console.WriteLine("Cancelada.");
                    else
                        Console.WriteLine("Consulta não encontrada.");
                    break;
                case 4:
                    Console.Write("Descrição para buscar: ");
                    desc = Console.ReadLine();
                    int idx = consultas.PosicaoDe(desc);
                    if (idx >= 0)
                        Console.WriteLine($"Posição: {idx}");
                    else
                        Console.WriteLine("Não encontrada.");
                    break;
                case 5:
                    consultas.Imprimir();
                    break;
            }
        } while (opcao != 0);
    }
}