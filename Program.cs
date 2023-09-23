// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// System.Console.WriteLine("Введите первое число:");
// int a=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число:");
// int b=Convert.ToInt32(Console.ReadLine());
// if (a>b)
// {
//     System.Console.WriteLine($"a = {a}; b = {b} -> max = {a}");
// }
// else{
//     System.Console.WriteLine($"a = {a}; b = {b} -> max = {b}");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число a:");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число b:");
int b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число d:");
int d=Convert.ToInt32(Console.ReadLine());
int max=a;
if (b>max)max=b;
if (d>max)max=d;
System.Console.WriteLine($"a = {a}, b = {b}, d = {d} -> max = {max}");