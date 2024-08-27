using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISavingDataService 
{
    void SaveHighScore(int highScore);
    int GetHighScore();
}
