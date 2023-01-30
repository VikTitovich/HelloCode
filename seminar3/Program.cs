
Console.WriteLine("Введите 1-ое число: ");

                int.TryParse(Console.ReadLine(), out int number);

                Console.WriteLine("Введите 2-ое число: ");

                int.TryParse(Console.ReadLine(), out int number1);

                if (number % number1 == 0)
                {
                Console.WriteLine("Кратно");
                }
                else 
                Console.WriteLine("Некратно, остаток " + number % number1);