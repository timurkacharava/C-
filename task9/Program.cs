int number = new Random().Next(10, 100);
Console.WriteLine("Ваше случайное число: " + number);
int digit1 = number/10;
int digit2 = number%10;
if(digit1 > digit2)
{
    Console.WriteLine($"Первая цифра {digit1} больше второй {digit2}");
}
else if(digit2 > digit1)
{
    Console.WriteLine($"Вторая цифра {digit2} больше первой {digit1}");
}
else
{
    Console.WriteLine("Цифры равны");
}
