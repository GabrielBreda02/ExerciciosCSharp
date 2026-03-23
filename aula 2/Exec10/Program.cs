using System;

// 1. Solicitando o número
Console.Write("Informe um número: ");
double numero = double.Parse(Console.ReadLine());

// 2. Verificando a condição do número
if (numero > 0)
{
    Console.WriteLine("O número é positivo");
}
else if (numero < 0)
{
    Console.WriteLine("O número é negativo");
}
else
{
    // Se não é maior que zero nem menor, só pode ser zero
    Console.WriteLine("O número é zero");
}

// 3. Finalização
Console.WriteLine("Fim da execução do programa");