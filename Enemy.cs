using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit Enemy");
        DestroyEnemy();

        //This Works as a Trigger for the EventSys
    }

    void DestroyEnemy()
    {
        Destroy(gameObject);
    }

}
