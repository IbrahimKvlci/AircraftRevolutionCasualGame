using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicIoC : MonoBehaviour
{
    public IGameReadyService GameReadyService { get; set; }
    public ILanguageService LanguageService { get; set; }
    public IADService ADService { get; set; }

    public static BasicIoC Instance { get; set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(gameObject);

        GameReadyService = new YDGameReadyManager();
        LanguageService = new YDLanguageManager();
        ADService = new YDADManager();
    }
}
