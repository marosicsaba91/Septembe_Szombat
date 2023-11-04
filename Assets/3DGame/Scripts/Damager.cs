using UnityEngine;

class Damager : MonoBehaviour
{
    [SerializeField] int damage = 5;

    void OnTriggerEnter(Collider other)
    {
        GameObject otherGameObject = other.gameObject;

        HealthObject healthObject = 
            otherGameObject.GetComponent<HealthObject>();

        if (healthObject != null) 
        {
            healthObject.Damage(damage);
        }
    }
}
