using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttack : MonoBehaviour
{
    public GameObject attackHitbox;

    public bool attacking = false;

    public int hunger;
    public int health;
    public Text healthText;
    public int hungerTimer;
    public int hungerTimerMax;
    private Animator animator;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        hungerTimer--;
        if (hungerTimer <= 0)
        {
            hunger--;
            hungerTimer = hungerTimerMax;
            if (hunger <= 0)
            {
                hunger = 0;
                TakeDamage(1);
            }
        }
    }

    void Update()
    {
        healthText.text = ("HP" + health);
        
        if (Input.GetMouseButtonDown(0)&& attacking == false)//(Input.GetButtonDown("attack"))
        {
            Attack();
        }
    }
    
    //attack functions
    void Attack()
    {
        attacking = true;
        animator.SetBool("Attacking" , true);
        Invoke("AttackActive", 0.1f);
    }
    void AttackActive()
    {
        attackHitbox.gameObject.SetActive(true);
        Invoke("AttackEnd", 0.5f);
    }
    void AttackEnd()
    {
        attackHitbox.gameObject.SetActive(false);
        animator.SetBool("Attacking", false);
        attacking = false;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Death();
        }
    }
    public void Death()
    {
        healthText.text = ("HP 0");
        this.gameObject.SetActive(false);
    }
}
