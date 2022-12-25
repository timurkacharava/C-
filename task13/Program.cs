// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int digit3 = (a % 100) % 10;
if (digit3 > 0)
{
    Console.WriteLine(digit3);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
