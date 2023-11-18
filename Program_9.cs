Console.WriteLine(" Задача 64.");
Console.WriteLine(" Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N. M = 1; N = 9. -> 3, 6, 9 M = 13; N = 20. ->  15, 18 ");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

Console.WriteLine("Задайте значения M и N");
int N = Convert.ToInt32 (Console.ReadLine());
int M = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Натуральные числа кратные трем:"); 
Recursion (N, M);
void Recursion (int n, int m)
{
    if (n > m) return;
    if (n % 3 == 0) Console.Write(n + " ");
    Recursion (n + 1, m);
}


Console.WriteLine("");
Console.WriteLine(" Задача 66.");
Console.WriteLine(" Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

Console.WriteLine("Задайте значения M и N");
int N1 = Convert.ToInt32 (Console.ReadLine());
int M1 = Convert.ToInt32 (Console.ReadLine());

int sum = 0;
Recursion1 (N1, M1);
int Recursion1 (int n, int m)
{
    if (n > m) return sum;
    sum = sum + n;
    Recursion1 (n + 1, m);
    return sum;
}
Console.WriteLine ("Сумма натуральных чисел от " + N1 + " до " + M1 + " = " + sum);



Console.ReadKey();
Console.WriteLine(" Задача 68.");
Console.WriteLine(" Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.  n = 2, m = 3 -> A(n,m) = 9");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

Console.Write("Введите число n: ");
ulong n = Convert.ToUInt64(Console.ReadLine());
Console.Write("Введите число m: ");
ulong m = Convert.ToUInt64(Console.ReadLine());

            
ulong A(ulong n, ulong m)
{
 if (n == 0) return m + 1;
 if (n != 0 && m == 0) return A(n - 1, 1);
 if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
return A(n,m);
}
            
Console.Write("Function A [" + n + ", " + m + "] = " + A(n, m));
