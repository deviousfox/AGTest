using UnityEngine;

namespace _AGTestEnemies
{
    public class EnemySpawn : MonoBehaviour
    {
        public bool CanSpawn => canSpawn;
        private bool canSpawn = true;

        private void OnBecameVisible()
        {
            canSpawn = false;
        }

        private void OnBecameInvisible()
        {
            canSpawn = true;
        }
    } 
}

