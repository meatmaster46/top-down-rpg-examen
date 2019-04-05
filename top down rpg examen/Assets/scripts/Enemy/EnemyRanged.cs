using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRanged : Enemy
{
    public GameObject ShootThing;
    public Transform ShootStart;

    public override void Attack()
    {
        base.Attack();
        Instantiate(ShootThing, ShootStart.transform.position, transform.rotation);
    }
}
