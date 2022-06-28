//  Напишите программу, которая принимает на вход 
//  трёхзначное число и на выходе показывает вторую
//  цифру этого числа.
int rndnum = new Random(). Next(100, 1000);
Console.WriteLine($"Случайное число из 100, 999 => {rndnum}");
int RemSecDigit(int num)
{
    int secondDigit = (num % 100) / 10;
    return secondDigit;
}
int res = RemSecDigit(rndnum);
Console.WriteLine(res);