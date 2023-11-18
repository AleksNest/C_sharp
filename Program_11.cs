Console.WriteLine(" Задача 1.");
Console.WriteLine(" На вход подуются два числа n и m, такие, что n<m. Заполните массив случайными числами из промежутка [n, m].");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

int n = 2; int m =10; 

Random rnd = new Random();
int [] mass  = new int [rnd.Next(3, 15)];
Console.Write ("Массив из случайных чисел от " + n + " до " + m + ":  ");
PrintArray (FillArray(mass, n, m));


int [] FillArray(int [] array, int n, int m )                 // метод заполнения массива случайными  числами от n до m
{
    Random rand = new Random();
    for (int i= 0; i < array.Length; i++)
    {
        array [i] = rand.Next(n, m);
    }
    return array;

}

void PrintArray (int [] array)                                  // метод распечатки массива
{
    for (int i= 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
 Console.WriteLine();   
}

Console.ReadLine();

Console.WriteLine(" Задача 2.");
Console.WriteLine(" Двумерный массив заполнен случайными натуральными числами от 1 до 10. Найдите количество элементов, значение которых больше 5, и их сумму.");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

int NumMas=5;

int [,] mass1 = new int [rnd.Next(2,10), rnd.Next(2,10)];
FillArray2 (mass1, 10);
Console.WriteLine ("Двумерный исходный массив :");

PrintArray2 (FillArray2 (mass1, 10));
Zadacha2(mass1, NumMas);

int [,] FillArray2 (int [,] array, int range_rnd)                                   // метод заполнгения массива
{   
    Random rand = new Random();
    for (int i= 0; i < array.GetLength(0); i++)                    
    {
        for (int j= 0; j < array.GetLength (1); j++)            
        {
            array [i, j] =  rand.Next(1, range_rnd);                                             
        }
        
    }
    return array;
}
void PrintArray2 (int [,] array)                                // метод вывода массива
{
    for (int i= 0; i < array.GetLength(0); i++)
    {
        for (int j= 0; j < array.GetLength (1); j++)             
        {
           Console.Write (" {0}  ",  array [i, j]);
        }
        Console.WriteLine();
    }
}

void Zadacha2 (int [,] array, int NumMass)  
{
    int count = 0;
    int sum = 0;
    for (int i= 0; i < array.GetLength(0); i++)
    {
        for (int j= 0; j < array.GetLength (1); j++)             
        {
           if (array [i, j] > NumMass)
           {
               sum += array [i, j];
               count ++;
           }
           
        }
    }
Console.WriteLine("Кол элементов массива, которое больше " + NumMass + " = " + count);
Console.WriteLine("Сумма значенийц этих элементов массива:" + sum);
}        

Console.ReadLine();

Console.WriteLine(" Задача 3.");
Console.WriteLine(" Напишите рекурсивный метод, который принимает номер года и определяет, является ли он високосным или нет.");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

Console.WriteLine ("Введите год");
int year = Convert.ToInt32(Console.ReadLine());
Console.Write ("Год " + year);
LeapYear(year);

void LeapYear (int year)
{
    if (year == 0)
    {
        Console.WriteLine(" - високосный");
        return;
    }
    else if (year < 0)
        {
            Console.WriteLine(" - невисокосный");
            return;
        }
    LeapYear (year - 4);

}

// допы

Console.ReadLine();

Console.WriteLine(" Задача 1.");
Console.WriteLine(" Двумерная матрица заполнена натуральными числами. Найти тройку чисел, для которых площадь треугольника со сторонами,");
Console.WriteLine("определяемыми данной тройкой, будет максимальна.");

Console.WriteLine ("Двумерный массив :");
int [,] mass2 = new int [rnd.Next(2,10), rnd.Next(2,10)];

PrintArray2 (FillArray2 (mass2, 10000));
Console.WriteLine("");
//PrintArray2 (OrderedArray (mass2));
MaxAreaTriangle (ConvertionArray (( OrderedArray (mass2) )));

int [,] OrderedArray (int [,] array)                         // метод сортировки двумерного массива от макс к  мин
{
   
for (int l= 0; l < array.Length; l++)
{
    for (int i= 0; i < array.GetLength(0); i++)
    {
        if (i !=0)
        {
            if (array [i, 0] > array [i-1, array.GetLength(1)-1])
            {
                int temp = array [i, 0];
                array [i, 0] = array [i-1, array.GetLength(1)-1];
                 array [i-1, array.GetLength(1)-1] =  temp;
            }
        }
        for (int j= 0; j < array.GetLength (1)-1 ; j++)             
        {
            if (array [i, j+1] > array [i, j])
            {
                int temp = array [i, j+1];
                array [i, j+1] = array [i, j];
                array [i, j] =  temp;
            }
        }
    }
}
return array;
}

int [] ConvertionArray ( int [,]array)          // метод переноса  элементов массива  из двумерного в одномерный от макс к мин 
{
    int [] array1 = new int [array.Length];                   
    int k = 0;
    for (int i= 0; i < array.GetLength(0); i++)    
    {                
        for (int j= 0; j < array.GetLength (1)  ; j++)             
        {
            array1 [k] = array [i, j];
         //   Console.Write (array1 [k] +" ");
            k++;
        }
    } 
return array1;
}

void MaxAreaTriangle ( int [] array)                                   // метод определения по трем сторонам максимальной площади треугольника
{
for ( int i = 0; i < array.Length-3; i++)
    {
        for (int j = 0; j < array.Length-3; j++)
        {
            for (int m = 0; m < array.Length-3; m++)
            {
                if (array [i] + array [j+1] > array [m+2]  &&  array [j+1] + array [m+2] > array [i] &&  array [i] + array [m+2] > array [j+1] )
                {
                    Console.Write ("максимальная площадь треугольника при значениях:" + array [i] + " " + array [i+1] + " " + array [i+2] );
                    return;
                }
            }
        }
        
    }
}

Console.WriteLine("");
Console.WriteLine("");