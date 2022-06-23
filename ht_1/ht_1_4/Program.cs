Console.WriteLine("Введите число");
double num = double.Parse(Console.ReadLine());

if (num > 0) {     
double evenNum = 2;
while (evenNum <= num){
    Console.WriteLine(evenNum);
    evenNum += 2;
    }
} 
else {
double evenNum = 0;
while (evenNum >= num){
    Console.WriteLine(evenNum);
    evenNum -= 2;
    }
} 
          