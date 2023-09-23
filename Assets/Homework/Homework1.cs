using UnityEngine;

class Homework1 : MonoBehaviour
{
    [SerializeField] int a, b;
    [SerializeField] int d, r;
    [Header("Mean")]
    [SerializeField] int n1;
    [SerializeField] int n2, n3, n4, n5;
    [SerializeField] float mean;
    [Space]
    [SerializeField] int pa;
    [SerializeField] int pb;
    [SerializeField] int pc;
    [SerializeField] bool isPythagorean;
    [Space]
    [SerializeField] float baseNumber;
    [SerializeField] int exponent;
    [SerializeField] float power;


    void OnValidate()
    {
        d = a / b;
        r = a % b;

        // --------------------

        mean = (n1 + n2 + n3 + n4 + n5) / 5f;

        // --------------------

        isPythagorean = pa * pa + pb * pb == pc * pc;

        // --------------------

        // power = Mathf.Pow(baseNumber, exponent);

        power = 1;
        for (int i = 0; i < exponent; i++)
        {
            power *= baseNumber;
            // power = power * baseNumber;    (Ugyanaz)
        }
    }

}
