// See https://aka.ms/new-console-template for more information
Console.Write("informe o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("informe o segundo número: ");
double num2 = double.Parse(Console.ReadLine());

Console.Write("informe o terceiro número: ");
double num3 = double.Parse(Console.ReadLine());

double media = (num1 + num2 + num3) / 3.0;

Console.WriteLine($"A média aritmética dos números é: {media:F2}");
Console.WriteLine("fim da execução do programa");
