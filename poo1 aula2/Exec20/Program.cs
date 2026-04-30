using System;

// 1. Gerando o número aleatório
Random gerador = new Random();
int numeroSecreto = gerador.Next(1, 101); // Gera entre 1 e 100
int palpite = 0;

Console.WriteLine("Tente adivinhar o número entre 1 e 100:");

// 2. O laço de repetição "Enquanto" (while)
// Ele vai repetir o bloco de código ENQUANTO o palpite for diferente do secreto
while (palpite != numeroSecreto)
{
    Console.Write("> ");
    palpite = int.Parse(Console.ReadLine());

    if (palpite < numeroSecreto)
    {
        Console.WriteLine("O número é maior");
        Console.WriteLine("Tente novamente:");
    }
    else if (palpite > numeroSecreto)
    {
        Console.WriteLine("O número é menor");
        Console.WriteLine("Tente novamente:");
    }
}

// 3. Finalização (só chega aqui quando sai do while, ou seja, quando acertar)
Console.WriteLine($"Parabéns! Você acertou o número: {numeroSecreto}");
Console.WriteLine("Fim da execução do programa");
