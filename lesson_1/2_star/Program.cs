
Console.WriteLine("Введите число");
double num = double.Parse(Console.ReadLine());

if (num == 0) { 
Console.WriteLine("Ноль не имеет обратного числа");
}
else {
   Console.Write("Обратное число ");
Console.WriteLine(1/num); 
}