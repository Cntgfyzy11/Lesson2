// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Random rnd = new Random();
int number = rnd.Next(100, 1000);

int firstDigit = number % 100; // 456%100=5
int secondDigit = firstDigit /10; // 456/10=45
Console.WriteLine($"Число от {number} это {secondDigit}");