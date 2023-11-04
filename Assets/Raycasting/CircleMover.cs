/*
using UnityEngine;

class CircleMover : MonoBehaviour
{
	[SerializeField] float anglarSpeed;
    void Update()
    {
		float dir = Input.GetAxis("Horizontal");

		Vector3 euler = transform.rotation.eulerAngles;

		euler.y += dir * anglarSpeed * Time.deltaTime;
		euler.y = Mathf.Clamp(euler.y, 0, 359.99f);

		transform.rotation = Quaternion.Euler(euler);

	}
}
*/