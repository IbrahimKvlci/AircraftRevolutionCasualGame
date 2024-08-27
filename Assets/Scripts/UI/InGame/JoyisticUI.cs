using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyisticUI : MonoBehaviour
{


    private void Start()
    {
        GameManager.Instance.OnPausedChanged += Instance_OnPausedChanged;
        ((GameOverState)GameManager.Instance.GameOverState).OnGameOver += JoyisticUI_OnGameOver;

        Show();
    }

    private void JoyisticUI_OnGameOver(object sender, System.EventArgs e)
    {
        Hide();
    }

    private void Instance_OnPausedChanged(object sender, System.EventArgs e)
    {
        if (GameManager.Instance.IsGamePaused)
        {
            Hide();
        }
        else
        {
            Show();
        }
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {

    gameObject.SetActive(false); 
    }
}
