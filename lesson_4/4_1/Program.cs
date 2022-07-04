int SumNum (int num){
    int allSum = 0;
    for (int i = 1; i <= num; i++) allSum += i;
    return allSum;
}

Console.WriteLine(SumNum(7));
Console.WriteLine(SumNum(4));