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

// 3. Solicitando o número de posições para rotacionar
Console.Write("Informe o número de posições (n): ");
int n = int.Parse(Console.ReadLine());

// 4. Chamando a função para rotacionar
int[] vetorRotacionado = RotacionarVetor(numeros, n);

// 5. Exibindo o resultado final
Console.WriteLine($"Vetor rotacionado: {{ {string.Join(", ", vetorRotacionado)} }}");
Console.WriteLine("Fim da execução do programa");

// --- FUNÇÃO ROTACIONAR VETOR ---
static int[] RotacionarVetor(int[] vetorOriginal, int posicoes)
{
    int tamanho = vetorOriginal.Length;
    int[] novoVetor = new int[tamanho];

    // Evita voltas desnecessárias caso o usuário digite um 'n' maior que o vetor
    // Ex: rotacionar 6 vezes um vetor de tamanho 5 é a mesma coisa que rotacionar 1 vez.
    int deslocamento = posicoes % tamanho;

    for (int i = 0; i < tamanho; i++)
    {
        // A matemática elegante: calculamos a nova posição de forma circular
        int novaPosicao = (i + deslocamento) % tamanho;

        // Colocamos o valor na sua nova casa
        novoVetor[novaPosicao] = vetorOriginal[i];
    }

    return novoVetor;
}