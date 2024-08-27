using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class YDLanguageManager : ILanguageService
{
    public GameLanguageController.LanguagesEnum GetLanguagesEnum()
    {
        switch (YandexGame.lang)
        {
            case "en":
                return GameLanguageController.LanguagesEnum.English;
            case "ru":
                return GameLanguageController.LanguagesEnum.Russian;
            default:
                return GameLanguageController.LanguagesEnum.English;
        }
    }
}
