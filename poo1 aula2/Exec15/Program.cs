using System;

Console.WriteLine("Números pares:");

// 1. O laço percorre de 1 até 100
for (int i = 1; i <= 100; i++)
{
    // 2. Verificamos se o número atual (i) é par
    if (i % 2 == 0)
    {
        // 3. Imprimimos o número seguido de vírgula ou espaço
        Console.Write(i + (i < 100 ? ", " : ""));
    }
}

// 4. Finalização
Console.WriteLine("\nFim da execução do programa");
