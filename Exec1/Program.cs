// See https://aka.ms/new-console-template for more information
Console.Write("informe o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("informe o segundo número: ");
double num2 = double.Parse(Console.ReadLine()); 

double soma = num1 + num2;

Console.WriteLine($"A soma dos números é: {soma}");
Console.WriteLine($"fim da execução do programa");