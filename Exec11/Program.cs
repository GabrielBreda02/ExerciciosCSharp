using System;

// 1. Criamos uma variável para guardar o maior número. 
// Inicializamos com um valor bem baixo ou o primeiro número lido.
double maior;

Console.Write("Informe o número 1: ");
double n1 = double.Parse(Console.ReadLine());
maior = n1; // O primeiro número é, por enquanto, o maior de todos

Console.Write("Informe o número 2: ");
double n2 = double.Parse(Console.ReadLine());
if (n2 > maior) maior = n2; // Se n2 for maior que o atual, ele assume o trono

Console.Write("Informe o número 3: ");
double n3 = double.Parse(Console.ReadLine());
if (n3 > maior) maior = n3;

Console.Write("Informe o número 4: ");
double n4 = double.Parse(Console.ReadLine());
if (n4 > maior) maior = n4;

Console.Write("Informe o número 5: ");
double n5 = double.Parse(Console.ReadLine());
if (n5 > maior) maior = n5;

// 2. Exibindo o vencedor
Console.WriteLine($"O maior número digitado foi: {maior}");
Console.WriteLine("Fim da execução do programa");