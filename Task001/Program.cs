﻿/*  Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числаю
78 -> 8
12 -> 2
85 ->8
*/

Random rnd = new Random();
int number = rnd.Next(10, 100);

int firstDigit = number / 10;
int secondDigit = number % 10;

if(firstDigit > secondDigit)

    Console.WriteLine($"Наибольшая цифра числа {number} = {firstDigit}");

else if(secondDigit > firstDigit)
    Console.WriteLine($"Наибольшая цифра числа {number} = {secondDigit}");
else
    Console.WriteLine("Числа равны");   

