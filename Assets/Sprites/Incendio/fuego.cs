using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuego : MonoBehaviour
{
    private int clics = 0;
    private int valida = 0;

    private int j = 10;

    // Start is called before the first frame update
    void Start()
    {
        j = Random.Range(5,10);
    }

    // Update is called once per frame
    void Update()
    {       
            if (Input.GetMouseButtonDown(0) && valida == 1)
            {
                clics = clics + 1;
                Debug.Log("Numero actual: "+clics);
            }

            if (clics >= j )
            {   
                clics = 0;
                valida = 0;
                this.gameObject.SetActive(false);

            }
    }

        void OnMouseOver()
    {
        valida = 1;    
    }
    
        void OnMouseExit()
    {
        valida = 0;
    }

}
