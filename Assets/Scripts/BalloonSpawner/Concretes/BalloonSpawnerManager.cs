using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawnerManager : IBalloonSpawnerService
{
    public void SpawnBalloonAtPointWithLevel(Balloon balloon,Vector3 point, int level)
    {
        Balloon spawnedBalloon=GameObject.Instantiate(balloon,point,Quaternion.Euler(0,180,0));
        spawnedBalloon.LevelToGiveAircraft=level;
    }
}
