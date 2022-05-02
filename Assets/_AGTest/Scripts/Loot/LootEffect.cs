using UnityEngine;

namespace _AGTestLoot
{
    public class LootEffect : MonoBehaviour
    {
        [SerializeField] private float pingPongStrange = 1;
        [SerializeField] private float rotationSpeed = 10f;
        private Vector3 startPosition;
        private void Awake()
        {
            startPosition = transform.position;
        }

        void Update()
        {
            transform.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime,0);
            transform.position =
                new Vector3(startPosition.x, startPosition.y + Mathf.PingPong(Time.time, pingPongStrange), startPosition.z);
        }
    } 
}


