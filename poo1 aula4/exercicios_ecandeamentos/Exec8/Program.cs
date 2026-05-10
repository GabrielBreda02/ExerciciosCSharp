using System;

class Program
{
    static void Main()
    {
        ListaDupla<string> alunos = new ListaDupla<string>();
        int op;
        do
        {
            Console.WriteLine("\n=== ALUNOS ===");
            Console.WriteLine("1 - Adicionar aluno");
            Console.WriteLine("2 - Inserir em posição (lista de espera)");
            Console.WriteLine("3 - Verificar inscrição");
            Console.WriteLine("4 - Remover aluno (desistente)");
            Console.WriteLine("5 - Posição do aluno");
            Console.WriteLine("6 - Listar alunos");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Nome: ");
                    alunos.Adicionar(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Posição: ");
                    int p = int.Parse(Console.ReadLine());
                    Console.Write("Nome: ");
                    alunos.Inserir(p, Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Nome: ");
                    Console.WriteLine(alunos.Contem(Console.ReadLine()) ? "Inscrito." : "Não inscrito.");
                    break;
                case 4:
                    Console.Write("Nome a remover: ");
                    Console.WriteLine(alunos.Remover(Console.ReadLine()) ? "Removido." : "Não encontrado.");
                    break;
                case 5:
                    Console.Write("Nome: ");
                    int idx = alunos.IndiceDe(Console.ReadLine());
                    Console.WriteLine(idx >= 0 ? $"Posição: {idx}" : "Não está.");
                    break;
                case 6:
                    int i = 0;
                    foreach (var aluno in alunos)
                        Console.WriteLine($"[{i++}] {aluno}");
                    break;
            }
        } while (op != 0);
    }
}