using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawningDistanceFromPlane;
    [SerializeField] private float spawningXPointStart;
    [SerializeField] protected float spawningXPointEnd;

    [SerializeField] private float spawningTimerDurationMax,spawningTimerDurationMin;

    [SerializeField] private Aircraft aircraft;
    [SerializeField] private AircraftBase aircraftBase;
    [SerializeField] private Enemy enemyPrefab;

    private float timer,timerMax;

    private IEnemySpawnerService _enemySpawnerService;

    public static EnemySpawner Instance { get; set; }

    private void Awake()
    {
        Instance = this;

        _enemySpawnerService = InGameIoC.Instance.EnemySpawnerService;
    }

    private void Start()
    {
        timerMax = spawningTimerDurationMax;
    }

    public void HandleEnemySpawn()
    {
        timer += Time.deltaTime;
        if (timer >= timerMax)
        {
            timer = 0;
            SetTimerMax();
            SpawnEnemyAtRandomPointAwayFromAircraft();
        }
    }

    private void SpawnEnemyAtRandomPointAwayFromAircraft()
    {
        Vector3 randomXPointAwayFromAircraft = new Vector3(Random.Range(spawningXPointStart, spawningXPointEnd), 0, aircraftBase.transform.position.z + spawningDistanceFromPlane);
        _enemySpawnerService.SpawnEnemyWithLevelAtPoint(randomXPointAwayFromAircraft, enemyPrefab, Random.Range(1,GameManager.Instance.GetMaxEnemyLevelAccordingToTheDifficulty()+1));
    }

    private void SetTimerMax()
    {
        timerMax = spawningTimerDurationMax - ((spawningTimerDurationMax - spawningTimerDurationMin) / GameManager.Instance.GameDifficultyCount) * (GameManager.Instance.GameDifficulty+1);
    }
}
