using _AGTestFabric;

namespace _AGTestEnemies
{
    public class EnemyHealth : Health
    {
        protected override void Die()
        {
            FindObjectOfType<LootFabric>().GetRandomLoot(transform.position);
            Destroy(gameObject);
        }
    }
}

