// Задача 1: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон


bool Triangle (int num1, int num2, int num3){
    if (num1+num2 > num3 && num2+num3 > num1 && num3+num1 > num2) return true;
    return false;
}

Console.WriteLine(Triangle(1,2,3));
Console.WriteLine(Triangle(2,2,3));

