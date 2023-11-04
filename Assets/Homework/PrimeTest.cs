using UnityEngine;

public class PrimeTest : MonoBehaviour
{
    [SerializeField, Min(1)] int number = 10;
    [SerializeField] bool isPrime;

    void OnValidate()
    {
        isPrime = IsPrime(number);

        /*
        for (int i = 0; i < 100; i++)
        {
            if (i % 7 == 0)
            {
                continue;
            }

            Debug.Log(i);
        }
        */
    }


    bool IsPrime(int number)
    {
        if (number == 1)
            return false;

        if (number == 2)
            return true;

        for (int i = 3; i < number / 2; i += 2)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }


    bool IsPrime2(int number)
    {
        bool isPrime = true;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        return isPrime;
    }

}
