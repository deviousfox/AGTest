using System;
using System.Collections.Generic;
using UnityEngine;

namespace _AGTestLoot
{
    public class PlayerLoot : MonoBehaviour
    {
        public static Action<Dictionary<CubeColor, int>> OnUpdatePlayerLoot;
        
        private Dictionary<CubeColor, int> storage;

        private void Start()
        {
            storage = new Dictionary<CubeColor, int>()
            {
                {CubeColor.green, 0},
                {CubeColor.red, 0},
                {CubeColor.yellow, 0}
            };
            OnUpdatePlayerLoot(storage);
        }

        public void AddCube(CubeColor color, int amount)
        {
            storage[color] += amount;
            OnUpdatePlayerLoot(storage);
        }
    }
}

