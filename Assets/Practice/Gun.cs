using UnityEngine;

class Gun : MonoBehaviour
{
    [SerializeField] int ammo = 10;

    [SerializeField] int magazineSize = 10;
    [SerializeField] int magazineCount = 5;

    void Update()
    {
        bool shoot = Input.GetKeyDown(KeyCode.Space);

        if (shoot)
        {
            if (ammo > 0)
            {
                Debug.Log("Bang!!!");
                ammo--;
            }
            else
            {
                Debug.Log("Click");

                if (magazineCount > 0)
                {
                    magazineCount--;
                    ammo = magazineSize;
                }
            }
        }
    }
}