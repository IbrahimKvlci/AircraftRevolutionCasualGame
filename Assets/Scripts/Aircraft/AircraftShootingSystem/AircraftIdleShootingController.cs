using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftIdleShootingController : MonoBehaviour
{
    [field: SerializeField] public List<GameObject> ShootingLocationList { get; set; }
    [SerializeField] private Aircraft aircraft;

    private IAircraftShootingService _aircraftShootingService;

    private float timer;

    private void Awake()
    {
        _aircraftShootingService = InGameIoC.Instance.AircraftShootingService;
    }

    private void Start()
    {
        timer = 0;
    }

    public void HandleIdleShooting()
    {
        timer += Time.deltaTime;
        if (timer>=aircraft.AircraftSO.idleShootingDurationTime)
        {
            timer = 0;

            Transform shootingTransfom = GetRandomShootingPos();
            _aircraftShootingService.RaycastShoot(shootingTransfom.position, shootingTransfom.forward, aircraft.AircraftSO.idleAttackDamage);
        }
    }

    private Transform GetRandomShootingPos()
    {
        int randomIndex=Random.Range(0,ShootingLocationList.Count);

        return ShootingLocationList[randomIndex].transform;
    }
}
