// Задача 1: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


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

double [,] ChangeFirstLastLine (double [,] matr){

    double [,] resultArray = new double [matr.GetLength(0),matr.GetLength(1)];
    resultArray = matr;

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        resultArray [0,j] = matr [matr.GetLength(0)-1,j];
        resultArray [resultArray.GetLength(0)-1,j] = matr [0,j];
    }    
    return resultArray;
}


double [,] massiv = FillArrayFunc(3,4);
PrintDoubleArray(massiv);
Console.WriteLine();
PrintDoubleArray(ChangeFirstLastLine(massiv));