using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneLoader
{
    public enum SceneEnum
    {
        GamePlayScene,
    }

    public static void LoadScene(SceneEnum scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
}
