// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.


int ProdNum (int num){
    int allProd = 1;
    for (int i = 1; i <= num; i++) allProd *= i;
    return allProd;
}

Console.WriteLine(ProdNum(7));
Console.WriteLine(ProdNum(4));