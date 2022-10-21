// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру");
int numberA = int.Parse(Console.ReadLine());
if(numberA == 6 && numberA == 7 || numberA > 5)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}



