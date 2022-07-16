//  Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateArray(int size)
{
    int[] userArray= new int[size];
    for(int i= 0; i<userArray.Length;i++)
    {
        Console.WriteLine($"Введите {i} число в массив: ");
        userArray[i]=Convert.ToInt32(Console.ReadLine());
    }
    return userArray;
}
void PrintArray(int[] arr)
{
    for(int i=0; i<arr.Length;i++)
    {
        if(i==0) Console.Write("[");
        if(i<arr.Length-1)Console.Write(arr[i]+",");
        else Console.Write(arr[i]+"]");
    }
}

void NegNumber(int[] neg)
{
    int count = 0;
    for(var i= 0; i<neg.Length;i++)
    {
        if(neg[i]>0)
        {
            count++;
        }
    }
    Console.WriteLine($"Колличество положительных {count}");
}
int[] arr = CreateArray(5);
NegNumber(arr);
PrintArray(arr);
