// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21




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
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}

// int[] ProductionOfPairsOfElements(int[] arr)
// {
//     int size;

//     if (arr.Length % 2 == 0)
//     {
//         size = arr.Length / 2;
//     }
//     else
//     {
//         size = arr.Length / 2 + 1;
//     }
//     int[] prodArr = new int[size];
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         prodArr[i] = arr[i] * arr[arr.Length - 1 - i];
//     }
//     if (arr.Length % 2 != 0) prodArr[prodArr.Length - 1] = arr[arr.Length / 2];
//     return prodArr;

// }

int[] ProductionOfPairsOfElements(int[] arr)
{
    int size = arr.Length/2 + arr.Length%2;

    int[] prodArr = new int[size];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        prodArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 != 0) prodArr[prodArr.Length - 1] = arr[arr.Length / 2];
    return prodArr;

}


int[] array1 = MassNums(10);
Print(array1);
Print(ProductionOfPairsOfElements(array1));

int[] array2 = MassNums(1);
Print(array2);
Print(ProductionOfPairsOfElements(array2));

int[] array3 = MassNums(3);
Print(array3);
Print(ProductionOfPairsOfElements(array3));

int[] array4 = MassNums(5);
Print(array4);
Print(ProductionOfPairsOfElements(array4));