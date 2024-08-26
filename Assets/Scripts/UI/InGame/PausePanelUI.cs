using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausePanelUI : MonoBehaviour
{
    [SerializeField] private Button resumeBtn,exitBtn;
    [SerializeField] private Button pauseBtn;

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
        HidePanel();
    }

    private void ShowPanel()
    {
        gameObject.SetActive(true);
    }

    private void HidePanel()
    {
        gameObject.SetActive(false);
    }
}
