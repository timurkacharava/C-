﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine("Ваше случайное число: " + number);
int digit2 = (number % 100) / 10;
Console.WriteLine(digit2);