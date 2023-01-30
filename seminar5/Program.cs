Console.WriteLine("Введите 1-ое число: ");

int.TryParse(Console.ReadLine(), out int number);

Console.WriteLine("Введите 2-ое число: ");

int.TryParse(Console.ReadLine(), out int number1);

                if ((number == Math.Sqrt(number1)) || (number1 == number*number))//Math.Sqrt(number)) )
                {
                Console.WriteLine("Да");
                }
                else 
                Console.WriteLine("Нет ");