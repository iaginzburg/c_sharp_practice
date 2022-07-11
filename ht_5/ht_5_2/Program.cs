// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (делаем на нечетных индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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
        arr[i] = new Random().Next(-20, 20);        
    }    
    return arr;
}

int SumOfOddNum (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ( i%2 != 0 ) sum += arr[i];
    }
    return sum;
}

int SumOfOddNumV2 (int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum += arr[i];
    }
    return sum;
}

int [] array1 = MassNums(6);
Print(array1);
Console.WriteLine(SumOfOddNum(array1));
Console.WriteLine(SumOfOddNumV2(array1));