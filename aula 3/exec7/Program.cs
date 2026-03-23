using System;
using System.Collections.Generic; // Necessário para usar List

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

// 3. Chamando a função para limpar os duplicados
int[] vetorLimpo = RemoverDuplicados(numeros);

// 4. Exibindo o resultado final
Console.WriteLine($"Vetor sem duplicados: {{ {string.Join(", ", vetorLimpo)} }}");
Console.WriteLine("Fim da execução do programa");

// --- FUNÇÃO REMOVER DUPLICADOS ---
static int[] RemoverDuplicados(int[] vetorOriginal)
{
    // Criamos uma Lista dinâmica, pois não sabemos quantos números vão sobrar no final
    List<int> unicos = new List<int>();

    foreach (int num in vetorOriginal)
    {
        // O sinal de exclamação (!) significa "NÃO". 
        // Lemos assim: "Se a lista unicos NÃO contém o num..."
        if (!unicos.Contains(num))
        {
            unicos.Add(num); // Adiciona na lista segura
        }
    }

    // Convertemos a lista dinâmica de volta para um vetor (array) fixo para retornar
    return unicos.ToArray();
}