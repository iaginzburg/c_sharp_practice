// 4. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.



Console.WriteLine("Введите число");
int num_int_1 = int.Parse(Console.ReadLine());

void SecondMultipleFirst(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("Введенное число кратно 7 и 23");
    }
    else
    {
        Console.WriteLine("Введенное число НЕкратно 7 и 23");

    }
}

SecondMultipleFirst(num_int_1);