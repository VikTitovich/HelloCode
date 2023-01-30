Console.WriteLine("Введите число: ");

    int.TryParse(Console.ReadLine(), out int number);

    if ((number % 7 == 0) && (number % 23 ==0))
                {
                Console.WriteLine("Да");
                }
                else 
                Console.WriteLine("Нет");