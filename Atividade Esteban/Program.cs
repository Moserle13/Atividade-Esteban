using System;

public class BuscaSequencial
{
    public static int ContarOcorrencias(int[] array, int elemento)
    {
        int contador = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == elemento)
                contador++;
        }
        return contador;
    }

    public static void Main()
    {
        int[] arr = { 1, 3, 5, 3, 7, 3 };
        int elemento = 3;
        int ocorrencias = ContarOcorrencias(arr, elemento);

        Console.WriteLine($"O número {elemento} aparece {ocorrencias} vezes.");
    }
}
