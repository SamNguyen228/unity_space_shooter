using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float shootingInterval;
    private float lastBulletTime;

    void Update()
    {
        if (Time.time - lastBulletTime >= shootingInterval)
        {
            ShootBullet();
            lastBulletTime = Time.time;
        }
    }

    private void ShootBullet()
    {
        Instantiate(bulletPrefabs, transform.position, transform.rotation);
    }
}
