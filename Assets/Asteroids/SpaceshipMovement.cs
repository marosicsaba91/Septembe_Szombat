using UnityEngine;

class SpaceshipMovement : MonoBehaviour
{
    [SerializeField] float angularSpeed = 180f;
    [SerializeField] float maxSpeed = 2f;
    [SerializeField] float acceleration = 1;
    [SerializeField] float drag = 0.5f;

    Vector3 velocity;
    
    void FixedUpdate()
    {
        // Gyorsulás
        float movementInput = Input.GetAxisRaw("Vertical");
        if (movementInput > 0)
        {
            Vector3 globalDirection = transform.up * movementInput;
            velocity += acceleration * Time.fixedDeltaTime * globalDirection;
            velocity = Vector3.ClampMagnitude(velocity, maxSpeed);             
        }

        // Közegellenállás
        Vector3 dragAcceleration = -velocity * drag;
        velocity += dragAcceleration * Time.fixedDeltaTime;
    }

    void Update()
    {         
        // Fordulás
        float rotationInput = -Input.GetAxisRaw("Horizontal");
        transform.Rotate(0, 0, rotationInput * angularSpeed * Time.deltaTime);

        // Mozgás
        transform.position += velocity * Time.deltaTime;
    }
}
