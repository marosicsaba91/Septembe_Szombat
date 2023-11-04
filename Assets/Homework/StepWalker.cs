using UnityEngine;

public class StepWalker : MonoBehaviour
{
    [SerializeField] float speed;

    Vector2 target;

    void Update()
    {
        if ((Vector2)transform.position == target)
        {

            Vector2 dir = Vector2.zero;
            if (Input.GetKeyDown(KeyCode.W))
                dir = Vector2.up;
            else if (Input.GetKeyDown(KeyCode.A))
                dir = Vector2.left;
            else if (Input.GetKeyDown(KeyCode.S))
                dir = Vector2.down;
            else if (Input.GetKeyDown(KeyCode.D))
                dir = Vector2.right;

            target += dir;
        }

        // transform.position += (Vector3) dir;

        // -------------------------------------

        transform.position = Vector3.MoveTowards(
            transform.position,
            target,
            speed * Time.deltaTime );
    }
}
