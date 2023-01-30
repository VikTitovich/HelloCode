
Random rnd = new Random();

int number = rnd.Next(100,999);

Console.WriteLine(number);

int i = number % 10; //Последняя цифра числа

while (number >= 100)
{
    number /=100;
}

int j = number; //Первая цифра числа

Console.WriteLine(j*10+i);

