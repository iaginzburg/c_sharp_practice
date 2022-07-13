// Задача 4: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования. 

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


void FillIntArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}


int [,] CopyIntArray(int [,] matr)
{
    int [,] copyOfmatr = new int [matr.GetLength(0),matr.GetLength(1)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            copyOfmatr[i, j] = matr[i,j];
        }
    }
    return copyOfmatr;
}

int [,] matrix = new int [3,4];

FillIntArray(matrix);
PrintIntArray(matrix);
Console.WriteLine();
PrintIntArray(CopyIntArray(matrix));

