using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftRocketShootingController : MonoBehaviour
{
    [field:SerializeField] public List<GameObject> RocketLocationList {  get; private set; }

    [SerializeField] private GameObject rocketPrefab;
    [SerializeField] private float rocketFireDuration;
    [SerializeField] private Aircraft aircraft;
    [SerializeField] private float rocketDamageMultiplier;

    private IInputService inputService;

    private float rocketDurationtimer;

    private void Awake()
    {
        inputService=InGameIoC.Instance.InputService;
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
            rocket.Damage =  aircraft.AircraftSO.rocketAttackDamage+aircraft.Level * rocketDamageMultiplier;
            rocket.TargetPos = targetPos;
        }
    }

    private Transform GetRandomSpawnPoint()
    {
        int randomIndex=Random.Range(0, RocketLocationList.Count);

        return RocketLocationList[randomIndex].transform;
    }
}
