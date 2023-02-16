using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLocation : MonoBehaviour
{
    public GameObject towerPrefab;
    void OnMouseUpAsButton()
    {
        GameObject newTower = (GameObject)Instantiate(towerPrefab);
        newTower.transform.position = transform.position + Vector3.up;
    }
}
