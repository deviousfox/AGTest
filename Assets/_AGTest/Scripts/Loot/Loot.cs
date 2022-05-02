using UnityEngine;

namespace _AGTestLoot
{
    
    [RequireComponent(typeof(Rigidbody))]
    public class Loot : MonoBehaviour
    {
        protected virtual void OnTriggerEnter(Collider other)
        {
            
        }

        public virtual void OnPickUp(GameObject pickuper)
        {
            
        }
    }
}

