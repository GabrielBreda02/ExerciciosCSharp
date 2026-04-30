using System;

// 1. O Laço de Repetição (for) para contagem regressiva
// int i = 10   -> Começamos em 10
// i >= 0       -> Continue enquanto i for maior ou igual a 0
// i--          -> A cada volta, subtraímos 1 do valor de i
for (int i = 10; i >= 0; i--)
{
    // Usamos Console.Write (sem o Line) para os números ficarem na mesma linha
    Console.Write(i + " ");
}

// 2. Finalização (Pulando uma linha antes para não ficar grudado nos números)
Console.WriteLine("\nFim da execução do programa");
