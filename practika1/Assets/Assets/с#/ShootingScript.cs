using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public Transform firePoint;
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit2D hit = Physics2D.Raycast(firePoint.position, firePoint.right);
        if (hit)
        {

        }
    }
}
