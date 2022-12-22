int MiddleDigit(int digit)
{
    while (digit > 999)
    {
        digit = (digit / 10);
    }
    return digit % 10;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры тю-тю");
}
else
{
    Console.WriteLine(MiddleDigit(number));
}





//{
//    Console.WriteLine(Middle(number));
//}

//int res = 98765;
//while (res > 999)
//{
//    res = res / 10;
//}
//Console.Write(res);





