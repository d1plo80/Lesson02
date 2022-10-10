// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a >= 100)
{
    if (a > 999)
    {
        int b = 10;
        while (a / b > 1000)
        {
            b = b * 10;
        }
        Console.WriteLine(a / b % 10);
    }
    else
    {
        Console.WriteLine(a % 10);
    }
    
}
else
{
    Console.WriteLine("Я сделал всё что мог, но третьей цифры не нашёл...");
}