//  Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

//________________________________________________________________________________

//РЕШЕНИЕ1 через / и %

// bool PalindromCheck5Digits (int fiveDigits){
//     if (fiveDigits/100000 != 0 || fiveDigits/10000 == 0) {
//        Console.WriteLine("Вы ввели не пятизначное число");
//        return false;
//     }
//     else{
//     bool flag = true;
//     int count = 0;
//     int devider = 10000;
//     int tempNum = fiveDigits;
//     while (count < 2) {
//         if (tempNum/devider == tempNum %10) 
//         {
//         tempNum = (tempNum - tempNum/devider*devider);
//         tempNum /=10;
//         devider /=100;
//         count++;
//         }
//         else {
//             flag = false; 
//             break;
//             }
//     }
//     return flag;
//     }
// }

// // Console.WriteLine(PalindromCheck5Digits(14212));
// // Console.WriteLine(PalindromCheck5Digits(23432));
// // Console.WriteLine(PalindromCheck5Digits(12821));

// Console.WriteLine("Введите пятизначное число, проверим является ли оно палиндромом:");
// Console.WriteLine(PalindromCheck5Digits(int.Parse(Console.ReadLine())));


//________________________________________________________________________________


// //РЕШЕНИЕ2 через преобразование в строку и индексы 

// //5 знаков: 2 пары + 1 цифра (2 итерации достаточно)
// //6 знаков: 3 пары
// //7 знаков: 3 пары + 1 цифра (3 итерации достаточно)
// //8 знаков: 4
// //9 знаков: 4 пары + 1 цифра


bool PalindromCheck(int number)
{

    string num = number.ToString();
    int count = 0;
    bool flag = true;
    while (count < num.Length / 2)
    {
        if (num[count] != num[^(count + 1)])
        {
            flag = false;
            break;
        }
        count++;
    }
    return flag;

}

Console.WriteLine("Введите число, проверим является ли оно палиндромом:");
int input = int.Parse(Console.ReadLine());
Console.WriteLine(PalindromCheck(input));









