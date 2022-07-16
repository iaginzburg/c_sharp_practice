// Задача 3: Задайте двумерный массив. Найдите сумму элементов
// главной диагонали.

// Например, задан массив:
// 1 4 7
// 5 9 2
// 8 4 2
// Сумма элементов главной диагонали: 1+9+2 = 12



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
            resultArray[i, j] = new Random().Next(0, 10);
        }
    }

    return resultArray;
}

int SumDiag (int [,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i,i];
    }

    return sum;
}

int [,] matrix = FillArrayFunc(4,4);
PrintIntArray(matrix);
Console.WriteLine(SumDiag(matrix));
