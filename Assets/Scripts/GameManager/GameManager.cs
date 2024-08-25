using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [field: SerializeField] public int GameDifficultyCount { get; set; }
    [field: SerializeField] public float DifficultyChangingTime { get; set; }

    [SerializeField] private EnemySO enemySO;

    public List<int> EnemyLevelsByDifficulty {  get; set; }

    public float GameTime { get; set; }
    public int GameDifficulty { get; set; }

    public IGameState GameStartingState {  get; set; }
    public IGameState GamePlayingState { get; set; }
    public IGameState GamePausedState { get; set; }

    private IGameStateService _gameStateService;

    public static GameManager Instance { get; set; }

    private void Awake()
    {
        Instance = this;

        _gameStateService = new GameStateManager();

        GameStartingState = new GameStartingState(this,_gameStateService,enemySO);
        GamePlayingState=new GamePlayingState(this,_gameStateService);
        GamePausedState=new GamePausedState(this,_gameStateService);

       
    }

    private void Start()
    {
        _gameStateService.Initialize(GameStartingState);
    }

    private void Update()
    {
        _gameStateService.CurrentGameState.UpdateState();
    }


    public int GetMaxEnemyLevelAccordingToTheDifficulty()
    {
        return EnemyLevelsByDifficulty[GameDifficulty];
    }
}
