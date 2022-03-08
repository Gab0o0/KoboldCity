using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 5f;
    public Transform target;
    //bool bulletHit = false;
    private Vector3 forwardDir;
    private Vector3 currentPos;
    
    // Update is called once per frame
    void Awake()
    {
     //   setTarget(enemy);
    }

    void Start() 
    {
        forwardDir = transform.forward;
        currentPos = transform.position;
    }

    //public void Setup()
    /*
    void setTarget(GameObject target)
    {
        target = Tower.GetComponent<Tower>().targetEnemy;
        Debug.Log("Target Set");
    }
    */

    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        //forwardDir = target.transform.position - currentPos;


        //transform.position += enemy.position * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit Enemy");
        DestroyBullet();

        //This Works as a Trigger for the EventSys
    }

    void DestroyBullet() {
        Destroy(gameObject);
    }
}
