using System;

// 1. Solicitando o tamanho do vetor
Console.Write("Informe o tamanho do vetor: ");
int tamanho = int.Parse(Console.ReadLine());

int[] numeros = new int[tamanho];

// 2. Preenchendo o vetor
for (int i = 0; i < tamanho; i++)
{
    Console.Write($"Informe o elemento {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

// 3. Chamando a função para calcular os extremos
// Repare na palavra 'out' indicando que essas variáveis vão receber os resultados
EncontrarExtremos(numeros, out int maior, out int menor);

// 4. Exibindo os resultados finais
Console.WriteLine($"Maior: {maior}");
Console.WriteLine($"Menor: {menor}");
Console.WriteLine("Fim da execução do programa");

// --- FUNÇÃO ENCONTRAREXTREMOS ---
// O tipo é 'void' porque ela não usa um 'return' tradicional, ela devolve pelos parâmetros 'out'
static void EncontrarExtremos(int[] vetor, out int maior, out int menor)
{
    // Partimos do princípio que o primeiro elemento é, até o momento, o maior e o menor
    maior = vetor[0];
    menor = vetor[0];

    // Percorremos o vetor verificando se alguém supera essas marcas
    foreach (int num in vetor)
    {
        if (num > maior)
        {
            maior = num; // Atualiza o maior
        }

        if (num < menor)
        {
            menor = num; // Atualiza o menor
        }
    }
}