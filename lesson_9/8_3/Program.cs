// Задача 3: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int SumOfNums (int num){
    if (num == 0)  return 0;
    return SumOfNums(num/10) + num%10;
} 

Console.WriteLine(SumOfNums(453));
Console.WriteLine(SumOfNums(45));