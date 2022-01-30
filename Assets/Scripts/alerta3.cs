using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alerta3 : MonoBehaviour
{
    Color colores;
    int validador = 0;

    public GameObject Alerta3;
    public GameObject MiniJuego3;
    // Start is called before the first frame update
    void Start()
    {
        colores = transform.GetComponent<MeshRenderer>().material.color;       
    }

    // Update is called once per frame
    void Update()
    {
        if (validador == 1)
        {
         Debug.Log("Se hizo clic");
         Alerta3.SetActive(false);
         transform.GetComponent<MeshRenderer>().material.color = colores;
         MiniJuego3.SetActive(true);
         validador = 0;
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Hay un Incendio forestal");
        Debug.Log("La ciudad corre peligro");
        validador = 1;
    }

    void OnMouseOver()
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.green;
    }

    void OnMouseExit()
    {
        transform.GetComponent<MeshRenderer>().material.color = colores;
    }
    
}
