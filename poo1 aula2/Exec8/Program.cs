// See https://aka.ms/new-console-template for more information
Console.Write("Informe o ano: ");
int ano = int.Parse(Console.ReadLine());

if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
{
    Console.WriteLine("O ano informado é bissexto");
}
else
{
    Console.WriteLine("O ano informado não é bissexto");
}