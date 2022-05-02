using System.Collections;
using UnityEngine;

namespace _AGTestEnemies
{
    public class EnemyAttack : MonoBehaviour
    {
        [SerializeField] private float attackCooldown = 1f;
        [SerializeField] private float damage = 5f;
        private WaitForSeconds attackTimer;

        private void Start()
        {
            attackTimer = new WaitForSeconds(attackCooldown);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out PlayerHealth playerHealth))
            {
                StartCoroutine(AttackCycle(playerHealth));
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out PlayerHealth playerHealth))
            {
                StopAllCoroutines();
            }
        }

        private IEnumerator AttackCycle(PlayerHealth target)
        {
            while (true)
            {
                target.ApplyDamage(damage);
                yield return attackTimer;
            }
        }
    }
}

