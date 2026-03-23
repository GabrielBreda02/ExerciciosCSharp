using System;

// 1. Solicitando a dimensão (tamanho) dos vetores
Console.Write("Informe a dimensão dos vetores: ");
int dimensao = int.Parse(Console.ReadLine());

int[] vetor1 = new int[dimensao];
int[] vetor2 = new int[dimensao];

// 2. Preenchendo o Vetor 1
for (int i = 0; i < dimensao; i++)
{
    Console.Write($"Informe o elemento {i + 1} do vetor 1: ");
    vetor1[i] = int.Parse(Console.ReadLine());
}

// 3. Preenchendo o Vetor 2
for (int i = 0; i < dimensao; i++)
{
    Console.Write($"Informe o elemento {i + 1} do vetor 2: ");
    vetor2[i] = int.Parse(Console.ReadLine());
}

// 4. Chamando a função para calcular o produto escalar
int resultado = ProdutoEscalar(vetor1, vetor2);

// 5. Exibindo o resultado final
Console.WriteLine($"Produto escalar: {resultado}");
Console.WriteLine("Fim da execução do programa");

// --- FUNÇÃO PRODUTO ESCALAR ---
static int ProdutoEscalar(int[] v1, int[] v2)
{
    int somaTotal = 0;

    // Como ambos têm o mesmo tamanho, um único laço resolve
    for (int i = 0; i < v1.Length; i++)
    {
        // Multiplica os elementos na mesma posição e acumula na soma
        somaTotal += (v1[i] * v2[i]);
    }

    return somaTotal;
}