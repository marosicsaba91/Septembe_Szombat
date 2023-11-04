using System.Collections.Generic;
using UnityEngine;

class Collectable : MonoBehaviour
{
	static List<Collectable> all = new();

	void OnEnable()
	{
		all.Add(this);
	}

	void OnDisable()
	{
		all.Remove(this);
	}

	static void TeleportAll() 
	{
		foreach (var c in all)
			c.Teleport();
	}

	[SerializeField] int value = 10;
	[SerializeField] Bounds teleportBounds;

	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.magenta;
		Gizmos.DrawWireCube(teleportBounds.center, teleportBounds.size);		
	}

	public int GetValue() { return value; }

	public void Teleport()
	{
		float rx = Random.Range(teleportBounds.min.x, teleportBounds.max.x);
		float ry = Random.Range(teleportBounds.min.y, teleportBounds.max.y);
		float rz = Random.Range(teleportBounds.min.z, teleportBounds.max.z);

		float r1 = Random.Range(0f, 100f);

		Vector3 randomPoint = new(rx, ry, rz);
		transform.position = randomPoint;
	}
}
