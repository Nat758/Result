// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да


Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
string Palindrom(int digit)
{
    string answer = "";
     int a = digit / 10000; 
     int b = digit % 10;
     int c = (digit / 1000) % 10;
     int d = (digit % 100) / 10;
     if (a == b && c == d)
     {
        answer= "Да";
     }
     else
     {
        answer="Нет";
     }
    return answer;
}    
Console.WriteLine(Palindrom(num));




