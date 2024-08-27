using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPanelUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText, levelText, playAgainBtnText;
    [SerializeField] private Button playAgainBtn;

    [SerializeField] private Aircraft aircraft;
    [SerializeField] private GameObject backgroundBlur;

    private void Awake()
    {
        playAgainBtn.onClick.AddListener(() =>
        {
            SceneLoader.LoadScene(SceneLoader.SceneEnum.GamePlayScene);
        });
    }

    private void Start()
    {
        ((GameOverState)GameManager.Instance.GameOverState).OnGameOver += GameOverPanelUI_OnGameOver;

        Hide();
    }

    private void GameOverPanelUI_OnGameOver(object sender, System.EventArgs e)
    {
        Show();
    }

    private void OnEnable()
    {
        UpdateScoreText();
        UpdateLevelText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = GameManager.Instance.Score.ToString();
    }
    private void UpdateLevelText()
    {
        levelText.text = $"{aircraft.Level} {GameLanguageController.LevelText}";
        playAgainBtnText.text = $"{GameLanguageController.PlayAgainText}";
    }

    private void Show()
    {
        gameObject.SetActive(true);
        backgroundBlur.SetActive(true);
    }
    private void Hide()
    {
        backgroundBlur.SetActive(false);
        gameObject.SetActive(false);
    }
}
