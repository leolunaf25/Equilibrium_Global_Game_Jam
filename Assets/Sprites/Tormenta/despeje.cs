using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despeje : MonoBehaviour
{
    private int validador = 0;
    float time;

    public GameObject Principal;
    public GameObject Tormenta;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (validador == 1)
        {
             time = time + 1.0f * Time.deltaTime;
             if (time > 2)
             { //Activar y Desactivar camaras
                time = 0;
                validador = 0;
                Principal.SetActive(true);
                Tormenta.SetActive(false);

             }

        }
        
    }


    private void OnTriggerStay(Collider other)
    {
        validador = 0;
    }

    private void OnTriggerExit(Collider other)
    {
        validador = 1;
    }
}
