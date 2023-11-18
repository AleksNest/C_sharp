
Console.WriteLine(" Задача 1.");
Console.WriteLine(" 1. Дано число n. Получите число, записанное в обратном порядке.345 >> 543");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

Random rnd = new Random();

int num = rnd.Next(0, 100000);
Console.WriteLine("числу = " + num);

Console.Write("сответстует обратное число = ");
Task1 (num);

void Task1 (int num, int result = 0)
{
    if (num == 0)
    {
        Console.Write (result );
        return;
    }
    result = result * 10 +  num % 10;
    num = num / 10;
    Task1 (num, result);
   
}

Console.ReadLine();

Console.WriteLine(" Задача 2.");
Console.WriteLine(" Дана монотонная последовательность, в которой каждое натуральное число n встречается ровно n раз: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... ");
Console.WriteLine(" Дано число m. Выведите первые m членов этой последовательности- m = 5 >> 1, 2, 2, 3, 3");
Console.WriteLine("");

int m = rnd.Next(1, 15);
Console.WriteLine(" последовательность из m = " + m + ":");
Task2 (m);

void  Task2 (int count, int currentNum = 1, int countNum = 0 )
{
    if ( count == 0) return;
    count --;  countNum ++;
    
    if( countNum > currentNum)
    {
        currentNum++; 
        countNum = 1;
    }
    Console.Write (currentNum + "\t");
    Task2 (count, currentNum, countNum);
}



Console.ReadLine();

Console.WriteLine(" Задача 3.");
Console.WriteLine(" Дано натуральное число n > 1. Вывести все простые множители данного числа. ");
Console.WriteLine(" 10 >> 5, 2.");
Console.WriteLine("");

int number = rnd.Next(1, 100);
Console.WriteLine ("простые множители числа " + number + ":");
Task3(number);

void Task3 (int  currentNumber, int del = 1)
{
    if (currentNumber == 1) return;
    del++;
    if (currentNumber % del  == 0) 
    {
        Console.Write (del + "\t");
        currentNumber /= del;
        del = 1;
    }    
    Task3 (currentNumber, del); 

}


// ДОПЫ


Console.ReadLine();

Console.WriteLine(" Задача доп 1.");
Console.WriteLine(" Даны два числа a, b. Сложите их, используя только операции инкремента и декремента.. ");
Console.WriteLine("");

int n1 = rnd.Next(1, 1000);
int n2 = rnd.Next(1, 1000);
Console.Write ("Сумма натуральных чисел " + n1 + " и " + n2 + " = ");

Task4(n1, n2);

void Task4 (int  n1, int n2, int count1 = 0)
{
    
    if (n2 == 0) 
    {
        Console.WriteLine (count1); 
        return;
    }
    if (n1 != 0)
    {
        count1 ++;
        n1 --;
    }
    else 
    {
        count1 ++;
        n2--;
    }

    Task4 (n1, n2, count1); 

}




Console.ReadLine();

Console.WriteLine(" Задача доп 2.");
Console.WriteLine(" Дана последовательность натуральных чисел. Определите значение второго по величине элемента в этой последовательности");
Console.WriteLine("{1, 2, 3, 4, 5} >> 4");

Console.WriteLine("");

int [] mass = new int [rnd.Next(5,15)];
int secondMax = mass [0];
int firstMax = mass [0];
int j1 = mass.Length;
int j2 = 0;
Console.WriteLine("Массив из натуральных чисел :");
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rnd.Next(1,1000);
    Console.Write(mass[i] + " \t");
    
    if (mass [i] > firstMax ) 
    {
        firstMax = mass [i] ;
         j1=i;
    }
}
 for ( int i = 0; i < mass.Length; i++)
{   
    if (mass [i] > secondMax & i != j1)
       {
        secondMax = mass [i] ;
        j2=i;
       }
}
Console.WriteLine();
Console.WriteLine("Второй по величине элемент массива mass[" + j2 + "] = " + secondMax);





Console.ReadLine();

Console.WriteLine(" Задача доп 3.");
Console.WriteLine(" Дан массив, состоящий из случайных целых чисел. Дано число M. Выведите случайное подмножество массива, ");
Console.WriteLine (" сумма элементов в котором не превосходит M.  {11, 52, 36, 8, 19}, M = 50 >> 11, 19, 8");
Console.WriteLine();

int [] mass1 = new int [rnd.Next(5,6)];
int [] arr = new int [mass1.Length];
int M = 15;

Console.WriteLine("Массив из натуральных чисел :");

for (int i = 0; i < mass1.Length; i++)
{
    mass1[i] = rnd.Next(1,10);
    Console.Write(mass1[i] + " \t");
        
}

Console.WriteLine();
Console.WriteLine("Не превышает M = " + M + " сумма следующих элементов массива:");
GetRandomArr(arr); 
int sum = 0;

for (int i = 0; i < mass1.Length; i++)                                           //  вывод элементов массива удовлетворяющих условию <= M
{
   sum += mass1 [arr[i]];
  if (sum <= M)
  {
   Console.Write ("mass [" + arr[i] + "] = "+ mass1 [arr[i]] + "  ");
  }
}
  Console.WriteLine();   
                   
 void GetRandomArr(int[] arr )                                          // метод генерации случайных неповторяющихся чисел
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                var num = random.Next(1, arr.Length + 1);
 
                if (arr.Contains(num))
                {
                    i--;
                }
                else
                {
                    arr[i] = num;
                }
            }
           for (int i = 0; i < arr.Length; i++) 
           arr[i] = arr[i] - 1;
        }

