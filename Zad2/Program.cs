// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Clear(); // очищает консоль
Console.WriteLine("Введите число 1: ");                   // задаем вопрос пользователю данной командой
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");                  // задаем вопрос пользователю данной командой
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3: ");                  // задаем вопрос пользователю данной командой
int d = int.Parse(Console.ReadLine());
max = a;
if(a < max) max = b;
Console.Write("max = ");
Console.WriteLine(max);
if(b < max) max = a;
Console.Write("max = ");
Console.WriteLine(max);
if(C < max) max = c;
Console.Write("max = ");
Console.WriteLine(max);
