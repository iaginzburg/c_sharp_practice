// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


int SumOfNums (int M, int N){
    if (M > N)  return 0;
    return SumOfNums(M+1, N) + M;
} 

Console.WriteLine(SumOfNums(1, 15));
Console.WriteLine(SumOfNums(4, 8));