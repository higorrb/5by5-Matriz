//2- faça um programa que gere uma matriz 3x5 populada automaticamente e baseada nela gera uma nova matriz inversa 5x3.

using System.Security.Cryptography;

int linha = 3;
int coluna = 5;

int[,] matriz1 = new int[linha, coluna];
int[,] matriz2 = new int[coluna, linha];

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

void GerarMatrizInversa(int[,] matriz)
{
    
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            matriz2[j, i] = matriz[i, j];
        }
        Console.WriteLine(" ");
    }
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
GerarMatrizInversa(matriz1);
MostrarMatriz(matriz1, linha, coluna);
Console.WriteLine(" ");
MostrarMatriz(matriz2, coluna, linha);