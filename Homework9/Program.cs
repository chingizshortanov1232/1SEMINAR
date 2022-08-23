// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Decimal number1 = new  Random().Next(1,6);
Decimal number2 = new  Random().Next(10,100000);
Decimal number3 = number2 % number1;
Console.WriteLine("Делитель " + number1);
Console.WriteLine("Делимое " + number2);
if(number3 == 0 )
{
    Console.WriteLine(number2 + " Кратно " + number1);
}
else
{
 Console.WriteLine(number2 + " не кратно " + number1);
 Console.WriteLine("Остаток:  " + number3);
}

