// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125

void Pow3 (int N){
    int num = 0;
while (num < N) {
    num += 1;
    Console.Write($"{Math.Pow(num, 3)} ");
}
Console.WriteLine(" ");
}

Pow3 (3);
Pow3 (5);