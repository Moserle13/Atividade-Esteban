using System;

public class BuscaSequencial
{
    public static int BuscarElemento(int[] array, int elemento)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == elemento)
                return i;
        }
        return -1; // Retorna -1 se não encontrar
    }

    public static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 9 };
        int elemento = 7;
        int indice = BuscarElemento(arr, elemento);

        Console.WriteLine(indice == -1 ? "Elemento não encontrado" : $"Elemento encontrado no índice {indice}");
    }
}
