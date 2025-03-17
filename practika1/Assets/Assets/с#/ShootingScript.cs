using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public Transform firePoint;

    public GameObject bulletPrefab;
    public GameObject canvas;
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bulletInstance = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        bulletInstance.transform.parent = canvas.transform;
        RaycastHit2D hit = Physics2D.Raycast(firePoint.position, firePoint.forward);
        if (hit)
        {
            Debug.Log("Hit " + hit.collider.gameObject);
            Enemy enemy = hit.collider.gameObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.GetDamage();
            }
        }
    }
}
