// See https://aka.ms/new-console-template for more information
using System;

// 1. Lendo os números e o operador
Console.Write("Informe o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Informe o segundo número: ");
double num2 = double.Parse(Console.ReadLine());

Console.Write("Informe o operador (+, -, *, /): ");
string operador = Console.ReadLine();

double resultado = 0;

// 2. Decidindo qual conta fazer com base no operador digitado
if (operador == "+")
{
    resultado = num1 + num2;
}
else if (operador == "-")
{
    resultado = num1 - num2;
}
else if (operador == "*")
{
    resultado = num1 * num2;
}
else if (operador == "/")
{
    // Uma pequena validação: não dá para dividir por zero!
    if (num2 != 0)
    {
        resultado = num1 / num2;
    }
    else
    {
        Console.WriteLine("Erro: Divisão por zero não permitida.");
        return; // Encerra o programa mais cedo se houver erro
    }
}
else
{
    Console.WriteLine("Operador inválido!");
    return;
}

// 3. Exibindo o resultado final
Console.WriteLine($"Resultado da operação: {resultado}");
Console.WriteLine("Fim da execução do programa");