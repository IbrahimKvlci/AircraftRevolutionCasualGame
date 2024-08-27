using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingDataController : MonoBehaviour
{
    private ISavingDataService _savingDataService;

    private void Awake()
    {
        _savingDataService = InGameIoC.Instance.SavingDataService;
    }

    private void Start()
    {
        GameManager.Instance.OnHighScoreChanged += GameManager_OnHighScoreChanged;

        GameManager.Instance.HighScore=_savingDataService.GetHighScore();
    }

    private void GameManager_OnHighScoreChanged(object sender, System.EventArgs e)
    {
        _savingDataService.SaveHighScore(GameManager.Instance.HighScore);
    }

}
