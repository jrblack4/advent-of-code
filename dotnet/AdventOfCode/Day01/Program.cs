string[] lines = File.ReadAllLines("./input.txt");
int sum = 0;

for(int i = 0; i <= lines.Length - 1; i++)
{
	string line = lines[i];
	char first = '0';
	char last = '0';

	for(int j = 0; j < line.Length; j++)
	{
		if (Char.IsDigit(line[j]))
		{
			first = line[j];
			break;
		}
	}

	for(int k = line.Length - 1; k >= 0; k--)
	{
		if (Char.IsDigit(line[k]))
		{
			last = line[k];
			break;
		}
	}

	char[] chars = {first, last};
	string number = new string(chars);
	int num = Int32.Parse(number);
//	Console.WriteLine("num");
//	Console.WriteLine(num);
	sum += num;

	Console.Write(number);
	Console.Write("-");
	Console.WriteLine(sum);

	// Console.WriteLine(num);
}

// Console.WriteLine("sum");
Console.WriteLine(sum);

