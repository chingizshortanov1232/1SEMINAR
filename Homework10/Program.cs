// Найти третью цифру числа или сообщить, что её нет

int Number = new Random().Next(10,1000);
Console.WriteLine(Number);

while (Number>=10)
{
    Number = Number - 10;
}
Console.WriteLine(Number);
if (Number == 0) Console.WriteLine("третее число отсутствует или равно нулю");