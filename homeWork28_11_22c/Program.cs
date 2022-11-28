// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

//ВАРИАНТ 1 где рандомный массив в заданную ВАМИ величину.
// Console.WriteLine("Введите величину массива : "); 
// int number = Convert.ToInt32(Console.ReadLine());
// int [] mass = new int [number];
// for (int i = 0; i < number; i++)
// {
//     mass[i] = new Random().Next(0, 10);
// }
// Console.WriteLine("[" + string.Join(",", mass) + "]" );

//ВАРИАНТ 2 где рандомный массив из 8 элементов
int a = 8;
int [] mass = new int [a];
for (int i = 0; i < a ; i++)
{
    mass[i] = new Random().Next(0, 10);
}
Console.WriteLine("[" + string.Join(",", mass) + "]" );

