// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void SumOfDigits (int num){
int res = 0;
for (int temp  = num; temp != 0; temp /= 10){
    res += temp%10;
}
Console.WriteLine(res);
}

 SumOfDigits(452);
 SumOfDigits(82);
 SumOfDigits(9012);