using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftShootingManager : IAircraftShootingService
{
    public void RaycastShoot(Vector3 shootPos, Vector3 shootDir,float damage)
    {
        if (Physics.Raycast(shootPos, shootDir,out RaycastHit hitInfo))
        {
            if(hitInfo.transform.TryGetComponent<Enemy>(out Enemy enemy))
            {
                enemy.EnemyHealth.TakeDamage(damage);
            }
        }
    }
}
