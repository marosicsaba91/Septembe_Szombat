using UnityEngine;

class LoopPractice : MonoBehaviour
{
    void Start()
    {
        // int i = 1;
        int found = 0;

        for (int i = 1; found < 100; i++)
        {
            bool d3 = i % 3 == 0;
            bool d7 = i % 7 == 0;

            if (d3 || d7)
            {
                Debug.Log(i);
                found++;
            }
            //i++;
        }
        int length = 10;

        for (int i = 100; i >= 1; i--)
        {
            Debug.Log(i);
        }
    }
}
