// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


Console.WriteLine("Введите первое число: ");

int.TryParse(Console.ReadLine(), out int number);

Console.WriteLine("Введите второе число: ");

int.TryParse(Console.ReadLine(), out int number1);

if (number % number1 == 0)
{
    Console.WriteLine("Кратно");
}
else
    Console.WriteLine($"Некратно, остаток равен {number % number1}");