using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextCanvas : MonoBehaviour
{
    //
    // Start is called before the first frame update
    public TMP_Text txtSGO;
    private int cont;
    private float tiempo1=0, tiempo2;
    private int tGO=3;
    public TMP_Text txtTowers;
    private int towerCount=Estatica.torresMax;
    public GameObject botones;
    public TMP_Text txtEnemiesCount;
    
    void Start()
    {
        Time.timeScale = 1;
        txtSGO.text = "Start";
        cont = 6;
        txtTowers.text ="Defensores por asignar: "+ Estatica.torresMax;
        txtEnemiesCount.text ="Atacantes por salir: "+Estatica.numPollos;
        botones.SetActive(false);
        Estatica.numPollos = 10;
        Estatica.torresMax = 2;
        Estatica.gameOver = false;
        Estatica.pollosVivos = 10;
        Estatica.respawn = 3;
    }

    // Update is called once per frame
    void Update()
    {
        txtEnemiesCount.text ="Atacantes por salir: "+Estatica.numPollos;
        txtTowers.text ="Defensores por asignar: "+ Estatica.torresMax;
        if (Estatica.gameOver)
        {
            tiempo2 = Time.time;
            txtSGO.text = "Game Over";
            botones.SetActive(true);
            if ((tiempo2 - tiempo1) > 1)
            {
                tiempo1 = tiempo2;
                tGO--;
            }

            if (tGO<=0)
            {
                Time.timeScale = 0;
            }
        }
        if (Estatica.pollosVivos<= 0)
        {
            Estatica.gameOver = true;
        }
    }

    private void FixedUpdate()
    {
        if (cont > 0)
        {
            cont--;
        }
        else
        {
            txtSGO.text = "";
        }
    }
}
