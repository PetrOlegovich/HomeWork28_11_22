
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int i = 1;
if (num == 0)
{
    Console.WriteLine("сумма цифр = 0");
}

else
{
    while (i > 0)
    {
        sum = sum + num%10;
        i = num/10;
        num = num/10;
        
    }
Console.WriteLine("сумма цифр: " + sum);
}

