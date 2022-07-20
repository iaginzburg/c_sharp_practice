// Задача 4: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


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

double[,]  DeleteLineColomnOfMinElement (double[,] matr)
{
    int indexOfLine = 0;
    int indexOfColomn = 0;

    for (int i = 0; i < matr.GetLength(0); i++)                     //ищем индексы наименьшего элемента
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if ( matr[i,j] < matr[indexOfLine, indexOfColomn]) {
                indexOfLine = i;
                indexOfColomn = j;
            }
        }
    }
    
    double[,] resultArray = new double[matr.GetLength(0)-1, matr.GetLength(1)-1]; //создаем итоговый массив и заполняем его
                                                                                    
        int ires = -1;                              
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int jres = -1;
        if (i != indexOfLine) {
            ires++;
            for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j != indexOfColomn){
            jres++;
            resultArray[ires, jres] = matr[i, j];
            } 
        }

        
        }
    }

    return resultArray;
}


double[,] massiv = FillArrayFunc(4, 4);
PrintDoubleArray(massiv);
Console.WriteLine();
PrintDoubleArray(DeleteLineColomnOfMinElement(massiv));
// Console.WriteLine();
// PrintDoubleArray(DeleteLineColomnOfMinElement(DeleteLineColomnOfMinElement(massiv)));
// Console.WriteLine();
// PrintDoubleArray(DeleteLineColomnOfMinElement(DeleteLineColomnOfMinElement(DeleteLineColomnOfMinElement(massiv))));