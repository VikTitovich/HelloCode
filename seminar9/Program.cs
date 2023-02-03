// Задача 3.4 Напишите программу, которая принимает на вход число N и выдаёт таблицу квадратов чисел от 1 до N

System.Console.WriteLine("Введите число");

int.TryParse(Console.ReadLine(), out int a);

int b = 1;

while(b <= a)
{
    System.Console.WriteLine(Math.Pow(b, 2));
    b++;
}