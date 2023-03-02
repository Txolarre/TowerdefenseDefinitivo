using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void BTP2()
    {
        SceneManager.LoadScene("Pantalla2");
        
    }
    public static void BTP1()
    {
        SceneManager.LoadScene("Pantalla1");
    }
}
