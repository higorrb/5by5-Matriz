//1- faça um programa que crie uma matriz de numeros inteiros na quantidade de linhas e colunas q o usuario informar,
//essa matriz deve ser populada automaticamente e ser exibida do 1 ao ultimo e do ultimo para o 1.

using System.Security.Cryptography;


Console.WriteLine("Digite o numero de linhas: ");
int linha = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o numero de colunas: ");
int coluna = int.Parse(Console.ReadLine());

int[,] matriz1 = new int[linha, coluna];


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

void MostrarMatriz()
{
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            Console.Write($"[{matriz1[i, j]}] ");
        }
        Console.WriteLine(" ");
    }

}

void MostrarMatrizInverso()
{
    for (int i = linha - 1; i >= 0; i--)
    {
        for (int j = coluna - 1; j >= 0; j--)
        {
            Console.Write($"[{matriz1[i, j]}] ");
        }
        Console.WriteLine(" ");
    }
}

PopularMatriz();
Console.WriteLine("Matriz Normal");
MostrarMatriz();
Console.WriteLine(" ");
Console.WriteLine("Matriz Inversa");
MostrarMatrizInverso();