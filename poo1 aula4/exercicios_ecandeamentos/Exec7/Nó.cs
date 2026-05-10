using System;
using System.Collections;
using System.Collections.Generic;

public class ListaDupla<T> : IEnumerable<T>
{
    private class No
    {
        public T Valor;
        public No Anterior;
        public No Proximo;
        public No(T valor) => Valor = valor;
    }

    private No inicio;
    private No fim;
    private int quantidade;

    public int Count => quantidade;

    // Adiciona no final
    public void Adicionar(T valor)
    {
        No novo = new No(valor);
        if (inicio == null)
        {
            inicio = fim = novo;
        }
        else
        {
            fim.Proximo = novo;
            novo.Anterior = fim;
            fim = novo;
        }
        quantidade++;
    }

    // Insere em uma posição (0‑based). Se pos == Count, insere no final.
    public void Inserir(int posicao, T valor)
    {
        if (posicao < 0 || posicao > quantidade)
            throw new ArgumentOutOfRangeException(nameof(posicao));

        if (posicao == quantidade)
        {
            Adicionar(valor);
            return;
        }

        No novo = new No(valor);
        if (posicao == 0)
        {
            novo.Proximo = inicio;
            inicio.Anterior = novo;
            inicio = novo;
        }
        else
        {
            No atual = inicio;
            for (int i = 0; i < posicao - 1; i++)
                atual = atual.Proximo;

            novo.Proximo = atual.Proximo;
            novo.Anterior = atual;
            atual.Proximo.Anterior = novo;
            atual.Proximo = novo;
        }
        quantidade++;
    }

    // Verifica se contém o valor
    public bool Contem(T valor)
    {
        No atual = inicio;
        while (atual != null)
        {
            if (Equals(atual.Valor, valor))
                return true;
            atual = atual.Proximo;
        }
        return false;
    }

    // Remove a primeira ocorrência do valor. Retorna true se removeu.
    public bool Remover(T valor)
    {
        No atual = inicio;
        while (atual != null)
        {
            if (Equals(atual.Valor, valor))
            {
                RemoverNo(atual);
                return true;
            }
            atual = atual.Proximo;
        }
        return false;
    }

    // Remove o elemento no índice especificado
    public void RemoverEm(int indice)
    {
        if (indice < 0 || indice >= quantidade)
            throw new ArgumentOutOfRangeException(nameof(indice));

        No atual = inicio;
        for (int i = 0; i < indice; i++)
            atual = atual.Proximo;

        RemoverNo(atual);
    }

    private void RemoverNo(No no)
    {
        if (no.Anterior != null)
            no.Anterior.Proximo = no.Proximo;
        else
            inicio = no.Proximo;

        if (no.Proximo != null)
            no.Proximo.Anterior = no.Anterior;
        else
            fim = no.Anterior;

        quantidade--;
    }

    // Retorna o índice (baseado em 0) da primeira ocorrência, ou -1 se não encontrar.
    public int IndiceDe(T valor)
    {
        No atual = inicio;
        int indice = 0;
        while (atual != null)
        {
            if (Equals(atual.Valor, valor))
                return indice;
            atual = atual.Proximo;
            indice++;
        }
        return -1;
    }

    // Indexador (opcional, útil)
    public T this[int indice]
    {
        get
        {
            if (indice < 0 || indice >= quantidade)
                throw new ArgumentOutOfRangeException();
            No atual = inicio;
            for (int i = 0; i < indice; i++)
                atual = atual.Proximo;
            return atual.Valor;
        }
        set
        {
            if (indice < 0 || indice >= quantidade)
                throw new ArgumentOutOfRangeException();
            No atual = inicio;
            for (int i = 0; i < indice; i++)
                atual = atual.Proximo;
            atual.Valor = value;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        No atual = inicio;
        while (atual != null)
        {
            yield return atual.Valor;
            atual = atual.Proximo;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}