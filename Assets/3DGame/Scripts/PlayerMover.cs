using UnityEngine;

class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float angularSpeed = 360;
    [SerializeField] Transform cameraTransform;

    void Update()
    {
        Vector3 direction = GetInputVector();

        if (direction != Vector3.zero)
        {
            Vector3 cameraDir = cameraTransform.TransformDirection(direction);
            cameraDir.y = 0;
            cameraDir.Normalize();

            Vector3 velocity = cameraDir * speed;
            transform.position += velocity * Time.deltaTime;

            Quaternion targetRotation = Quaternion.LookRotation(cameraDir);
            transform.rotation = Quaternion.RotateTowards (
                transform.rotation,
                targetRotation,
                angularSpeed * Time.deltaTime);
        }
    }

    Vector3 GetInputVector()
    {
        /*
        bool inputUp = Input.GetKey(KeyCode.W);
        bool inputLeft = Input.GetKey(KeyCode.A);
        bool inputDown = Input.GetKey(KeyCode.S);
        bool inputRight = Input.GetKey(KeyCode.D);

        float x = BoolsToDirection(inputRight, inputLeft);
        float z = BoolsToDirection(inputUp, inputDown);
        */

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 direction = new(x, 0, z);
        direction.Normalize();
        return direction;
    }

    float BoolsToDirection(bool positive, bool negative)
    {
        float result = 0;
        if (positive)
            result += 1;
        if (negative)
            result -= 1;
        return result;
    }

}
