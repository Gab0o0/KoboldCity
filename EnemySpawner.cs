using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject enemy;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        keySpawn();
    }

    void keySpawn() 
    {
        if (Input.GetKeyDown("space")) 
        {
            Debug.Log("Enemy has spawned");

            GameObject enemyPawn = Instantiate(enemy, gameObject.transform.position, Quaternion.identity);
        }
    }

}
