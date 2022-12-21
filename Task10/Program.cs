int Middle(int argument)
{
    int newargument = (argument / 10) % 10;
    return newargument;
}

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());


int newnewargument = Middle(number);
Console.WriteLine(newnewargument);