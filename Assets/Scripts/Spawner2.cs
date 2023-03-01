using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject enemy;
    public TMP_Text txtEnemiesCount;
   
    private float tiempo1=0, tiempo2;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnNext", respawn, respawn);
        txtEnemiesCount.text ="Atacantes por salir: "+Estatica.numPollos;
    }
    void SpawnNext() {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        tiempo2 = Time.time;
        if ((Estatica.numPollos > 0)&&(tiempo2-tiempo1)>Estatica.respawn+1)
        {
            tiempo1 = tiempo2;
            SpawnNext();
            Estatica.numPollos--;
            txtEnemiesCount.text="Atacantes por salir: "+Estatica.numPollos;
            //Estatica.pollosVivos++;
        }
    }
}
