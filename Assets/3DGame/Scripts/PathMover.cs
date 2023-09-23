using UnityEngine;

class PathMover : MonoBehaviour
{
    [SerializeField] Transform t1, t2;
    [SerializeField] float speed = 5;
    [SerializeField] Color c1, c2;

    [SerializeField, Range(0,1)] float startPositionRate = 0.5f;

    Vector3 targetPoint;

    void OnValidate()
    {
        /*
        transform.position =
            t1.position * startPositionRate +
            t2.position * (1 - startPositionRate);
        */

        transform.position = 
            Vector3.Lerp(t1.position, t2.position, startPositionRate);
    }

    void Start()
    {
        targetPoint = t2.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position, targetPoint, speed * Time.deltaTime);

        if (transform.position == targetPoint)
        {
            if (targetPoint == t1.position)
                targetPoint = t2.position;
            else
                targetPoint = t1.position;
        }
    }

    void OnDrawGizmos()
    {
        if (t1 == null || t2 == null)
            return;

        Vector3 p1 = t1.position;
        Vector3 p2 = t2.position;

        Gizmos.color = c1;
        Gizmos.DrawWireSphere(p1, 0.2f);

        Gizmos.color = c2;
        Gizmos.DrawWireSphere(p2, 0.2f);

        // Gizmos.color = targetPoint == p1 ? c1 : c2;
        Gizmos.color = Color.Lerp(c1, c2, startPositionRate);
        Gizmos.DrawLine(p1, p2);
    }
}
