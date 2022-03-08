using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    public Transform shootPos;


    void Start()
    {
        EventSystem.current.onEnemyInTowerRange += OnEnemyInTowerRange;
    }

    private void OnEnemyInTowerRange(Transform shootPos, Transform enemyPosition)
    {
     //This is the action caused by the EventSys
        Debug.Log("EnemyInRange"+" Targer Postion"+shootPos.position);
        
        GameObject spawnedBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);
        spawnedBullet.GetComponent<Bullet>().target = enemyPosition;
    }

    void Update()
    {
        
    }
}

