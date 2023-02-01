// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет



// Console.WriteLine("Введите 1-ое число: ");

// int.TryParse(Console.ReadLine(), out int number);

// Console.WriteLine("Введите 2-ое число: ");

// int.TryParse(Console.ReadLine(), out int number1);

//                 if ((number == Math.Sqrt(number1)) || (number1 == number*number))//Math.Sqrt(number)) )
//                 {
//                 Console.WriteLine("Да");
//                 }
//                 else 
//                 Console.WriteLine("Нет ");


int number = 0;//непонятно, почему пришлось инициализировать

Console.WriteLine("Введите первое число: ");

bool isnumber = int.TryParse(Console.ReadLine(), out number); //проверка, является введенное числом

int number1 = 0; //непонятно, почему пришлось инициализировать

Console.WriteLine("Введите второе число: ");

isnumber = isnumber && int.TryParse(Console.ReadLine(), out number1);//проверка, является введенное числом

if (isnumber)
{

    if ((Math.Abs(number) == Math.Sqrt(number1)) || (Math.Abs(number1) == Math.Sqrt(number))) // Math.Abs - модуль числа, Math.Sqrt 
    {                                                                                         // использовать лучше с модулем
        Console.WriteLine("Да");                                                                  // иначе лучше Math.Pow
    }
    else
        Console.WriteLine("Нет ");
}
else
{
    Console.WriteLine("Вы ввели не число.");
}