// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите цифру плоскости координат ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 == 1)
{
    Console.WriteLine("x > 0,y > 0");
}
else if (num1 == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if (num1 == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else if (num1 == 4)
{
    Console.WriteLine("x > 0, y < 0");
}
else
{
    Console.WriteLine("Неверный ввод");
}

// string[] quarters = {"x > 0, y > 0",
// "x < 0, y > 0",
// "x < 0, y < 0",
// "x > 0, y < 0"};

// Console.Write("Введите цифру плоскости координат ");
// int quater = Convert.ToInt32(Console.ReadLine());
// if(quater >= 1 && quater <= 4)
// {
// Console.WriteLine(quarters[quater - 1]);
// }
// else
// {
// Console.WriteLine("Неверный ввод" );
// }