// Задача 3: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных. Значения элементов массива 0..9

// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза


void PrintDoubleArray(double[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");

        }
        Console.WriteLine();
    }
}

double[,] FillArrayFunc(int m, int n)
{
    double[,] resultArray = new double[m, n];

    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n; j++)
        {
            resultArray[i, j] = Math.Round(new Random().NextDouble() * (10 + 0) - 0, 0);
        }
    }

    return resultArray;
}

void  CountQuantityOfNums (double[,] matr)              //метод выполненный перебором
{
    int[] quantity = new int [10];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j]==0) quantity[0] +=1;
            if (matr[i,j]==1) quantity[1] +=1;
            if (matr[i,j]==2) quantity[2] +=1;
            if (matr[i,j]==3) quantity[3] +=1;
            if (matr[i,j]==4) quantity[4] +=1;
            if (matr[i,j]==5) quantity[5] +=1;
            if (matr[i,j]==6) quantity[6] +=1;
            if (matr[i,j]==7) quantity[7] +=1;
            if (matr[i,j]==8) quantity[8] +=1;
            if (matr[i,j]==9) quantity[9] +=1;
        }
    }

    for (int i = 0; i < quantity.GetLength(0); i++){
        Console.WriteLine($"{i} встречается {quantity[i]} раз");
    }

    
}



double[,] massiv = FillArrayFunc(3, 4);
PrintDoubleArray(massiv);
Console.WriteLine();
CountQuantityOfNums(massiv);                     



double [] Vocabulary(double [,] arr)            //метод с использованием конструкции foreach
{
    double [] array = new double [10];
    foreach (int item in arr) array[item]++;
    return array;
}

void PrintVocabulary(double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
      
        Console.Write($"{i} - {arr[i]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}




Console.WriteLine();
PrintVocabulary(Vocabulary(massiv));





