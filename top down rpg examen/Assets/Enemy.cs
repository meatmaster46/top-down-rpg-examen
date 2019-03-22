using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;

    public float health;

    public bool seesPlayer;
    public float visionLength;
    public LayerMask playerLayer;

    public float speed;

    //attacking
    public bool attacking = false;
    public GameObject attackHitbox;


    void Start()
    {
        player = FindObjectOfType<PlayerMovement>().gameObject;
    }
    
    void Update()
    {
        seesPlayer = Physics2D.OverlapCircle(this.transform.position, visionLength, playerLayer);

        if (seesPlayer == true)
        {
            Move();
        }
    }
    public void Move()
    {
        
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed);
        transform.up = player.transform.position - this.transform.position;

        if (Vector2.Distance(this.transform.position, player.transform.position) < 2)
        {
            Attack();
        }
    }
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
        Debug.Log("taken damage");
    }
    //RaycastHit2D hit = Physics2D.Raycast(this.transform.position, player.transform.position - transform.position);
    //Debug.DrawRay(this.transform.position, player.transform.position - transform.position, Color.red, visionLength);
    ////RaycastHit hit;

    //if (hit.collider != null)
    //{
    //    if (hit.collider != null)
    //    {
    //        seesPlayer = true;
    //    }
    //    else
    //    {
    //        seesPlayer = false;
    //    }
    //}
    //else
    //{
    //    seesPlayer = false;
    //}
}
