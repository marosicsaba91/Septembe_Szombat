using UnityEngine;

class HealthObject : MonoBehaviour
{
    [SerializeField] int startHealth = 10;

    int heath;

    void Start()
    {
        heath = startHealth;
    }

    public void Damage(int damage)
    {
        if (heath <= 0) return;

        heath -= damage;

        if (heath < 0)
            heath = 0;

        if (heath <= 0)
            Debug.Log("I'm dead");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            heath = startHealth;
        }
    }
}