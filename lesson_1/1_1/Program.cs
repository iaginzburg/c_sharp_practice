//Это задача номер 0, на вывод квадрата введенного числа
//Развернутое решение
/*
string num_str = Console.ReadLine();
int num_int = int.Parse(num_str);
Console.WriteLine(num_int*num_int);
*/
//Оптимизированное по коду решение
/*
int num_int = int.Parse(Console.ReadLine());
Console.WriteLine(num_int*num_int);
*/



//Это задача номер 1

Console.WriteLine("Введите первое число");
int num_int_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num_int_2 = int.Parse(Console.ReadLine());

if (num_int_1*num_int_1 == num_int_2){
    Console.WriteLine("Второе число является квадратом первого");
}
else{
    Console.WriteLine("Второе число НЕ является квадратом второго");
}