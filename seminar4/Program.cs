// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


Console.WriteLine("Введите число: ");

    int.TryParse(Console.ReadLine(), out int number);

    if ((number % 7 == 0) && (number % 23 ==0))
                {
                Console.WriteLine("Да");
                }
                else 
                Console.WriteLine("Нет");



// Даны числа 2 и 3. Найти суммк первых 5 чисел, которые кратны и 2 и 3.

// 1 вариант

// int a = 1;
// int count = 0;
// int sum = 0;
// while (count < 5)
// {
//     if ((a % 2 == 0) && (a % 3 == 0))
//     {
//         Console.WriteLine(a);
//         sum = sum + a;
//         count++;
//     }
//     a++;
// }
// Console.WriteLine (sum);

// 2 вариант неверно работатет, разобраться.

// int a = 3; 
// int count = 0;
// int sum = 0;
// while (count < 5)
// {
//     if ((a % 2 == 0) && (a % 3 == 0))
//     {
//         Console.WriteLine(a);
//         sum = sum + a;
//         count++;
//     }
//     a = a * 2;
// }
// Console.WriteLine (sum);

//Квадратик
// Console.WriteLine(@"* * * * *");
// Console.WriteLine(@"*       *");
// Console.WriteLine(@"*       *");
// Console.WriteLine(@"*       *");
// Console.WriteLine(@"* * * * *");