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
        RaycastHit2D hit = Physics2D.Raycast(firePoint.position, firePoint.forward);
        if (hit)
        {
            Debug.Log("Hit " + hit.collider.gameObject);
        }
    }
}
