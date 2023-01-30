Random rnd = new Random();

int number = rnd.Next(10,99);

Console.WriteLine(number);

int i = number % 10; //Последняя цифра числа

while (number >= 10)
{
    number /=10;
}

int j = number; //Первая цифра числа

if (i > j) 
{
Console.WriteLine(i);
}
else
{
Console.WriteLine(j);
}















