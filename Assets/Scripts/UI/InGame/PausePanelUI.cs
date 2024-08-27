using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PausePanelUI : MonoBehaviour
{
    [SerializeField] private Button resumeBtn,exitBtn;
    [SerializeField] private Button pauseBtn;
    [SerializeField] private TextMeshProUGUI pausedTxt,resumeBtnTxt,exitBtnTxt;
    [SerializeField] private GameObject backgroundBlur;

    private void Awake()
    {
        resumeBtn.onClick.AddListener(() =>
        {
            GameManager.Instance.IsGamePaused = false;
            HidePanel();
        });
        exitBtn.onClick.AddListener(() =>
        {
            GameManager.Instance.IsGameOver = true;
            HidePanel();
        });
        pauseBtn.onClick.AddListener(() =>
        {
            GameManager.Instance.IsGamePaused = true;
            ShowPanel();
        });
    }

    private void Start()
    {
        pausedTxt.text = $"{GameLanguageController.PausedText}";
        resumeBtnTxt.text = $"{GameLanguageController.ResumeText}";
        exitBtnTxt.text =$"{GameLanguageController.ExitText}";
        HidePanel();
    }

    private void ShowPanel()
    {
        gameObject.SetActive(true);
        backgroundBlur.SetActive(true);
    }

    private void HidePanel()
    {
        backgroundBlur.SetActive(false);
        gameObject.SetActive(false);
    }
}
