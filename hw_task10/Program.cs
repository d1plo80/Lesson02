// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 100 & a <= 999)
{
   int b =  a % 100 / 10;
   Console.WriteLine(b);
}
else
{
   Console.WriteLine("Вы умудрились ввести неверное число");
}
