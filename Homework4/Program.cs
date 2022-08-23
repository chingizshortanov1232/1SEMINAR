// Выяснить является ли число чётным

Decimal number1 = new Random().Next();
Decimal number2 = 2;
Decimal number3 = number1 % number2;
Console.WriteLine(number1);

if(number3 == 0 )
{
    Console.WriteLine("Четное");
}
else
{
 Console.WriteLine("Нечетное");
}

    

