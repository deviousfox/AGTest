using System;
using _AGTest.TagLabels;
using UnityEngine;

namespace _AGTestLoot
{
    public class CubeLoot : Loot
    {
        public static Action<CubeColor> OnCubePickup;
        [SerializeField] private CubeColor cubeType;
        [SerializeField] private int amount;
        private PlayerLoot playerLoot;
        
        private void Awake()
        {
            playerLoot = FindObjectOfType<PlayerLoot>();
        }

        protected override void OnTriggerEnter(Collider other)
        {
            GameObject pickuper = other.gameObject;
            if (pickuper.TryGetComponent(out PlayerLabel label))
            {
                OnPickUp(pickuper);
            }
        }

        public override void OnPickUp(GameObject pickuper)
        {
            playerLoot.AddCube(cubeType, amount);
            OnCubePickup(cubeType);
            Destroy(gameObject);
        }
    }
    
    public enum CubeColor{red = 0,green = 1,yellow = 2}
}

