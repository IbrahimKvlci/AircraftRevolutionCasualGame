using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [field:SerializeField] public EnemySO EnemySO { get; set; }

    [field: SerializeField] public EnemyVisual EnemyVisual { get; set; }
    public EnemyHealth EnemyHealth { get; set; }
    public int EnemyLevel { get; set; } = 0;

    public IEnemyState EnemyFreezingState { get; set; }
    public IEnemyState EnemyPlayingState { get; set; }

    private IEnemyStateService _enemyStateService;
    private IEnemyMovementService _enemyMovementService;

    private void Awake()
    {
        _enemyMovementService = InGameIoC.Instance.EnemyMovementService;

        EnemyHealth = new EnemyHealth(this);

        _enemyStateService = new EnemyStateManager();

        EnemyFreezingState= new EnemyFreezingState(this,_enemyStateService);
        EnemyPlayingState=new EnemyPlayingState(this, _enemyStateService,_enemyMovementService);
    }

    private void Start()
    {
        _enemyStateService.Initialize(EnemyFreezingState);
    }

    private void Update()
    {
        _enemyStateService.CurrentEnemyState.UpdateState();
    }
}
