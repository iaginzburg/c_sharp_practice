// Задача 2: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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
            resultArray[i, j] = Math.Round(new Random().NextDouble() * (10 + 10) - 10, 1);
        }
    }

    return resultArray;
}

double[,] LineToColomn(double[,] matr)
{

    double[,] resultArray = new double[matr.GetLength(1), matr.GetLength(0)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            resultArray[j, i] = matr[i, j];
        }
    }

    return resultArray;
}


double[,] massiv = FillArrayFunc(3, 4);
PrintDoubleArray(massiv);
Console.WriteLine();
PrintDoubleArray(LineToColomn(massiv));


Console.WriteLine();
double[,] massiv2 = FillArrayFunc(4, 4);
PrintDoubleArray(massiv2);
Console.WriteLine();
PrintDoubleArray(LineToColomn(massiv2));