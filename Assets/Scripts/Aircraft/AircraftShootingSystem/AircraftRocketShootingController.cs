using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftRocketShootingController : MonoBehaviour
{
    [field:SerializeField] public List<GameObject> RocketLocationList {  get; private set; }

    [SerializeField] private GameObject rocketPrefab;
    [field:SerializeField] public float rocketFireDuration {  get;  set; }
    [SerializeField] private Aircraft aircraft;
    [field:SerializeField] public float rocketDamageMultiplier {  get; set; }

    public float RocketDamage { get; set; }

    private IInputService inputService;

    private float rocketDurationtimer;

    private void Awake()
    {
        inputService=InGameIoC.Instance.InputService;
    }

    private void Start()
    {
        RocketDamage = aircraft.AircraftSO.rocketAttackDamage;
    }

    private void Update()
    {
        HandleRocketShoot();
    }

    private void HandleRocketShoot()
    {
        rocketDurationtimer += Time.deltaTime;

        if (rocketDurationtimer >= rocketFireDuration)
        {
            rocketDurationtimer = 0;

            Vector3 spawnPos = GetRandomSpawnPoint().position;

            Vector3 targetPos = new Vector3(aircraft.transform.position.x,0,aircraft.transform.position.z+5);

            Vector3 rocketDir=targetPos - spawnPos;
            rocketDir.Normalize();

            Rocket rocket = Instantiate(rocketPrefab,spawnPos ,Quaternion.identity ).GetComponent<Rocket>();
            rocket.Damage =  RocketDamage;
            rocket.TargetPos = targetPos;
        }
    }

    private Transform GetRandomSpawnPoint()
    {
        int randomIndex=Random.Range(0, RocketLocationList.Count);

        return RocketLocationList[randomIndex].transform;
    }
}
