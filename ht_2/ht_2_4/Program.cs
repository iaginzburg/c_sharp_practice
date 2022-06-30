Console.WriteLine("Введите день недели");
int dayOfweek = int.Parse(Console.ReadLine());

void CheckWeekend(int dayOfweek)
{
    if (dayOfweek > 7 || dayOfweek < 0)
    {
        Console.WriteLine("Ошибка. В неделе всего 7 дней! Введите цифру от 1 до 7.");
    }
    else if (dayOfweek == 6 || dayOfweek == 7)
    {
        Console.WriteLine("Это выходной");
    }
    else { Console.WriteLine("Это не выходной"); }
}


CheckWeekend(dayOfweek);