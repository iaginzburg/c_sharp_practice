// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.


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

void FindMinSumLine (int [,] array)
{
    int [] sumOfLines = new int [array.GetLength(0)];       //создаем и заполняем массив сумм строк

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfLines[i] += array[i, j];
        }
    }

    int indexMinSumLine = 0;                                 
                                                            //наименьший элемент массива (его идекс = индексу искомой строки)
    for (int i = 0; i < array.GetLength(0); i++){
        if (sumOfLines[indexMinSumLine] > sumOfLines[i]) indexMinSumLine = i;
    }

    Console.WriteLine($"строка с наименьшей суммой элементов {indexMinSumLine+1}"); //вывод порядкового номера искомой строки
}

int[,] array = new int[4, 4] { { 100, 4, 7, 2 }, { 55, 9, 2, 3 }, { 8, 4, 2, 4 }, { 2, 25, 5, 2 } };
PrintIntArray(array);
Console.WriteLine();
FindMinSumLine(array);
