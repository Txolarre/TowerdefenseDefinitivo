using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StartGOver : MonoBehaviour
{
    TextMesh tm;

    //public TextMesh enemiesP;
    
    // Start is called before the first frame update
    void Start()
    {
        tm = GetComponent<TextMesh>();
        tm.text = "Strat";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        var s = 2;
        if (s > 0)
        {
            tm.text = "";
        }
        else
        {
            s--;
        }
    }
}
