// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8


Random rnd = new Random();

int number = rnd.Next(10,99+1);// min, max + 1

Console.WriteLine(number);

int i = number % 10; //Последняя цифра числа

//Цикл подойдёт если число трехзначное и т.д.
//while (number >= 10)
//{
   // number /=10;
//}

int j = number / 10;  //Первая цифра числа

if (i > j) 
{
Console.WriteLine($"В числе {number} самая большая цифра {i}.");
}
else
{
Console.WriteLine($"В числе {number} самая большая цифра {j}.");
}















