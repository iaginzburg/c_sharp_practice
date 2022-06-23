Console.WriteLine("Введите первое число");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число");
double num3 = double.Parse(Console.ReadLine());

if (num1 > num2) { 
    if (num1 > num3){
    Console.WriteLine("Наибольшее число");
    Console.WriteLine(num1);
    } 
    else {
    Console.WriteLine("Наибольшее число");
    Console.WriteLine(num3);
    }
}
else {
    if (num2 > num3){
    Console.WriteLine("Наибольшее число");
    Console.WriteLine(num2);
    } 
    else {
    Console.WriteLine("Наибольшее число");
    Console.WriteLine(num3);
    }
}
