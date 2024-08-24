using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class EnemySO : ScriptableObject
{
    public float healthMultiplier;
    public float speed;
    public float maxVisualScale;
    public float minVisualScale;
    public int maxLevel;
}
