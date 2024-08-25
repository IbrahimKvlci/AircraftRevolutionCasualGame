using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    [SerializeField] private float spawningDistanceFromPlane;
    [SerializeField] private List<Vector3> pointsToSpawnBalloonList;
    [SerializeField] private float balloonSpawningTimeMin, balloonSpawningTimeMax;
    [SerializeField] private int balloonLevelMin, balloonLevelMax;

    [SerializeField] private Balloon balloonPrefab;
    [SerializeField] private Aircraft aircraft;

    private float timerMax;
    private float timer;
  
    private IBalloonSpawnerService _balloonSpawnerService;

    private void Awake()
    {
        _balloonSpawnerService = InGameIoC.Instance.BalloonSpawnerService;
    }

    private void Start()
    {
        timerMax=Random.Range(balloonSpawningTimeMin,balloonSpawningTimeMax);
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timerMax)
        {
            timer = 0;
            timerMax = Random.Range(balloonSpawningTimeMin, balloonSpawningTimeMax);

            SpawnBalloon();
        }
    }

    private void SpawnBalloon()
    {
        int randomBalloonLevel=Random.Range(balloonLevelMin, balloonLevelMax+1);


        _balloonSpawnerService.SpawnBalloonAtPointWithLevel(balloonPrefab, GetRandomPointFromListWithAwayFromAircraft(), randomBalloonLevel);
    }

    private Vector3 GetRandomPointFromListWithAwayFromAircraft()
    {
        int randIndex=Random.Range(0,pointsToSpawnBalloonList.Count);
        Vector3 randPoint=pointsToSpawnBalloonList[randIndex];
        randPoint.z=aircraft.transform.position.z+spawningDistanceFromPlane;

        return randPoint;
    }

}
