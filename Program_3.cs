

Console.WriteLine(" --------------------------------------------------------------------------------------------- ");
Console.WriteLine(" Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. ");
Console.WriteLine(" --------------------------------------------------------------------------------------------- ");

Random rnd = new Random();
int N = rnd.Next (1,20);
Console.WriteLine ("_________________________________");
Console.WriteLine ("Таблица кубов чисел");
Console.WriteLine ("_________________________________");
Console.WriteLine ("");
Console.WriteLine ("N = " + N);
Console.WriteLine ("");
for (int i= 1; i<= N; i++)
{
    string text = "--------+--------\n";
    text = text + "|  "+i+"\t|  "+ i*i*i + "\t|";
    Console.WriteLine (text);
}    




Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");
Console.WriteLine(" Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------- ");

int aX = rnd.Next (-5, 5);
int aY = rnd.Next (-5, 5);
int aZ = rnd.Next (-5, 5);
int bX = rnd.Next (-5, 5);
int bY = rnd.Next (-5, 5);
int bZ = rnd.Next (-5, 5);

// формула длина отрезка 3D = SQRT((aX-bX)^2 + (aY-bY)^2 + (aZ-bZ)^2 )
Console.WriteLine ("т. А -  [" + aX + ", " + aY + ", " + aZ + "]");
Console.WriteLine ("т. B -  [" + bX + ", " + bY + ", " + bZ + "]");
Console.WriteLine ("длина отрезка AB в 3D = " + Math.Sqrt((aX-bX)*(aX-bX)+(aY-bY)*(aY-bY)+(aZ-bZ)*(aZ-bZ)));


Console.WriteLine(" ---------------------вариант с числовым форматом-------------------------------------------------------- ");
Console.WriteLine(" Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine(" -------------------------------------------------------------------------------------------------------- ");

int number = Convert.ToInt32(Console.ReadLine());

int Perenert (int number1)                // метод для переворачивания целого числа
{
int i = number1;
if (i<0) number1=-1*number1; 
int number2 = 0;
while (number1 > 0)
{
    int digit = number1 % 10;            // находим остаток - последнюю цифру исходного числа
    number1 = number1 / 10;              // удаляем последнюю цифру исходного числа (уменьшаем разрядность)
    number2 = number2 * 10;              // формируем новое  второе число (увеличиваем разрядность)
    number2 = number2 + digit;           // добавляем цифру в разряд втрого числа
}
    if (i<0) return number2=-1*number2;
    return number2;
}

int number2 = Perenert (number);
if(number == number2) Console.WriteLine("число:  "+ number+ "  - является палиндромом");
else  Console.WriteLine("число:  "+ number+ "  - не является палиндромом");


Console.WriteLine(" ---------------------вариант с форматом строка (более универсальный)------------------------------------ ");
Console.WriteLine(" Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine(" -------------------------------------------------------------------------------------------------------- ");
Console.WriteLine("Введите данные");

string str = Console.ReadLine();

void Perenert1 (string str1)                // метод для переворачивания целого числа
{
int L=str1.Length;
char[] str1_C = str1.ToCharArray();
char[] str2_C = new char [L];
int i2 = L;
for (int i1 = 0; i1 < L; i1++)
{
    i2 = i2 - 1;
    str2_C[i2] = str1_C[i1];
    //Console.WriteLine("str_C["+i1+"] = " + str1[i1] + "    str_C["+i2+"] = " + str2_C[i2]);
}
int count = 0;
for (int i3 = 0; i3 < L; i3++)
{ if(str2_C[i3] == str1_C[i3])  count++; }

//str2_C[i2] = str1_C[i1];
//i2 = i2--;
//Console.WriteLine("число:  "+ str1_C[i1] + str2_C[i2]);
//}
if(count == L) Console.WriteLine("запись:  "+ str1 + "  - является палиндромом");
else  Console.WriteLine("запись:  "+ str1 + "  - не является палиндромом");
}

Perenert1 (str);  

Console.WriteLine(" ---------------------вариант с форматом строка (более универсальный)------------------------------------ ");
Console.WriteLine(" Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine(" -------------------------------------------------------------------------------------------------------- ");
Console.WriteLine("Введите данные");
string num1 = Console.ReadLine();
Palindrom (num1);
void  Palindrom(string num)
{
if (num[0] == num[4] && num [1] == num [3])
{
    Console.WriteLine ($"число {num}является полиндромом");
}
    else
{
   Console.WriteLine ($"число {num} не является полиндромом");
}

}
    

//------------------------ДОПОЛНИТЕЛЬНЫЕ ЗАДАНИЯ------------------------------------------------------------------------------

Console.WriteLine(" -------------------------------------------------------------------------------------------------------- ");
Console.WriteLine(" Напишите программу, на ввод подается номер четверти . Создаются N случайных точек в этой чеиверти. .");
Console.WriteLine(" Определитьб оптимальный маршрут торгового представителя, который выезжает из центра координат .");
Console.WriteLine(" -------------------------------------------------------------------------------------------------------- ");
found:
Console.WriteLine("Введите номер четверти");
int number_chetv = Convert.ToInt32(Console.ReadLine());

int xMult = 0; int yMult = 0;
if (number_chetv == 1)                                 // расчета мультипликатора для задания точек для определенной четверти
    {
    xMult = 1; yMult = 1;
    }
else if (number_chetv == 2) 
    {
    xMult = -1; yMult = 1;
    }
else if (number_chetv == 3) 
    {
    xMult = -1; yMult = -1;
    }
else if (number_chetv == 4) 
    {
    xMult = 1; yMult = -1;
    }
else 
    {
    Console.WriteLine("Введите правильный номер четверти");
    goto found;
    }


Console.WriteLine("Введите количество точек ");
int number_point = Convert.ToInt32(Console.ReadLine());


//Random rand = new Random();
int [] array_X = new int[number_point];                           // инициализация массива всех  точек по х координате
int [] array_Y = new int[number_point];                           // инициализация массива всех точек  по Y координате
int [] array_X_input = new int[number_point];                     // инициализация массива всех  точек по х координате
int [] array_Y_input = new int[number_point];
double [] array_Distance = new double [number_point];             // инициализация массива расстояний от центра до каждой точки
int Length = array_X.Length;                                      // кол элементов массива (точек)

void Method_FillArray (int[] array, int Mult)                     // Метод (процедура) Method_FillArray для  заполнения массива случайными заданной четверти
{
    int Length = array.Length;                   
    int index1 =  0;
    while (index1 < Length)
    {
    array[index1] = Mult * new Random().Next(1,10);     
    index1++;
    }   
}

Method_FillArray (array_X, xMult);                                // заполнение массива координатами Х соответствующей четверти
Method_FillArray (array_Y, yMult);                                // заполнение массива координатами Y соответствующей четверти

for (int m=0; m<Length; m++)                                       // массив для вывода первоначальных значений точек
{
array_X_input[m] = array_X[m];
array_Y_input[m] = array_Y[m];
}

int index =  0;
while (index < Length)                                             // заполнение массива расстояние от центра до каждой точки
    {
    array_Distance [index] = Math.Sqrt (array_X[index]*array_X[index]+ array_Y[index]*array_Y[index]);     
    index++;
    }   

for (int i=0; i<Length; i++)                                       // сортировка элоементов массива от иеньшего значения к большему
{
    for (int j=0; j<Length-1; j++)
    {
        if (array_Distance [j]> array_Distance [j+1])
        {
        double t_D = array_Distance [j+1];
        int t_X = array_X[j+1];
        int t_Y = array_Y[j+1];
        array_Distance [j+1] = array_Distance [j];
        array_X[j+1] = array_X [j];
        array_Y[j+1] = array_Y [j];
        array_Distance [j] = t_D;
        array_X[j] = t_X;
        array_Y[j] = t_Y;
        }
    }
}

Console.WriteLine("|      ввод         |     построение пути         | ");
Console.WriteLine("|точка | координата |   точка  - расстояние       |");
    index =  0;
    while (index < Length)
    {
    Console.WriteLine("|   "+ index +"  |  [" + array_X_input[index] + "; " + array_Y_input[index] + "]   " +"|  [" + array_X[index] + "; " + array_Y[index] + "]" + " = " + array_Distance[index]+ "|");
    index++;
    }

 


Console.WriteLine(" -------------------------------------------------------------------------------------------------------- ");
Console.WriteLine(" Даны 4 точки A (x1,y1), B (x2,y2), C (x3, y3), D (x4, y4) Пересекаются ли вектора AB и CD.  .");
Console.WriteLine(" Найти в какой честверти лежит точка пересечения векторов.");
Console.WriteLine(" -------------------------------------------------------------------------------------------------------- ");

Random rnd1 = new Random();
double x1_1 = rnd1.Next (-5,5);
double y1_1 = rnd1.Next (-5,5);
double x1_2 = rnd1.Next (-5,5);
double y1_2 = rnd1.Next (-5,5);
double x2_1=  rnd1.Next (-5,5);
double y2_1 = rnd1.Next (-5,5);
double x2_2 = rnd1.Next (-5,5);
double y2_2 = rnd1.Next (-5,5);

double A1, A2, B1, B2, C1, C2;
double y = 0, x=0;

A1 = y1_1 - y1_2;
B1 = x1_2 - x1_1;
C1 = x1_1*y1_2 - x1_2*y1_1;
A2 = y2_1 - y2_2;
B2 = x2_2 - x2_1;
C2 = x2_1*y2_2 - x2_2*y2_1;

    
if ((B1*A2 - B2*A1) != 0)
    {
    y = (C2*A1 - C1*A2) / (B1*A2 - B2*A1);
    x = (-C1 - B1*y) / A1;
    }

double Method_max (double arg1, double arg2)     // Метод  определения максимального числа из двух
{
    double result = arg1;
    if (arg2 > result) result = arg2;
    return result;
}

double Method_min (double arg1, double arg2)     // Метод определения минимального числа из двух
{
    double result = arg1;
    if (arg2 < result) result = arg2;
    return result;
}

 Console.WriteLine("AB:  A = ["+ x1_1+", " + y1_1 + "];  " + "B = ["+ x1_2+", " + y1_2 + "];  и   CD:  " + "C = ["+ x2_1+", " + y2_1 + "];  "+"D = ["+ x2_2+", " + y2_2 + "];  ");
if (((x >= Method_min(x1_1, x1_2)) &  (x <= Method_max (x1_1, x1_2))) &  (y >= Method_min(y1_1, y1_2)) &  (y <= Method_max (y1_1, y1_2)))   
{
Console.WriteLine("есть точка пересечения:  [x =" + x + ";  y=" + y+"]");
if (x >0 & y > 0) Console.WriteLine (" точка пересечения в 1 четверти");
else if (x <0 & y > 0) Console.WriteLine (" точка пересечения во 2 четверти");
else if (x >0 & y < 0) Console.WriteLine (" точка пересечения в 4 четверти");
}
else
{
Console.WriteLine("точки  пересечения НЕТ ");
}
if ( B1*A2 - B2*A1 == 0) Console.WriteLine("отрезки параллельны");



