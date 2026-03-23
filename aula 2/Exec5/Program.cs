// See https://aka.ms/new-console-template for more information
Console.Write("digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 18) 
{
    Console.WriteLine("você é maior de idade");
}
else
{
    Console.WriteLine("você é menor de idade");
}
