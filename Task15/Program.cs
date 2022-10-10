// Задача 15: 
// 1.Напишите программу, которая принимает на вход цифру, обозначающую день недели.
// 2.И проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int weekday = Convert.ToInt32(Console.ReadLine());

if (weekday == 1) Console.WriteLine("понедельник");
else if (weekday == 2) Console.WriteLine("вторник");
else if (weekday == 3) Console.WriteLine("среда");
else if (weekday == 4) Console.WriteLine("четверг");
else if (weekday == 5) Console.WriteLine("пятница");
else if (weekday == 6) Console.WriteLine("суббота");
else if (weekday == 7) Console.WriteLine("воскресенье");
else Console.WriteLine("такого дня неделли несуществует");

if(weekday == 6||weekday == 7) Console.WriteLine("выходной день");
else Console.WriteLine("рабочий день");