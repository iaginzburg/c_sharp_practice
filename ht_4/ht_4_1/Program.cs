// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

void Pow (int num, int pow){
    int result = num;
    for (int i = 1; i < pow; i++){
        result *= num;
    }
    Console.WriteLine(result);
}

Pow(2,2);
Pow(2,3);
Pow(2,4);
Pow(3,2);
Pow(3,3);