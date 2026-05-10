using System;

class Program
{
    static void Main()
    {
        ListaDupla<string> fila = new ListaDupla<string>();
        int op;
        do
        {
            Console.WriteLine("\n=== FILA DE IMPRESSÃO ===");
            Console.WriteLine("1 - Adicionar documento");
            Console.WriteLine("2 - Inserir documento urgente (posição)");
            Console.WriteLine("3 - Verificar documento");
            Console.WriteLine("4 - Remover documento (impresso)");
            Console.WriteLine("5 - Posição do documento");
            Console.WriteLine("6 - Listar fila");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Documento: ");
                    fila.Adicionar(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Posição: ");
                    int p = int.Parse(Console.ReadLine());
                    Console.Write("Documento: ");
                    fila.Inserir(p, Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Documento: ");
                    Console.WriteLine(fila.Contem(Console.ReadLine()) ? "Sim." : "Não.");
                    break;
                case 4:
                    Console.Write("Documento a remover: ");
                    Console.WriteLine(fila.Remover(Console.ReadLine()) ? "Removido." : "Não encontrado.");
                    break;
                case 5:
                    Console.Write("Documento: ");
                    int idx = fila.IndiceDe(Console.ReadLine());
                    Console.WriteLine(idx >= 0 ? $"Posição: {idx}" : "Não está na fila.");
                    break;
                case 6:
                    int i = 0;
                    foreach (var doc in fila)
                        Console.WriteLine($"[{i++}] {doc}");
                    break;
            }
        } while (op != 0);
    }
}