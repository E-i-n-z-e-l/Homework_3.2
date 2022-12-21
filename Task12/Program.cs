int Middle(int argument)
{
     if( argument < 100)
     {
        Console.WriteLine("Третьей цифры нет");
     }
     if (argument < 1000)
     {
        int newargument = argument % 10;
        return newargument;
     }
     if (argument < 10000)
     {
        int newargument = (argument /10) % 10;
        return newargument;
     }
}




