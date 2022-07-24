// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"



void EvenNumRec (int M, int N){
    if (N%2 != 0) N -= 1;
    if (M > N)  return;
    EvenNumRec (M, N-2);
    Console.Write($"{N}, ");
}


Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());


EvenNumRec(M,N);