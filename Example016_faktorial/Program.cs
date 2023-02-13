bool isWork = true;

while (isWork)
{
    Console.WriteLine("Enter NUmber of Task, 1, 2 or -1: Exit Program: ");

    if (int.TryParse(Console.ReadLine(), out int j))
    {
        switch (j)
        {
            case 1:
                {

                    for (int i = 1; i < 40; i++)
                    {
                        Console.WriteLine($"{i}! = {Factorial(i)}");
                    }

                    break;
                }
            case 2:
                {
                    for (int i = 1; i < 40; i++)
                    {
                        Console.WriteLine($"f{i} = {Fibonacci(i)}");
                    }
                    break;
                }
            case -1: isWork = false; break;
        }
    }
}

double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}


