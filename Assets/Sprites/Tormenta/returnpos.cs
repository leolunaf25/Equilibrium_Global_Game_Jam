using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnpos : MonoBehaviour
{
    public Transform PosInicial;
    Vector3 regresa; 

    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        regresa = PosInicial.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        time = time + 1.0f * Time.deltaTime;
        if (time >= 10)
        {
         transform.position = regresa;
         time = 0;
        }
    }
}
