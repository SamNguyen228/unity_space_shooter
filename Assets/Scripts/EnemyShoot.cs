using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Vector3 fireOffset;
    public float fireRate;

    float nextFireTime;

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void Shoot()
    {
        Vector3 firePosition = transform.position + fireOffset;

        Instantiate(bulletPrefab, firePosition, transform.rotation);
    }
}
