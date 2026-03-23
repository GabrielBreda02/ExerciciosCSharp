using System;

// 1. Solicitando o número
Console.Write("Informe um número: ");
int n = int.Parse(Console.ReadLine());

// 2. Criando o ACUMULADOR de multiplicação
// Usamos 'long' em vez de 'int' porque fatoriais crescem muito rápido 
// e podem estourar o limite de um número inteiro comum.
long fatorial = 1;

// 3. O laço calcula a multiplicação decrescente
// Ex: 5! = 5 * 4 * 3 * 2 * 1
for (int i = n; i >= 1; i--)
{
    fatorial *= i; // Mesmo que: fatorial = fatorial * i;
}

// 4. Exibindo o resultado
Console.WriteLine($"Fatorial de {n} = {fatorial}");
Console.WriteLine("Fim da execução do programa");