using UnityEngine;

public class VectorFunctions : MonoBehaviour
{
    [SerializeField] Vector2 a;
    [SerializeField] Vector2 b;

    [SerializeField] int stepCount;
    [SerializeField] Vector2 step;

    void OnValidate() 
    {
        Vector2 v = b - a;
        float length = v.magnitude;
        stepCount = Mathf.CeilToInt(length);
        step = v / stepCount;
    }


    Vector3 GetDirection(Vector3 a, Vector3 b) 
    {
        Vector3 v = b - a;

        v.Normalize();

        return v;    
    }



}
