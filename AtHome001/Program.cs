Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
int max = num1;
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 > max) ;
{
    max = num2;
}
Console.WriteLine("Введите третье число:");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num3 > max) ;
{
    max = num3;
}
Console.Write("max = ");
Console.Write(max);
