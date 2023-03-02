using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;

    private float tiempo1=0, tiempo2;
    //
    void Start()
    {
        //InvokeRepeating("SpawnNext", respawn, respawn);
    }
    void SpawnNext() {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        tiempo2 = Time.time;
        if ((Estatica.numPollos > 0)&&(tiempo2-tiempo1)>Estatica.respawn)
        {
            tiempo1 = tiempo2;
            SpawnNext();
            Estatica.numPollos--;
        }
    }
}
