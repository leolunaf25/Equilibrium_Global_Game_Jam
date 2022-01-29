using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alerta1 : MonoBehaviour
{
    Color colores;
    // Start is called before the first frame update
    void Start()
    {
        colores = transform.GetComponent<MeshRenderer>().material.color;       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        Debug.Log("Hay un derrumbe en la zona");
        Debug.Log("La ciudad necesita tu ayuda");
    }

    void OnMouseOver()
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.green;
    }

    void OnMouseExit()
    {
        transform.GetComponent<MeshRenderer>().material.color = colores;
    }
<<<<<<< Updated upstream
}
=======
}
>>>>>>> Stashed changes
