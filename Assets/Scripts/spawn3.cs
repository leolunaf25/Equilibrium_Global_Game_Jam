//Script que permite la generación de población. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn3 : MonoBehaviour
{
    public Transform posicionInicial;
    private int posIn;

    public GameObject npc;
    
    private int contadorPoblacion = 0;
    float time;
    float timeDelay;

    void Start()
    {
        time = 0.0f;
        timeDelay = .75f;

    }

    void Update()
    {
        time = time + 1.0f * Time.deltaTime;

        if (time >= timeDelay && contadorPoblacion < 310)
        {
            time = 0.0f;
            contadorPoblacion++;
            Instantiate(npc, posicionInicial.transform.position, posicionInicial.transform.rotation);
        }
    }
}
