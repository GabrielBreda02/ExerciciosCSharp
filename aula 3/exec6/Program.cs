using System;

// 1. Lendo os dados do Vetor 1
Console.Write("Informe o tamanho do vetor 1: ");
int tamanho1 = int.Parse(Console.ReadLine());
int[] vetor1 = new int[tamanho1];

for (int i = 0; i < tamanho1; i++)
{
    Console.Write($"Informe o elemento {i + 1} do vetor 1: ");
    vetor1[i] = int.Parse(Console.ReadLine());
}

// 2. Lendo os dados do Vetor 2
Console.Write("Informe o tamanho do vetor 2: ");
int tamanho2 = int.Parse(Console.ReadLine());
int[] vetor2 = new int[tamanho2];

for (int i = 0; i < tamanho2; i++)
{
    Console.Write($"Informe o elemento {i + 1} do vetor 2: ");
    vetor2[i] = int.Parse(Console.ReadLine());
}

// 3. Chamando a função para intercalar
int[] vetorIntercalado = IntercalarVetores(vetor1, vetor2);

// 4. Exibindo o resultado final
Console.WriteLine($"Vetor intercalado: {{ {string.Join(", ", vetorIntercalado)} }}");
Console.WriteLine("Fim da execução do programa");

// --- FUNÇÃO INTERCALAR VETORES ---
static int[] IntercalarVetores(int[] v1, int[] v2)
{
    // O novo vetor precisa ter o tamanho da soma dos dois originais
    int[] resultado = new int[v1.Length + v2.Length];

    int i = 0; // Vai controlar a posição (índice) que estamos lendo no v1
    int j = 0; // Vai controlar a posição (índice) que estamos lendo no v2
    int k = 0; // Vai controlar a posição (índice) que estamos gravando no resultado

    // O laço (while) continua rodando enquanto ainda houver itens em algum dos vetores
    while (i < v1.Length || j < v2.Length)
    {
        // Se ainda tem itens no Vetor 1, pega um item e joga no resultado
        if (i < v1.Length)
        {
            resultado[k] = v1[i];
            k++; // Anda uma casinha no resultado
            i++; // Anda uma casinha no vetor 1
        }

        // Se ainda tem itens no Vetor 2, pega um item e joga no resultado
        if (j < v2.Length)
        {
            resultado[k] = v2[j];
            k++; // Anda uma casinha no resultado
            j++; // Anda uma casinha no vetor 2
        }
    }

    return resultado;
}