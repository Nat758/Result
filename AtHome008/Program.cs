// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int res1 = num % 7;
int res2 = num %23;
if(res1==0 && res2==0)
{
    Console.WriteLine($"Кратно");
}  

else
{
    Console.WriteLine($"Не кратно, остаток от деления {res1} && {res2}");
}