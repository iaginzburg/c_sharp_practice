
Console.WriteLine("Введите номер дня недели");
int day_of_week = int.Parse(Console.ReadLine());

if (day_of_week == 1 )
{
  Console.WriteLine("Понедельник");  
}
else if (day_of_week == 2 )
    {
    Console.WriteLine("Вторник");  
    }
    else if (day_of_week == 3 )
        {
        Console.WriteLine("Среда");  
        }
        else if (day_of_week == 4 )
            {
            Console.WriteLine("Четверг");
            }
            else if (day_of_week == 5 )
                 {
                Console.WriteLine("Пятница");
                }
                else if (day_of_week == 6 )
                    {
                    Console.WriteLine("Суббота");
                    }
                    else if (day_of_week == 7 )
                        {
                        Console.WriteLine("Воскресение");
                        }
                        else {
                            Console.WriteLine("Введен некорректный номер дня недели");
                        }


