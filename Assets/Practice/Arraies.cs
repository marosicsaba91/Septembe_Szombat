using System;
using UnityEngine;

class Arrays : MonoBehaviour
{
	[SerializeField] int number;
	[SerializeField] string[] strings;

	void Start()
	{
		number = AbsoluteVal(number);

		Reverse2(strings);

		/*
		int[] myFirstArray = new int[10];
		string[] myFirstStringArray = { "Alma", "Ban�n", "Citrom" };

		int element3 = myFirstArray[3];            // 0
		string element1 = myFirstStringArray[1];   // "Ban�n"

		myFirstArray[3] = 123;

		for (int i = 0; i < myFirstArray.Length; i++)
		{
			myFirstArray[i] = i + 1;
		}

		char myFirstChar = 'x';
		char char2 = '2';
		char char3 = '?';

		string myString = "Bear";
		char[] myCharArray = myString.ToCharArray();

		myCharArray[2] = 'e';
		string myNewString = new string(myCharArray);
		Debug.Log(myNewString);  //  "Beer"
		*/
	}

	float GetProduct(float[] array)
	{
		float product = 1;

		for (int i = 0; i < array.Length; i++)
		{
			product *= array[i];
		}
		return product;
	}

	int[] GetPowerArray(int length, int power) 
	{
		int[] array = new int[length];

		for (int i = 0; i < length; i++)
		{
			int n = i + 1;
			array[i] = Pow(n, power);
		}

		return array;
	}

	int Pow(int baseNum, int exp) 
	{
		int result = 1;
		for (int i = 0; i < exp; i++)
		{
			result *= baseNum;
		}
		return result;
	}

	float Max(float[] array) 
	{
		if (array.Length == 0) return 0;

		float max = array[0];

		for (int i = 1; i < array.Length; i++)
		{
			if (array[i] > max)
				max = array[i];
		}

		return max;	
	}

	string[] Reverse(string[] array) 
	{
		string[] reversed = new string[array.Length];

		for (int i = 0; i < array.Length; i++)
		{
			reversed[i] = array[^(i + 1)];
		}

		return reversed;
	}

	void Reverse2(string[] array)
	{
		for (int i = 0; i < array.Length /2 ; i++)
		{
			string temp = array[i];
			array[i] = array[^(i + 1)];
			array[^(i + 1)] = temp;
		}
	}

	int AbsoluteVal(int n) 
	{
		if (n < 0)
			n = -n;

		return n;
	}
}
