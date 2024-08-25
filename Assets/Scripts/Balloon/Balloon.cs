using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int LevelToGiveAircraft { get; set; }


    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Aircraft>(out Aircraft aircraft))
        {
            aircraft.AddLevel(LevelToGiveAircraft);
            DestroyBalloon();
        }
    }

    private void DestroyBalloon()
    {
        Destroy(gameObject);
    }
}
