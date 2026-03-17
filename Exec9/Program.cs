// See https://aka.ms/new-console-template for more information
Console.Write("Informe a nota: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 60)
{
    Console.WriteLine("Situação: Aprovado");
}
else
{
    Console.WriteLine("Situação: Reprovado");
}
