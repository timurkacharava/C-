Console.Write("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
  if (a > c)
    {
    Console.Write("max" +  a);
    } 
} 
else if (b > c)
{
    Console.Write("max" +  b);
}
else Console.Write("max" +  c);