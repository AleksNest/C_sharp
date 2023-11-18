Console.WriteLine(" --------------------------------------------------------------------------------------------- ");
Console.WriteLine(" программа, которая принимает на вход целое число и на выходе выводит перевёрнутое число. ");
Console.WriteLine(" --------------------------------------------------------------------------------------------- ");
Console.WriteLine("Введите целое число");
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

Console.WriteLine("числу: " + number + "  соответствует перевернутое число:  " + Perenert (number));



Console.WriteLine(" --------------------------------------------------------------------------------------------- ");
Console.WriteLine(" программа,  которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. ");
Console.WriteLine(" --------------------------------------------------------------------------------------------- ");

Console.WriteLine("Введите целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 ==0) 
{
    while (number1 ==0)
    {
        Console.WriteLine("Введите целое число отличнное от 0");
        int number2 = Convert.ToInt32(Console.ReadLine());
        number1 = number2;
    }
}
Console.WriteLine("Введите порядковый номер цифры в числе");
int n = Convert.ToInt32(Console.ReadLine());

void fun (int num)                         // метод выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
{
    int num1 = Math.Abs(num);             
    int digit1 = 0;
    while(num1>0)                          // расчет кол разрядов в числе
    {
        num1 = num1/10; 
        digit1++;
    }
    int [] array = new int[digit1]; 

    int numB = Math.Abs(Perenert (num));    //  метод переворачивает число
    int s = numB; 
    int digit2 = 0;
    while(numB>0)                           // число переводится в массив
    {
        numB = numB/10;
        int numA = s - numB*10;
        array[digit2] = numA;
        s = s/10;
        digit2++;
    }
if (n < digit2+1)                            // проверка условия наличия цифры в знаке числа
    { 
        Console.WriteLine( "цифра в числе " + number1 + " под №" + n + "   имеет заначениe:  "  + array[n-1]);
    }
    else 
    {
        Console.WriteLine ("цифра в числе под №" +n+ " отсутствует");
    }
}
fun (number1);




Console.WriteLine(" --------------------------------------------------------------------------------------------- -----------------------");
Console.WriteLine(" программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. ");
Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------------");

Console.WriteLine("Введите порядковый номер  недели от 1 до 7 ");
int number3 = Convert.ToInt32(Console.ReadLine());
string ss = "";
string HoliDay_YN(int num6)                  // метод определения является день недели ли выходным или нет
{
    if ((num6 == 6) | (num6 == 7)) 
    {
        ss = " - является выходным";
    }
    else 
    {
        ss = " - не является выходным"; 
    } 
return ss;
}

string s ="";
string Week (int num5)                      // метод определения дня недели по числу
{
 switch(num5)
 {
    case 1:
    s ="понедельник"; return s; 
    break;
    case 2:
    s ="вторник"; return s; 
    break;
    case 3:
    s ="среда"; return s; 
    break;
    case 4:
    s ="четверго"; return s; 
    break;
    case 5:
    s ="впятница"; return s; 
    break;
    case 6:
    s ="суббота"; return s; 
    break;
    case 7:
    s ="воскресенье"; return s; 
    break;
    default:
    s ="ввели неправильное число"; return s; 
    break;
 }
 return s;
}

Console.WriteLine(number3 + " - " + Week(number3) + " " + HoliDay_YN(number3));


// ДОПОЛНИТЕЛЬНЫЕ ЗАДАЧИ


Console.WriteLine(" --------------------------------------------------------------------------------------------------------------------");
Console.WriteLine(" программа, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.. ");
Console.WriteLine(" ---------------------------------------------------------------------------------------------------------------------");


int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

void isosceles_YN(int a1, int b1, int c1)
{
if ((a == b) | (a == c) | (b == c)) Console.WriteLine("треугольник равнобедренный");
else Console.WriteLine("треугольник неравнобедренный");
}
isosceles_YN(a, b, c);



Console.WriteLine(" --------------------------------------------------------------------------------------------------------------------");
Console.WriteLine (" Иван в январе года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.");
Console.WriteLine(" ---------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Введите кол. месяцев");
int mounth = Convert.ToInt32(Console.ReadLine());
double vklad  = 1000;
void Vklad_Percent (double vklad1, int mounth1)                                     // метод расчета суммы вклада от кол месяцев  с процентом 1,5% ежемесячно
{
int ind = 1;
double sum = vklad1;
double percent = 1.5/100;
while (ind <= mounth1)
{
vklad1 = sum * percent + sum;
sum = vklad1;
ind = ind +1;
}
Console.WriteLine ("Процент ежемесячный =  " + percent*100 + "%" +  ", кол. месяцев по вкладу = "+ mounth1);
Console.WriteLine ("Вклад с учетом процентов = " + Math.Round (vklad1, 2) + "руб.");
}

Vklad_Percent (vklad, mounth);



Console.WriteLine(" --------------------------------------------------------------------------------------------------------------------");
Console.WriteLine (" На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 февраля 2022 года.");
Console.WriteLine(" ---------------------------------------------------------------------------------------------------------------------");

int fun_month (int month3)                              // метод проверки правильности ввода месяца
{ 
    while (month3 > 12 | month3 <= 0) 
{
    Console.WriteLine("Введите корректный месяц");
    month3 = Convert.ToInt32(Console.ReadLine());
}
    return month3;
}    
int fun_day (int day3)                                  // метод проверки правильности ввода дня
{ 
    while (day3 > 31 | day3 <= 0) 
{
    Console.WriteLine("Введите корректную дату");
    day3 = Convert.ToInt32(Console.ReadLine());
}
    return day3;
}    

Console.WriteLine("Введите дату рождения");
Console.WriteLine("год");
int year1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("месяц");
int month1 = Convert.ToInt32(Console.ReadLine());
month1 = fun_month(month1);
Console.WriteLine("день");
int day1 = Convert.ToInt32(Console.ReadLine());
day1 = fun_day(day1);

Console.WriteLine("Введите текущую дату");
Console.WriteLine("год");
int year2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("месяц");
int month2 = Convert.ToInt32(Console.ReadLine());
month2 = fun_month(month2);
Console.WriteLine("день");
int day2 = Convert.ToInt32(Console.ReadLine());
day2 = fun_day(day2);

void fun_age (int year_1, int year_2, int month_1, int month_2, int day_1, int day_2)          // метод расчета возраста
{
int age = 0;
if ( year_2 > year_1)  
   if ((month_2 < month_1) & (day_2 < day_1))
       age = year_2 - year_1 -1;
        else
        age = year_2 - year_1;
  Console.WriteLine("возраст (кол полных лет) = " + age);
}  

fun_age (year1, year2, month1, month2, day1, day2);
