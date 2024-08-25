using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [field: SerializeField] public int GameDifficultyCount { get; set; }
    [SerializeField] private EnemySO enemySO;
    [SerializeField] private float difficultyChangingTime;

    private List<int> enemyLevelsByDifficulty;

    public float GameTime { get; set; }
    public int GameDifficulty { get; set; }

    public static GameManager Instance { get; set; }

    private void Awake()
    {
        Instance = this;

        enemyLevelsByDifficulty=new List<int>(GameDifficultyCount);
        for (int i = 0; i < GameDifficultyCount; i++)
        {
            enemyLevelsByDifficulty.Add(enemySO.maxLevel/GameDifficultyCount * (i + 1));
        }
    }

    private void Start()
    {
        GameTime = 0;
        GameDifficulty = 0;
    }

    private void Update()
    {
        GameTime += Time.deltaTime;

        ChangeGameDifficulty();
    }

    private void ChangeGameDifficulty()
    {
        GameDifficulty=(int)(GameTime/difficultyChangingTime);
        if (GameDifficulty > enemyLevelsByDifficulty.Count-1)
        {
            GameDifficulty = enemyLevelsByDifficulty.Count - 1;
        }
    }

    public int GetMaxEnemyLevelAccordingToTheDifficulty()
    {
        return enemyLevelsByDifficulty[GameDifficulty];
    }
}
