using UnityEngine;

public class FireController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 1.5f;

    private float nextFireTime = 0f;

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        ObjectPooler.Instance.SpawnFromPool("Bullet", firePoint.position, firePoint.rotation);
    }
}