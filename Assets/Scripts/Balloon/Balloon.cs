using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int LevelToGiveAircraft { get; set; }
    [SerializeField] private TextMeshProUGUI levelTxt;


    private void Start()
    {
        levelTxt.text = $"+{LevelToGiveAircraft} {GameLanguageController.LevelText}";
    }

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
        SoundManager.Instance.PlayAudioFromPool(SoundManager.Instance.AudioSO.balloonSound);
        Destroy(gameObject);
    }
}
