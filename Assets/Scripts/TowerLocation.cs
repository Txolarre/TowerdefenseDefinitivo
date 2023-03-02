using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TowerLocation : MonoBehaviour
{
    public GameObject towerPrefab;
    
    private void Start()
    {
      
    }

    void OnMouseUpAsButton()
    {
        if (Estatica.torresMax>0)
        {
            GameObject newTower = (GameObject)Instantiate(towerPrefab);
            newTower.transform.position = transform.position + Vector3.up;
            Estatica.torresMax--;
        }
    }
}