// Задача 2: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

//Функция печати массива
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

//Фнкция поиска элемента в массиве по позиции
int FindElementByPosition(int[,] array)
{
    Console.Write("Введите строку в которой ищем элемент: "); //Запрос ввода строки в которой ищем элемент и проверка наличия такой строки в массиве
    int line = Convert.ToInt32(Console.ReadLine());
    if (line > array.GetLength(0) || line < 1 ) {
        Console.WriteLine("в заданном массиве меньше строк");
        return 0;
    }
    Console.Write("Введите столбец в котором ищем элемент: "); //Запрос вводы столбца в котором ищем элемент и проверка наличия такого столбца в массиве
    int colomn = Convert.ToInt32(Console.ReadLine());
     if (colomn > array.GetLength(1) || colomn < 1 ) {
        Console.WriteLine("в заданном массиве меньше столбцов");
        return 0;
    }
    return array[line-1, colomn-1];  //В случае успешного прохождения проверок на наличие указанных столбцов и строк, возвращаем искомый элемент
}

int[,] array = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
PrintIntArray(array);
Console.WriteLine(FindElementByPosition(array));


