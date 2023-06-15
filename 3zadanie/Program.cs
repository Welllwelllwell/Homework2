// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день 
// недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число");
int DayWeek = Convert.ToInt32(Console.ReadLine());

if (DayWeek == 1 || DayWeek == 2 || DayWeek == 3 || DayWeek == 4 || DayWeek == 5)
{
    System.Console.WriteLine("Нет");
}
if (DayWeek == 6 || DayWeek == 7)
{
    System.Console.WriteLine("ДА!!!");
}
