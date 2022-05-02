using System.Collections;
using _AGTestFabric;
using UnityEngine;

namespace _AGTestEnemies
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private EnemyFabric enemyFabric;
        [SerializeField] private EnemySpawn[] spawns;
        [SerializeField] private float spawnCooldown = 3f;
        private WaitForSeconds spawnTimer;
       
        private void Awake()
        {
            if(enemyFabric == null || spawns.Length == 0)
                return;
            spawnTimer = new WaitForSeconds(spawnCooldown);
            StartCoroutine(SpawnCycle());
        }

        public void SpawnEnemy()
        {
            foreach (var spawn in spawns)
            {
                if (spawn.CanSpawn)
                {
                    enemyFabric.GetRandomEnemy(spawn.transform.position);
                    break;
                }
            }
        }

        private IEnumerator SpawnCycle()
        {
            while (true)
            {
                SpawnEnemy();
                yield return spawnTimer;
            }
        }
    }
}

