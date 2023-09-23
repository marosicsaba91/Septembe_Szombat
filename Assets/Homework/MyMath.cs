using UnityEngine;

class MyMath : MonoBehaviour
{
    [SerializeField] float n1, n2;
    [SerializeField] float min, max;
    

    void OnValidate()
    {
        min = Min(n1, n2);
        max = Max(n1, n2);

        float x = Power(2.4f, 5);
        float y = Power(3.3f, 10);
        float z = Power(2, 8);

        float w = Mathf.Pow(2, 12);    }


    float Min(float a, float b)
    {
        return a < b ? a : b;
    }

    float Max(float a, float b)
    {
        return a > b ? a : b;
    }

    float Power(float baseNumber, int exponent) 
    {
        float power = 1;
        for (int i = 0; i < exponent; i++)
        {
            power *= baseNumber;
        }
        return power;
    }

    float Floor(float n) 
    {
        // float remainder = n % 1;
        // return n - remainder;

        int a = (int)n;
        return (float)a;
    }

    float Ceil(float n)
    {
        float remainder = n % 1;

        if (remainder == 0)
            return n;
        else
            return n + (1 - remainder);
    }

    float Round(float n)
    {
        float remainder = n % 1;
        if (remainder < 0.5f)
        {
            return Floor(n);
        }
        else 
        {
            return Ceil(n);
        }

    }
}