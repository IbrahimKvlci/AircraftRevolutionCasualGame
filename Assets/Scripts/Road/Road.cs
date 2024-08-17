using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [field:SerializeField] public List<GameObject> RoadSectionList {  get; private set; }

    [SerializeField] public GameObject CurrentRoadSection {  get;  set; }
    [SerializeField] private Aircraft aircraft;

    [SerializeField] private float distanceBetweenRoads;

    private void Awake()
    {
        CurrentRoadSection = RoadSectionList[0];
    }

    private void Update()
    {
        HandleEndlessRoad();
    }

    private void HandleEndlessRoad()
    {
        foreach (var roadSection in RoadSectionList)
        {
            if (aircraft.transform.position.z >= roadSection.transform.position.z)
            {
                if (CurrentRoadSection != roadSection)
                {
                    CurrentRoadSection= roadSection;
                    roadSection.transform.position += Vector3.forward * distanceBetweenRoads;
                }
            }
        }
    }

}
