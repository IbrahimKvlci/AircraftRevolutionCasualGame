using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLevelsPassedController : MonoBehaviour
{
    public event EventHandler OnEnemyPassedLevelsChanged;

    [field: SerializeField] public int MaxEnemyLevelslPassed { get; set; }
    [SerializeField] private AircraftBase aircraftBase;
    public int TotalEnemyLevelsPassed { get; set; }

    private float zDistanceFromAircraf;

    private void Start()
    {
        zDistanceFromAircraf = aircraftBase.transform.position.z - transform.position.z;
    }

    private void Update()
    {
        FollowAircraft();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Enemy>(out Enemy enemy))
        {
            AddEnemyLevelToTheTotalEnemyLevelsPassed(enemy.EnemyLevel);
            enemy.EnemyHealth.DestroySelf();
        }
    }

    private void AddEnemyLevelToTheTotalEnemyLevelsPassed(int level)
    {
        TotalEnemyLevelsPassed += level;
        OnEnemyPassedLevelsChanged?.Invoke(this, EventArgs.Empty);

        if(TotalEnemyLevelsPassed >= MaxEnemyLevelslPassed)
        {
            GameManager.Instance.IsGameOver = true;
        }

    }

    private void FollowAircraft()
    {
       transform.position=new Vector3(transform.position.x,transform.position.y, aircraftBase.transform.position.z-zDistanceFromAircraf);

    }
}
