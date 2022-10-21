/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую йифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

Random rnd = new Random();
int number = rnd.Next(100, 1000);
int firstDigit = number / 100;
int secondDigit = number % 10;
Console.WriteLine($"Число от {number} это {firstDigit*10 + secondDigit} ");
