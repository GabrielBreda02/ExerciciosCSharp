using System;

// 1. Solicitando o tamanho do vetor
Console.Write("Informe o tamanho do vetor: ");
int tamanho = int.Parse(Console.ReadLine());

// 2. Criando o vetor com o tamanho escolhido pelo usuário
int[] numeros = new int[tamanho];

// 3. Preenchendo o vetor
for (int i = 0; i < tamanho; i++)
{
    Console.Write($"Informe o elemento {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

// 4. Chamando a função para calcular a soma
int resultado = SomarElementos(numeros);

// 5. Exibindo o resultado final
Console.WriteLine($"Resultado: {resultado}");
Console.WriteLine("Fim da execução do programa");

// --- FUNÇÃO SOMARELEMENTOS ---
// Ela recebe o vetor e devolve um número inteiro (a soma)
static int SomarElementos(int[] vetor)
{
    int soma = 0;
    foreach (int num in vetor)
    {
        soma += num;
    }
    return soma;
}