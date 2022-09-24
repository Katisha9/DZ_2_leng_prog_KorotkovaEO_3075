// Задача 10: Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
Console.WriteLine("Введите трехначное число: ");
int number0 = int.Parse(Console.ReadLine());

int number1 = number0 % 100 / 10;

Console.WriteLine($"Вторая цифра числа: {number1}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
if (number1 / 100 > 0)
{
    while (number1 / 1000 > 0)
    {
        number1 = number1 / 10;
    }

    number1 = number1 % 10;
    Console.WriteLine($"Третья цифра числа: {number1}");
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

/*
Console.WriteLine("Введите порядковый номер дня недели от 1 до 7: ");
int number0 = int.Parse(Console.ReadLine());
if ((number0 == 6) || (number0 == 7))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");

}
*/
