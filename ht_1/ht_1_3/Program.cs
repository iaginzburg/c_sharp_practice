internal class Program3
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число");
        double num = double.Parse(Console.ReadLine());

        if (num % 1 != 0)
        {
            Console.WriteLine("введено не целое число");
        }
        else if (num%2 == 0){
                Console.WriteLine("это четное число");
                } else {
                Console.WriteLine("это нечетное число");
                }

    }
}