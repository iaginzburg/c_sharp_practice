Console.WriteLine("Введите первое число");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
double num2 = double.Parse(Console.ReadLine());

if (num1 >= num2) { 
if (num1 == num2){
    Console.WriteLine("Числа равны");
    } 
    else {
       Console.WriteLine("Первое число больше второго");
    }
}
else {
   Console.WriteLine("Первое число меньше второго");
}