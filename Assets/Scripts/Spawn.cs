using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public float respawn = 3;
    void Start()
    {
        InvokeRepeating("SpawnNext", respawn, respawn);
    }
    void SpawnNext() {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
