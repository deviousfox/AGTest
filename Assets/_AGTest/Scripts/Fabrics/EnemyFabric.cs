using _AGTestEnemies;
using UnityEngine;

namespace _AGTestFabric
{
    public class EnemyFabric : MonoBehaviour
    {
        [SerializeField] private Enemy[] availableEnemies;

        public Enemy GetRandomEnemy(Vector3 enemySpawnPosition)
        {
            
           
                return Instantiate(availableEnemies[Random.Range(0, availableEnemies.Length)], enemySpawnPosition,
                    Quaternion.identity);
            
            
        }
    }
}

