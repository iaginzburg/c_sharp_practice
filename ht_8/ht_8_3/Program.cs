// Задача 3: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

void PrintIntArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");

        }
        Console.WriteLine();
    }
}

int[,] Production2Array (int [,] arr1, int [,] arr2 )
{
    int[,] resultArray = new int[arr1.GetLength(0), arr1.GetLength(1)];

    if (arr1.GetLength(0) != arr2.GetLength(0) && arr1.GetLength(1) != arr2.GetLength(1)) {                //проверка входных данных
        Console.WriteLine("данный метод не работает c не равнми по кол-ву строк и столбцов массивами");
        return resultArray;
    }

    for (int i = 0; i < arr1.GetLength(0); i++)                 //заполнение итогового массива произведениями элементов
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            resultArray[i,j] = arr1[i,j]*arr2[i,j];
        }
    }
    return resultArray;
}

int[,] array1 = new int[4, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 2, 2, 5, 2 } };
int [,] array2 = new int[4, 4] { { 2, 3, 1, 2 }, { 6, 2, 3, 1 }, { 3, 1, 2, 1 }, { 2, 5, 2, 3 } };
PrintIntArray(array1);
Console.WriteLine();
PrintIntArray(array2);
Console.WriteLine();
PrintIntArray(Production2Array(array1,array2));