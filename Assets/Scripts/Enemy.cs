using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        GameObject egg = GameObject.Find("Egg");
        if (egg)
            GetComponent<NavMeshAgent>().destination = egg.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("choca con: "+other.name);
        if (other.name == "Egg")
        {
            other.GetComponentInChildren<HealthBar>().decrease();
            Destroy(gameObject);
        }
    }
}
