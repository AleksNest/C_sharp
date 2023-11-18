Console.WriteLine(" Задача 34, 36-------------------------------------------------------------------------------------------------------- ");
Console.WriteLine(" Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. ");
Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

Console.WriteLine ("массив из случайных положительных  трехзначных чисел:");
int L = new Random().Next(1,10);
int [] array = new int [L];
FillArray(array);
PrintArray (array);
Console.WriteLine ("");
Console.WriteLine ("количество четных чисел в массиве = "+ PrintArrayEven (array)); Console.WriteLine ("");
Console.WriteLine ("сумма элементов на нечетных позициях = "+ PrintArraySumOddPos (array)); Console.WriteLine ("");

void FillArray(int [] array)                 // метод заполнения массива случайными трехзначными положит числами
{
    Random rand = new Random();
    for (int i= 0; i < array.Length; i++)
    {
        array [i] = rand.Next(100, 998);
    }
}

void PrintArray (int [] array)                // метод распечатки массива
{
    for (int i= 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
 Console.WriteLine();   
}

int PrintArrayEven (int [] array)          // метод подсчета кол четных значений в массиве
{
    int count = 0;
    for (int i= 0; i < array.Length; i++)
    {
       if (array[i] % 2 == 0) count++;
    }
 return count;   
}

int PrintArraySumOddPos (int [] array)    // метод вычисления суммы значений элементов массива на нечетных позициях
{
    int sum = 0;
    for (int i= 0; i < array.Length; i++)
    {
       if (i % 2 != 0) sum += array[i];
    }
 return sum;   
}




Console.WriteLine(" Задача 38-------------------------------------------------------------------------------------------------------- ");
Console.WriteLine(" Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. ");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

Console.WriteLine ("массив из случайных вещественных чисел:");
int m = new Random().Next(1,20);
double [] array1 = new double [m];
FillArrayD(array1);
PrintArrayD (array1);
Console.WriteLine ("");
MaxMinusMinArray (array1);


void FillArrayD (double [] array)                 //  метод заполнения массива случайными вещественными числами
{
    Random rand = new Random();
    for (int i= 0; i < array.Length; i++)
    {
        array [i] = Math.Round(rand.NextDouble() + rand.Next(-1000000, 1000000), 3);
    }
}

void PrintArrayD (double [] array)                       // метод распечатки массива
{
    for (int i= 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " | ");
    }
 Console.WriteLine();   
}

void MaxMinusMinArray (double [] array)                // метод нахождения разности максимального и минимального значений элементов массива
{
    double max = array[0];
    double min = array[0];
    int j = 0; int k = 0;
    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i] > max) 
            {
                max = array[i];
                j=i;
            }
        if (array[i] < min) 
            {
                min = array[i];
                k=i;
            }
    }   
   Console.WriteLine ("array["+j+"]  max = " + max+ ";  array["+k+"]  min = " + min);
   Console.WriteLine ("max - min = "+ (max - min)); Console.WriteLine ("");
}    



Console.WriteLine(" ДОПОЛНИТЕЛЬНЫЕ ЗАДАНИЯ");

Console.WriteLine(" ЗАДАЧА 2----------------------------------------------------------------------------------------------------------------------- ");
Console.WriteLine(" На вход подаются два числа случайной длины. Найдите произведение каждого разряда первого числа на каждый разряд второго. Ответ запишите в массив. 24, 132 -> {2, 6, 4, 4, 12, 8}");
Console.WriteLine(" ------------------------------------------------------------------------------------------------------------------------------- ");

Random rnd = new Random();
int L1 = rnd.Next(-1000,1000);                           // задание чисел
int L2 = rnd.Next(0-1000,1000);   

int L3 = KolNumber(L1)*KolNumber(L2);
int [] arrayL1L2 = new int [L3];
int [] arrayL1 = new int [KolNumber(L1)];             // задается размер массива с помощью метода определения кол цифр в числе
int [] arrayL2 = new int [KolNumber(L2)];
FillArrayN (arrayL1, L1);                             // заполнение массива цифрами из числа
FillArrayN (arrayL2, L2);
PrintArrayN(arrayL1);                                   // распечатка массива, состоящий из цифр числа
PrintArrayN(arrayL2);
ArrayL1L2 (arrayL1, arrayL2,arrayL1L2 );                 // задается массив с перемноженными элементами исходныъх двух массивов
Console.WriteLine(" массив с перемноженными элементами");
PrintArrayN(arrayL1L2);


void FillArrayN (int [] array, int L)                                  // метод заполнения массива цифрами из числа
{
    for (int i= array.Length-1; i>=0;  i--)
    {
        array [i] = L - L/10*10;
        L = L/10;
        
    }
}

void PrintArrayN (int [] array)                                   // метод распечатки массива
{
    for (int i= 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
 Console.WriteLine();   
}

int KolNumber (int L)                        // метод определения кол цифр в числе
{
int count = 0;
L=Math.Abs(L);
while (L >  0)
{
  L= L/10;

    count++;
}
return count;
}

void ArrayL1L2 (int[] arrayL1, int [] arrayL2, int [] arrayL1L2)                         // метод перемножения элементов массива, состоящих из цифр числа
{
    int k = 0;
    for (int i = 0; i < arrayL1.Length ; i++ )
    {
        for (int j = 0; j < arrayL2.Length; j++ )
        {
           arrayL1L2[k] = arrayL1[i] * arrayL2[j];
           k++;
        }
    }    
}

Console.WriteLine("");
Console.WriteLine(" ЗАДАЧА 1----------------------------------------------------------------------------------------------------------------------- ");
Console.WriteLine("  Задан массив из случайных цифр на 15 элементов. На вход подаётся трёхзначное натуральное число. Напишите программу, которая определяет, есть в массиве последовательность" );
Console.WriteLine("из трёх элементов, совпадающая с введённым числом. {0, 5, 6, 2, 7, 7, 8, 1, 1, 9} - 277 -> да  {4, 4, 3, 6, 7, 0, 8, 5, 1, 2} - 812 -> нет");
Console.WriteLine(" ------------------------------------------------------------------------------------------------------------------------------- ");

int numberH = rnd.Next(100,998);
Console.WriteLine(" на ввод подается трехзначное число:  " +numberH );
int [] arrayy = new int [15];
FillArrayy(arrayy);
PrintArrayy (arrayy);
Sequence (arrayy,numberH );              // поиск последовательности

void FillArrayy(int [] array)                 // метод заполнения массива случайными трехзначными положит числами
{
    Random rand = new Random();
    for (int i= 0; i < array.Length; i++)
    {
        array [i] = rand.Next(0, 9);
    }
}

void PrintArrayy (int [] array)                // метод распечатки массива
{
    for (int i= 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
 Console.WriteLine();   
}

async void Sequence (int [] array, int number)                 // метод определения есть в массиве последовательность из трех элементов
{
    int num = number/10;
    int a3 = number - num*10;
    int a2 = num - num/10*10;
    int a1 = num/10;
    int i=0;
    int f = 0;
    int L = array.Length;
    while  ( i < L)
    {
        if(array[i] == a1 && (L-i) >2  ) 
        {
            i++; 
            if (array[i] == a2)
            {
                i++;
               if (array[i] == a3) 
               {
                   f = 1;
               }
            }
        }
        i++;
    }
  if ( f!=1) Console.WriteLine("последовательность " + number + "   НЕТ в массиве");  
  else  Console.WriteLine("последовательность " + number + "  ЕСТЬ в массиве"); 
}
