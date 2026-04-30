using System;
using System.Collections.Generic;

// 1. Solicitando a quantidade de elementos
Console.Write("Informe a quantidade de elementos da sequência Fibonacci: ");
int n = int.Parse(Console.ReadLine());

// Usamos uma Lista para facilitar a exibição final entre colchetes [ ]
List<int> sequencia = new List<int>();

int a = 0; // Primeiro número
int b = 1; // Segundo número

// 2. Gerando a sequência
for (int i = 0; i < n; i++)
{
    sequencia.Add(a);

    // O "pulo do gato": calculamos o próximo e rotacionamos os valores
    int proximo = a + b;
    a = b;
    b = proximo;
}

// 3. Exibindo o resultado formatado
Console.WriteLine("[" + string.Join(", ", sequencia) + "]");
Console.WriteLine("Fim da execução do programa");