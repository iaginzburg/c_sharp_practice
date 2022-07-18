// Задача 1: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.



void PrintDoubleArray(double[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");

        }
        Console.WriteLine();
    }
}

double[,] FillArrayFunc(int m, int n)
{
    double[,] resultArray = new double[m, n];

    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n; j++)
        {
            resultArray[i, j] = Math.Round(new Random().NextDouble() * (10 + 0) - 0, 0);
        }
    }

    return resultArray;
}

void SortDoubleArray (double[,] matr){
      for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
             for (int k = j+1; k < matr.GetLength(1); k++)
        {
            if(matr[i,j] < matr[i,k]) (matr[i,j], matr[i,k]) = (matr[i,k], matr[i,j]);
        }
        }
    }

}

double[,] massiv = FillArrayFunc(4, 4);
PrintDoubleArray(massiv);
SortDoubleArray(massiv);
Console.WriteLine();
PrintDoubleArray(massiv);