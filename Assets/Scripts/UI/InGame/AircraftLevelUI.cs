using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AircraftLevelUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI aircraftLevelTxt;
    [SerializeField] private Aircraft aircraft;

    private void Start()
    {
        aircraft.OnLevelChanged += Aircraft_OnLevelChanged;

        UpdateLevelTxt();
    }

    private void Aircraft_OnLevelChanged(object sender, System.EventArgs e)
    {
        UpdateLevelTxt();
    }

    private void UpdateLevelTxt()
    {
        aircraftLevelTxt.text=$"{aircraft.Level} LEVEL";
    }
}
