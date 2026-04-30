using System;

// 1. Solicitando o número base da tabuada
Console.Write("Informe um número: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"Tabuada de {numero}:");

// 2. O Laço de Repetição (for)
// int i = 1    -> Começamos o contador em 1
// i <= 10      -> A repetição continua enquanto i for menor ou igual a 10
// i++          -> A cada volta, somamos +1 ao valor de i
for (int i = 1; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}

// 3. Finalização
Console.WriteLine("Fim da execução do programa");
