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

// 3. Solicitando o valor a ser contado (x)
Console.Write("Informe o valor a contar (x): ");
int x = int.Parse(Console.ReadLine());

// 4. Chamando a função de contagem
int quantidade = ContarElementos(numeros, x);

// 5. Exibindo o resultado
Console.WriteLine($"O número {x} aparece {quantidade} vezes");
Console.WriteLine("Fim da execução do programa");

// --- FUNÇÃO CONTARELEMENTOS ---
static int ContarElementos(int[] vetor, int valorProcurado)
{
    int contador = 0;

    // Percorremos cada item do vetor
    foreach (int num in vetor)
    {
        // Se o item for igual ao que procuramos, incrementamos o contador
        if (num == valorProcurado)
        {
            contador++;
        }
    }

    return contador;
}