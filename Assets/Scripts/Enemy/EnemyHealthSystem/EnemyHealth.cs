using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth
{
    public float Health { get; set; }

    private Enemy _enemy;

    public EnemyHealth(Enemy enemy)
    {
        _enemy = enemy;
    }

    public void TakeDamage(float damage)
    {
        Health -= damage;
        if(Health < 0)
        {
            DestroySelf();
        }
    }
    public void SetHealthByLevel(float healthMultiplier,int level)
    {
        Health = healthMultiplier*level;
    }

    public void DestroySelf()
    {
        GameObject.Destroy(_enemy.gameObject);
    }
}
