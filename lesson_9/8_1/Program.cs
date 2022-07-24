// Задача 2: Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8" 

string NumbersRec (int a, int b){
    if (a < b){
        return ($"{a}, " + NumbersRec(a + 1, b)) ;
    }
    else return $"{b}";
}

void NumbersRecV2 (int num){
    if (num == 0)  return;
    NumbersRecV2(num-1);
    Console.Write($"{num},");
}

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumbersRec(1, N));
NumbersRecV2(N);
