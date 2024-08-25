using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBalloonSpawnerService
{
    void SpawnBalloonAtPointWithLevel(Balloon balloon,Vector3 point,int level);
}
