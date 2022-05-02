using System.Collections;
using _AGTest.TagLabels;
using UnityEngine;
using UnityEngine.AI;

namespace _AGTestEnemies
{

[RequireComponent(typeof(NavMeshAgent))]
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        [SerializeField]private NavMeshAgent agent;
        private WaitForSeconds destinationTimer = new WaitForSeconds(1f);

        private void Awake()
        {
            if (agent == null)
                agent = GetComponent<NavMeshAgent>();
            agent.speed = moveSpeed;
            InitEnemy(FindObjectOfType<PlayerLabel>().transform);
        }

        public void InitEnemy(Transform target)
        {
            StartCoroutine(UpdateDestination(target));
        }
        
        private IEnumerator UpdateDestination(Transform target)
        {
            while (true)
            {
                    agent.SetDestination(target.position);
                    yield return destinationTimer;
            }
        }
    }
}
