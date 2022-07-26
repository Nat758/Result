// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29


Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int fuctionAckerman = Aсkerman(m,n);
Console.Write($"{fuctionAckerman } ");

int Aсkerman(int m,int n)
{
  if (m == 0) return n + 1;
  else if (n == 0 && m>0) return Aсkerman (m - 1, 1);
  else if(n>0 &&m>0) return Aсkerman(m - 1, Aсkerman(m, n - 1));
  else return n+1;
}

