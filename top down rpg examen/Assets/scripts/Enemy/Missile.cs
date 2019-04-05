using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public int damage;

    private void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rb.velocity = transform.up * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerAttack>())
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<PlayerAttack>().TakeDamage(damage);
        }
        
    }
}
