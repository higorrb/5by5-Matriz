//3- desenvolva o programa q crie e preencha uma matriz quadrada q temanho sera informa pela usuario, mostre os calculos somando
//os valores de cada linha de cada coluno, diagonal principal e diagonal inversa

using System.Security.Cryptography;

Console.WriteLine("Digite o numero da matriz quadrada: ");
int tamanholinha = int.Parse(Console.ReadLine());
int tamanhocoluna = tamanholinha;


int[,] matriz1 = new int[tamanholinha, tamanhocoluna];


void PopularMatriz()
{
    for (int i = 0; i < tamanholinha; i++)
    {
        for (int j = 0; j < tamanhocoluna; j++)
        {
            matriz1[i, j] = RandomNumberGenerator.GetInt32(1, 6);
        }
    }
}

void MostraSomaLinhaMatriz(int[,] matriz)
{
    int contador = 0;

    Console.Write("soma das linhas: \n");
    for (int i = 0; i < tamanholinha; i++)
    {
        contador = 0;

        for (int j = 0; j < tamanhocoluna; j++)
        {
            contador += matriz[i, j];
        }

        Console.Write($"linha {i}: " + contador);
        Console.WriteLine();
    }
}

void MostraSomaColunaMatriz(int[,] matriz)
{
    int contador = 0;

    Console.Write("soma das colunas: \n");
    for (int i = 0; i < tamanholinha; i++)
    {
        contador = 0;

        for (int j = 0; j < tamanhocoluna; j++)
        {
            contador += matriz[j, i];
        }

        Console.Write($"coluna {i}: " + contador);
        Console.WriteLine();
    }
}

int CalcularDiagonalMatriz(int[,] matriz)
{
    int contador = 0;
    for (int i = 0; i < tamanholinha; i++)
    {
        for (int j = 0; j < tamanhocoluna; j++)
        {
            if (i == j)
                contador += matriz[i, j];
        }
    }
    return contador;
}

int CalcularDiagonalInversaMatriz(int[,] matriz)
{
    int contador = 0;
    for (int i = 0; i < tamanholinha; i++)
    {
        for (int j = tamanhocoluna - 1; j >= 0; j--)
        {
            if (i + j == tamanhocoluna - 1)
            {
                contador += matriz[i, j];
            }
        }
    }
    return contador;
}



void MostrarMatriz(int[,] matriz, int linha, int coluna)
{
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            Console.Write($"[{matriz[i, j]}] ");
        }
        Console.WriteLine(" ");
    }

}

PopularMatriz();
MostrarMatriz(matriz1, tamanholinha, tamanhocoluna);

MostraSomaLinhaMatriz(matriz1);
MostraSomaColunaMatriz(matriz1);
Console.Write("soma da diagonal: ");
Console.WriteLine(CalcularDiagonalMatriz(matriz1));
Console.Write("soma da diagonal inversa: ");
Console.WriteLine(CalcularDiagonalInversaMatriz(matriz1));