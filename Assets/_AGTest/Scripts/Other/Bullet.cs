using _AGTestEnemies;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float damage;
    private float speed;
    private Vector3 direction;

    public void InitBullet(Vector3 direction, float damage, float speed)
    {
        this.damage = damage;
        this.speed = speed;
        this.direction = direction;
    }

    private void Update()
    {
        Ray bulletRay = new Ray(transform.position, direction.normalized);
        RaycastHit bulletHit = new RaycastHit();
        if (Physics.Raycast(bulletRay, out bulletHit, 0.5f))
        {
            if (bulletHit.collider.TryGetComponent(out EnemyHealth enemyHealth))
            {
                enemyHealth.ApplyDamage(damage);
                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
        transform.Translate(direction*speed*Time.deltaTime);
    }
}
