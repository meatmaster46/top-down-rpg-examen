using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject attackHitbox;

    public bool attacking = false;

    public int hunger;
    public int health;
    public int hungerTimer;

    private void FixedUpdate()
    {
        hungerTimer--;
        if (hungerTimer <= 0)
        {
            hunger--;
            if (hunger <= 0)
            {
                hunger = 0;
                TakeDamage(1);
            }
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)&& attacking == false)//(Input.GetButtonDown("attack"))
        {
            Attack();
        }
    }
    
    //attack functions
    void Attack()
    {
    attacking = true;
    Invoke("AttackActive", 0.1f);
    }
    void AttackActive()
    {
        attackHitbox.gameObject.SetActive(true);
        Invoke("AttackEnd", 0.2f);
    }
    void AttackEnd()
    {
        attackHitbox.gameObject.SetActive(false);
        attacking = false;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
