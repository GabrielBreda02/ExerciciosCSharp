// See https://aka.ms/new-console-template for more information
Console.Write("digite um numero:");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("O número é PAR.");
}
else
{
    Console.WriteLine("O número é ÍMPAR.");
}