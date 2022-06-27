//newRandom().Next(10, 99)

int MaxDigitOfNum(int num)
{

if (num % 10 > num / 10)
    {
        return num % 10;
    }
    else
    {
        return num / 10;
    }

}

int num1 = new Random().Next(10, 100);
Console.WriteLine (num1);
Console.WriteLine(MaxDigitOfNum (num1));
// Console.WriteLine(MaxDigitOfNum (newRandom().Next(10, 100)));