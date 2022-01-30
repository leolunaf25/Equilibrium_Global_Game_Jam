using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alerta1 : MonoBehaviour
{
    Color colores;
    int validador = 0;

    public GameObject Alerta1;
    public GameObject MiniJuego1;
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
         Alerta1.SetActive(false);
         transform.GetComponent<MeshRenderer>().material.color = colores;
         MiniJuego1.SetActive(true);
         validador = 0;
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Hay una fuerte Erupción del volcán");
        Debug.Log("La ciudades corren peligro");
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
