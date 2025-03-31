using System;

public class BuscaSequencial
{
    public static int BuscarNome(string[] nomes, string nome)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nome)
                return i;
        }
        return -1;
    }

    public static void Main()
    {
        string[] nomes = { "Ana", "Carlos", "Mariana", "João" };
        string nomeBusca = "Mariana";
        int indice = BuscarNome(nomes, nomeBusca);

        Console.WriteLine(indice == -1 ? "Nome não encontrado" : $"Nome encontrado no índice {indice}");
    }
}
