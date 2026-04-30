using System;

class Program
{
    static void Main()
    {
        var mao = new ListaEncadeada<string>();
        int opcao;

        do
        {
            Console.WriteLine("\n--- Jogo de Cartas ---");
            Console.WriteLine("1. Adicionar carta à mão (posição específica)");
            Console.WriteLine("2. Verificar se possui uma carta");
            Console.WriteLine("3. Jogar uma carta (remover)");
            Console.WriteLine("4. Encontrar a posição de uma carta");
            Console.WriteLine("5. Mostrar a mão");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarCarta(mao);
                    break;
                case 2:
                    VerificarCarta(mao);
                    break;
                case 3:
                    RemoverCarta(mao);
                    break;
                case 4:
                    EncontrarPosicao(mao);
                    break;
                case 5:
                    Console.WriteLine("Mão (da esquerda para a direita):");
                    mao.Imprimir();
                    break;
                case 0:
                    Console.WriteLine("Encerrando o jogo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != 0);
    }

    static void AdicionarCarta(ListaEncadeada<string> mao)
    {
        Console.Write("Valor da carta (A, 2-10, J, Q, K): ");
        string valor = Console.ReadLine().Trim().ToUpper();
        if (!ValidarValor(valor))
        {
            Console.WriteLine("Valor inválido. Use A, 2-10, J, Q ou K.");
            return;
        }

        Console.WriteLine("Naipes disponíveis:");
        Console.WriteLine("  C - Copas");
        Console.WriteLine("  E - Espadas");
        Console.WriteLine("  O - Ouros");
        Console.WriteLine("  P - Paus");
        Console.Write("Digite a letra do naipe: ");
        string naipe = Console.ReadLine().Trim().ToUpper();
        if (naipe != "C" && naipe != "E" && naipe != "O" && naipe != "P")
        {
            Console.WriteLine("Naipe inválido.");
            return;
        }

        string carta = $"{valor}{naipe}"; // Ex: "10C", "AE", "KP"
        Console.Write("Posição onde inserir (0 = início): ");
        if (!int.TryParse(Console.ReadLine(), out int pos))
        {
            Console.WriteLine("Posição inválida.");
            return;
        }

        if (mao.Adicionar(pos, carta))
            Console.WriteLine($"Carta {carta} adicionada na posição {pos}.");
        else
            Console.WriteLine("Posição fora dos limites.");
    }

    static void VerificarCarta(ListaEncadeada<string> mao)
    {
        Console.Write("Digite a carta a verificar com a letra/numero e o naipe do lado (ex: 10C, AE): ");
        string carta = Console.ReadLine().Trim().ToUpper();
        if (mao.Contem(carta))
            Console.WriteLine($"Você possui a carta {carta}.");
        else
            Console.WriteLine($"Carta {carta} não encontrada na mão.");
    }

    static void RemoverCarta(ListaEncadeada<string> mao)
    {
        Console.Write("Digite a carta que foi jogada: ");
        string carta = Console.ReadLine().Trim().ToUpper();
        if (mao.Remover(carta))
            Console.WriteLine($"Carta {carta} removida da mão.");
        else
            Console.WriteLine($"Carta {carta} não está na mão.");
    }

    static void EncontrarPosicao(ListaEncadeada<string> mao)
    {
        Console.Write("Digite a carta para buscar: ");
        string carta = Console.ReadLine().Trim().ToUpper();
        int pos = mao.PosicaoDe(carta);
        if (pos >= 0)
            Console.WriteLine($"A carta {carta} está na posição {pos}.");
        else
            Console.WriteLine($"Carta {carta} não está na mão.");
    }

    static bool ValidarValor(string valor)
    {
        if (valor == "A" || valor == "J" || valor == "Q" || valor == "K")
            return true;
        if (int.TryParse(valor, out int num) && num >= 2 && num <= 10)
            return true;
        return false;
    }
}