using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    TextMesh tm;
    private bool muerto = false;
    public ParticleSystem explosionPS;

    public AudioSource explosionAS;
    // Start is called before the first frame update

    void Start()
    {
        tm = GetComponent<TextMesh>();
        //ParticleSystem exp = transform.parent.GetComponent<ParticleSystem>();
        //exp.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = Camera.main.transform.forward;
    }

    public int current()
    {
        return tm.text.Length;
    }

    public void decrease()
    {
        if (current() > 1)
        {
            tm.text = tm.text.Remove(tm.text.Length - 1);
        }
        else
        {
            explosionAS.Play();
            explosionPS.Play();
            if (transform.parent.gameObject.name == "Egg")
            {
                Estatica.gameOver = true;
            }
            else
            {
                if (!muerto)
                {
                    muerto = true;
                    Estatica.pollosVivos--;
                }
            }
            Destroy(transform.parent.gameObject, 1);
        }
    }
}