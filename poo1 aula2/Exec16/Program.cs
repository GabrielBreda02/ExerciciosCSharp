using System;

// 1. Solicitando o número limite (N)
Console.Write("Informe o número N: ");
int n = int.Parse(Console.ReadLine());

// 2. Criando o ACUMULADOR (começa em zero)
int soma = 0;

// 3. O laço percorre de 1 até o número digitado (N)
for (int i = 1; i <= n; i++)
{
    // soma += i é o mesmo que: soma = soma + i;
    soma += i;
}

// 4. Exibindo o resultado final
Console.WriteLine($"Soma de 1 até {n} = {soma}");
Console.WriteLine("Fim da execução do programa");
