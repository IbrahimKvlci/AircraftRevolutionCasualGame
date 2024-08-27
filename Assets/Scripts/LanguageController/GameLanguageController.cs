using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLanguageController
{
    public static event EventHandler OnLanguageChanged;

    public enum LanguagesEnum
    {
        Russian,
        English,
    }

    private static LanguagesEnum _language=LanguagesEnum.Russian;
    public static LanguagesEnum Language
    {

        get { return _language; }
        set { _language = value; OnLanguageChanged?.Invoke(typeof(GameLanguageController), EventArgs.Empty); }
    }

    public static string LevelText
    {
        get
        {
            switch (Language)
            {
                case LanguagesEnum.Russian:
                    return "УРОВЕНЬ";
                    break;
                case LanguagesEnum.English:
                    return "LEVEL";
                    break;
                default:
                    return "LEVEL";
                    break;
            }
        }
    }
    public static string PlayAgainText
    {
        get
        {
            switch (Language)
            {
                case LanguagesEnum.Russian:
                    return "ИГРАТЬ СНОВА";
                    break;
                case LanguagesEnum.English:
                    return "PLAY AGAIN";
                    break;
                default:
                    return "PLAY AGAIN";
                    break;
            }
        }
    }
    public static string ResumeText
    {
        get
        {
            switch (Language)
            {
                case LanguagesEnum.Russian:
                    return "ПРОДОЛЖИТЬ";
                    break;
                case LanguagesEnum.English:
                    return "RESUME";
                    break;
                default:
                    return "RESUME";
                    break;
            }
        }
    }
    public static string PausedText
    {
        get
        {
            switch (Language)
            {
                case LanguagesEnum.Russian:
                    return "ПАУЗА";
                    break;
                case LanguagesEnum.English:
                    return "PAUSED";
                    break;
                default:
                    return "PAUSED";
                    break;
            }
        }
    }
    public static string ExitText
    {
        get
        {
            switch (Language)
            {
                case LanguagesEnum.Russian:
                    return "ВЫХОД";
                    break;
                case LanguagesEnum.English:
                    return "EXIT";
                    break;
                default:
                    return "EXIT";
                    break;
            }
        }
    }
}