using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class AircraftSO : ScriptableObject
{
    public float speed;
    public float speedMultiplier;
    public float turningSpeed;
    public float idleAttackDamage;
    public float rocketAttackDamage;
    public float idleShootingDurationTime;
    public float turningTime;
}
