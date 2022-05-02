using System;
using UnityEngine.SceneManagement;

public class PlayerHealth : Health
{
    public static Action<int> OnUpdatePlayerHealth;

    private void Start()
    {
        OnUpdatePlayerHealth((int) currentHealth);
    }
        
    

    public override void ApplyDamage(float damage)
    {
        OnUpdatePlayerHealth((int)currentHealth);
        base.ApplyDamage(damage);
    }

    protected override void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
