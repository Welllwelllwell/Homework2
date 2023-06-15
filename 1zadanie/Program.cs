// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB= numberA/10;
int numberC= numberB%10;
System.Console.WriteLine(numberC);