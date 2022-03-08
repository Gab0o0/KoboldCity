using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    public static EventSystem current;

    void Awake()
    {
        current = this;
    }

    public event Action<Transform, Transform> onEnemyInTowerRange;
    public void EnemyInTowerRange(Transform shootPos, Transform enemyPosition) 
    {
        if (onEnemyInTowerRange != null)
        {
            onEnemyInTowerRange(shootPos, enemyPosition);
        }
        
    }
    
}
