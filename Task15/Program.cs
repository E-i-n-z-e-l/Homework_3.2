int Daysoftheweek(int numberDay)
{
    if (numberDay < 6) Console.WriteLine("Иди на работу");
    if (numberDay == 6) Console.WriteLine("Лежи дома на диванчике, выходной же");
    if (numberDay == 7) Console.WriteLine("Лежи дома на диванчике, выходной же");
    if (numberDay > 7) Console.WriteLine("Такого дня недели нет");
    return numberDay;
}

Console.WriteLine("Введите число обозначающие день недели");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Daysoftheweek(number));