// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int Get(string message)
{
    Console.WriteLine(message);
    string numberAStr = Console.ReadLine();
    int numberA = Convert.ToInt32(numberAStr);
    return (numberA);
}
int numberA = Get ("Введите число");

if(numberA >= 100)
{
    Console.WriteLine($"Число {numberA} это {(numberA/100)%10}");
}
else
{
    Console.WriteLine("нет третьей цифры");
}
