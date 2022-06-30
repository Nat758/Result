
// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
string N = (Console.ReadLine());
int numLength = N.Length;
int num = Convert.ToInt32(N);
if(num<100)
{
Console.WriteLine("Третьей цифры нет:");
}
else if(num>100 && num<1000)
{
    Console.WriteLine(num%10);
}
else if (num>=1000)
{
    
    num = num % (int)Math.Pow(10,numLength-1);   
    num = num % (int)Math.Pow(10,numLength-2);   
    num = num / (int)Math.Pow(10,numLength-3);
   Console.WriteLine (num);
}
