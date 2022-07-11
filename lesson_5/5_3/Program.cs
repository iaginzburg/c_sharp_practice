// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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
        arr[i] = new Random().Next(-9, 10);        
    }    
    return arr;
}

bool FindNum (int num, int[] arr)
{
    bool flag = false;
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        if (arr[i] == num) {
            flag = true; 
            break;
            }
    }

    return flag;
}

int [] array1 = MassNums(12);
Print(array1);
Console.WriteLine(FindNum(1, array1));
Console.WriteLine(FindNum(2, array1));
Console.WriteLine(FindNum(3, array1));
Console.WriteLine(FindNum(4, array1));
Console.WriteLine(FindNum(5, array1));
Console.WriteLine(FindNum(6, array1));
Console.WriteLine(FindNum(7, array1));
Console.WriteLine(FindNum(8, array1));
Console.WriteLine(FindNum(9, array1));
Console.WriteLine(FindNum(-1, array1));
Console.WriteLine(FindNum(-2, array1));
Console.WriteLine(FindNum(-3, array1));
Console.WriteLine(FindNum(-4, array1));
Console.WriteLine(FindNum(-5, array1));
Console.WriteLine(FindNum(-6, array1));
Console.WriteLine(FindNum(-7, array1));
Console.WriteLine(FindNum(-8, array1));
Console.WriteLine(FindNum(-9, array1));

