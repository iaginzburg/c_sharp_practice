// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.

void SecondMultipleFirst(int num1, int num2)
{
    if (num2 % num1 == 0)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine($"Второе число НЕкратно первому, остаток от деления {num2 % num1}");

    }
}

SecondMultipleFirst(5, 34);
SecondMultipleFirst(4, 16);