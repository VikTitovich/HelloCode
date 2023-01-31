// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rnd = new Random();

int number = rnd.Next(100,999);

Console.WriteLine(number);

int i = number % 10; //Последняя цифра числа

int j = number / 100; 

// while (number >= 100)
// {
//     number /=100;
// }

Console.WriteLine(j*10+i);

