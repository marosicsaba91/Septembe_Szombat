using UnityEngine;

class Rocket : MonoBehaviour
{
	[SerializeField] Transform target;

	[SerializeField] float maxSpeed = 5f;
	[SerializeField] float angularSpeed = 360f;
	[SerializeField] float acceleration = 2f;
	[SerializeField] float maxDistance = 1f;
	[SerializeField] bool startAtMaxSpeed;

	float speed;

	void Start()
	{
		if (startAtMaxSpeed)
			speed = maxSpeed;
	}

	void Update()
    {
		// FORDUL
		Vector3 targetDir = target.position - transform.position;

		Quaternion targetRotation = Quaternion.LookRotation(targetDir);
		float speedRate = speed / maxSpeed;

		transform.rotation =
			Quaternion.RotateTowards(transform.rotation, targetRotation, speedRate * angularSpeed * Time.deltaTime);

		// GYORSULÁS / LASSULÁS
		float distance = targetDir.magnitude;
		bool isInsideMaxDistance = maxDistance >= distance;
		float targetSpeed = isInsideMaxDistance ? 0 : maxSpeed;
		speed = Mathf.MoveTowards(speed, targetSpeed, acceleration * Time.deltaTime);

		// MOZOG
		Vector3 direction = transform.forward;
		Vector3 velocity = direction * speed;
		transform.position += velocity * Time.deltaTime;
    }

	void OnDrawGizmos()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(target.position, maxDistance);
	}
}
