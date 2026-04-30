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

// 3. Chamando a função de ordenação
int[] vetorOrdenado = OrdenarVetor(numeros);

// 4. Exibindo o resultado final formatado
Console.WriteLine($"Vetor ordenado: {{ {string.Join(", ", vetorOrdenado)} }}");
Console.WriteLine("Fim da execução do programa");

// --- FUNÇÃO ORDENARVETOR ---
static int[] OrdenarVetor(int[] vetorOriginal)
{
    // Criamos uma cópia para não bagunçar o vetor original do usuário
    int[] vetor = (int[])vetorOriginal.Clone();

    int tamanho = vetor.Length;

    // Lógica do Bubble Sort
    // O primeiro laço garante que passaremos por todo o vetor várias vezes
    for (int i = 0; i < tamanho - 1; i++)
    {
        // O segundo laço compara os vizinhos lado a lado
        for (int j = 0; j < tamanho - 1 - i; j++)
        {
            // Se o elemento da esquerda for MAIOR que o da direita, eles trocam de lugar
            if (vetor[j] > vetor[j + 1])
            {
                int copoVazio = vetor[j];      // Guarda o valor da esquerda no copo vazio
                vetor[j] = vetor[j + 1];       // O da esquerda recebe o valor da direita
                vetor[j + 1] = copoVazio;      // O da direita recebe o valor que estava guardado
            }
        }
    }

    return vetor;
}