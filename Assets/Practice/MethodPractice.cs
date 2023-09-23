using UnityEngine;

class MethodPractice : MonoBehaviour
{
    [SerializeField] float input;
    [SerializeField] float abs;

    void OnValidate()
    {
        abs = MyAbs(input);

        /*
        float pow = Mathf.Pow(2, 3);    // 8
        float abs = Mathf.Abs(-12);     // 12
        float sign = Mathf.Sign(-34);   // -1
        float rounded = Mathf.Round(22.75f);   //  23f;
        float floored = Mathf.Floor(22.999f);  //  22f;
        float ceiled = Mathf.Ceil(22.001f);    //  23f;

        float min = Mathf.Min(12, 4);  // 4
        float max = Mathf.Max(47, 3);  // 47
        */
    }

    float MyAbs(float number) 
    {
        if (number < 0)
            return -number;
        else
            return number;
    }
}
