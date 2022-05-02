using UnityEngine;
using _AGTestLoot;

namespace _AGTestFabric
{
    public class LootFabric : MonoBehaviour
    {
       [SerializeField] private Loot[] availableLoots;

        public Loot GetRandomLoot(Vector3 lootSpawnPosition)
        {
            //Maybe a better solution using object pool but i'm so lazy
            return Instantiate(availableLoots[Random.Range(0, availableLoots.Length)], lootSpawnPosition,
                Quaternion.identity);
        }
    }
}

