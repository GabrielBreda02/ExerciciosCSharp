// See https://aka.ms/new-console-template for more information
Console.WriteLine("Informe a temperatura em celsius : ");
double celsius = double.Parse(Console.ReadLine());

double fahrenheit = (celsius * 9.0 / 5.0) + 32;

Console.WriteLine($"A temperatura em fahrenheit é: {fahrenheit:F2}");
Console.WriteLine($"temperatura em celsius: {celsius:F2}");
Console.WriteLine("fim da execução do programa");
