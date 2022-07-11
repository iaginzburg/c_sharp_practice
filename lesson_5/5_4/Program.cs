// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{       
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-100, 100);        
    }    
    return arr;
}

int CountQualityOfNumInSegment (int lowBorder, int highBorder, int[] arr)
{
    int quality = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ( arr[i] > lowBorder && arr[i] < highBorder) quality++;
    }
    return quality;
}

int [] array1 = MassNums(123);
Print(array1);
Console.WriteLine(CountQualityOfNumInSegment(9, 100, array1));