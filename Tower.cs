using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    private Transform enemyPosition;
    private GameObject targetEnemy;
    public Transform shootPos;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //This Works as a Trigger for the EventSys
        targetEnemy = collision.gameObject;
        enemyPosition = targetEnemy.transform;
        EventSystem.current.EnemyInTowerRange(shootPos, enemyPosition);

    }

    void OnCollisionStay(Collision collision)
    {
        transform.LookAt(enemyPosition);
        /*
        targetEnemy = collision.gameObject;
        enemyPosition = targetEnemy.transform;
        StartCoroutine(ExecuteAfterTime(10));
        */
        // Debug.Log("Enemy in range");
        //focusEnemy(collision.transform);
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("Enemy left");
    }

    /*Observe al enemigo
    void focusEnemy(Transform transform)
    {
        transform.LookAt(transform);
    }
    */

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        EventSystem.current.EnemyInTowerRange(shootPos, enemyPosition);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
