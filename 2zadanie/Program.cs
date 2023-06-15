
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA<100)
{
    System.Console.WriteLine("Нет третьей цифры");
}
if (numberA>100)
{
    while (numberA>1000) numberA /=10;
    int numberB=numberA%10;
    System.Console.WriteLine(numberB);
}