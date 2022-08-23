// Показать вторую цифру трёхзначного числа

int Number = new Random().Next(101,1000);
Console.WriteLine(Number);

while (Number>100)
{
  Number = Number - 100;
}
Console.WriteLine(Number);

Number = Number / 10;
Console.WriteLine(Number);