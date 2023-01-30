// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear(); // очищает консоль
Console.WriteLine("Введите число 1: "); // задаем вопрос пользователю данной командой
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: "); // задаем вопрос пользователю данной командой
int b = int.Parse(Console.ReadLine());
if(a > b){
Console.WriteLine($"Первое число больше чем второе");
return;
}
else
{
    Console.WriteLine($"Второе число больше чем первое");
}
