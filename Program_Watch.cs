string[,,] watchdigits =
{
    {
        {" ","0","0"," "},
        {"0"," "," ","0"},
        {"0"," "," ","0"},
        {"0"," "," ","0"},
        {"0"," "," ","0"},
        {"0"," "," ","0"},
        {" ","0","0"," "}
    },

    {
        {" "," ","0"," "},
        {" ","0","0"," "},
        {"0"," ","0"," "},
        {" "," ","0"," "},
        {" "," ","0"," "},
        {" "," ","0"," "},
         {"0","0","0","0"}

    },

    {
        {" ","0","0"," "},
        {"0"," "," ","0"},
        {" "," "," ","0"},
        {" ","0","0"," "},
        {"0"," "," "," "},
        {"0"," "," "," "},
        {"0","0","0","0"}

    },

    {
        {" ","0","0"," "},
        {"0"," "," ","0"},
        {" "," "," ","0"},
        {" ","0","0"," "},
        {" "," "," ","0"},
        {"0"," "," ","0"},
        {" ","0","0"," "}

    },

    {
        {"0"," "," ","0"},
        {"0"," "," ","0"},
        {"0"," "," ","0"},
        {"0","0","0","0"},
        {" "," "," ","0"},
        {" "," "," ","0"},
        {" "," "," ","0"}

    },

    {
        {"0","0","0","0"},
        {"0"," "," "," "},
        {"0","0","0"," "},
        {" "," "," ","0"},
        {" "," "," ","0"},
        {"0"," "," ","0"},
        {" ","0","0"," "}

    },

    {
        {" ","0","0","0"},
        {"0"," "," "," "},
        {"0","0","0"," "},
        {"0"," "," ","0"},
        {"0"," "," ","0"},
        {"0"," "," ","0"},
        {" ","0","0"," "}


    },

    {
        {"0","0","0","0"},
        {" "," "," ","0"},
        {" "," ","0","0"},
        {" ","0"," "," "},
        {" ","0"," "," "},
        {" ","0"," "," "},
        {" ","0"," "," "}

    },

    {

        {" ","0","0"," "},
        {"0"," "," ","0"},
        {"0"," "," ","0"},
        {" ","0","0"," "},
        {"0"," "," ","0"},
        {"0"," "," ","0"},
        {" ","0","0"," "}

    },

    {

        {" ","0","0"," "},
        {"0"," "," ","0"},
        {"0"," "," ","0"},
        {"0"," "," ","0"},
        {" ","0","0","0"},
        {" "," "," ","0"},
        {" ","0","0"," "}
    },
};



void PrintColonWatch(int pos1, int pos2)                                              // метод отображения разделителей и рамки на часы
{
    Console.SetCursorPosition(pos1, pos2);
    Console.Write("0");
    Console.SetCursorPosition(pos1, pos2);
    Console.WriteLine("");
    Console.WriteLine("");
    Console.SetCursorPosition(pos1, pos2 + 2);
    Console.Write("0");
    Console.SetCursorPosition(pos1 - 25, pos2 - 4);
    Console.Write("000000000000000000000000000000000000000000000000000000000");
    Console.SetCursorPosition(pos1 - 25, pos2 + 6);
    Console.Write("000000000000000000000000000000000000000000000000000000000");

}


void PrintWatchDigit(string[,,] watchdigits, int digit, int pos1, int pos2)              // метод вывода цифры на экран
{
    Console.SetCursorPosition(pos1, pos2);
    for (int j = 0; j < watchdigits.GetLength(1); j++)

    {
        for (int m = 0; m < watchdigits.GetLength(2); m++)
        {

            Console.Write(watchdigits[digit, j, m]);

        }
        Console.WriteLine("");
        pos2++;

        Console.SetCursorPosition(pos1, pos2);
    }
}

Console.Clear();
string t_str;
ConsoleKeyInfo cki = new ConsoleKeyInfo();

Console.SetCursorPosition(0, 6);
Console.Write("E L E C T R O N I C    C L O C K ");
Console.SetCursorPosition(65, 6);
Console.Write("выход - клавиша пробел ");

while (cki.Key != ConsoleKey.Spacebar)                            // условие выхода из цикла (нажатие клавиши пробел)
{                                                                   // цикл синхронизации счетчика времени с массивом даныых по выводу циферблата
    DateTime t = new DateTime();
    t = DateTime.Now;
    t_str = t.ToLongTimeString();
    


    if (t_str.Length == 8)
    {
        
        PrintWatchDigit(watchdigits, Convert.ToInt32(t_str[0].ToString()), 5, 10);
        PrintWatchDigit(watchdigits, Convert.ToInt32(t_str[1].ToString()), 15, 10);
        PrintWatchDigit(watchdigits, Convert.ToInt32(t_str[3].ToString()), 35, 10);
        PrintWatchDigit(watchdigits, Convert.ToInt32(t_str[4].ToString()), 45, 10);
        PrintWatchDigit(watchdigits, Convert.ToInt32(t_str[6].ToString()), 65, 10);
        PrintWatchDigit(watchdigits, Convert.ToInt32(t_str[7].ToString()), 75, 10);
        PrintColonWatch(25, 12);
        PrintColonWatch(55, 12);
        

    }
    else
    {
        PrintWatchDigit(watchdigits, 0, 5, 10);
        PrintWatchDigit(watchdigits, Convert.ToInt32(t_str[0].ToString()), 15, 10);
        PrintWatchDigit(watchdigits, Convert.ToInt32(t_str[2].ToString()), 35, 10);
        PrintWatchDigit(watchdigits, Convert.ToInt32(t_str[3].ToString()), 45, 10);
        PrintWatchDigit(watchdigits, Convert.ToInt32(t_str[5].ToString()), 65, 10);
        PrintWatchDigit(watchdigits, Convert.ToInt32(t_str[6].ToString()), 75, 10);
        PrintColonWatch(25, 12);
        PrintColonWatch(55, 12);
    }



    Thread.Sleep(1000);

    if (Console.KeyAvailable == true)
    {
        cki = Console.ReadKey(true);
    }
}
Console.Clear();


