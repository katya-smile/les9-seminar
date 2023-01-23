// ДЗ
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.WriteLine("Задайте значения N: ");
int num = Convert.ToInt32(Console.ReadLine());
int Nat(int num)
{
    if(num==1)
    {
        return 1;
    }
    Console.Write(num);
    return Nat(num-1);
}
int x =Nat(num);
Console.WriteLine(x);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Задайте значения m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задайте значения n: ");
int n = Convert.ToInt32(Console.ReadLine());
int Nat(int n, int m)
{
    if(n == m)
    {
        return m;
    }
    Console.Write(n);
    return num;
}
int x = Nat(n,m);
Console.WriteLine(x);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

System.Console.WriteLine("Задайте значения n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задайте значения m: ");
int m = Convert.ToInt32(Console.ReadLine());
int ack(int n, int m)
{
   if(n == 0)
   {
    return m + 1;
   }
    else if(m == 0)
   {
    return ack (n - 1, 1);
   }
return ack (n - 1, ack (n, m - 1)); 
}
int x = ack(n,m);
Console.WriteLine(x);