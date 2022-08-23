// Показать четные числа от 1 до N;
int index = 0;
int index2 = 1;
int NArray = 10000000;
int Number = 1;
int[] NameArray = new int[NArray];
    while (index < NArray)  // массив от 1 до N, где N это NArray
    {
        NameArray[index] = Number;
        index++;
        Number++;
    }

    while (index2 < NArray) //выводит все четные числа
    {
        Console.Write(-NameArray[index2]);
        index2 = index2 + 2;  
    } 