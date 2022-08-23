// Найти максимальное из трех чисел

int numberA = new Random().Next(); 
Console.WriteLine(numberA);

int numberB = new Random().Next();
Console.WriteLine(numberB);

int numberC = new Random().Next();
Console.WriteLine(numberC);

int max = numberA;

if ( numberA > max ) max = numberA;
if ( numberB > max ) max = numberB;
if ( numberC > max ) max = numberC;

Console.Write("максимальное число = ");
Console.WriteLine(max);
