using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPanelUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText, levelText, playAgainBtnText,highScoreTitleTxt,highScoreText,rewardBtnText;
    [SerializeField] private Button playAgainBtn,rewardADBtn;

    [SerializeField] private Aircraft aircraft;
    [SerializeField] private GameObject backgroundBlur;

    private IADService adService;

    private void Awake()
    {
        adService = BasicIoC.Instance.ADService;

        playAgainBtn.onClick.AddListener(() =>
        {
            SceneLoader.LoadScene(SceneLoader.SceneEnum.GamePlayScene);
            adService.ShowAD();
        });
        rewardADBtn.onClick.AddListener(() =>
        {
            adService.ShowRewardAD(IADService.RewardEnum.ContinueReward);
        });
    }

    private void Start()
    {
        ((GameOverState)GameManager.Instance.GameOverState).OnGameOver += GameOverPanelUI_OnGameOver;
        GameManager.Instance.OnContinueGame += GameManager_OnContinueGame;

        Hide();
    }

    private void GameManager_OnContinueGame(object sender, System.EventArgs e)
    {
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
        highScoreTitleTxt.text = $"{GameLanguageController.HighScoreText}";
        rewardBtnText.text = $"{GameLanguageController.ContinueWatchText}";

        highScoreText.text = GameManager.Instance.HighScore.ToString();
    }

    private void Show()
    {
        gameObject.SetActive(true);
        backgroundBlur.SetActive(true);
        if (GameManager.Instance.IsGamePaused)
        {
            rewardADBtn.gameObject.SetActive(false);
        }
        else
        {
            rewardADBtn.gameObject.SetActive(true);
        }
    }
    private void Hide()
    {
        backgroundBlur.SetActive(false);
        gameObject.SetActive(false);
    }
}
