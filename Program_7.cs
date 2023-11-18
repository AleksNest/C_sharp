
Console.WriteLine(" Задача 47------------------------------------------------------------------------------------------------------- ");
Console.WriteLine(" Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

int rows = 3;
int columns = 4;
double [,] array = new double [rows, columns];

FillArray ();
PrintArray ();

void FillArray ()
{
    Random rand = new Random();
    for (int i= 0; i < rows; i++)                    
    {
        for (int j= 0; j < columns; j++)            
        {
            array [i, j] = Math.Round((rand.NextDouble() * rand.Next(-10000, 9999)),1);
        }
        
    }
}
void PrintArray ()
{
    for (int i= 0; i < rows; i++)
    {
        for (int j= 0; j < columns; j++)             
        {
           Console.Write (" {0}  ",  array [i, j]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
Console.ReadLine();

Console.WriteLine(" Задача 50, 52------------------------------------------------------------------------------------------------------ ");
Console.WriteLine(" Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет..");
Console.WriteLine(" Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");


Console.WriteLine ("введите позицию элеиента двумерного массива i:");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите позицию элеиента двумерного массива j:");
int j = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int row = rnd.Next(2, 5);
int column = rnd.Next(2, 5);
int [,] arr = new int [row,column];
FillArr ();
PrintArr ();
ValueArr (i, j, arr);
Console.WriteLine ("");
PrintArr ();
Console.WriteLine ("");
AverValueColumnsArr ();



void ValueArr (int i, int j, int [,] arr )
{
 if ( i >= arr.GetLength (0) || j >= arr.GetLength(1)) 
 {
    Console.WriteLine ($"элемента под индексом [{i}, {j}] не существует в данном массиве");
 }    
 else
 {
      Console.WriteLine ($"значение элемента под индексом [{i}, {j}]  = {arr[i,j]}");
 }
}


void FillArr ()
{
    Random rand = new Random();
    for (int i= 0; i < row; i++)                    
    {
        for (int j= 0; j < column; j++)            
        {
            arr [i, j] =  rand.Next(1, 99);
        }
        
    }
}
void PrintArr ()
{
    for (int i= 0; i < row; i++)
    {
        for (int j= 0; j < column; j++)             
        {
           Console.Write (" {0}  ",  arr [i, j]);
        }
        Console.WriteLine();
    }
}

void AverValueColumnsArr ()
{
    double sr = 0;
    Console.WriteLine ("Среднеарифмитическое столбцов:");
    for (int j= 0; j < column; j++)                    
    { 
        double sum = 0;
        for (int i= 0; i < row; i++)            
        {
            sum +=  arr [i, j];
        }
    sr = sum/row;
    Console.Write ( sr + "  ");
    }
}


Console.WriteLine();
Console.ReadLine();



// ДОПНИКИ

Console.WriteLine(" Задача 1----------------------------------------------------------------------------------------------------- ");
Console.WriteLine("  Даны две матрицы, количество строк и столбцов которых может быть 3 или 4, заполнены числами от -9 до 9. Выполните умножение матриц.");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

Random rnd1 = new Random();
int row1 = rnd1.Next(3, 4);
int column1 = rnd1.Next(3, 4);
int [,] arr1 = new int [row1,column1];
int row2= rnd1.Next(3, 4);
int column2 = rnd1.Next(3, 4);
int [,] arr2 = new int [row2,column2]; 

FillArr1 (arr1);
FillArr1 (arr2);
Console.WriteLine("Матрица А");
PrintArr1 (arr1);
Console.WriteLine("Матрица B");
PrintArr1 (arr2);
Console.WriteLine("Матрица С = А * В :");
Multiplication (arr1, arr2);
PrintArr1 (Multiplication(arr1, arr2));


int[,] Multiplication(int[,] a, int[,] b)                            // метод перемножения матриц
{
        
    if (a.GetLength(1) != b.GetLength(0)) 
    {
      if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");  // принудительная генерация исключения 
    }
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i,j] += a[i,k] * b[k,j];
            }
        }
    }
            return r;
}
 void PrintArr1(int[,] c)                                             // метод вывода массива
        {
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write("{0} ", c[i, j]);
                }
                Console.WriteLine();
            }
        }
    


void FillArr1 (int [,] array)                                           // метод запорлнения массива
{ 
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    Random rand = new Random();
    for (int i= 0; i < row; i++)                    
    {
        for (int j= 0; j < column; j++)            
        {
            array [i, j] =  rand.Next(-9, 8);
        }
        
    }
}


Console.WriteLine();
Console.ReadLine();


Console.WriteLine(" Задача 2----------------------------------------------------------------------------------------------------- ");
Console.WriteLine("  Двумерный массив размером 3х4 заполнен числами от 100 до 9999. Найдите в этом массиве и сохраните в одномерный массив все числа, сумма цифр которых больше их произведения. Выведите оба массива..");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

int [,] arrayy = new int [3,4];
FillArrayy ();
Console.WriteLine("Двумернвый массив");
PrintArrayy ();
Console.WriteLine("Одномерный массив по учловию задачи");
NumberArray ();

void FillArrayy ()                                  // метод заполнения двумерного массива
{ 
    int row = arrayy.GetLength(0);
    int column = arrayy.GetLength(1);
    Random rand = new Random();
    for (int i= 0; i < row; i++)                    
    {
        for (int j= 0; j < column; j++)            
        {
            arrayy [i, j] =  rand.Next(100, 9998);
        }
        
    }
}

int CountNumArray (int Number)                      // метод определяет больше ли сумма цифр или произведение цифр элемента массива
{
   int MultCount = 1; 
   int SumCount = 0; 
   int num = 0; 
   while (Number > 0 )
   {
     num =  Number - Number/10*10;
     Number = Number/10;
     SumCount += num;
    MultCount *= num;
    }
  if (SumCount > MultCount ) return 1;  
  else return 0;
}

void NumberArray ()                                 // метод  перевода элементов двумерного массива по условию задачи в одномерный
{
    int row = arrayy.GetLength(0);
    int column = arrayy.GetLength(1);
    int count = 0;
    int m = 0;
    for (int i= 0; i < row; i++)
    {
         for (int j= 0; j < column; j++)     
        {
          if (CountNumArray (arrayy[i, j]) == 1 ) count++;
        }
    }
    if (count != 0) 
    {
        int [] array = new int [count];  

        for (int i= 0; i < row; i++)
        {
           for (int j= 0; j < column; j++)     
           {
                if (CountNumArray (arrayy[i, j]) == 1 ) 
               {
               array [m] = arrayy[i, j] ;
               Console.Write(array [m] + "  " );
               m++;
               }
           }
        }
    }
    else Console.WriteLine (" ни один из элементов массива не удовлетворил условию задачи");
}


void PrintArrayy ()                                 // мсетод вывода массива
{
    int row = arrayy.GetLength(0);
    int column = arrayy.GetLength(1);
    for (int i= 0; i < row; i++)
    {
         for (int j= 0; j < column; j++)             
        {
           Console.Write (" {0}  ",  arrayy [i, j]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine();




