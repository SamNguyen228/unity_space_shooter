using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    public int healthPoint;
    public System.Action onDead;
    public System.Action onHealthChanged;

    public void OTriggerEnter2D(Collider2D collision) => Die();

    private void Start()
    {
        healthPoint = defaultHealthPoint;
        onHealthChanged?.Invoke();
    }

    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(explosion, 1);
        onDead?.Invoke();
    }

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;

        healthPoint -= damage;
        onHealthChanged?.Invoke();

        if (healthPoint <= 0) Die();
    }
}
