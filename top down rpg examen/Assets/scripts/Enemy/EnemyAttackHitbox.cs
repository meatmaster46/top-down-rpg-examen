using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackHitbox : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerAttack>())
        {
            collision.gameObject.GetComponent<PlayerAttack>().TakeDamage(damage);
        }
    }
}
