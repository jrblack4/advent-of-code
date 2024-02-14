string[] lines = File.ReadAllLines("./input.txt");

for(int i = 0; i < 1; i++)
{
	string line = lines[i];
	char first;
	char last;

	for(int j = 0; j < line.Length; j++)
	{
		if (Char.IsDigit(line[j]))
		{
			first = line[j];
			Console.WriteLine(line[j]);
			break;
		}
	}

	for(int k = line.Length - 1; k > 0; k--)
	{
		if (Char.IsDigit(line[k]))
		{
			Console.WriteLine(line[k]);
			last = line[k];
			break;
		}
	}

	char[] chars = {first, last};

	Console.WriteLine(chars);
}

