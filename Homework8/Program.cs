// Удалить вторую цифру трёхзначного числа

int Number = new Random().Next(100,1000);
int n1 = 0;
int n2 = 0;
int max = 0;

n1 = Number / 100;


n2 = Number;
while (n2 >= 10)
{
 n2 = n2-10;
}

max = (n1*10)+n2;

Console.WriteLine(Number);
Console.WriteLine(max);

