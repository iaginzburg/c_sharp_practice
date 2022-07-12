// Задача 3: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// int Fibonacci (int n){
// if (n == 1) return 1;
// if (n == 2) return 1;
// return Fibonacci(n-1) + Fibonacci (n-2);
// }

// for (int i = 1; i < 10; i++){
// Console.WriteLine($"{i} - {Fibonacci(i)}");
// }


void Fibonacci (int number){
    int num1 = 0;
    int num2 = 1;
    
    for (int i = 0; i < number; i++){
        Console.Write ($"{num1} ");
        (num1, num2) = (num2, num1+num2);
    }

}

Fibonacci(7);