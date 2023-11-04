using System.Collections.Generic;

static class ArraysAndList
{
    public static string[] Combine(string[] a, string[] b)
	{
		string[] combined = new string[a.Length + b.Length];

		for (int i = 0; i < a.Length; i++)
			combined[i] = a[i];

		for (int i = 0; i < b.Length; i++)
			combined[i + a.Length] = b[i];

		return combined;
	}


	public static int[] CreateFibonacci(int n)
	{
		int[] fibonacci = new int[n];

		if (n >= 0)
			fibonacci[0] = 1;

		if (n >= 1)
			fibonacci[1] = 1;

		for (int i = 2; i < n; i++)
			fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];

		return fibonacci;
	}

	public static bool IsPalindrom(string text) 
	{
		text = text.ToLower();
		text = text.Replace(" ", "");

		char[] t = text.ToCharArray();

		for (int i = 0; i < t.Length / 2; i++)
		{
			bool isMirrored = t[i] == t[^(i - 1)];
			if (!isMirrored)
				return false;
		}

		return true;
	}

	public static int CountCharacters(string text) 
	{
		List<char> differentCharacters = new ();

		char[] t = text.ToCharArray();
		for (int i = 0; i < t.Length; i++)
		{
			char current = t[i];
			if (!differentCharacters.Contains(current))
				differentCharacters.Add(current);
		}

		return differentCharacters.Count;
	}


}
