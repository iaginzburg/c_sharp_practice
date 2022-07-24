// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 


int GradeOfNum (int num, int grade){
    if (grade == 0 )  return 1;
    return GradeOfNum(num, grade-1)  *num;
}

Console.WriteLine(GradeOfNum(3, 5));
Console.WriteLine(GradeOfNum(2, 3));
Console.WriteLine(GradeOfNum(2, 0));