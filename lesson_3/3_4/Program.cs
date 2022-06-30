// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


void Pow (int N){
    int num = 0;
while (num < N) {
    num += 1;
    Console.Write($"{Math.Pow(num, 2)} ");
}
Console.WriteLine(" ");
}

Pow (5);
Pow (2);
