// Задача 1: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

void PrintIntArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"-{matr[i, j]}- ");

        }
        Console.WriteLine();
    }
}


int[,] FillArrayFunc (int m, int n)
{
    int [,] resultArray = new int [m,n];

    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n; j++)
        {
            resultArray[i, j] = new Random().Next(-100, 100);
        }
    }

    return resultArray;
}

PrintIntArray(FillArrayFunc(3,4));