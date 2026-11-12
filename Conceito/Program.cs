using System.Security.Cryptography;

int[,] matriz1 = new int[2,4];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matriz1[i, j] = RandomNumberGenerator.GetInt32(1, 6);  
    }
}

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"[{matriz1[i, j]}] ");
    }
}