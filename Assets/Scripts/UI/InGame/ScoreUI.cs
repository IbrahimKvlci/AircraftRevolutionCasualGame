using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreTxt;

    private void Start()
    {
        GameManager.Instance.OnScoreChanged += GameManager_OnScoreChanged;
    }

    private void OnDisable()
    {
        GameManager.Instance.OnScoreChanged -= GameManager_OnScoreChanged;
    }

    private void GameManager_OnScoreChanged(object sender, System.EventArgs e)
    {
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreTxt.text = GameManager.Instance.Score.ToString();
    }
}
