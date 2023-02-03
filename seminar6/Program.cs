// Напишите программу, которая принимает на вход кооординаты точки (X и Y), 
// причём X и Y не равны 0 и выдаёт номер четверти плоскости, в которой
// находится эта точка.
// 2  |  1
// --------
// 3  |  4

while (true)
{
	Task1();
}


void Task1()
{
	int x = ReadInt("X");
	int y = ReadInt("Y");

	int quarter = GetQuarter(x, y);

	Console.WriteLine($"{quarter}: [{x} - {y}]");
}


int GetQuarter(int x, int y)
{
	if (x == 0 || y == 0)
	{
		return -1;
	}

	if (x > 0 && y > 0)
	{
		return 1;
	}
	else if (x < 0 && y > 0)
	{
		return 2;
	}
	else if (x < 0 && y < 0)
	{
		return 3;
	}
	else
	{
		return 4;
	}
}

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");

	int number = 0;
	while (!int.TryParse(Console.ReadLine(), out number))
	{
		Console.WriteLine("It's not a number");
	}

	return number;
}
