using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsSpaceshipMovement : MonoBehaviour
{
    [SerializeField] float angularSpeed = 180f;
    [SerializeField] float maxSpeed = 2f;
    [SerializeField] float acceleration = 1;

	[SerializeField, HideInInspector] Rigidbody2D rigidBody2D;	
	void OnValidate()
	{
        rigidBody2D = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate()
    {       
        // Gyorsulás
        float movementInput = Input.GetAxisRaw("Vertical");
        if (movementInput > 0)
        {
            Vector2 globalDirection = transform.up * movementInput;
            // rigidBody2D.velocity += acceleration * Time.fixedDeltaTime * globalDirection;

			rigidBody2D.AddForce(acceleration * globalDirection, ForceMode2D.Force);

			rigidBody2D.velocity = Vector2.ClampMagnitude(rigidBody2D.velocity, maxSpeed);
        }
    }

    void Update()
    {
        // Fordulás
        float rotationInput = -Input.GetAxisRaw("Horizontal");
        transform.Rotate(0, 0, rotationInput * angularSpeed * Time.deltaTime);
		rigidBody2D.angularVelocity = 0;

	}
}