// Задача 11. Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100, 1000); 
Console.WriteLine($"Случайное число = {number}");
int digit1 = number / 100; // 1вые цифры числа
int digit3 = number % 10;  // 3тьи цифры числа
int res = digit1 * 10 + digit3; // 10 так как число будет двузначное

Console.WriteLine($"Результат= {res}");
