// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Print(decimal [] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

decimal [] MassNums(int size)
{       
    decimal [] arr = new decimal [size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = (decimal) new Random().NextDouble()* new Random().Next(-1000,1000);        
    }    
    return arr;
}

decimal SumOfMinMaxNumOfCollection (decimal [] arr)
{
    decimal min, max;
    min = max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return max-min;
}

decimal [] array1 = MassNums(3);
Print(array1);
Console.WriteLine($"Разность между макс. и мин. числом массива {SumOfMinMaxNumOfCollection(array1)}");
