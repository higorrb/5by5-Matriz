//2- faça um programa que gere o boletim escolar de um aluno, 
//criterios: as linhas sao as materias as colunas sao as notas de cada bimestre
//+ a media e a situação do aluno em cada materia


int tamanholinha = 5, tamanhocoluna = 7;
string[,] matrizBoletim = new string[tamanholinha, tamanhocoluna];

void AdicionarMateria(string[,] matriz)
{
    for (int i = 0; i < tamanholinha; i++)
    {

        Console.Write("Digite uma materia: ");
        matriz[i, 0] = Console.ReadLine();

    }
}

void AdicionarNotas(string[,] matriz)
{

    for (int i = 0; i < tamanholinha; i++)
    {
        for (int j = 1; j < tamanhocoluna - 2; j++)
        {
            Console.Write($"Digite uma nota para {matriz[i, 0]}: ");
            matriz[i, j] = Console.ReadLine();
        }
        Console.WriteLine(" ");
    }

}

void AdicionarMedias(string[,] matriz)
{
    float contador = 0;
    for (int i = 0; i < tamanholinha; i++)
    {
        contador = 0;
        for(int j = 1; j < tamanhocoluna - 2; j++)
        {
            contador += float.Parse(matriz[i, j]);
        }
        matriz[i, 5] = (contador/4.0).ToString("F2");
    }
}

void AdicionarValidacao(string[,] matriz)
{
    for (int i = 0; i < tamanholinha; i++)
    {
        float media = float.Parse(matriz[i, 5]);

        if (media < 5)
        {
            matriz[i, 6] = "Reprovado";
        }
        else if (media < 7)
        {
            matriz[i, 6] = "Recuperacao";
        }
        else
        {
            matriz[i, 6] = "Aprovado";
        }
    }
}

void MostrarMatriz(string[,] matriz, int linha, int coluna)
{
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            Console.Write($"[{matriz[i, j]}] \t");
        }
        Console.WriteLine(" ");
    }

}

AdicionarMateria(matrizBoletim);
AdicionarNotas(matrizBoletim);
AdicionarMedias(matrizBoletim);
AdicionarValidacao(matrizBoletim);
MostrarMatriz(matrizBoletim, tamanholinha, tamanhocoluna);
