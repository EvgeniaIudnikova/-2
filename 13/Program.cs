// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Clear();
int a = new Random().Next(0, 100000000);

if (a < 100)
{
    Console.WriteLine($"В числе {a} нет 3ей цифры");
    return;
}
else
{
   int num = 1000;
   int a2 = a;

    while (100 < a2)
    { 
        if(a2 <= num)
        {
            int result = a2%10;
            Console.WriteLine($"В числе {a} 3я цифра: {result}");
        }
    a2 = a2/10;
    }
}