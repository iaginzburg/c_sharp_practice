// Задача 2: Задайте двумерный массив. Найдите элементы, у которых
// обе позиции чётные, и замените эти элементы на их квадраты.

// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


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

int[,] ChangeEvenNumsArray (int [,] array)
{
    int [,] resultArray = array;

    for (int i = 1; i < resultArray.GetLength(0); i+=2)
    {

        for (int j = 1; j < resultArray.GetLength(1); j+=2)
        {
            resultArray[i, j] *=  resultArray[i, j];
        }
    }

    return resultArray;
}

int [,] matrix = FillArrayFunc(4,4);
PrintIntArray(matrix);
Console.WriteLine();
PrintIntArray(ChangeEvenNumsArray(matrix));
