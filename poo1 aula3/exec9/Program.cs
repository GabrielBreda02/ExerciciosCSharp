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

// 3. Chamando a função de verificação
bool resultado = EhPalindromo(numeros);

// 4. Exibindo o resultado
Console.WriteLine($"Resultado: {resultado}");
Console.WriteLine("Fim da execução do programa");

// --- FUNÇÃO EHPALINDROMO ---
static bool EhPalindromo(int[] vetor)
{
    int inicio = 0;
    int fim = vetor.Length - 1;

    // O laço corre até os dois índices se encontrarem no meio
    while (inicio < fim)
    {
        // Se os valores nas extremidades forem diferentes, não é palíndromo
        if (vetor[inicio] != vetor[fim])
        {
            return false;
        }

        // Move os ponteiros para o centro
        inicio++;
        fim--;
    }

    // Se percorreu tudo e não retornou false, então é verdadeiro
    return true;
}