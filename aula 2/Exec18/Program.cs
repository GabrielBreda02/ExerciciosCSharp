using System;

// 1. Solicitando a frase
Console.Write("Informe uma frase: ");
string frase = Console.ReadLine();

// Convertemos tudo para minúsculo para facilitar a comparação
// Assim não precisamos testar 'A' e 'a' separadamente.
string fraseMinuscula = frase.ToLower();

int contadorVogais = 0;
string vogais = "aeiouáéíóúâêîôûãõ"; // Incluímos as vogais com acento

// 2. Percorrendo cada letra da frase
foreach (char letra in fraseMinuscula)
{
    // Verificamos se a letra atual existe dentro da nossa string de vogais
    if (vogais.Contains(letra))
    {
        contadorVogais++;
    }
}

// 3. Exibindo o resultado
Console.WriteLine($"Número de vogais: {contadorVogais}");
Console.WriteLine("Fim da execução do programa");
