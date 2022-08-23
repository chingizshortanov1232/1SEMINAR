//По двум заданным числам проверять является ли первое квадратом второго

int numberA = new Random().Next(1, 100); 
Console.WriteLine("Первое чило: " + numberA );

int numberB = new Random().Next(1, 100);
Console.WriteLine("Второе число: " + numberB );

Console.Write("Является ли первое число квадратом второго? ");

if ( (numberA / numberB) != numberB)
        {
            Console.WriteLine ("Нет");
        }
else
        {
            Console.WriteLine ("Да");
        }
