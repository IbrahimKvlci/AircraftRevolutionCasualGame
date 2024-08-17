using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyHealth EnemyHealth { get; set; }

    private void Awake()
    {
        EnemyHealth = new EnemyHealth();
        EnemyHealth.Health = 2;
    }
}
