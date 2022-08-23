// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int Number = new Random().Next(10,100);
int n1 = 0;
int n2 = 0;
int max = 0;

n1 = Number / 10;


n2 = Number;
while (n2 > 10)
{
 n2 = n2-10;
}

max = n1;
if (max < n2) max = n2;

Console.WriteLine(Number);
Console.Write(n1 );
Console.WriteLine(- n2);
Console.WriteLine(max);
