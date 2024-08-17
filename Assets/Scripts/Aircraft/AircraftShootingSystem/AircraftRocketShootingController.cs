using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftRocketShootingController : MonoBehaviour
{
    [field:SerializeField] public List<GameObject> RocketLocationList {  get; private set; }

    [SerializeField] private GameObject rocketPrefab;

    private IInputService inputService;


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
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 spawnPos = GetRandomSpawnPoint().position;

            Vector3 targetPos = inputService.GetMousePositionOnATarget();

            Vector3 rocketDir=targetPos - spawnPos;
            rocketDir.Normalize();

            Rocket rocket = Instantiate(rocketPrefab,spawnPos ,Quaternion.identity ).GetComponent<Rocket>();
            rocket.TargetPos = targetPos;
        }
    }

    private Transform GetRandomSpawnPoint()
    {
        int randomIndex=Random.Range(0, RocketLocationList.Count);

        return RocketLocationList[randomIndex].transform;
    }
}
