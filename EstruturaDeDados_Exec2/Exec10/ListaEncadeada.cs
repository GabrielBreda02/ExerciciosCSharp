using System;

public class ListaEncadeada<T>
{
    private class No
    {
        public T Valor;
        public No Proximo;

        public No(T valor)
        {
            Valor = valor;
            Proximo = null;
        }
    }

    private No cabeca;
    private int tamanho;

    public ListaEncadeada()
    {
        cabeca = null;
        tamanho = 0;
    }

    public int Tamanho => tamanho;

    // Adiciona no final (para inserção simples)
    public void Adicionar(T item)
    {
        if (cabeca == null)
        {
            cabeca = new No(item);
        }
        else
        {
            No atual = cabeca;
            while (atual.Proximo != null)
                atual = atual.Proximo;
            atual.Proximo = new No(item);
        }
        tamanho++;
    }

    // Adiciona em uma posição específica (0 = início)
    public bool Adicionar(int indice, T item)
    {
        if (indice < 0 || indice > tamanho)
            return false;

        No novo = new No(item);

        if (indice == 0)
        {
            novo.Proximo = cabeca;
            cabeca = novo;
        }
        else
        {
            No anterior = cabeca;
            for (int i = 0; i < indice - 1; i++)
                anterior = anterior.Proximo;
            novo.Proximo = anterior.Proximo;
            anterior.Proximo = novo;
        }
        tamanho++;
        return true;
    }

    // Verifica se um elemento existe na lista
    public bool Contem(T item)
    {
        No atual = cabeca;
        while (atual != null)
        {
            if (Equals(atual.Valor, item))
                return true;
            atual = atual.Proximo;
        }
        return false;
    }

    // Remove a primeira ocorrência do item (retorna true se removeu)
    public bool Remover(T item)
    {
        if (cabeca == null) return false;

        if (Equals(cabeca.Valor, item))
        {
            cabeca = cabeca.Proximo;
            tamanho--;
            return true;
        }

        No anterior = cabeca;
        No atual = cabeca.Proximo;
        while (atual != null)
        {
            if (Equals(atual.Valor, item))
            {
                anterior.Proximo = atual.Proximo;
                tamanho--;
                return true;
            }
            anterior = atual;
            atual = atual.Proximo;
        }
        return false;
    }

    // Retorna a posição (0‑based) da primeira ocorrência, ou -1 se não achar
    public int PosicaoDe(T item)
    {
        No atual = cabeca;
        int pos = 0;
        while (atual != null)
        {
            if (Equals(atual.Valor, item))
                return pos;
            atual = atual.Proximo;
            pos++;
        }
        return -1;
    }

    // Para testes: imprime a lista
    public void Imprimir()
    {
        No atual = cabeca;
        while (atual != null)
        {
            Console.Write(atual.Valor + " -> ");
            atual = atual.Proximo;
        }
        Console.WriteLine("null");
    }
}