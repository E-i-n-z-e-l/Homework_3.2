int Daysoftheweek(int numberDay)
{
    if (numberDay < 6) Console.WriteLine("Рабочий день");
    if (numberDay == 6) Console.WriteLine("Выходной");
    if (numberDay == 7) Console.WriteLine("Выходной");
    if (numberDay > 7) Console.WriteLine("Такого дня недели нет");
    return numberDay;
}

Console.WriteLine("Введите число обозначающие день недели");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Daysoftheweek(number));