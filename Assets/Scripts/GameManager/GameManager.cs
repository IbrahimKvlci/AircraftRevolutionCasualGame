using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public event EventHandler OnScoreChanged;
    public event EventHandler OnPausedChanged;


    [field: SerializeField] public int GameDifficultyCount { get; set; }
    [field: SerializeField] public float DifficultyChangingTime { get; set; }
    

    [SerializeField] private EnemySO enemySO;

    public List<int> EnemyLevelsByDifficulty {  get; set; }

    public float GameTime { get; set; }
    
    public int GameDifficulty { get; set; }
    public bool IsGameOver { get; set; }

    private bool _isGamePaused;
    public bool IsGamePaused
    {
        get
        {
            return _isGamePaused;
        }
        set
        {
            _isGamePaused = value;
            OnPausedChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    private int _score;
    public int Score
    {
        get { return _score; }
        set { _score = value; 
            OnScoreChanged?.Invoke(this, EventArgs.Empty); } 
    }

    public IGameState GameStartingState {  get; set; }
    public IGameState GamePlayingState { get; set; }
    public IGameState GamePausedState { get; set; }
    public IGameState GameOverState { get; set; }

    public IGameStateService GameStateService {  get; set; }

    public static GameManager Instance { get; set; }

    private void Awake()
    {
        Instance = this;

        GameStateService = new GameStateManager();

        GameStartingState = new GameStartingState(this,GameStateService,enemySO);
        GamePlayingState=new GamePlayingState(this,GameStateService);
        GamePausedState=new GamePausedState(this,GameStateService);
        GameOverState=new GameOverState(this,GameStateService);

        EnemyLevelsByDifficulty = new List<int>(GameDifficultyCount);
        for (int i = 0; i < GameDifficultyCount; i++)
        {
            EnemyLevelsByDifficulty.Add(enemySO.maxLevel / GameDifficultyCount * (i + 1));
        }
    }

    private void Start()
    {
        GameStateService.Initialize(GameStartingState);
    }

    private void Update()
    {
        GameStateService.CurrentGameState.UpdateState();
    }


    public int GetMaxEnemyLevelAccordingToTheDifficulty()
    {
        return EnemyLevelsByDifficulty[GameDifficulty];
    }

    public void ResetGame()
    {
        GameTime = 0;
        GameDifficulty = 0;
        Score = 0;
        IsGameOver = false;
        IsGamePaused = false;
    }
}
