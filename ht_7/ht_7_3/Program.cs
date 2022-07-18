// Задача 3: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.


//Функция печати массива, вспомогательная
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

//Фнкция вычисления среднего арифметического элементов каждого столбца
void AveregeSumOfColomns(int[,] array)
{
    int sumOfColomn;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumOfColomn = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumOfColomn += array[i, j];
        }
        Console.WriteLine($"среднее арифметическое столбца {j + 1}: {Math.Round((double)sumOfColomn / array.GetLength(0), 2)}");
    }
}

int[,] array = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
PrintIntArray(array);
AveregeSumOfColomns(array);
