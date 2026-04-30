using System;

class Program
{
    static void Main()
    {
        var alunos = new ListaEncadeada<string>();
        int opcao;

        do
        {
            Console.WriteLine("\n--- Registro de Alunos ---");
            Console.WriteLine("1. Adicionar aluno em posição específica (lista de espera)");
            Console.WriteLine("2. Verificar se aluno está inscrito");
            Console.WriteLine("3. Remover aluno (desistência)");
            Console.WriteLine("4. Encontrar posição de um aluno");
            Console.WriteLine("5. Listar alunos");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Nome do aluno: ");
                    string nome = Console.ReadLine();
                    Console.Write("Posição (0 = início): ");
                    int pos = int.Parse(Console.ReadLine());
                    if (alunos.Adicionar(pos, nome))
                        Console.WriteLine("Aluno adicionado.");
                    else
                        Console.WriteLine("Posição inválida.");
                    break;
                case 2:
                    Console.Write("Nome do aluno: ");
                    nome = Console.ReadLine();
                    Console.WriteLine(alunos.Contem(nome) ? "Inscrito." : "Não inscrito.");
                    break;
                case 3:
                    Console.Write("Nome do aluno que desistiu: ");
                    nome = Console.ReadLine();
                    if (alunos.Remover(nome))
                        Console.WriteLine("Removido.");
                    else
                        Console.WriteLine("Aluno não encontrado.");
                    break;
                case 4:
                    Console.Write("Nome do aluno: ");
                    nome = Console.ReadLine();
                    int idx = alunos.PosicaoDe(nome);
                    if (idx >= 0)
                        Console.WriteLine($"Posição: {idx}");
                    else
                        Console.WriteLine("Não encontrado.");
                    break;
                case 5:
                    alunos.Imprimir();
                    break;
            }
        } while (opcao != 0);
    }
}