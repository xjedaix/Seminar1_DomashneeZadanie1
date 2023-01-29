// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear(); // очищает консоль
Console.WriteLine("Введите число 1: "); // задаем вопрос пользователю данной командой
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: "); // задаем вопрос пользователю данной командой
int number2 = int.Parse(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine("первое число больше чем второе");
}
if(numberA < numberB)
{
    Console.WriteLine("Первое число меньше чем второе");
}