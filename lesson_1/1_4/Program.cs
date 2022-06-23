int N = int.Parse(Console.ReadLine());


if (N < 0) { N = -N;}

int negativeN = -N;

while (negativeN<N+1) 
{ 
Console.WriteLine(negativeN);
negativeN+=1;
}