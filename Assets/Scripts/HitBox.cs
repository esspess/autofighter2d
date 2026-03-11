using UnityEngine;

public class HitBox : MonoBehaviour
{
    [Header("Damage Settings")]
    public float damagePerTick;
    public float damageInterval = 1f; // 1.0 = Once per second

    private float timer;

    void Start()
    {
        // Set timer to interval so the first hit can happen immediately
        timer = damageInterval;
    }

    void Update()
    {
        if (timer < damageInterval)
        {
            timer += Time.deltaTime;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // Only attempt damage if the timer is ready
        if (timer >= damageInterval)
        {
            IDamagable other = collision.GetComponent<IDamagable>();

            if (other != null)
            {
                other.TakeDamage(damagePerTick);
                timer = 0; // Reset timer after successful damage
                Debug.Log($"Damaged {collision.name} for {damagePerTick}");
            }
        }
    }

    public void SetHitPoint(float amount)
    {
        damagePerTick = amount;
    }
}