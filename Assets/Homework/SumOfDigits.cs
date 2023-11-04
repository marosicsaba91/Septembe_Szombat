using System;
using UnityEngine;

public class SumOfDigits : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] int sum;

    void Start()
    {
        sum = GetSumOfDigits(number);
    }

    int GetSumOfDigits(int number)
    {
        string st = number.ToString();
        int summa = 0;

        for (int i = 0; i < st.Length; i++)
        {
            char c = st[i];
            int digit = int.Parse(c.ToString());
            summa += digit;
        }
        return summa;
    }
}
