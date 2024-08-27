using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class YDSavingManager : ISavingDataService
{
    public int GetHighScore()
    {
        return YandexGame.savesData.highScore;
    }

    public void SaveHighScore(int highScore)
    {
        YandexGame.savesData.highScore= highScore;
        YandexGame.SaveProgress();
    }
}
