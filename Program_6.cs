
Console.WriteLine(" Задача 41-------------------------------------------------------------------------------------------------------- ");
Console.WriteLine(" Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. ");
Console.WriteLine("0, 7, 8, -2, -2 -> 2");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

Console.WriteLine ("введите кол чисел:");
int m = Convert.ToInt32(Console.ReadLine());
int [] array = new int [m];
FillArray (array);
PrintArray (array);
ZeroArray ( array);

void FillArray ( int[] array)                 //  метод заполнения массива случайными целыми числами
{
    Random rand = new Random();
    for (int i= 0; i < array.Length; i++)
    {
        array [i] = rand.Next(-1000, 999);
    }
}

void PrintArray (int [] array)                       // метод распечатки массива
{
    for (int i= 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " | ");
    }
 Console.WriteLine();   
}

void ZeroArray (int [] array)
{
    int count = 0;
    for (int i= 0; i < m; i++)
    {
        if (array [i] > 0 )  count++;
    }
    Console.WriteLine ("Количество чисел > 0 = "+ count);
}

Console.WriteLine("");
Console.WriteLine(" Задача 43------------------------------------------------------------------------------------------------------- ");
Console.WriteLine(" Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. ");
Console.WriteLine("1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

Console.WriteLine ("введите k1:  ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("введите b1:  ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("введите k2:  ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("введите b2:  ");
double b2= Convert.ToDouble(Console.ReadLine());

PointIntersection (k1, b1, k2,  b2);

void PointIntersection(double k1, double b1,double k2, double b2)     // метод нахождения точки пересечения прямых
{
    if (k1 == k2) 
    Console.WriteLine ("графики не пересекаются");
    else
    {
        double x = (b2 - b1) / (k1 - k2) ;
        double y = k1 * x + b1;
        Console.WriteLine ("точка пересечения: [" + x + "; " + y + "]");
    }
}


// ДОПНИКИ

Console.WriteLine("");
Console.WriteLine(" Задача 1------------------------------------------------------------------------------------------------------- ");
Console.WriteLine(" Написать перевод десятичного числа в двоичное, используя рекурсию. ");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");


Console.WriteLine("Введите десятичное число ");
int number = Convert.ToInt32(Console.ReadLine());
string Dvcod (int number)                                       // метод перевода десятичного числа в двоичный
{
    string s = "";
    while (number >= 1)
    {
      string DvFigura1 = s;
      DvFigura1 = Convert.ToString(number % 2);
      return    Dvcod (number / 2)+ DvFigura1;
    }      
    return "";
}
Dvcod (number);
Console.WriteLine ("десятичное число " + number + " = двоичному числу " + Dvcod (number) );


Console.WriteLine("");
Console.WriteLine(" Задача 2------------------------------------------------------------------------------------------------------- ");
Console.WriteLine(" На вход подаётся текст, например поговорка “без труда не выловишь и рыбку из пруда”. Используя рекурсию, подсчитайте, сколько в поговорке гласных букв");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

string str = "без труда не выловишь и рыбку из пруда";
int pos = 0;

int SearchSymbol (string str, int pos = 0) 
{
char[] glasnie = new char[20] { 'а', 'о', 'и', 'е','ё','э','ы','у','ю','я','А','О','И','Е','Ё','Э','Ы','У','Ю','Я' };
            
            
            int count = 0;
               if (pos < str.Length)
            {            
                for (int j = 0; j < glasnie.Length; j++)
                {
                    if (glasnie[j] == str[pos]) { count++; }
                }
                pos ++;
                return count + SearchSymbol (str, pos);
            }
            else return 0;
            
}

Console.WriteLine("Количество гласных букв в тексте: " + str + " = " +  SearchSymbol (str));



