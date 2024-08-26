using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftVisual : MonoBehaviour
{
    [SerializeField] private List<GameObject> aircraftVisualList;
    [SerializeField] private Aircraft aircraft;

    private void Start()
    {
        aircraft.OnLevelChanged += Aircraft_OnLevelChanged;

        ChangeVisual();
    }

    private void OnDisable()
    {
        aircraft.OnLevelChanged -= Aircraft_OnLevelChanged;

    }

    private void Aircraft_OnLevelChanged(object sender, System.EventArgs e)
    {
        ChangeVisual();
    }

    private void ChangeVisual()
    {
        foreach (var item in aircraftVisualList)
        {
            item.SetActive(false);
        }

        for (int i = aircraftVisualList.Count; i >= 0; i--)
        {
            if (aircraft.Level >= (20 / aircraftVisualList.Count) * (i))
            {
                if(i==aircraftVisualList.Count)
                    aircraftVisualList[i-1].SetActive(true);
                else
                    aircraftVisualList[i].SetActive(true);
                break;
            }
        }
    }
}
