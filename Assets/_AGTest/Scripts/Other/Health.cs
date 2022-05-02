using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] protected float maxHealth = 100;
    [SerializeField] protected float currentHealth;

    protected virtual void Awake()
    {
        currentHealth = maxHealth;
    }

    public virtual void ApplyDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0) 
            Die();
            
    }

    protected virtual void Die()
    {
        
    }
}
