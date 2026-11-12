//2- faça um programa que gere uma matriz 3x5 populada automaticamente e baseada nela gera uma nova matriz inversa 5x3.

using System.Security.Cryptography;

int linha = 3;
int coluna = 5;

int[,] matriz1 = new int[linha, coluna];
int[,] matriz2 = new int[coluna, linha];
int[,] matriz3 = new int[linha, coluna];

void PopularMatriz()
{
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            matriz1[i, j] = RandomNumberGenerator.GetInt32(1, 6);
        }
    }
}

int[,] GerarMatrizInvertida(int[,] matrizOrigem, int[,] matrizInvertida)
{
    
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            matrizInvertida[j, i] = matrizOrigem[i, j];
        }
        Console.WriteLine(" ");
    }
    return matrizInvertida;
}

int[,] GerarMatrizInversa(int[,] matrizOrigem, int[,] matrizInversa)
{
    for (int i = linha - 1; i >= 0; i--)
    {
        for (int j = coluna - 1; j >= 0; j--)
        {
            matrizInversa[i, j] = matrizOrigem[i, j];
        }
        Console.WriteLine(" ");
    }
    return matrizInversa;
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

void MostrarMatrizInversa(int[,] matriz, int linha, int coluna)
{
    for (int i = linha - 1; i >= 0; i--)
    {
        for (int j = coluna - 1; j >= 0; j--)
        {
            Console.Write($"[{matriz[i, j]}] ");
        }
        Console.WriteLine(" ");
    }

}

PopularMatriz();
matriz2 = GerarMatrizInvertida(matriz1,matriz2);
matriz3 = GerarMatrizInversa(matriz1, matriz3);
MostrarMatriz(matriz1, linha, coluna);
Console.WriteLine(" ");
MostrarMatriz(matriz2, coluna, linha);
Console.WriteLine(" ");
MostrarMatrizInversa(matriz3, linha, coluna);