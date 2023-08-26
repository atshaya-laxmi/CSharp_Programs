using System;

class avgarrays
{
	public static void Main()
	{
		char[] arr = {'G', 'e', 'e', 'k', 's',
						'f', 'o', 'r', 'G', 'e',
								'e', 'k', 's'};
		
		Console.Write("Print array using for loop = ");

		for (int i = 0; i < arr.Length; i++)
		{
			Console.Write(arr[i]);
		}

		Console.WriteLine();

		Console.Write("Print array using foreach loop = ");

	
		foreach(char ch in arr)
		{
			Console.Write(ch);
		}
	}
}