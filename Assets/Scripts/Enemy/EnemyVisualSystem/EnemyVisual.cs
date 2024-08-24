using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVisual : MonoBehaviour
{
    [SerializeField] private CapsuleCollider enemyCollider;
    [SerializeField] private SkinnedMeshRenderer skinnedMeshRenderer;


    public void SetEnemyVisualByLevel(float minVisualScale, float maxVisualScale, int maxLevel, int level)
    {
        SetEnemyScale(minVisualScale, maxVisualScale, maxLevel, level);
        SetEnemyCollider(minVisualScale);
        SetEnemyColor(maxLevel, level);

    }

    private void SetEnemyScale(float minVisualScale, float maxVisualScale, int maxLevel, int level)
    {
        transform.localScale = Vector3.one * minVisualScale;

        float scaleSum = (maxVisualScale - minVisualScale) / maxLevel;
        transform.localScale += Vector3.one * scaleSum * level;
    }

    private void SetEnemyCollider(float minVisualScale)
    {
        enemyCollider.height *= transform.localScale.x / minVisualScale;
        enemyCollider.radius *= transform.localScale.x / minVisualScale;
        enemyCollider.center *= transform.localScale.x / minVisualScale;
    }

    private void SetEnemyColor(int maxLevel, int level)
    {
        float newRedValue = (float)(maxLevel - level) / (float)(maxLevel - 1);
        Debug.Log(newRedValue);
        skinnedMeshRenderer.material.color = new Color(newRedValue, 0, 0);
    }
}
