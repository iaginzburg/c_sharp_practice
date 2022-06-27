// Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры 
// нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int CheckQualityOfDigits_v2(int num)
{
    int numOfDigits = 1;
    int lowBorder = -10;
    int highBorder = 10;
    bool flg = true;
    while (true)
    {
        if (lowBorder < num && num < highBorder)
        {
            return numOfDigits;
        }
        else
        {
            lowBorder *= 10;
            highBorder *= 10;
            numOfDigits++;
        }
    }
    
    // if (-10 < num && num < 10) return 1;
    // if (-100 < num && num < 100) return 2;
    // if (-1000 < num && num < 1000) return 3;
    // if (-10000 < num && num < 10000) return 4;
    // if (-100000 < num && num < 100000) return 5; 
    return 0; 
}


Console.WriteLine("Введите число");
int num_int_1 = int.Parse(Console.ReadLine());

// Console.WriteLine(CheckQualityOfDigits_v2(num_int_1));

if (CheckQualityOfDigits_v2(num_int_1) < 3)
{
    Console.WriteLine("3-ей цифры нет");
}
else
{
    int digit3;
    int coefOfPositinonMarker = 1;
    int qualityOfDigits = CheckQualityOfDigits_v2(num_int_1);
    while (qualityOfDigits > 3)
    {
        coefOfPositinonMarker *= 10;
        qualityOfDigits -= 1;
    }
    digit3 = num_int_1 / coefOfPositinonMarker % 10;
     if (digit3 < 0) digit3 = digit3 * -1;
    Console.WriteLine("Третья цифра " + digit3);
}


// Console.WriteLine(num_int_1/10%10);