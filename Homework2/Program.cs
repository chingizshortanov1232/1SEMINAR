// По заданному номеру дня недели вывести его название

int DayWeek = new Random().Next( 1, 8 );
Console.WriteLine (DayWeek);


if (DayWeek == 1)
{
    Console.Write ("Today is ");
    Console.WriteLine ("Monday");
}
if (DayWeek == 2)
{
Console.Write ("Today is ");
Console.WriteLine ("Tuesday");
}
if (DayWeek == 3)
{
    Console.Write ("Today is ");
    Console.WriteLine ("Wednesday");
}
if (DayWeek == 4)
{
Console.Write ("Today is ");
Console.WriteLine ("Thursday");
}
if (DayWeek == 5)
{
    Console.Write ("Today is ");
    Console.WriteLine ("Friday");
}
if (DayWeek == 6)
{
Console.Write ("Today is ");
Console.WriteLine ("Saturday");
}
if (DayWeek == 7)
{
    Console.Write ("Today is ");
    Console.WriteLine ("Sunday");
}
