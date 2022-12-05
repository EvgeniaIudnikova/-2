// Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

Console.Clear();
int num = new Random().Next(100, 1000);
int result = (num / 10)%10;
Console.WriteLine($"{num} вторая цифра {result}");
