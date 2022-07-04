// Напишите программу, которая задаёт массив из
// 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции


void ArrayFill(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0, 11);
    }
}

void ArrayPrint(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] +  " ");
    }
}

int[] array = new int[8];
ArrayFill(array);
ArrayPrint(array);