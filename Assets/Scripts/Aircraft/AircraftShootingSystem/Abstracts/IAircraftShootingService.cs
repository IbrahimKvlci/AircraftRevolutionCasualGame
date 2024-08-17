using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAircraftShootingService 
{
    void RaycastShoot(Vector3 shootPos,Vector3 shootDir,float damage);
}
