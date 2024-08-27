using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsSavingManager : ISavingDataService
{
    enum PlayerPrefsTitleEnum
    {
        HighScore,
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt(PlayerPrefsTitleEnum.HighScore.ToString(), 0);
    }

    public void SaveHighScore(int highScore)
    {
        PlayerPrefs.SetInt(PlayerPrefsTitleEnum.HighScore.ToString(), highScore);
    }
}
