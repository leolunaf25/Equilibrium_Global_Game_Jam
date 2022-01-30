using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventos : MonoBehaviour
{
    float time;
    float timeDelay;

    public GameObject Alerta1;
    public GameObject Alerta2;
    public GameObject Alerta3;

    int fenomeno = 0;

    private int id = 0;


    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
        timeDelay = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        fenomeno = Random.Range(1,4);
        time = time + 1.0f * Time.deltaTime;       
        
        if (fenomeno == 1 && time >= timeDelay && id != 1)
        {
        Alerta1.SetActive(true);
        Alerta2.SetActive(false);
        Alerta3.SetActive(false);

            //Derrumbe();
            time = 0;
            id = 1;
        }

        if (fenomeno == 2 && time >= timeDelay && id != 2)
        {
        Alerta1.SetActive(false);
        Alerta2.SetActive(true);
        Alerta3.SetActive(false);
            //Erupcion();
            time = 0;
            id = 2;
        }

        if (fenomeno == 3 && time >= timeDelay && id != 3)
        {
        Alerta1.SetActive(false);
        Alerta2.SetActive(false);
        Alerta3.SetActive(true);
            //Incendio();
            time = 0;
            id = 3;
        }
    }
}
