// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// RandomObj.NextDouble() * (end - begin) + begin


void PrintDoubleArray(double [,] matr)
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

double [,] FillArrayFunc (int m, int n)
{
    double [,] resultArray = new double [m,n];

    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n; j++)
        {
            resultArray[i, j] = Math.Round(new Random().NextDouble() * (10+10)-10, 1); 
        }
    }

    return resultArray;
}

PrintDoubleArray(FillArrayFunc(3,4));
