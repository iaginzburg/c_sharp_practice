// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int[] MassNumsFromConsole (int size)
{       
    
    int[] arr = new int[size];

    Console.WriteLine("Введите числа: ");

    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());        
    }    
    return arr;
}

int CountQuantityOfPositiveNumsInCollection (int[] coll)
{
    int quality = 0;
    for (int i = 0; i < coll.Length; i++)
    {
        if ( coll[i] > 0 ) quality++;
    }
    return quality;
}


Console.Write("Введите количество чисел которое будем введено: ");
int quantityOfNums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введенное количество положительных чисел - {CountQuantityOfPositiveNumsInCollection(MassNumsFromConsole(quantityOfNums))}");