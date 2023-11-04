using System;
using System.Collections;
using UnityEngine;

class HealthObject : MonoBehaviour
{
    [SerializeField] int startHealth = 10;

	[SerializeField] float invincibilityFrames = 2f;
	[SerializeField] float flickTime = 0.2f;

    int heath;

    void Start()
    {
        heath = startHealth;
    }

    public void Damage(int damage)
    {
        if (heath <= 0) return;

        heath -= damage;
		StartCoroutine(StartInvincibility());

        if (heath < 0)
            heath = 0;

        if (heath <= 0)
            Debug.Log("I'm dead");
    }

	IEnumerator StartInvincibility() 
	{
		Collider coll = GetComponentInChildren<Collider>();
		Renderer[] renderers = GetComponentsInChildren<Renderer>();
		coll.enabled = false;

		float maxTime = Time.time + invincibilityFrames;
		while (Time.time < maxTime) 
		{
			yield return new WaitForSeconds(flickTime);
			foreach (Renderer renderer in renderers)
				renderer.enabled = !renderer.enabled;
		}

		foreach (Renderer renderer in renderers)
			renderer.enabled = true;

		coll.enabled = true;
	}

	void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            heath = startHealth;
        }
    }
}