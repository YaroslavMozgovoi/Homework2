// Задача 13: 
// 1.Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// 2.Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите числлло");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (number > 1000)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine(number);
}