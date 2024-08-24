using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth
{
    public float Health { get; set; }

    public void TakeDamage(float damage)
    {
        Health -= damage;
        if(Health < 0)
        {
            Debug.Log("Dead");
        }
        Debug.Log("Damaged");
    }
    public void SetHealthByLevel(float healthMultiplier,int level)
    {
        Health = healthMultiplier*level;
    }
}
