// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 1:
        Console.WriteLine("Понедельник - будний день");
        break;
    case 2:
        Console.WriteLine("Вторник - - будний день");
        break;
    case 3:
        Console.WriteLine("Среда - будний день");
        break;
    case 4:
        Console.WriteLine("Четверг - будний день");
        break;
    case 5:
        Console.WriteLine("Пятница - будний день");
        break;
    case 6:
        Console.WriteLine("Суббота - наконец выходной день");
        break;
    case 7:
        Console.WriteLine("Воскресение - выходной день");
        break;
    default:
        Console.WriteLine("Такого дня недели нет");
        break;
}