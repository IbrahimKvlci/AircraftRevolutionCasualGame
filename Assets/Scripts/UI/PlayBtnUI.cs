using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayBtnUI : MonoBehaviour
{
    [SerializeField] private Button plyBtn;

    private void Awake()
    {
        plyBtn.onClick.AddListener(() =>
        {
            SceneLoader.LoadScene(SceneLoader.SceneEnum.GamePlayScene);
        });
    }
}
