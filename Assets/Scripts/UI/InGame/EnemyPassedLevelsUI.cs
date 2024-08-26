using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyPassedLevelsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI enemyLevelsPassedTxt;
    [SerializeField] private TextMeshProUGUI enemyLevelsPassedMaxTxt;

    [SerializeField] private EnemyLevelsPassedController enemyLevelsPassedController;

    private void Start()
    {
        enemyLevelsPassedController.OnEnemyPassedLevelsChanged += EnemyLevelsPassedController_OnEnemyPassedLevelsChanged;

        enemyLevelsPassedMaxTxt.text = $"/{enemyLevelsPassedController.MaxEnemyLevelslPassed} LEVEL";
        UpdateEnemyLevelPassedText();
    }

    private void OnDisable()
    {
        enemyLevelsPassedController.OnEnemyPassedLevelsChanged -= EnemyLevelsPassedController_OnEnemyPassedLevelsChanged;

    }

    private void EnemyLevelsPassedController_OnEnemyPassedLevelsChanged(object sender, System.EventArgs e)
    {
        UpdateEnemyLevelPassedText();
    }

    private void UpdateEnemyLevelPassedText()
    {
        enemyLevelsPassedTxt.text = enemyLevelsPassedController.TotalEnemyLevelsPassed.ToString();

        switch (enemyLevelsPassedController.MaxEnemyLevelslPassed/(enemyLevelsPassedController.TotalEnemyLevelsPassed+1))
        {
            case 3:
                enemyLevelsPassedTxt.color = Color.yellow;
                break;
            case 1:
                enemyLevelsPassedTxt.color = new Color(1, 0.5f, 0);
                break;
            case 0:
                enemyLevelsPassedTxt.color=Color.red; break;
            default:
                break;
        }
    }
}
