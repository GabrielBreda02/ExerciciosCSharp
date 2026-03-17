
using System;

// 1. Lendo o número
Console.Write("Informe um número: ");
int numero = int.Parse(Console.ReadLine());

bool ehPrimo = true;

// Regra básica: números menores ou iguais a 1 não são primos
if (numero <= 1)
{
    ehPrimo = false;
}
else
{
    // 2. Testamos divisões de 2 até chegar perto do número
    // Se encontrarmos qualquer divisor no caminho, ele não é primo
    for (int i = 2; i < numero; i++)
    {
        if (numero % i == 0)
        {
            ehPrimo = false;
            break; // Já descobrimos que não é primo, não precisa continuar testando
        }
    }
}

// 3. Exibindo o veredito
if (ehPrimo)
{
    Console.WriteLine("O número é primo");
}
else
{
    Console.WriteLine("O número não é primo");
}

Console.WriteLine("Fim da execução do programa");