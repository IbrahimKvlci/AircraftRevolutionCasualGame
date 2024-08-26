using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftBase : MonoBehaviour
{
    [SerializeField] private Aircraft aircraft;

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        transform.Translate(Vector3.forward * aircraft.Speed * Time.deltaTime);
    }
}
