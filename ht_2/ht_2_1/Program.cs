// Задача 1: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1



int CheckQualityOfDigits1_5(int num)
{
    if (-10 < num && num < 10) return 1;
    if (-100 < num && num < 100) return 2;
    if (-1000 < num && num < 1000) return 3;
    if (-10000 < num && num < 10000) return 4;
    if (-100000 < num && num < 100000) return 5;
    return 0;
}

Console.WriteLine("Введите число");
int num_int_1 = int.Parse(Console.ReadLine());

// Console.WriteLine(CheckQualityOfDigits1_5(num_int_1));

// Console.WriteLine(num_int_1/100);
// Console.WriteLine(num_int_1%10);
// Console.WriteLine(num_int_1/10%10);

if (CheckQualityOfDigits1_5(num_int_1) == 3)
{
    int modOfnum;
    if (num_int_1 < 0)
    {
        modOfnum = num_int_1 * -1;
    }
    else
    {
        modOfnum = num_int_1;
    }
    Console.WriteLine($"Вторая цифра введенного числа {modOfnum / 10 % 10}");

}
else
{
    Console.WriteLine("Введенное число не трехзначное");
}