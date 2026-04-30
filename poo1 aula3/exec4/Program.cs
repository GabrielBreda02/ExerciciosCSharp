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

// 3. Chamando a função com os parâmetros 'out'
CalcularMediaDesvioPadrao(numeros, out double media, out double desvioPadrao);

// 4. Exibindo os resultados arredondados para 2 casas decimais
Console.WriteLine($"Média: {media}");
Console.WriteLine($"Desvio padrão: {Math.Round(desvioPadrao, 2)}");
Console.WriteLine("Fim da execução do programa");

// --- FUNÇÃO CALCULAR MÉDIA E DESVIO PADRÃO ---
static void CalcularMediaDesvioPadrao(int[] vetor, out double media, out double desvio)
{
    // Passo A: Calcular a Média
    int soma = 0;
    foreach (int num in vetor)
    {
        soma += num;
    }
    media = (double)soma / vetor.Length;

    // Passo B: Calcular a soma dos quadrados das diferenças
    double somaQuadrados = 0;
    foreach (int num in vetor)
    {
        // (num - media)²
        somaQuadrados += Math.Pow(num - media, 2);
    }

    // Passo C: Calcular o Desvio Padrão (Raiz quadrada da variância)
    // Nota: Usando N (vetor.Length) para Desvio Padrão Populacional
    desvio = Math.Sqrt(somaQuadrados / vetor.Length);
}