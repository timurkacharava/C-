﻿Console.WriteLine("Число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;
while (count <= N)
{
    Console.Write(count + " ");
    count++;
}